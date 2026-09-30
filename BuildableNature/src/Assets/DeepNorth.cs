using ClassSystem;
using PieceManager;
using UnityEngine;
using static UnityEngine.Object;

namespace BuildableNature;

public static partial class Assets
{
    public static void DeepNorth()
    {
        var piece_black_ice_core = new Clone("BlackIce_Core");
        piece_black_ice_core.OnCreated += prefab =>
        {
            prefab.Remove<TriggerPersistentEventOnDestroy>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<SpawnArea>();
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_black_ice_core";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_ice_hit", "vfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_blackice_destroyed", "sfx_malicious_ice_break").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Black Ice Core");

            build.RequiredItems.Add("HatefulBlood", 1, true);
            build.Snapshot();
        };
        var piece_black_ice_core_outer = new Clone("BlackIce_Core_outer");
        piece_black_ice_core_outer.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_black_ice_core_outer";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_ice_hit", "vfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_blackice_destroyed", "sfx_malicious_ice_break").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Black Ice Core Outer");

            build.RequiredItems.Add("HatefulBlood", 1, true);
            build.Snapshot();
        };
        var piece_black_ice_start = new Clone("BlackIce_Start");
        piece_black_ice_start.OnCreated += prefab =>
        {
            prefab.Remove<TriggerPersistentEventOnDestroy>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_black_ice_core_outer";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_ice_hit", "vfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_blackice_destroyed", "sfx_malicious_ice_break").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Black Ice Core");

            build.RequiredItems.Add("HatefulBlood", 1, true);
            build.Snapshot();
        };
        var piece_black_ice_shard1 = new Clone("BlackIceShard_01");
        piece_black_ice_shard1.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_black_ice_shard";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_ice_hit", "vfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_blackice_destroyed", "sfx_malicious_ice_break").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Black Ice Shard");

            build.RequiredItems.Add("Ice", 1, true);
            build.Snapshot();
        };
        var piece_black_ice_shard2 = new Clone("BlackIceShard_02");
        piece_black_ice_shard2.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_black_ice_shard";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_ice_hit", "vfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_blackice_destroyed", "sfx_malicious_ice_break").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Black Ice Shard");

            build.RequiredItems.Add("Ice", 1, true);
            build.Snapshot();
        };
        var piece_blob_mork = new Clone("BlobMorkBig");
        piece_blob_mork.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<SpawnArea>();
            prefab.Remove<HoverText>();
            prefab.Remove<StaticPhysics>();
            var aoe = prefab.GetComponentInChildren<Aoe>();
            DestroyImmediate(aoe);
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_blob_mork";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_blobmork_hit", "sfx_blob_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_blob_death", "vfx_blobmork_death").m_effectList;
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
            build.Name.English("Blob Cube");

            build.RequiredItems.Add("OozeMork",10 ,true);
            build.Snapshot();
        };
        var piece_bush_deepnorth = new Clone("Bush01_deepnorth");
        piece_bush_deepnorth.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();

            var capsule = prefab.GetComponentInChildren<CapsuleCollider>();
            DestroyImmediate(capsule);
            var sphere = prefab.GetComponentsInChildren<SphereCollider>();
            foreach (var s in sphere)
            {
                DestroyImmediate(s);
            }
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var collider = prefab.AddCollider(0.6f);
            collider.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_bush_deepnorth";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_bush_leaf_puff", "sfx_bush_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_bush_destroyed").m_effectList;
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
            build.Name.English("Frozen Bush");

            build.RequiredItems.Add("Wood",1 ,true);
            build.RequiredItems.Add("Ice", 1, true);
            build.Snapshot();
        };
        var piece_elaking_trashpile = new Clone("elaking_trashpile");
        piece_elaking_trashpile.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<HoverText>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.7f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_elaking_trashpile";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_hit", "vfx_HitSparks").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("elaking_trashpile_destruction", "sfx_wood_destroyed").m_effectList;
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
            build.Name.English("Elaking Trash Pile");

            build.RequiredItems.Add("Frostwood",10 ,true);
            build.Snapshot();
        };
        var piece_fimbul_winter_orb = new Clone("FimbulvinterOrb");
        piece_fimbul_winter_orb.OnCreated += prefab =>
        {
            prefab.Remove<TriggerPersistentEventOnDestroy>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_fimbul_winter_orb";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_wall", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef( "sfx_hit", "vfx_HitSparks").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_noSupportWear = true;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Winter Orb");

            build.RequiredItems.Add("Ice", 10, true);
            build.Snapshot();
        };
        var piece_fir_big = new Clone("FirTree_big");
        piece_fir_big.OnCreated += prefab =>
        {
            prefab.Remove<TreeBase>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var capsule = prefab.GetComponentInChildren<CapsuleCollider>();
            DestroyImmediate(capsule);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_firtree_big";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_tree_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_tree_fall", "vfx_firtreecut").m_effectList;
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
            build.Name.English("Winter Fir Tree");

            build.RequiredItems.Add("FirConeFrost", 1, true);
            build.Snapshot();
        };
        var piece_firtree_big_stub = new Clone("FirTree_Big_plantable_Stub");
        piece_firtree_big_stub.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_firtree_big_stub";
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
            build.Name.English("Winter Fir Tree Stub");

            build.RequiredItems.Add("FirConeFrost", 1, true);
            build.Snapshot();
        };
        var piece_firtree_big_sapling = new Clone("FirTree_big_Sapling");
        piece_firtree_big_sapling.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_firtree_big_sapling";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_canBeRemoved = true;
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
            build.Name.English("Winter Fir Tree Sapling");

            build.RequiredItems.Add("FirConeFrost", 1, true);
        };
        var piece_firtree_snow_stub = new Clone("FirTree_Snow_Stub");
        piece_firtree_snow_stub.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_firtree_snow_stub";
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
            build.Name.English("Big Fir Tree Stub");

            build.RequiredItems.Add("FirConeFrost", 1, true);
            build.Snapshot();
        };
        var piece_frozen_greydwarf = new Clone("FrozenGD");
        piece_frozen_greydwarf.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_frozen_greydwarf";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_smallitem", "sfx_build_hammer_crystal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_frozengd_destroyed", "sfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Frozen Greydwarf");

            build.RequiredItems.Add("Ice", 3, true);
            build.RequiredItems.Add("TrophyGreydwarf", 1, true);
            build.Snapshot();
        };
        var piece_frozen_ship = new Clone("frozenship");
        piece_frozen_ship.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var guide = prefab.GetComponentInChildren<GuidePoint>();
            DestroyImmediate(guide);
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_frozen_ship";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_VikingShip", "sfx_build_hammer_crystal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_Destroyed_VikingShip_frozen", "sfx_ship_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Frozen Ship");

            build.RequiredItems.Add("Ice", 10, true);
            build.RequiredItems.Add("FineWood", 20, true);
            build.Snapshot();
        };
        var piece_frozen_ship2 = new Clone("frozenship02");
        piece_frozen_ship2.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var guide = prefab.GetComponentInChildren<GuidePoint>();
            DestroyImmediate(guide);
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_frozen_ship";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_VikingShip", "sfx_build_hammer_crystal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_Destroyed_VikingShip_frozen", "sfx_ship_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Frozen Ship");

            build.RequiredItems.Add("Ice", 10, true);
            build.RequiredItems.Add("FineWood", 20, true);
            build.Snapshot();
        };
        var piece_frozen_ship3 = new Clone("frozenship03");
        piece_frozen_ship3.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var guide = prefab.GetComponentInChildren<GuidePoint>();
            DestroyImmediate(guide);
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_frozen_ship";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_VikingShip", "sfx_build_hammer_crystal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_Destroyed_VikingShip_frozen", "sfx_ship_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Frozen Ship");

            build.RequiredItems.Add("Ice", 10, true);
            build.RequiredItems.Add("FineWood", 20, true);
            build.Snapshot();
        };
        var piece_frozen_skeleton = new Clone("FrozenSkeleton_Pose1");
        piece_frozen_skeleton.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_frozen_skeleton";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_smallitem", "sfx_build_hammer_crystal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_frozengd_destroyed", "sfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Frozen Skeleton");

            build.RequiredItems.Add("Ice", 3, true);
            build.RequiredItems.Add("TrophySkeleton", 1, true);
            build.Snapshot();
        };
        
        var piece_frozen_skeleton2 = new Clone("FrozenSkeleton_Pose2");
        piece_frozen_skeleton2.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_frozen_skeleton";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_smallitem", "sfx_build_hammer_crystal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_frozengd_destroyed", "sfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Frozen Skeleton");

            build.RequiredItems.Add("Ice", 3, true);
            build.RequiredItems.Add("TrophySkeleton", 1, true);
            build.Snapshot();
        };
        var piece_gold_vein = new Clone("goldvein");
        piece_gold_vein.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            prefab.Remove<HoverText>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_gold_vein";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed_large").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Gold Vein");

            build.RequiredItems.Add("Stone", 5, true);
            build.RequiredItems.Add("GoldOre", 1, true);
            build.Snapshot();
        };
        var piece_hole_root_floor = new Clone("HoleRock_rootFloor1");
        piece_hole_root_floor.OnCreated += prefab =>
        {
            prefab.Remove<MaterialVariation>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_hole_rock_floor";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_branch_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_branch_break", "vfx_SawDust").m_effectList;
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
            build.Name.English("Root Floor");

            build.RequiredItems.Add("Frostwood", 2, true);
            build.Snapshot();
        };
        
        var piece_hole_root_wall = new Clone("HoleRock_rootWall1");
        piece_hole_root_wall.OnCreated += prefab =>
        {
            prefab.Remove<MaterialVariation>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_hole_rock_wall";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_branch_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_branch_break", "vfx_SawDust").m_effectList;
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
            build.Name.English("Root Wall");

            build.RequiredItems.Add("Frostwood", 2, true);
            build.Snapshot();
        };
        var piece_iceberg = new Clone("ice_rock1");
        piece_iceberg.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_iceberg";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_ice_destroyed", "vfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Iceberg");

            build.RequiredItems.Add("Ice", 10, true);
            build.Snapshot();
        };
        var piece_ice_float = new Clone("ice1");
        piece_ice_float.OnCreated += prefab =>
        {
            prefab.Remove<Floating>();
            prefab.Remove<Rigidbody>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<ZSyncTransform>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ice_platform";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_ice_destroyed", "vfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ice Platform");

            build.RequiredItems.Add("Ice", 4, true);
            build.Snapshot();
        };
        var piece_ice_pond = new Clone("IcePond_rock");
        piece_ice_pond.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.layer = 10;
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ice_pond";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_clipEverything = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_ice_destroyed", "vfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ice Pond");

            build.RequiredItems.Add("Ice", 10, true);
            build.Snapshot();
        };
        var piece_ice_shard1 = new Clone("IceShard_01");
        piece_ice_shard1.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ice_shard";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_clipEverything = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_ice_destroyed", "vfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ice Shard");

            build.RequiredItems.Add("Ice", 1, true);
            build.Snapshot();
        };
        var piece_ice_shard2 = new Clone("IceShard_02");
        piece_ice_shard2.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ice_shard";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_clipEverything = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_ice_destroyed", "vfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ice Shard");

            build.RequiredItems.Add("Ice", 1, true);
            build.Snapshot();
        };
        var piece_ice_shard3 = new Clone("IceShard_03");
        piece_ice_shard3.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ice_shard";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_clipEverything = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_ice_destroyed", "vfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ice Shard");

            build.RequiredItems.Add("Ice", 1, true);
            build.Snapshot();
        };
        var piece_ice_shard4 = new Clone("IceShard_04");
        piece_ice_shard4.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ice_shard";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_clipEverything = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_ice_destroyed", "vfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ice Shard");

            build.RequiredItems.Add("Ice", 1, true);
            build.Snapshot();
        };
        var piece_ice_shard5 = new Clone("IceShard_05");
        piece_ice_shard5.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ice_shard";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_clipEverything = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_ice_destroyed", "vfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ice Shard");

            build.RequiredItems.Add("Ice", 1, true);
            build.Snapshot();
        };
        var piece_ice_shard6 = new Clone("IceShard_06");
        piece_ice_shard6.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ice_shard";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_clipEverything = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_ice_destroyed", "vfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ice Shard");

            build.RequiredItems.Add("Ice", 1, true);
            build.Snapshot();
        };
        var piece_ice_shore = new Clone("IceShore_1");
        piece_ice_shore.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.layer = 10;
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ice_platform_large";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_clipEverything = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_ice_destroyed", "vfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ice Shore");

            build.RequiredItems.Add("Ice", 10, true);
            build.Snapshot();
        };
        var piece_ice_shore_shard = new Clone("IceShoreShard");
        piece_ice_shore_shard.OnCreated += prefab =>
        {
            prefab.Remove<Floating>();
            prefab.Remove<Rigidbody>();
            prefab.Remove<Destructible>();
            prefab.Remove<ZSyncTransform>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ice_platform";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_ice_hit", "sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_ice_destroyed", "vfx_ice_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;

            wnt.m_materialType = WearNTear.MaterialType.Ice;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ice Platform");

            build.RequiredItems.Add("Ice", 4, true);
            build.Snapshot();
        };
        SetupWallGemStands();
        var piece_lingon_berry_bush = new Clone("LingonberryBush");
        piece_lingon_berry_bush.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();

            var sphere = prefab.GetComponentInChildren<SphereCollider>();
            DestroyImmediate(sphere);
            var capsules = prefab.GetComponentsInChildren<CapsuleCollider>();
            for (int i = 0; i < capsules.Length; ++i)
            {
                var c = capsules[i];
                DestroyImmediate(c);
            }
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_lingonberry_bush";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_clipEverything = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_bush_leaf_puff").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_bush_destroyed", "sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
            
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Lingonberry Bush");

            build.RequiredItems.Add("Lingonberry", 1, true);
            build.Snapshot();
        };
        var piece_memorial_stone_large = new Clone("MemorialStone_Large");
        piece_memorial_stone_large.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<HoverText>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_memorial";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
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
            build.Name.English("Stone Memorial");

            build.RequiredItems.Add("Stone", 10, true);
            build.Snapshot();
        };
        var piece_memorial_stone_medium = new Clone("MemorialStone_Medium");
        piece_memorial_stone_medium.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<HoverText>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_memorial";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
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
            build.Name.English("Stone Memorial");

            build.RequiredItems.Add("Stone", 10, true);
            build.Snapshot();
        };
        var piece_memorial_stone_small = new Clone("MemorialStone_Small");
        piece_memorial_stone_small.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<HoverText>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_memorial";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
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
            build.Name.English("Stone Memorial");

            build.RequiredItems.Add("Stone", 10, true);
            build.Snapshot();
        };
        var piece_morkhalla_bedroll = new Clone("Morkhalla_Bedroll1");
        piece_morkhalla_bedroll.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_bedroll";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_wood_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_destroyed", "vfx_SawDust").m_effectList;
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
            build.Name.English("Morkhalla Bedroll");

            build.RequiredItems.Add("MooseHide", 1, true);
            build.RequiredItems.Add("LoxPelt", 1 , true);
            build.RequiredItems.Add("AskHide", 1, true);
            build.RequiredItems.Add("WolfPelt", 1, true);
            build.Snapshot();
        };
        var piece_morkhalla_bedroll2 = new Clone("Morkhalla_Bedroll2");
        piece_morkhalla_bedroll2.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_bedroll";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_wood_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_destroyed", "vfx_SawDust").m_effectList;
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
            build.Name.English("Morkhalla Bedroll");

            build.RequiredItems.Add("MooseHide", 1, true);
            build.RequiredItems.Add("LoxPelt", 1 , true);
            build.RequiredItems.Add("AskHide", 1, true);
            build.RequiredItems.Add("WolfPelt", 1, true);
            build.Snapshot();
        };
        
        var piece_morkhalla_firepit = new Clone("Morkhalla_firepit");
        piece_morkhalla_firepit.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_morkhalla_firepit";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor | Piece.UsageTagFlags.Lighting;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_metal_blocked", "vfx_HitSparks").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_metal_blocked").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
            wnt.m_materialType = WearNTear.MaterialType.Iron;
            wnt.m_health = 1000f;
            
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Morkhalla Fire Pit");

            build.RequiredItems.Add("Ironpit", 1, true);
            build.RequiredItems.Add("Wood", 1 , false);
            build.RequiredItems.Add("MemorialCoal", 1, true);
            build.Snapshot();
        };

        var piece_morkhalla_gate_wall = new Clone("Morkhalla_GateDoor");
        piece_morkhalla_gate_wall.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            
            var snap1 = new GameObject($"$hud_snappoint_corner 1");
            snap1.SetActive(false);
            snap1.transform.SetParent(prefab.transform);
            snap1.tag = "snappoint";
            snap1.transform.localPosition = new Vector3(-2f, 3.5f, 0f);
            var snap2 = new GameObject($"$hud_snappoint_corner 2");
            snap2.SetActive(false);
            snap2.transform.SetParent(prefab.transform);
            snap2.tag = "snappoint";
            snap2.transform.localPosition = new Vector3(2f, 3.5f, 0f);
            var snap3 = new GameObject($"$hud_snappoint_corner 3");
            snap3.SetActive(false);
            snap3.transform.SetParent(prefab.transform);
            snap3.tag = "snappoint";
            snap3.transform.localPosition = new Vector3(-2f, -4f, 0f);
            var snap4 = new GameObject($"$hud_snappoint_corner 4");
            snap4.SetActive(false);
            snap4.transform.SetParent(prefab.transform);
            snap4.tag = "snappoint";
            snap4.transform.localPosition = new Vector3(2f, -4f, 0f);
            
            var c = new GameObject("collider").AddComponent<BoxCollider>();
            c.transform.SetParent(prefab.transform);
            c.transform.localPosition = Vector3.zero;
            c.size = new Vector3(4f, 0.01f, 0.08f);
            c.excludeLayers = LayerMask.GetMask("character");
            
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_gate_wall";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_metal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_metalbars_break", "vfx_HitSparks").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_metalbars_break").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
            wnt.m_noSupportWear = false;
            var port = prefab.AddComponent<Portcullis>();
            port.m_openEffects = new EffectListRef("sfx_catapult_legs_up");
            port.m_closedEffects = new EffectListRef("sfx_catapult_legs_down");
            port.m_gate = Utils.FindChild(prefab.transform, "gate");
            port.m_openPosition = Vector3.zero;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Morkhalla Portcullis");

            build.RequiredItems.Add("Frostwood", 1, true);
            build.RequiredItems.Add("Iron", 2, true);
            build.Snapshot();
        };

        var piece_morkhalla_gate_barricade = new Clone("Morkhalla_GateDoor02");
        piece_morkhalla_gate_barricade.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);

            var snap1 = new GameObject($"$hud_snappoint_corner 1");
            snap1.SetActive(false);
            snap1.transform.SetParent(prefab.transform);
            snap1.tag = "snappoint";
            snap1.transform.localPosition = new Vector3(-2f, 3f, 0f);
            var snap2 = new GameObject($"$hud_snappoint_corner 2");
            snap2.SetActive(false);
            snap2.transform.SetParent(prefab.transform);
            snap2.tag = "snappoint";
            snap2.transform.localPosition = new Vector3(2f, 3f, 0f);
            var snap3 = new GameObject($"$hud_snappoint_corner 3");
            snap3.SetActive(false);
            snap3.transform.SetParent(prefab.transform);
            snap3.tag = "snappoint";
            snap3.transform.localPosition = new Vector3(-2f, -3f, 0f);
            var snap4 = new GameObject($"$hud_snappoint_corner 4");
            snap4.SetActive(false);
            snap4.transform.SetParent(prefab.transform);
            snap4.tag = "snappoint";
            snap4.transform.localPosition = new Vector3(2f, -3f, 0f);
            
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_barricade";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_wood_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_destroyed", "vfx_SawDust").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Morkhalla Barricade");

            build.RequiredItems.Add("Frostwood", 10, true);
            build.RequiredItems.Add("IronNails", 4 , true);
            build.Snapshot();
        };
        
        var piece_morkhalla_gate_wall2 = new Clone("Morkhalla_GateDoor03");
        piece_morkhalla_gate_wall2.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            
            var snap1 = new GameObject($"$hud_snappoint_corner 1");
            snap1.SetActive(false);
            snap1.transform.SetParent(prefab.transform);
            snap1.tag = "snappoint";
            snap1.transform.localPosition = new Vector3(-2f, 3.5f, 0f);
            var snap2 = new GameObject($"$hud_snappoint_corner 2");
            snap2.SetActive(false);
            snap2.transform.SetParent(prefab.transform);
            snap2.tag = "snappoint";
            snap2.transform.localPosition = new Vector3(2f, 3.5f, 0f);
            var snap3 = new GameObject($"$hud_snappoint_corner 1");
            snap3.SetActive(false);
            snap3.transform.SetParent(prefab.transform);
            snap3.tag = "snappoint";
            snap3.transform.localPosition = new Vector3(-2f, -4f, 0f);
            var snap4 = new GameObject($"$hud_snappoint_corner 2");
            snap4.SetActive(false);
            snap4.transform.SetParent(prefab.transform);
            snap4.tag = "snappoint";
            snap4.transform.localPosition = new Vector3(2f, -4f, 0f);
            
            var c = new GameObject("collider").AddComponent<BoxCollider>();
            c.transform.SetParent(prefab.transform);
            c.transform.localPosition = Vector3.zero;
            c.size = new Vector3(4f, 0.01f, 0.08f);
            c.excludeLayers = LayerMask.GetMask("character");
            
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_gate_wall";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_metal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_metalbars_break", "vfx_HitSparks").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_metalbars_break").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
            wnt.m_noSupportWear = false;
            var port = prefab.AddComponent<Portcullis>();
            port.m_openEffects = new EffectListRef("sfx_catapult_legs_up").m_effectList;
            port.m_closedEffects = new EffectListRef("sfx_catapult_legs_down").m_effectList;
            port.m_gate = model.transform;
            port.m_openPosition = new Vector3(0f, 4f, 0f);
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Morkhalla Portcullis");

            build.RequiredItems.Add("Frostwood", 1, true);
            build.RequiredItems.Add("Iron", 2, true);
            build.Snapshot();
        };

        var piece_morkhalla_rubble_trash = new Clone("Morkhalla_rubble_trashpile");
        piece_morkhalla_rubble_trash.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_rubble_trashpile";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_wood_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_destroyed", "vfx_SawDust").m_effectList;
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
            build.Name.English("Morkhalla Trash Pile");

            build.RequiredItems.Add("Frostwood", 1, true);
            build.RequiredItems.Add("Blackwood", 1 , true);
            build.RequiredItems.Add("Wood", 2, true);
            build.Snapshot();
        };

        var piece_morkhalla_rubble = new Clone("Morkhalla_Rubble1");
        piece_morkhalla_rubble.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_rubble";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_RockDestroyed", "sfx_rock_destroyed").m_effectList;
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
            build.Name.English("Morkhalla Rubble");

            build.RequiredItems.Add("Grausten", 5, true);
            build.RequiredItems.Add("AncientCoin", 1 , true);
            build.Snapshot();
        };
        
        var piece_morkhalla_rubble2 = new Clone("Morkhalla_Rubble2");
        piece_morkhalla_rubble2.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_rubble";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_RockDestroyed", "sfx_rock_destroyed").m_effectList;
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
            build.Name.English("Morkhalla Rubble");

            build.RequiredItems.Add("Grausten", 5, true);
            build.RequiredItems.Add("AncientCoin", 1 , true);
            build.Snapshot();
        };
        
        var piece_morkhalla_rubble3 = new Clone("Morkhalla_Rubble3");
        piece_morkhalla_rubble3.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_rubble";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_RockDestroyed", "sfx_rock_destroyed").m_effectList;
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
            build.Name.English("Morkhalla Rubble");

            build.RequiredItems.Add("Grausten", 5, true);
            build.RequiredItems.Add("AncientCoin", 1 , true);
            build.Snapshot();
        };
        
        var piece_morkhalla_rubble4 = new Clone("Morkhalla_Rubble4");
        piece_morkhalla_rubble4.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_rubble";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_RockDestroyed", "sfx_rock_destroyed").m_effectList;
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
            build.Name.English("Morkhalla Rubble");

            build.RequiredItems.Add("Grausten", 5, true);
            build.RequiredItems.Add("AncientCoin", 1 , true);
            build.Snapshot();
        };

        var piece_morkhalla_rug_corner = new Clone("Morkhalla_Rug_corner");
        piece_morkhalla_rug_corner.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_rug_corner";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_comfort = 2;
            piece.m_comfortGroup = Piece.ComfortGroup.Carpet;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_wood_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_destroyed", "vfx_SawDust").m_effectList;
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
            build.Name.English("Morkhalla Rug Corner");

            build.RequiredItems.Add("JuteRed", 5, true);
            build.RequiredItems.Add("AncientCoin", 1 , true);
            build.Snapshot();
        };
        
        var piece_morkhalla_rug_end = new Clone("Morkhalla_Rug_end1");
        piece_morkhalla_rug_end.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_rug_end";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_comfort = 2;
            piece.m_comfortGroup = Piece.ComfortGroup.Carpet;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_wood_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_destroyed", "vfx_SawDust").m_effectList;
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
            build.Name.English("Morkhalla Rug End");

            build.RequiredItems.Add("JuteRed", 5, true);
            build.RequiredItems.Add("AncientCoin", 1 , true);
            build.Snapshot();
        };
        
        var piece_morkhalla_rug_end2 = new Clone("Morkhalla_Rug_end2");
        piece_morkhalla_rug_end2.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_rug_end";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_comfort = 2;
            piece.m_comfortGroup = Piece.ComfortGroup.Carpet;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_wood_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_destroyed", "vfx_SawDust").m_effectList;
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
            build.Name.English("Morkhalla Rug End");

            build.RequiredItems.Add("JuteRed", 5, true);
            build.RequiredItems.Add("AncientCoin", 1 , true);
            build.Snapshot();
        };
        
        var piece_morkhalla_rug_middle = new Clone("Morkhalla_Rug_middle");
        piece_morkhalla_rug_middle.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_rug_middle";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_comfort = 2;
            piece.m_comfortGroup = Piece.ComfortGroup.Carpet;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_wood_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_destroyed", "vfx_SawDust").m_effectList;
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
            build.Name.English("Morkhalla Rug Middle");

            build.RequiredItems.Add("JuteRed", 5, true);
            build.RequiredItems.Add("AncientCoin", 1 , true);
            build.Snapshot();
        };
        SetupBrokenStatue();
        var piece_morkhalla_weapon_stand = new Clone("Morkhalla_WeaponStand");
        piece_morkhalla_weapon_stand.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_weapon_stand";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_comfort = 1;
            piece.m_comfortGroup = Piece.ComfortGroup.Display;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_wood_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_destroyed", "vfx_SawDust").m_effectList;
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
            build.Name.English("Morkhalla Weapon Stand");

            build.RequiredItems.Add("Frostwood", 5, true);
            build.RequiredItems.Add("AncientCoin", 1 , true);
            build.Snapshot();
        };
        var piece_morkhalla_web_corner = new Clone("morkhalla_web_corner");
        piece_morkhalla_web_corner.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider())
            {
                var c = prefab.AddCollider();
                c?.excludeLayers = LayerMask.GetMask("character");
            }
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_web";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_wood_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_destroyed", "vfx_morkhalla_web_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
        
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 50f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Morkhalla Web");

            build.RequiredItems.Add("Frostwood", 1, true);
            build.RequiredItems.Add("AncientCoin", 1 , true);
            build.Snapshot();
        };
        var piece_morkhalla_web_horizontal = new Clone("morkhalla_web_horisontal");
        piece_morkhalla_web_horizontal.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider())
            {
                var c = prefab.AddCollider();
                c?.excludeLayers = LayerMask.GetMask("character");
            }
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_web";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_wood_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_destroyed", "vfx_morkhalla_web_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
        
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 50f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Morkhalla Web");

            build.RequiredItems.Add("Frostwood", 1, true);
            build.RequiredItems.Add("AncientCoin", 1 , true);
            build.Snapshot();
        };
        var piece_morkhalla_web_tunnel = new Clone("morkhalla_web_tunnel");
        piece_morkhalla_web_tunnel.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider())
            {
                var c = prefab.AddCollider();
                c?.excludeLayers = LayerMask.GetMask("character");
            }
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_web";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_wood_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_destroyed", "vfx_morkhalla_web_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
        
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 50f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Morkhalla Web");

            build.RequiredItems.Add("Frostwood", 1, true);
            build.RequiredItems.Add("AncientCoin", 1 , true);
            build.Snapshot();
        };
        
        var piece_morkhalla_floor = new Clone("Morkhalla_WoodBoards");
        piece_morkhalla_floor.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            model.transform.localScale = new Vector3(0.83f, 0.83f, 0.8f);
            model.transform.localPosition = Vector3.zero;
            for (int i = 0; i < model.transform.childCount; ++i)
            {
                var child = model.transform.GetChild(i);
                child.localPosition = Vector3.zero;
            }
            
            var snap1 = new GameObject("$hud_snappoint_corner 1");
            snap1.SetActive(false);
            snap1.transform.SetParent(prefab.transform);
            snap1.tag = "snappoint";
            snap1.transform.localPosition = new Vector3(-2f, 0.05f, 0f);
            var snap2 = new GameObject("$hud_snappoint_corner 2");
            snap2.SetActive(false);
            snap2.transform.SetParent(prefab.transform);
            snap2.tag = "snappoint";
            snap2.transform.localPosition = new Vector3(2f, 0.05f, 0f);
            var snap3 = new GameObject("$hud_snappoint_corner 3");
            snap3.SetActive(false);
            snap3.transform.SetParent(prefab.transform);
            snap3.tag = "snappoint";
            snap3.transform.localPosition = new Vector3(-2f, 0.05f, -4f);
            var snap4 = new GameObject("$hud_snappoint_corner 4");
            snap4.SetActive(false);
            snap4.transform.SetParent(prefab.transform);
            snap4.tag = "snappoint";
            snap4.transform.localPosition = new Vector3(2f, 0.05f, -4f);
            
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_floorboards";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Floor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_wood_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_break", "vfx_SawDust").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Timberwood;
            wnt.m_health = 1000f;
            
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Morkhalla Floor");
            build.RequiredItems.Add("Frostwood", 2, true);
            build.RequiredItems.Add("AncientCoin", 1 , true);
            build.Snapshot();
        };
        
        var piece_snow_fir_tree = new Clone("SnowFirTree");
        piece_snow_fir_tree.OnCreated += prefab =>
        {
            prefab.Remove<TreeBase>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();
            var capsule = prefab.GetComponentInChildren<CapsuleCollider>();
            DestroyImmediate(capsule);

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_firtree_snow";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_tree_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_tree_fall", "vfx_firtreecut_snow").m_effectList;
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
            build.Name.English("Snow Fir Tree");

            build.RequiredItems.Add("FirConeFrost", 1, true);
            build.Snapshot();
        };
        var piece_snow_fir_tree2 = new Clone("SnowFirTree 2");
        piece_snow_fir_tree2.OnCreated += prefab =>
        {
            prefab.Remove<TreeBase>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();
            var capsule = prefab.GetComponentInChildren<CapsuleCollider>();
            DestroyImmediate(capsule);
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_firtree_snow";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_tree_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_tree_fall", "vfx_firtreecut_snow").m_effectList;
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
            build.Name.English("Snow Fir Tree");

            build.RequiredItems.Add("FirConeFrost", 1, true);
            build.Snapshot();
        };
        var piece_snowball = new Clone("SnowRoller");
        piece_snowball.OnCreated += prefab =>
        {
            prefab.Remove<Rigidbody>();
            prefab.Remove<ZSyncTransform>();
            prefab.Remove<SnowRoller>();
            prefab.Remove<Destructible>();
            
            var c = prefab.AddCollider(0.5f);
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_snowball";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("fx_snow_wall_break").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("fx_snowshovel").m_effectList;
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
            build.Name.English("Snowball");
            
            build.RequiredItems.Add("Ice", 2, true);
            build.Snapshot();
        };
        var piece_elaking_hole = new Clone("Spawner_Hole");
        piece_elaking_hole.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<SpawnArea>();
            prefab.Remove<HoverText>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_elaking_hole";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_RockHit", "sfx_rock_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_HoleSpawner_destruction").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
            wnt.m_autoCreateFragments = false;
        
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Elaking Hole");
        
            build.RequiredItems.Add("Frostwood", 4, true);
            build.RequiredItems.Add("TrophyElaking", 1, true);
            build.Snapshot();
        };
    }
    
    private static void SetupWallGemStands()
    {
        var piece_morkhalla_eye = new Clone("Morkhalla_Eye1");
        piece_morkhalla_eye.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_black_gem_socket";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Draumyx");

            build.RequiredItems.Add("AncientGemstoneBlack", 1, true);
            build.RequiredItems.Add("Stone", 10 , true);
            build.Snapshot();
        };
        var piece_morkhalla_eye2 = new Clone("Morkhalla_Eye2");
        piece_morkhalla_eye2.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_green_gem_socket";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Grimvarn");

            build.RequiredItems.Add("AncientGemstoneGreen", 1, true);
            build.RequiredItems.Add("Stone", 10 , true);
            build.Snapshot();
        };
        var piece_morkhalla_eye3 = new Clone("Morkhalla_Eye3");
        piece_morkhalla_eye3.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_orange_gem_socket";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Solryth");

            build.RequiredItems.Add("AncientGemstoneOrange", 1, true);
            build.RequiredItems.Add("Stone", 10 , true);
            build.Snapshot();
        };
        var piece_morkhalla_eye4 = new Clone("Morkhalla_Eye4");
        piece_morkhalla_eye4.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_purple_gem_socket";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Veydris");

            build.RequiredItems.Add("AncientGemstonePurple", 1, true);
            build.RequiredItems.Add("Stone", 10 , true);
            build.Snapshot();
        };
        
        var piece_morkhalla_eye5 = new Clone("Morkhalla_Eye5_gemstone");
        piece_morkhalla_eye5.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_blue_gem_socket";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Iolite");

            build.RequiredItems.Add("GemstoneBlue", 1, true);
            build.RequiredItems.Add("Stone", 10 , true);
            build.Snapshot();
        };
        
        var piece_morkhalla_eye6 = new Clone("Morkhalla_Eye6_gemstone");
        piece_morkhalla_eye6.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_green_gem_gem_socket";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Jade");

            build.RequiredItems.Add("GemstoneGreen", 1, true);
            build.RequiredItems.Add("Stone", 10 , true);
            build.Snapshot();
        };
        
        var piece_morkhalla_eye7 = new Clone("Morkhalla_Eye7_gemstone");
        piece_morkhalla_eye7.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_red_gem_gem_socket";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Bloodstone");

            build.RequiredItems.Add("GemstoneRed", 1, true);
            build.RequiredItems.Add("Stone", 10 , true);
            build.Snapshot();
        };
        
        var piece_morkhalla_insert = new Clone("Morkhalla_Eye7_gemstone");
        piece_morkhalla_insert.OnCreated += prefab =>
        {
            prefab.name = "piece_gemstone_socket_bn";
            prefab.Remove<Pickable>();

            var attach = prefab.transform.Find("attach");
            for (int i = 0; i < attach.childCount; ++i)
            {
                var child = attach.GetChild(i);
                DestroyImmediate(child.gameObject);
            }
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_eye_interactable";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 1000f;

            var stand = prefab.AddComponent<GemStand>();
            stand.m_name = "$piece_itemstand";
            stand.m_attachOther = attach;
            stand.m_dropSpawnPoint = attach;
            stand.m_canBeRemoved = true;
            stand.m_effects = new EffectListRef("vfx_pickable_pick", "sfx_pickable_pick").m_effectList;
            
            for (int i = 0; i < BuildPiece._scene.m_prefabs.Count; ++i)
            {
                var p = BuildPiece._scene.m_prefabs[i];
                if (!p.TryGetComponent(out ItemDrop component)) continue;
                if (p.name.StartsWith("AncientGemstone") || p.name.StartsWith("Gemstone"))
                {
                    stand.m_supportedItems.Add(component);
                }
            }
            
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Gem Socket");

            build.RequiredItems.Add("FrozenFuel", 1, true);
            build.RequiredItems.Add("Stone", 10 , true);
            build.Snapshot();
        };
        
    }

    private static void SetupBrokenStatue()
    {
        var piece_morkhalla_statue_arm_l = new Clone("Morkhalla_StatuePieceArmL");
        piece_morkhalla_statue_arm_l.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider())
            {
                var c = prefab.AddCollider();
                c?.excludeLayers = LayerMask.GetMask("character");
            }                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_statue_arm_l";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_MorkhallaStatueDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Statue Arm L");

            build.RequiredItems.Add("Stone", 50, true);
            build.RequiredItems.Add("AncientCoin", 1, true);
            build.Snapshot();
        };
        
        var piece_morkhalla_statue_arm_r = new Clone("Morkhalla_StatuePieceArmR");
        piece_morkhalla_statue_arm_r.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider())
            {
                var c = prefab.AddCollider();
                c?.excludeLayers = LayerMask.GetMask("character");
            }                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_statue_arm_l";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_MorkhallaStatueDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Statue Arm L");

            build.RequiredItems.Add("Stone", 50, true);
            build.RequiredItems.Add("AncientCoin", 1, true);
            build.Snapshot();
        };
        var piece_morkhalla_statue_face = new Clone("Morkhalla_StatuePieceFace");
        piece_morkhalla_statue_face.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider())
            {
                var c = prefab.AddCollider();
                c?.excludeLayers = LayerMask.GetMask("character");
            }                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_statue_arm_l";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_MorkhallaStatueDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Statue Arm L");

            build.RequiredItems.Add("Stone", 50, true);
            build.RequiredItems.Add("AncientCoin", 1, true);
            build.Snapshot();
        };
        var piece_morkhalla_statue_feet = new Clone("Morkhalla_StatuePieceFeet");
        piece_morkhalla_statue_feet.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider())
            {
                var c = prefab.AddCollider();
                c?.excludeLayers = LayerMask.GetMask("character");
            }                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_statue_arm_l";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_MorkhallaStatueDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Statue Arm L");

            build.RequiredItems.Add("Stone", 50, true);
            build.RequiredItems.Add("AncientCoin", 1, true);
            build.Snapshot();
        };
        var piece_morkhalla_statue_horn = new Clone("Morkhalla_StatuePieceHorn");
        piece_morkhalla_statue_horn.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider())
            {
                var c = prefab.AddCollider();
                c?.excludeLayers = LayerMask.GetMask("character");
            }                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_statue_arm_l";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_MorkhallaStatueDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Statue Arm L");

            build.RequiredItems.Add("Stone", 50, true);
            build.RequiredItems.Add("AncientCoin", 1, true);
            build.Snapshot();
        };
        var piece_morkhalla_statue_horn2 = new Clone("Morkhalla_StatuePieceHorn2");
        piece_morkhalla_statue_horn2.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider())
            {
                var c = prefab.AddCollider();
                c?.excludeLayers = LayerMask.GetMask("character");
            }                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_statue_arm_l";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_MorkhallaStatueDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Statue Arm L");

            build.RequiredItems.Add("Stone", 50, true);
            build.RequiredItems.Add("AncientCoin", 1, true);
            build.Snapshot();
        };
        var piece_morkhalla_statue_legs = new Clone("Morkhalla_StatuePieceLegs");
        piece_morkhalla_statue_legs.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider())
            {
                var c = prefab.AddCollider();
                c?.excludeLayers = LayerMask.GetMask("character");
            }                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_statue_arm_l";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_MorkhallaStatueDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Statue Arm L");

            build.RequiredItems.Add("Stone", 50, true);
            build.RequiredItems.Add("AncientCoin", 1, true);
            build.Snapshot();
        };
        var piece_morkhalla_statue_sword = new Clone("Morkhalla_StatuePieceSword");
        piece_morkhalla_statue_sword.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider())
            {
                var c = prefab.AddCollider();
                c?.excludeLayers = LayerMask.GetMask("character");
            }                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_statue_arm_l";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_MorkhallaStatueDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Statue Arm L");

            build.RequiredItems.Add("Stone", 50, true);
            build.RequiredItems.Add("AncientCoin", 1, true);
            build.Snapshot();
        };
        var piece_morkhalla_statue_torso = new Clone("Morkhalla_StatuePieceTorso");
        piece_morkhalla_statue_torso.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider())
            {
                var c = prefab.AddCollider();
                c?.excludeLayers = LayerMask.GetMask("character");
            }
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morkhalla_statue_arm_l";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_MorkhallaStatueDestroyed").m_effectList;
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
            build.Name.English("Morkhalla Statue Arm L");

            build.RequiredItems.Add("Stone", 50, true);
            build.RequiredItems.Add("AncientCoin", 1, true);
            build.Snapshot();
        };
        var piece_frost_core = new Clone("Pickable_FrostCoreHanger");
        piece_frost_core.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<RandomSpawn>();

            var chain = Utils.FindChild(prefab.transform, "chain");
            DestroyImmediate(chain.gameObject);
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_frost_core";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_hit", "vfx_frostcore_pick").m_effectList;
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
            build.Name.English("Frost Core");

            build.RequiredItems.Add("FrostCore", 1, true);
            build.Snapshot();
        };
        var piece_stump_hole = new Clone("StumpHole");
        piece_stump_hole.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var c = prefab.AddCollider(0.5f);
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_stump_hole";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
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
            build.Name.English("Stump Hole");

            build.RequiredItems.Add("Frostwood", 1, true);
            build.Snapshot();
        };
        
        var piece_stump_hut = new Clone("StumpHut");
        piece_stump_hut.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var c = prefab.AddCollider(0.5f);
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_stump_hut";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
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
            build.Name.English("Stump Hut");

            build.RequiredItems.Add("Frostwood", 1, true);
            build.Snapshot();
        };
        
        var piece_stump_log = new Clone("StumpLog");
        piece_stump_log.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var stub = model.transform.Find("stub");
            stub.localRotation = Quaternion.identity;
            var c = prefab.AddCollider(0.6f);
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_stump_log";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
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
            build.Name.English("Stump Log");

            build.RequiredItems.Add("Frostwood", 1, true);
            build.Snapshot();
        };
        var piece_troll_frost_dead = new Clone("TrollFrost_Dead");
        piece_troll_frost_dead.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            prefab.Remove<HoverText>();
            var beacon = prefab.GetComponentInChildren<Beacon>();
            DestroyImmediate(beacon);
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var c = prefab.AddCollider(0.9f);
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_troll_frost_dead";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_RockHit", "sfx_rock_hit");
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_RockDestroyed_large");
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;

            wnt.m_materialType = WearNTear.MaterialType.Ancient;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Gammetroll");

            build.RequiredItems.Add("Stone", 50, true);
            build.RequiredItems.Add("GoldOre", 20, true);
            build.Snapshot();
        };
        
        var piece_deep_north_lantern_standing = new Clone("deepnorth_lantern_standing");
        piece_deep_north_lantern_standing.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_deep_north_lantern_standing";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_smallitem", "sfx_build_hammer_metal").m_effectList;
                

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Standing Lantern");

            build.RequiredItems.Add("Lantern_DN", 1, true);
            build.RequiredItems.Add("Iron", 1, true);
            build.Snapshot();
        };
    }
}