using ClassSystem;
using PieceManager;
using UnityEngine;
using static UnityEngine.Object;

namespace BuildableNature;

public static partial class Assets
{
    public static void BlackForest()
    {
        var piece_big_rock = new Clone("BigRock");
        piece_big_rock.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var meshCollider = prefab.GetComponentInChildren<MeshCollider>();
            meshCollider.convex = false;
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_big_rock";
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
            build.Name.English("Big Rock");

            build.RequiredItems.Add("Stone", 10, true);
            build.Snapshot();
        };
        var piece_blueberry_bush = new Clone("BlueberryBush");
        piece_blueberry_bush.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<Pickable>();
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
            piece.m_name = "$piece_blueberry_bush";
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
            build.Name.English("Blueberry Bush");

            build.RequiredItems.Add("Blueberries",1 ,true);
            build.Snapshot();
        };
        var piece_bonepile = new Clone("BonePileSpawner");
        piece_bonepile.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            prefab.Remove<SpawnArea>();
            prefab.Remove<HoverText>();
            var meshCollider = prefab.GetComponentInChildren<MeshCollider>();
            meshCollider.convex = false;
            var sphereCollider = prefab.GetComponentInChildren<SphereCollider>();
            DestroyImmediate(sphereCollider);

            var particles = prefab.transform.Find("particles");
            DestroyImmediate(particles.gameObject);
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.7f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_bonepile";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_skeleton_hit", "sfx_skeleton_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bonepile_destroyed", "vfx_bonepile_destroyed").m_effectList;
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
            build.Name.English("Bone Pile");

            build.RequiredItems.Add("BoneFragments",10 ,true);
            build.RequiredItems.Add("TrophySkeleton", 5, true);
            build.Snapshot();
        };
        var piece_rock_copper = new Clone("rock4_copper");
        piece_rock_copper.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_copper_rock";
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
            build.Name.English("Copper Vein");

            build.RequiredItems.Add("Stone", 30, true);
            build.RequiredItems.Add("CopperOre", 1, true);
            build.Snapshot();
        };
        var piece_skeleton_chest = new Clone("crypt_skeleton_chest");
        piece_skeleton_chest.OnCreated += prefab =>
        {
            var closed = Utils.FindChild(prefab.transform, "stonechesttop_closed");
            var open = Instantiate(closed.gameObject, closed.parent);
            open.name = "stonechesttop_open";
            open.transform.localPosition = new Vector3(0f, 0.082f, 0f);
            open.transform.localRotation = Quaternion.Euler(27.719f, 0f, 0f);
            open.SetActive(false);

            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<MaterialVariation>();
            prefab.Remove<HoverText>();
            prefab.Remove<EggHatch>();

            var container = prefab.AddComponent<Container>();
            container.m_name = "$ancient_chest";
            container.m_width = 5;
            container.m_height = 2;
            container.m_openEffects = new EffectListRef("sfx_chest_open").m_effectList;
            container.m_closeEffects = new EffectListRef("sfx_chest_close").m_effectList;
            container.m_closed = closed.gameObject;
            container.m_open = open;
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();

            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_skeleton_chest";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_rock_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_crypt_skeleton_chest_destroyed", "vfx_SawDust", "sfx_rock_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 50f;
            wnt.m_supports = false;
            
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Stone Chest");

            build.RequiredItems.Add("Stone", 10, true);
            build.RequiredItems.Add("BoneFragments", 5, true);
            build.Snapshot();
        };
        var piece_evil_heart = new Clone("EvilHeart_Forest");
        piece_evil_heart.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<SpawnArea>();
            prefab.Remove<HoverText>();

            var particles = prefab.GetComponentsInChildren<ParticleSystem>();
            for (int i = 0; i < particles.Length; ++i)
            {
                var particle = particles[i];
                particle.gameObject.SetActive(false);
            }
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.7f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_evil_heart";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_greydwarf_hit", "sfx_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_corpse_destruction_medium", "vfx_greydwarf_hit").m_effectList;
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
            build.Name.English("Evil Heart");

            build.RequiredItems.Add("AncientSeed",1 ,true);
            build.Snapshot();
        };
        var piece_fir = new Clone("FirTree");
        piece_fir.OnCreated += prefab =>
        {
            prefab.Remove<TreeBase>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_firtree";
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
            build.Name.English("Fir Tree");

            build.RequiredItems.Add("FirCone", 1, true);
            build.Snapshot();
        };
        var piece_firtree_oldlog = new Clone("FirTree_oldLog");
        piece_firtree_oldlog.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_firtree_oldlog";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_tree_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_break", "vfx_fir_oldlog").m_effectList;
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
            build.Name.English("Fir Log");

            build.RequiredItems.Add("FirCone", 1, true);
            build.Snapshot();
        };
        var piece_firtree_sapling = new Clone("FirTree_Sapling");
        piece_firtree_sapling.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_firtree_sapling";
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
            build.Name.English("Fir Tree Sapling");

            build.RequiredItems.Add("FirCone", 1, true);
        };
        var piece_firtree_small = new Clone("FirTree_small");
        piece_firtree_small.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_firtree_small";
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
            build.Name.English("Small Fir Tree");
            build.RequiredItems.Add("FirCone", 1, true);
            build.Snapshot();
        };  
        var piece_firtree_stub = new Clone("FirTree_Stub");
        piece_firtree_stub.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_firtree_stub";
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
            build.Name.English("Fir Tree Stub");

            build.RequiredItems.Add("FirCone", 1, true);
            build.Snapshot();
        };
        var piece_greydwarf_root = new Clone("Greydwarf_Root");
        piece_greydwarf_root.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_greydwarf_root";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_greydwarfnest_hit", "vfx_greydwarfnest_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_destroyed", "vfx_greydwarf_root_destroyed").m_effectList;
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
            build.Name.English("Greydwarf Nest Root");

            build.RequiredItems.Add("AncientSeed", 1, true);
            build.Snapshot();
        };
        var piece_minerock_tin = new Clone("MineRock_Tin");
        piece_minerock_tin.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<HoverText>();
            prefab.Remove<StaticPhysics>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_tin_deposit";
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
            build.Name.English("Tin Deposit");

            build.RequiredItems.Add("TinOre", 10, true);
            build.Snapshot();
        };
        var piece_crypt_remains = new Clone("Pickable_ForestCryptRemains01");
        piece_crypt_remains.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_crypt_remains";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_skeleton_hit", "vfx_skeleton_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bonepile_destroyed", "vfx_bonepile_destroyed").m_effectList;
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
            build.Name.English("Skeleton Remains");

            build.RequiredItems.Add("BoneFragments", 2, true);
            build.RequiredItems.Add("TrophySkeleton",1,true);
            build.Snapshot();
        };
        var piece_surtling_core_stand = new Clone("Pickable_SurtlingCoreStand");
        piece_surtling_core_stand.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.transform.localRotation = Quaternion.identity;
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
                
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_surtling_core_stand";
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
            build.Name.English("Molten Core Stand");

            build.RequiredItems.Add("SurtlingCore", 1, true);
            build.RequiredItems.Add("Iron", 1, true);
            build.Snapshot();
        };
        var piece_thistle = new Clone("Pickable_Thistle");
        piece_thistle.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);

            var box = prefab.GetComponentInChildren<BoxCollider>();
            box.excludeLayers = LayerMask.GetMask("character");
                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_thistle";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_hit").m_effectList;
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
            build.Name.English("Thistle");

            build.RequiredItems.Add("Thistle", 1, true);
            build.Snapshot();
        };
        var piece_tin = new Clone("Pickable_Tin");
        piece_tin.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_tin";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_destroyed").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed").m_effectList;
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
            build.Name.English("Tin");

            build.RequiredItems.Add("TinOre", 1, true);
            build.Snapshot();
        };
        var piece_crypt_remains2 = new Clone("Pickable_ForestCryptRemains02");
        piece_crypt_remains2.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_crypt_remains";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_skeleton_hit", "vfx_skeleton_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bonepile_destroyed", "vfx_bonepile_destroyed").m_effectList;
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
            build.Name.English("Skeleton Remains");

            build.RequiredItems.Add("BoneFragments", 2, true);
            build.RequiredItems.Add("TrophySkeleton",1,true);
            build.Snapshot();
        };
        var piece_crypt_remains3 = new Clone("Pickable_ForestCryptRemains03");
        piece_crypt_remains3.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_crypt_remains";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_skeleton_hit", "vfx_skeleton_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bonepile_destroyed", "vfx_bonepile_destroyed").m_effectList;
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
            build.Name.English("Skeleton Remains");

            build.RequiredItems.Add("BoneFragments", 2, true);
            build.RequiredItems.Add("TrophySkeleton",1,true);
            build.Snapshot();
        };
        var piece_crypt_remains4 = new Clone("Pickable_ForestCryptRemains04");
        piece_crypt_remains4.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_crypt_remains";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_skeleton_hit", "vfx_skeleton_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bonepile_destroyed", "vfx_bonepile_destroyed").m_effectList;
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
            build.Name.English("Skeleton Remains");

            build.RequiredItems.Add("BoneFragments", 2, true);
            build.RequiredItems.Add("TrophySkeleton",1,true);
            build.Snapshot();
        };
        var piece_pine_tree = new Clone("PineTree");
        piece_pine_tree.OnCreated += prefab =>
        {
            prefab.Remove<TreeBase>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_pine_tree_old";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_tree_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_break", "vfx_fir_oldlog").m_effectList;
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
            build.Name.English("Old Pine Tree");

            build.RequiredItems.Add("PineCone", 1, true);
            build.Snapshot();
        };

        var piece_pine_tree_1 = new Clone("Pinetree_01");
        piece_pine_tree_1.OnCreated += prefab =>
        {
            prefab.Remove<TreeBase>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var capsule = prefab.GetComponentInChildren<CapsuleCollider>();
            DestroyImmediate(capsule);

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_pine_tree";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_tree_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_break", "vfx_fir_oldlog").m_effectList;
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
            build.Name.English("Pine Tree");

            build.RequiredItems.Add("PineCone", 1, true);
            build.Snapshot();
        };
        
        var piece_pine_tree_stub = new Clone("Pinetree_01_Stub");
        piece_pine_tree_stub.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_pinetree_stub";
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
            build.Name.English("Pine Tree Stub");

            build.RequiredItems.Add("PineCone", 1, true);
            build.Snapshot();
        };

        var piece_pine_tree_sapling = new Clone("PineTree_Sapling");
        piece_pine_tree_sapling.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_pinetree_sapling";
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
            build.Name.English("Pine Tree Sapling");

            build.RequiredItems.Add("PineCone", 1, true);
        };
    }
}