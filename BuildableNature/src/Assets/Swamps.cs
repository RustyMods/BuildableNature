using ClassSystem;
using PieceManager;
using UnityEngine;
using static UnityEngine.Object;

namespace BuildableNature;

public static partial class Assets
{
    public static void Swamps()
    {
        var piece_firtree_small_dead = new Clone("FirTree_small_dead");
        piece_firtree_small_dead.OnCreated += prefab =>
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
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            piece.m_groundOnly = true;
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
        var piece_guck_sack = new Clone("GuckSack");
        piece_guck_sack.OnCreated += prefab =>
        {
            prefab.Remove<RandomSpawn>();
            prefab.Remove<HoverText>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_guck_sack";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_GuckSackHit", "sfx_GuckSackHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_GuckSackDestroyed", "sfx_GuckSackDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
            wnt.m_noSupportWear = true;

            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Guck Sack");

            build.RequiredItems.Add("Guck", 1, true);
            build.Snapshot();
        };
        var piece_guck_sack_small = new Clone("GuckSack_small");
        piece_guck_sack_small.OnCreated += prefab =>
        {
            prefab.Remove<RandomSpawn>();
            prefab.Remove<HoverText>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_guck_sack_small";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_GuckSackHit", "sfx_GuckSackHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_GuckSackDestroyed", "sfx_GuckSackDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
            wnt.m_noSupportWear = true;

            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Small Guck Sack");

            build.RequiredItems.Add("Guck", 1, true);
            build.Snapshot();
        };
        var piece_huge_root = new Clone("HugeRoot1");
        piece_huge_root.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<HoverText>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.7f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_huge_swamp_root";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_wood_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_break", "vfx_SawDust").m_effectList;
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
            build.Name.English("Huge Root");

            build.RequiredItems.Add("Wood", 10, true);
            build.RequiredItems.Add("Guck", 1, true);
            build.Snapshot();
        };
        
        var piece_mudpile = new Clone("mudpile");
        piece_mudpile.OnCreated += prefab =>
        {
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_mudpile";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_metal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_MudHit", "vfx_MudHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_MudDestroyed", "vfx_MudDestroyed").m_effectList;
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
            build.Name.English("Mud Pile");

            build.RequiredItems.Add("IronScrap", 2, true);
            build.RequiredItems.Add("WitheredBone", 1, true);
            build.Snapshot();
        };
        
        var piece_mudpile2 = new Clone("mudpile2");
        piece_mudpile2.OnCreated += prefab =>
        {
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_mudpile";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_metal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_MudHit", "vfx_MudHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_MudDestroyed", "vfx_MudDestroyed").m_effectList;
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
            build.Name.English("Mud Pile");

            build.RequiredItems.Add("IronScrap", 2, true);
            build.RequiredItems.Add("WitheredBone", 1, true);
            build.Snapshot();
        };
        
        var piece_draugr_pile = new Clone("Spawner_DraugrPile");
            piece_draugr_pile.OnCreated += prefab =>
            {
                prefab.Remove<DropOnDestroyed>();
                prefab.Remove<Destructible>();
                prefab.Remove<SpawnArea>();
                prefab.Remove<HoverText>();

                var sphere = prefab.GetComponentInChildren<SphereCollider>();
                DestroyImmediate(sphere);
                var meshCollider = prefab.GetComponentInChildren<MeshCollider>();
                meshCollider.convex = false;
            
                var model = prefab.CreateAndSetUnderModel();
                prefab.SetLayerRecursively(10);
                if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
                var piece = prefab.AddComponent<Piece>();
                piece.m_name = "$piece_draugr_pile";
                piece.m_category = Piece.PieceCategory.Misc;
                piece.m_usage = Piece.UsageTagFlags.Decor;
                piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
                var wnt = prefab.AddComponent<WearNTear>();
                wnt.m_hitEffect = new EffectListRef("vfx_draugrpile_hit", "sfx_draugrpile_hit").m_effectList;
                wnt.m_destroyedEffect = new EffectListRef("sfx_draugrpile_destroyed", "vfx_draugrpile_destroyed").m_effectList;
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
                build.Name.English("Draugr Pile");
        
                build.RequiredItems.Add("Entrails", 4, true);
                build.RequiredItems.Add("TrophyDraugr", 1, true);
                build.Snapshot();
            };

        var piece_root7 = new Clone("root07");
        piece_root7.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_swamp_root";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_wood_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_break", "vfx_SawDust").m_effectList;
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
            build.Name.English("Root");

            build.RequiredItems.Add("Wood", 1, true);
            build.RequiredItems.Add("Guck", 1, true);
            build.Snapshot();
        };
        var piece_root8 = new Clone("root08");
        piece_root8.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_swamp_root";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_wood_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_break", "vfx_SawDust").m_effectList;
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
            build.Name.English("Root");

            build.RequiredItems.Add("Wood", 1, true);
            build.RequiredItems.Add("Guck", 1, true);
            build.Snapshot();
        };
        var piece_root11 = new Clone("root11");
        piece_root11.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_swamp_root";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_wood_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_break", "vfx_SawDust").m_effectList;
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
            build.Name.English("Root");

            build.RequiredItems.Add("Wood", 1, true);
            build.RequiredItems.Add("Guck", 1, true);
            build.Snapshot();
        };
        var piece_root12 = new Clone("root12");
        piece_root12.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_swamp_root";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_wood_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_wood_break", "vfx_SawDust").m_effectList;
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
            build.Name.English("Root");

            build.RequiredItems.Add("Wood", 1, true);
            build.RequiredItems.Add("Guck", 1, true);
            build.Snapshot();
        };
        
        var piece_swamp_tree = new Clone("SwampTree1");
        piece_swamp_tree.OnCreated += prefab =>
        {
            prefab.Remove<TreeBase>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_swamp_tree";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_tree_hit");
            wnt.m_destroyedEffect = new EffectListRef("sfx_tree_fall", "vfx_firtreecut");
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
            build.Name.English("Swamp Tree");

            build.RequiredItems.Add("ElderBark", 1, true);
            build.Snapshot();
        };
        
        var piece_swamp_tree_stub = new Clone("SwampTree1_Stub");
        piece_swamp_tree_stub.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var c = prefab.AddCollider(0.6f);
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_swamp_tree_stub";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_tree_hit");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_break");
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
            build.Name.English("Swamp Stub");

            build.RequiredItems.Add("ElderBark", 1, true);
            build.Snapshot();
        };
    }
}