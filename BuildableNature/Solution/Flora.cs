using System.Collections.Generic;
using System.Linq;
using BepInEx;
using HarmonyLib;
using JetBrains.Annotations;
using PieceManager;
using UnityEngine;
using Object = UnityEngine.Object;

namespace BuildableNature.Solution;

public static class Flora
{
    private static CraftingStation m_station = null!;

    private static EffectList m_placeEffects = null!;
    private static EffectList m_destroyedEffects = null!;
    private static EffectList m_hitEffects = null!;

    private static readonly List<NaturePiece> m_naturePieces = new();
    
    [HarmonyPatch(typeof(FejdStartup), nameof(FejdStartup.Awake))]
    private static class FejdStartup_Awake_Patch
    {
        [UsedImplicitly]
        private static void Postfix(FejdStartup __instance)
        {
            var scene = __instance.m_objectDBPrefab.GetComponent<ZNetScene>();
            LoadAssets(scene);
            foreach (var prefab in scene.m_prefabs)
            {
                if (ExclusionList.IsExcluded(prefab.name)) continue;
                _ = new NaturePiece(prefab);
            }
            foreach (var piece in m_naturePieces)
            {
                BuildPiece build = new BuildPiece(piece.Prefab);
                build.Name.English(piece.Name);
                build.Category.Set(piece.Category);
                foreach (var resource in piece.Requirements)
                {
                    build.RequiredItems.Add(resource.Key, resource.Value, true);
                }
                build.Snapshot();
            }
            BuildableNaturePlugin.SetupFileWatcher();
            BuildPiece.Patch_FejdStartup(__instance);
        }
    }

    [HarmonyPatch(typeof(StaticPhysics), nameof(StaticPhysics.Awake))]
    private static class StaticPhysics_Awake_Patch
    {
        [UsedImplicitly]
        private static bool Prefix()
        {
            return !BuildPiece.TakingSnapshot;
        }
    }

    [HarmonyPatch(typeof(RandomFlyingBird), nameof(RandomFlyingBird.Awake))]
    private static class R
    {
        [UsedImplicitly]
        private static bool Prefix(RandomFlyingBird __instance)
        {
            return !BuildPiece.TakingSnapshot;
        }
    }

    [HarmonyPatch(typeof(ItemDrop), nameof(ItemDrop.Awake))]
    private static class ItemDrop_Awake_Patch
    {
        [UsedImplicitly]
        private static bool Prefix(ItemDrop __instance)
        {
            return !BuildPiece.TakingSnapshot;
        }
    }

    [HarmonyPatch(typeof(ItemDrop), nameof(ItemDrop.OnDestroy))]
    private static class ItemDrop_OnDestroy_Patch
    {
        [UsedImplicitly]
        private static bool Prefix(ItemDrop __instance)
        {
            if (!ZoneSystem.instance) return false;
            return true;
        }
    }

    public class NaturePiece
    {
        public GameObject Prefab = null!;
        public readonly Dictionary<string, int> Requirements = new();
        public readonly string Category = "";
        private bool NeedsCollider = false;
        public string Name = "";

        public NaturePiece(GameObject source)
        {
            if (source == null) return;
            if (ConvertPlant(source))
            {
                Category = "Flora";
            }
            else if (ConvertPickable(source))
            {
                Category = HandleCategory(source);
            }
            else if (ConvertDestructible(source))
            {
                Category = HandleCategory(source);
            }
            else if (ConvertTreeBase(source))
            {
                Category = "Flora";
            }
            else if (ConvertMineRock(source))
            {
                Category = "Rocks";
            }

            if (Category.IsNullOrWhiteSpace()) return;
            
            
            RemoveComponents();
            GameObject model = SetUnderModel(Prefab);
            if (NeedsCollider)
            {
                if (!AddCollider(Prefab)) return;
            }
            SetLayer(Prefab, LayerMask.NameToLayer("piece"));
            AddWearNTear(Prefab, model);
            AddPiece(Prefab, source);
            CreateRequirements(source);
 

            if (Name.IsNullOrWhiteSpace()) Name = GetDisplayName(source.name);
            m_naturePieces.Add(this);
        }

        private bool ConvertMineRock(GameObject source)
        {
            if (!source.GetComponent<MineRock>()) return false;
            if (!CheckCollider(source)) return false;
            Prefab = Object.Instantiate(source, BuildableNaturePlugin.m_root.transform, false);
            Prefab.name = $"$piece_{GetPrefabName(source.name)}";
            RemovePathfindingBlockers(Prefab);
            if (source.TryGetComponent(out HoverText text))
            {
                Name = Localization.instance.Localize(text.m_text);
            }
            return true;
        }

        private bool ConvertTreeBase(GameObject source)
        {
            if (!source.GetComponent<TreeBase>()) return false;
            if (!CheckCollider(source)) return false;
            Prefab = Object.Instantiate(source, BuildableNaturePlugin.m_root.transform, false);
            Prefab.name = $"$piece_{GetPrefabName(source.name)}";
            RemovePathfindingBlockers(Prefab);
            if (source.TryGetComponent(out HoverText text))
            {
                Name = Localization.instance.Localize(text.m_text);
            }
            return true;
        }

        private bool CheckCollider(GameObject source)
        {
            if (!HasCollider(source))
            {
                if (!source.TryGetComponent(out MeshCollider meshCollider))
                {
                    meshCollider = source.GetComponentInChildren<MeshCollider>();
                    if (meshCollider == null) return false;
                }

                NeedsCollider = true;
            }

            return true;
        }

        private bool ConvertDestructible(GameObject source)
        {
            if (!source.GetComponent<Destructible>()) return false;
            if (!CheckCollider(source)) return false;
            Prefab = Object.Instantiate(source, BuildableNaturePlugin.m_root.transform, false);
            Prefab.name = $"$piece_{GetPrefabName(source.name)}";
            RemovePathfindingBlockers(Prefab);
            if (source.TryGetComponent(out HoverText text))
            {
                Name = Localization.instance.Localize(text.m_text);
            }
            return true;
        }

        private bool ConvertPickable(GameObject source)
        {
            if (!HasCollider(source)) return false;
            if (!source.TryGetComponent(out Pickable component)) return false;
            Prefab = Object.Instantiate(source, BuildableNaturePlugin.m_root.transform, false);
            Prefab.name = $"$piece_{GetPrefabName(source.name)}";

            if (component.m_itemPrefab != null)
            {
                Name = Localization.instance.Localize(component.m_itemPrefab.GetComponent<ItemDrop>().m_itemData
                    .m_shared.m_name);
            }
            return true;
        }

        private bool ConvertPlant(GameObject source)
        {
            if (!source.TryGetComponent(out Plant plant)) return false;
            Prefab = Object.Instantiate(source, BuildableNaturePlugin.m_root.transform, false);
            Prefab.name = $"$piece_{GetPrefabName(source.name)}";
            var component = Prefab.GetComponent<Plant>();
            if (component.m_healthy) Object.Destroy(component.m_healthy);
            if (component.m_unhealthy) Object.Destroy(component.m_unhealthy);
            if (component.m_unhealthyGrown) Object.Destroy(component.m_unhealthyGrown);
            if (component.m_healthyGrown) component.m_healthyGrown.SetActive(true);

            Name = Localization.instance.Localize(plant.m_name);
            
            return true;
        }

        private void CreateRequirements(GameObject source)
        {
            if (source.TryGetComponent(out Fish fish))
            {
                Requirements[fish.name] = 1;
            }
            else if (source.TryGetComponent(out Pickable pickable) && pickable.m_itemPrefab != null)
            {
                Requirements[pickable.m_itemPrefab.name] = pickable.m_amount;
            }
            else if (source.TryGetComponent(out TreeBase treeBase))
            {
                foreach (var drop in treeBase.m_dropWhenDestroyed.m_drops)
                {
                    if (drop.m_item == null) continue;
                    Requirements.AddOrSet(drop.m_item.name, drop.m_stackMax);
                }
            }
            else if (source.TryGetComponent(out MineRock mineRock) && mineRock.m_dropItems != null)
            {
                foreach (var drop in mineRock.m_dropItems.m_drops)
                {
                    if (drop.m_item == null) continue;
                    Requirements.AddOrSet(drop.m_item.name, drop.m_stackMax);
                }
            }
            else if (source.TryGetComponent(out Destructible destructible) && destructible.m_spawnWhenDestroyed != null && destructible.m_spawnWhenDestroyed.TryGetComponent(out MineRock5 mineRock5))
            {
                foreach (var drop in mineRock5.m_dropItems.m_drops)
                {
                    if (drop.m_item == null) continue;
                    Requirements.AddOrSet(drop.m_item.name, drop.m_stackMax);
                }
            }
            else if (source.TryGetComponent(out DropOnDestroyed dropOnDestroyed))
            {
                foreach (var drop in dropOnDestroyed.m_dropWhenDestroyed.m_drops)
                {
                    if (drop.m_item == null) continue;
                    Requirements.AddOrSet(drop.m_item.name, drop.m_stackMax);
                }
            }
            else
            {
                Requirements.AddOrSet("Wood", 1);
            }
            var nonExistingItems = new List<string>() { "SeekerBrood", "Skeleton" };
            foreach (var item in nonExistingItems)
            {
                Requirements.Remove(item);
            }

            if (Requirements.Count <= 0)
            {
                Requirements.AddOrSet("Wood", 1);
            }
        }
        
        private void RemoveComponents()
        {
            Prefab.RemoveComponent<Destructible>();
            Prefab.RemoveComponent<Pickable>();
            Prefab.RemoveComponent<DropOnDestroyed>();
            Prefab.RemoveComponent<LuredWisp>();
            Prefab.RemoveComponent<Vine>();
            Prefab.RemoveComponent<ConditionalObject>();
            Prefab.RemoveComponent<HoverText>();
            Prefab.RemoveComponent<Floating>();
            Prefab.RemoveComponent<Rigidbody>();
            Prefab.RemoveComponent<ZSyncTransform>();
            Prefab.RemoveComponent<Fish>();
            Prefab.RemoveComponent<SpawnArea>();
            Prefab.RemoveComponent<TerrainModifier>();
            Prefab.RemoveComponent<MineRock>();
            Prefab.RemoveComponent<Leviathan>();
            Prefab.RemoveComponent<Plant>();
            Prefab.RemoveComponent<TreeBase>();
            Prefab.RemoveComponent<EggHatch>();
            Prefab.RemoveComponent<ItemDrop>();
            Prefab.RemoveComponent<RandomFlyingBird>();
            
            
            foreach (Transform child in Prefab.transform)
            {
                child.gameObject.RemoveComponent<TerrainModifier>();
            }
        }
        
    }

    private static void AddOrSet<T>(this Dictionary<T, int> dict, T key, int value, int maxItems = 4)
    {
        if (!dict.ContainsKey(key))
        {
            // If we're at the limit and trying to add a new key, don't add it
            if (dict.Count >= maxItems)
            {
                return; // Silently ignore
                // Or alternatively: throw new InvalidOperationException($"Cannot add more than {maxItems} items");
            }
            dict[key] = value;
        }
        else
        {
            // Key exists, so we can safely update the value
            dict[key] += value;
        }
    }

    private static GameObject? GetPrefab(ZNetScene instance, string name)
    {
        return instance.m_prefabs.Find(x => x.name == name);
    }

    private static void LoadAssets(ZNetScene instance)
    {
        var craftingStation = GetPrefab(instance, "piece_workbench");
        if (craftingStation == null || !craftingStation.TryGetComponent(out CraftingStation workbench)) return;
        m_station = workbench;

        if (!craftingStation.TryGetComponent(out Piece piece)) return;
        if (!craftingStation.TryGetComponent(out WearNTear wearNTear)) return;

        m_placeEffects = piece.m_placeEffect;
        m_destroyedEffects = wearNTear.m_destroyedEffect;
        m_hitEffects = wearNTear.m_hitEffect;
            
        // m_defaultRequirements = new[]
        // {
        //     new Piece.Requirement()
        //     {
        //         m_resItem = GetPrefab(instance, "Wood").GetComponent<ItemDrop>(),
        //         m_recover = true,
        //         m_amount = 1,
        //         m_amountPerLevel = 1,
        //         m_extraAmountOnlyOneIngredient = 1,
        //     }
        // };
    }
    
    private static void RemoveComponent<T>(this GameObject prefab) where T : Component
    {
        if (prefab.TryGetComponent(out T component)) Object.DestroyImmediate(component);
    }

    private static string HandleCategory(GameObject prefab)
    {
        try
        {
            if (prefab.TryGetComponent(out Destructible destructible))
            {
                if (destructible.GetDestructibleType() is DestructibleType.Tree) return "Flora";
                if (destructible.m_damages.m_chop is HitData.DamageModifier.Immune &&
                    destructible.m_damages.m_pickaxe is not HitData.DamageModifier.Immune) return "Rocks";
            }

            if (prefab.GetComponent<Fish>()) return "Nature";
            if (prefab.GetComponent<RandomFlyingBird>()) return "Nature";
            if (prefab.TryGetComponent(out Pickable pickable))
            {
                if (pickable.m_itemPrefab == null) return "Other";
                if (!pickable.m_itemPrefab.TryGetComponent(out ItemDrop itemDrop)) return "Other";
                if (!itemDrop.m_itemData.m_shared.m_teleportable) return "Rocks";
                if (itemDrop.m_itemData.m_shared.m_itemType is not ItemDrop.ItemData.ItemType.Consumable)
                    return "Nature";
            }

            return "Other";
        }
        catch
        {
            return "Other";
        }
    }

    private static bool AddCollider(GameObject prefab)
    {
        var renderer = prefab.GetComponentInChildren<MeshRenderer>();
        if (renderer == null) return false;
        GameObject root = new GameObject("collider");
        root.transform.SetParent(prefab.transform);
        BoxCollider collider = root.AddComponent<BoxCollider>();
        var bounds = renderer.bounds;
                
        collider.size = new Vector3(1f, bounds.size.y);
        collider.center = bounds.center;
        return true;
    }
    
    private static GameObject SetUnderModel(GameObject prefab)
    {
        List<Transform> children = new();
        foreach (Transform child in prefab.transform)
        {
            children.Add(child);
        }
        GameObject model = new GameObject("model");
        model.transform.parent = prefab.transform;
        foreach (var child in children)
        {
            child.parent = model.transform;
        }

        return model;
    }

    private static void RemovePathfindingBlockers(GameObject prefab)
    {
        foreach (var collider in prefab.GetComponentsInChildren<SphereCollider>())
        {
            if (!collider.name.Contains("Pathfinding")) continue;
            Object.Destroy(collider.gameObject);
        }
    }

    private static void AddPiece(GameObject prefab, GameObject original)
    {
        bool newPiece = false;
        if (!prefab.TryGetComponent(out Piece piece))
        {
            piece = prefab.AddComponent<Piece>();
            newPiece = true;
        }
        piece.m_primaryTarget = false;
        piece.m_randomTarget = false;
        piece.m_targetNonPlayerBuilt = false;
        piece.m_craftingStation = m_station;
        piece.m_cultivatedGroundOnly = false;
        piece.m_canBeRemoved = true;
        
        if (newPiece)
        {
            piece.m_name = "$piece_" + original.name;
            piece.m_placeEffect = m_placeEffects;
        }
    }

    private static void AddWearNTear(GameObject prefab, GameObject model, Destructible? destructible = null, TreeBase? treeBase = null, MineRock? mineRock = null)
    {
        WearNTear component = prefab.AddComponent<WearNTear>();
        component.m_new = model;
        component.m_worn = model;
        component.m_broken = model;
        component.m_supports = true;
        component.m_noRoofWear = true;
        component.m_noSupportWear = true;
        component.m_materialType = WearNTear.MaterialType.Wood;

        if (destructible != null)
        {
            component.m_health = destructible.m_health * 10;
            component.m_damages = destructible.m_damages;
            component.m_minToolTier = destructible.m_minToolTier;
            component.m_destroyedEffect = destructible.m_destroyedEffect.m_effectPrefabs.Length > 0 ? destructible.m_destroyedEffect : m_destroyedEffects;
            component.m_hitEffect = destructible.m_hitEffect.m_effectPrefabs.Length > 0 ? destructible.m_hitEffect : m_hitEffects;
            component.m_autoCreateFragments = destructible.m_autoCreateFragments;
        }
        else if (treeBase != null)
        {
            component.m_health = treeBase.m_health * 10;
            component.m_damages = treeBase.m_damageModifiers;
            component.m_minToolTier = treeBase.m_minToolTier;
            component.m_destroyedEffect = treeBase.m_destroyedEffect;
            component.m_hitEffect = treeBase.m_hitEffect;
            component.m_autoCreateFragments = true;
        }
        else if (mineRock != null)
        {
            component.m_health = mineRock.m_health * 10;
            component.m_damages = mineRock.m_damageModifiers;
            component.m_minToolTier = mineRock.m_minToolTier;
            component.m_destroyedEffect = mineRock.m_destroyedEffect;
            component.m_hitEffect = mineRock.m_hitEffect;
            component.m_autoCreateFragments = true;
        }
        else
        {
            component.m_health = 1000f;
            component.m_destroyedEffect = m_destroyedEffects;
            component.m_hitEffect = m_hitEffects;
            component.m_autoCreateFragments = true;
        }
    }

    private static string GetDisplayName(string name) => GetPrefabName(name).Replace('_', ' ');

    private static string GetPrefabName(string name)
    {
        List<string> wordsToRemove = new()
        {
            "pickable", "hanging", "spawner", "event", "destructable", "alwayshatch"
        };
        string[] words = name.ToLower().Split('_');
        IEnumerable<string> filteredWords = words.Where(word => !wordsToRemove.Contains(word));
        return string.Join("_", filteredWords);
    }

    private static bool HasCollider(GameObject prefab)
    {
        if (prefab.TryGetComponent(out BoxCollider collider)) return true;
        collider = prefab.GetComponentInChildren<BoxCollider>();
        if (collider != null) return true;
        if (prefab.TryGetComponent(out SphereCollider sphereCollider)) return true;
        sphereCollider = prefab.GetComponentInChildren<SphereCollider>();
        return sphereCollider != null;
    }
    
    private static void SetLayer(GameObject prefab, LayerMask layer)
    {
        if (LayerMask.LayerToName(prefab.layer) != "effect") prefab.layer = layer;
        if (prefab.transform.childCount <= 0) return;
        foreach (Transform child in prefab.transform)
        {
            SetLayer(child.gameObject, layer);
        }
    }
}