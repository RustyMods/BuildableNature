using System;
using ClassSystem;
using PieceManager;
using UnityEngine;
using static UnityEngine.Object;

namespace BuildableNature;

public static partial class Assets
{
    public static void Mistlands()
    {
        var piece_black_marble_altar = new Clone("blackmarble_altar_crystal");
        piece_black_marble_altar.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_blackmarble_altar";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_crystal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_destroyedEffect = new EffectListRef("fx_altar_crystal_destruction").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Black Marble Altar");

            build.RequiredItems.Add("DvergrKeyFragment", 1, true);
            build.RequiredItems.Add("BlackMarble",5 ,true);
            build.Snapshot();
        };
        var piece_black_marble_post = new Clone("blackmarble_post01");
        piece_black_marble_post.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_black_marble_post";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_crystal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_MarbleHit", "sfx_rock_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_MarbleDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Black Marble Altar");

            build.RequiredItems.Add("BlackMarble",10 ,true);
            build.Snapshot();
        };
        var piece_cliff_mistlands1 = new Clone("cliff_mistlands1");
        piece_cliff_mistlands1.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.7f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_cliff_mistlands1";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_RockDestroyed_large").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Mistlands Cliff");

            build.RequiredItems.Add("BlackMarble", 10, true);
            build.Snapshot();
        };
        var piece_cliff_mistlands1_creep = new Clone("cliff_mistlands1_creep");
        piece_cliff_mistlands1_creep.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.7f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_cliff_mistlands1_creep";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_RockDestroyed_large").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Mistlands Creep Cliff");

            build.RequiredItems.Add("BlackMarble", 10, true);
            build.Snapshot();
        };
        var piece_cliff_mistlands2 = new Clone("cliff_mistlands2");
        piece_cliff_mistlands2.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.7f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_cliff_mistlands2";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_RockDestroyed_large").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Mistlands Cliff");

            build.RequiredItems.Add("BlackMarble", 10, true);
            build.Snapshot();
        };
        var piece_egg_hanging = new Clone("CreepProp_egg_hanging01");
        piece_egg_hanging.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();

            var meshColliders = prefab.GetComponentsInChildren<MeshCollider>();
            for (int i = 0; i < meshColliders.Length; ++i)
            {
                var c = meshColliders[i];
                c.convex = false;
            }

            var particles = Utils.FindChild(prefab.transform, "Particles");
            particles.gameObject.SetActive(false);
            
            var model = prefab.CreateAndSetUnderModel();
            model.transform.localRotation = Quaternion.Euler(0f, 0f, 180f);
            prefab.SetLayerRecursively(10);
            var collider = prefab.AddCollider();
            collider.transform.localPosition += new Vector3(0f, -0.1f, 0f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_hanging_egg";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_inCeilingOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_hit", "vfx_HitSparks").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("fx_egg_splash").m_effectList;
            wnt.m_noSupportWear = false;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Hanging Eggs");

            build.RequiredItems.Add("RoyalJelly", 1, true);
            build.Snapshot();
        };
        var piece_hanging_slime = new Clone("CreepProp_hanging01");
        piece_hanging_slime.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();

            var meshColliders = prefab.GetComponentsInChildren<MeshCollider>();
            for (int i = 0; i < meshColliders.Length; ++i)
            {
                var c = meshColliders[i];
                c.convex = false;
            }
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var collider = prefab.AddCollider(0.5f);
            collider.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_hanging_slime";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_hit", "vfx_HitSparks").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_creep_hangingdetroyed").m_effectList;
            wnt.m_noSupportWear = false;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Hanging Slime");

            build.RequiredItems.Add("RoyalJelly", 1, true);
            build.Snapshot();
        };
        var piece_dvergr_barrel = new Clone("dvergrprops_barrel");
        piece_dvergr_barrel.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);

            if (BuildPiece.TryGetPrefab("fermenter", out var fermenter) && fermenter.TryGetComponent(out Fermenter component))
            {
                var roofCheckPoint = new GameObject("roof_check_point");
                roofCheckPoint.transform.SetParent(prefab.transform);
                roofCheckPoint.transform.localPosition = new Vector3(0f, 1.4f, 0f);
                
                var addButton = new GameObject("add_button");
                addButton.transform.SetParent(prefab.transform);
                addButton.transform.localPosition = new Vector3(0f, 1.464f, 0.777f);
                var add = addButton.AddComponent<Switch>();

                var tapButton = new GameObject("tap_button");
                tapButton.transform.SetParent(prefab.transform);
                tapButton.transform.localPosition = new Vector3(0f, 0.52f, 0.976f);
                var tap = tapButton.AddComponent<Switch>();

                var output = new GameObject("output");
                output.transform.SetParent(prefab.transform);
                output.transform.localPosition = new Vector3(0f, 0.295f, 0.9f);

                var topObj = new GameObject("top");
                topObj.transform.SetParent(prefab.transform);

                var ready = Instantiate(component.m_readyObject, prefab.transform);
                var fermenting = Instantiate(component.m_fermentingObject, prefab.transform);
                
                var ferment = prefab.AddComponent<Fermenter>();
                ferment.m_name = "$piece_fermenter";
                ferment.m_fermentationDuration = 2400f;
                ferment.m_addedEffects = component.m_addedEffects;
                ferment.m_tapEffects = component.m_tapEffects;
                ferment.m_spawnEffects = component.m_spawnEffects;
                ferment.m_roofCheckPoint = roofCheckPoint.transform;
                ferment.m_tapDelay = 2.5f;
                ferment.m_conversion = component.m_conversion;
                ferment.m_readyObject = ready;
                ferment.m_fermentingObject = fermenting;
                ferment.m_topObject = topObj;
                ferment.m_addSwitch = add;
                ferment.m_tapSwitch = tap;
                ferment.m_outputPoint = output.transform;

                var durConfig = BuildableNaturePlugin.instance.config("Fermenting Barrel", "Fermentation Duration", ferment.m_fermentationDuration,
                    "Set duration to ferment mead base into mead.");

                void OnDurConfigChanged(object sender, EventArgs args)
                {
                    ferment.m_fermentationDuration = durConfig.Value;
                }

                durConfig.SettingChanged += OnDurConfigChanged;
                OnDurConfigChanged(null, null);
            }

            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_barrel_fermenter";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor | Piece.UsageTagFlags.Crafting;
            piece.m_placeEffect = new EffectListRef("vfx_Place_smelter", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "vfx_watersplash_bathtub").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed", "vfx_watersplash_bathtub", "vfx_barrle_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 1000f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Fermenting Barrel");

            build.RequiredItems.Add("YggdrasilWood", 5, true);
            build.RequiredItems.Add("Bronze", 5, true);
            build.RequiredItems.Add("Resin", 10, true);
            build.Snapshot();
        };
        var piece_dverger_pickaxe = new Clone("dvergrprops_pickaxe");
        piece_dverger_pickaxe.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var meshCollider = prefab.GetComponentInChildren<MeshCollider>();
            meshCollider.convex = false;
            var collider = prefab.AddCollider();
                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_dverger_pickaxe";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_smallitem", "sfx_build_hammer_metal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_HitSparks", "sfx_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_HitSparks", "sfx_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 1000f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Dverger Pickaxe");

            build.RequiredItems.Add("YggdrasilWood", 1, true);
            build.RequiredItems.Add("Iron", 1, true);
            build.Snapshot();
        };
        var piece_dverger_beam = new Clone("dvergrtown_wood_beam");
        piece_dverger_beam.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();

            var meshNew = prefab.transform.Find("New").gameObject;
            var meshWorn = prefab.transform.Find("Worn").gameObject;
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);

            var collider = prefab.GetComponentInChildren<BoxCollider>();
            var corners = collider.GetLocalCorners();
            for (int i = 0; i < corners.Length; ++i)
            {
                var corner = corners[i];
                var snap = new GameObject($"$hud_snappoint_corner {i}");
                snap.SetActive(false);
                snap.transform.SetParent(prefab.transform);
                snap.tag = "snappoint";
                snap.transform.localPosition = corner;
            }
            
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_dverger_beam";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_beam", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_SawDust", "sfx_wood_destroyed").m_effectList;
            wnt.m_new = meshNew;
            wnt.m_worn = meshWorn;
            wnt.m_wet = meshWorn;
            wnt.m_broken = meshWorn;
            wnt.m_materialType = WearNTear.MaterialType.HardWood;
            wnt.m_health = 1000f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Yggdrasil Beam");

            build.RequiredItems.Add("YggdrasilWood", 2, true);
            build.Snapshot();
        };
        var piece_dverger_pole = new Clone("dvergrtown_wood_pole");
        piece_dverger_pole.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();

            var meshNew = prefab.transform.Find("New").gameObject;
            var meshWorn = prefab.transform.Find("Worn").gameObject;
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);

            var collider = prefab.GetComponentInChildren<BoxCollider>();
            var corners = collider.GetLocalCorners();
            for (int i = 0; i < corners.Length; ++i)
            {
                var corner = corners[i];
                var snap = new GameObject($"$hud_snappoint_corner {i}");
                snap.SetActive(false);
                snap.transform.SetParent(prefab.transform);
                snap.tag = "snappoint";
                snap.transform.localPosition = corner;
            }
            
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_dverger_pole";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_beam", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_SawDust", "sfx_wood_destroyed").m_effectList;
            wnt.m_new = meshNew;
            wnt.m_worn = meshWorn;
            wnt.m_wet = meshWorn;
            wnt.m_broken = meshWorn;
            wnt.m_materialType = WearNTear.MaterialType.HardWood;
            wnt.m_health = 1000f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Yggdrasil Pole");

            build.RequiredItems.Add("YggdrasilWood", 2, true);
            build.RequiredItems.Add("Copper", 1, true);
            build.Snapshot();
        };
        var piece_dverger_support = new Clone("dvergrtown_wood_support");
        piece_dverger_support.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);

            var colliders = prefab.GetComponentsInChildren<BoxCollider>();
            int index = 0;
            foreach (var collider in colliders)
            {
                var corners = collider.GetLocalCorners();
                for (int i = 0; i < corners.Length; ++i)
                {
                    ++index;
                    var corner = corners[i];
                    var snap = new GameObject($"$hud_snappoint_corner {index}");
                    snap.SetActive(false);
                    snap.transform.SetParent(prefab.transform);
                    snap.tag = "snappoint";
                    snap.transform.localPosition = corner;
                }
            }
            
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_dverger_support";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_beam", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_SawDust", "sfx_wood_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.HardWood;
            wnt.m_health = 1000f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Yggdrasil Support");

            build.RequiredItems.Add("YggdrasilWood", 8, true);
            build.Snapshot();
        };
        var piece_dvergrtown_wood_wall01 = new Clone("dvergrtown_wood_wall01");
        piece_dvergrtown_wood_wall01.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);

            var collider = prefab.GetComponentInChildren<BoxCollider>();
            collider.transform.localPosition += new Vector3(0f, -2f, 0f);
            var corners = collider.GetLocalCorners();
            for (int i = 0; i < corners.Length; ++i)
            {
                var corner = corners[i];
                var snap = new GameObject($"$hud_snappoint_corner {i}");
                snap.SetActive(false);
                snap.transform.SetParent(prefab.transform);
                snap.tag = "snappoint";
                snap.transform.localPosition = corner;
            }
            
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_dverger_wall1";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_beam", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_SawDust", "sfx_wood_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.HardWood;
            wnt.m_health = 1000f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Yggdrasil Wall");

            build.RequiredItems.Add("YggdrasilWood", 2, true);
            build.RequiredItems.Add("Copper", 2, true);
            build.Snapshot();
        };
        
        var piece_dvergrtown_wood_wall02 = new Clone("dvergrtown_wood_wall02");
        piece_dvergrtown_wood_wall02.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);

            var collider = prefab.GetComponentInChildren<BoxCollider>();
            var corners = collider.GetLocalCorners();
            for (int i = 0; i < corners.Length; ++i)
            {
                var corner = corners[i];
                var snap = new GameObject($"$hud_snappoint_corner {i}");
                snap.SetActive(false);
                snap.transform.SetParent(prefab.transform);
                snap.tag = "snappoint";
                snap.transform.localPosition = corner;
            }
            
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_dverger_wall2";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_beam", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_SawDust", "sfx_wood_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.HardWood;
            wnt.m_health = 1000f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Yggdrasil Wall");

            build.RequiredItems.Add("YggdrasilWood", 2, true);
            build.Snapshot();
        };
        
        var piece_dvergrtown_wood_wall03 = new Clone("dvergrtown_wood_wall03");
        piece_dvergrtown_wood_wall03.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);

            if (!prefab.HasCollider()) prefab.AddCollider();
            
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_dverger_wall3";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_beam", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_SawDust", "sfx_wood_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.HardWood;
            wnt.m_health = 1000f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Yggdrasil Wall Door");

            build.RequiredItems.Add("YggdrasilWood", 2, true);
            build.Snapshot();
        };
        var piece_giant_arm = new Clone("giant_arm");
        piece_giant_arm.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_giant_arm";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_stone_floor", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed_large").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Marble;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Giant Arm");

            build.RequiredItems.Add("BlackMarble", 5, true);
            build.Snapshot();
        };
        var piece_giant_brain = new Clone("giant_brain");
        piece_giant_brain.OnCreated += prefab =>
        {
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_giant_brain_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_stone_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_MudHit", "vfx_MudHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_MudDestroyed", "vfx_MudDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Giant Brain");

            build.RequiredItems.Add("Softtissue", 5, true);
            build.Snapshot();
        };
        var piece_giant_helmet = new Clone("giant_helmet1");
        piece_giant_helmet.OnCreated += prefab =>
        {
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_giant_helmet";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_metal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_HitSparks").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_GiantMetal_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ancient;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Giant Helmet");

            build.RequiredItems.Add("CopperScrap", 5, true);
            build.RequiredItems.Add("IronScrap", 1, true);
            build.Snapshot();
        };
        var piece_giant_helmet2 = new Clone("giant_helmet2");
        piece_giant_helmet2.OnCreated += prefab =>
        {
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_giant_helmet";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_metal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_HitSparks").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_GiantMetal_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ancient;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Giant Helmet");

            build.RequiredItems.Add("CopperScrap", 5, true);
            build.RequiredItems.Add("IronScrap", 1, true);
            build.Snapshot();
        };
        var piece_giant_ribs = new Clone("giant_ribs");
        piece_giant_ribs.OnCreated += prefab =>
        {
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_giant_ribs";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit_Marble").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed_marble").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Marble;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Giant Ribs");

            build.RequiredItems.Add("BlackMarble", 5, true);
            build.Snapshot();
        };
        var piece_giant_skull = new Clone("giant_skull");
        piece_giant_skull.OnCreated += prefab =>
        {
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_giant_skull";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit_Marble").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed_marble").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Marble;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Giant Skull");

            build.RequiredItems.Add("BlackMarble", 5, true);
            build.Snapshot();
        };
        var piece_giant_sword = new Clone("giant_sword1");
        piece_giant_sword.OnCreated += prefab =>
        {
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_giant_sword";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_metal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_HitSparks").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_GiantMetal_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ancient;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Giant Sword");

            build.RequiredItems.Add("CopperScrap", 5, true);
            build.RequiredItems.Add("IronScrap", 1, true);
            build.Snapshot();
        };
        var piece_giant_sword2 = new Clone("giant_sword2");
        piece_giant_sword2.OnCreated += prefab =>
        {
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_giant_sword";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_metal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_HitSparks").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_GiantMetal_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ancient;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Giant Sword");

            build.RequiredItems.Add("CopperScrap", 5, true);
            build.RequiredItems.Add("IronScrap", 1, true);
            build.Snapshot();
        };
        var piece_lured_wisp = new Clone("LuredWisp");
        piece_lured_wisp.OnCreated += prefab =>
        {
            prefab.Remove<ZSyncTransform>();
            prefab.Remove<LuredWisp>();
            prefab.Remove<Pickable>();

            var sphere = prefab.GetComponentInChildren<SphereCollider>();
            DestroyImmediate(sphere);
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_lured_wisp";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_hit", "vfx_HitSparks").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_hit", "vfx_HitSparks").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
                
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Wisp");

            build.RequiredItems.Add("Wisp", 1, true);

            if (BuildPiece.TryGetPrefab("Wisp", out var ember) &&
                ember.TryGetComponent(out ItemDrop component))
            {
                piece.m_icon = component.m_itemData.m_shared.m_icons[0];
            }
        };
        
        var piece_black_core_stand = new Clone("Pickable_BlackCoreStand");
        piece_black_core_stand.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.transform.localRotation = Quaternion.identity;
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
                
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_black_core_stand";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_metal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_HitSparks", "sfx_metal_blocked").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_HitSparks", "sfx_metal_blocked").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Iron;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Black Core Stand");

            build.RequiredItems.Add("BlackCore", 1, true);
            build.RequiredItems.Add("Iron", 1, true);
            build.Snapshot();
        };
        var piece_dverger_demister = new Clone("dverger_demister");
        piece_dverger_demister.OnCreated += prefab =>
        {
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_dverger_demister";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_comfort = 1;
            piece.m_comfortGroup = Piece.ComfortGroup.Banner;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_metal");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Demister");

            build.RequiredItems.Add("Wisp", 1, true);
            build.RequiredItems.Add("Iron", 1, true);
            build.Snapshot();
        };
        var piece_dverger_demister_broken = new Clone("dverger_demister_broken");
        piece_dverger_demister_broken.OnCreated += prefab =>
        {
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_dverger_demister_broken";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_comfort = 1;
            piece.m_comfortGroup = Piece.ComfortGroup.Banner;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_metal");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Broken Demister");

            build.RequiredItems.Add("Wisp", 1, true);
            build.RequiredItems.Add("Iron", 1, true);
            build.Snapshot();
        };
        var piece_dverger_demister_large = new Clone("dverger_demister_large");
        piece_dverger_demister_large.OnCreated += prefab =>
        {
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_dverger_demister_large";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_comfort = 1;
            piece.m_comfortGroup = Piece.ComfortGroup.Banner;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_metal");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Large Demister");

            build.RequiredItems.Add("Wisp", 1, true);
            build.RequiredItems.Add("Iron", 1, true);
            build.Snapshot();
        };
        var piece_rock_mistlands = new Clone("rock_mistlands1");
        piece_rock_mistlands.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.7f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_rock_mistlands";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_RockDestroyed_large").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Mistlands Rock");

            build.RequiredItems.Add("BlackMarble", 3, true);
            build.Snapshot();
        };
        var piece_seeker_egg = new Clone("SeekerEgg");
        piece_seeker_egg.OnCreated += prefab =>
        {
            prefab.Remove<EggHatch>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_seeker_egg";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("fx_egg_splash").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("fx_egg_splash").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Seeker Egg");

            build.RequiredItems.Add("RoyalJelly",1 ,true);
            build.Snapshot();
        };
        var piece_shoot_stump = new Clone("ShootStump");
        piece_shoot_stump.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_shoot_stub";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_tree_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_break").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Shoot Stub");

            build.RequiredItems.Add("Sap", 1, true);
            build.Snapshot();
        };
        var piece_rock_mistlands2 = new Clone("rock_mistlands2");
        piece_rock_mistlands2.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.7f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_rock_mistlands";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Mistlands Rock");

            build.RequiredItems.Add("BlackMarble", 3, true);
            build.Snapshot();
        };
        
        var piece_creep_slime = new Clone("CreepProp_entrance1");
        piece_creep_slime.OnCreated += prefab =>
        {
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_creep_slime";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Slime");

            build.RequiredItems.Add("RoyalJelly", 1, true);
            build.Snapshot();
        };
        
        var piece_creep_slime2 = new Clone("CreepProp_entrance2");
        piece_creep_slime2.OnCreated += prefab =>
        {
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_creep_slime";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Slime");

            build.RequiredItems.Add("RoyalJelly", 1, true);
            build.Snapshot();
        };
        
        var piece_creep_slime3 = new Clone("CreepProp_wall01");
        piece_creep_slime3.OnCreated += prefab =>
        {
            var random = prefab.GetComponentInChildren<RandomPieceRotation>();
            DestroyImmediate(random);
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_creep_slime";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Slime");

            build.RequiredItems.Add("RoyalJelly", 1, true);
            build.Snapshot();
        };
        
        var piece_shoot_small = new Clone("YggaShoot_small1");
        piece_shoot_small.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ygga_shoot_small";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_break", "vfx_yggashoot_small1_destroy");
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Small Yggrasil Tree");

            build.RequiredItems.Add("Sap", 1, true);
            build.Snapshot();
        };

        var piece_shoot_tree = new Clone("YggaShoot1");
        piece_shoot_tree.OnCreated += prefab =>
        {
            prefab.Remove<TreeBase>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ygga_shoot_tree";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_tree_hit");
            wnt.m_destroyedEffect = new EffectListRef("sfx_tree_fall", "vfx_yggashoot_cut");
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Yggdrasil Tree");

            build.RequiredItems.Add("Sap", 1, true);
            build.Snapshot();
        };
        var piece_shoot_tree2 = new Clone("YggaShoot2");
        piece_shoot_tree2.OnCreated += prefab =>
        {
            prefab.Remove<TreeBase>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ygga_shoot_tree";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_tree_hit");
            wnt.m_destroyedEffect = new EffectListRef("sfx_tree_fall", "vfx_yggashoot_cut");
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Yggdrasil Tree");

            build.RequiredItems.Add("Sap", 1, true);
            build.Snapshot();
        };
        var piece_shoot_tree3 = new Clone("YggaShoot3");
        piece_shoot_tree3.OnCreated += prefab =>
        {
            prefab.Remove<TreeBase>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ygga_shoot_tree";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_tree_hit");
            wnt.m_destroyedEffect = new EffectListRef("sfx_tree_fall", "vfx_yggashoot_cut");
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Yggdrasil Tree");

            build.RequiredItems.Add("Sap", 1, true);
            build.Snapshot();
        };
    }
}