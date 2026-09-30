using ClassSystem;
using PieceManager;
using UnityEngine;
using static UnityEngine.Object;

namespace BuildableNature;

public static partial class Assets
{
    public static void Misc()
    {
        var piece_ancient_skull = new Clone("ancient_skull");
        piece_ancient_skull.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ancient_skull";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_RockDestroyed_large").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Marble;
            wnt.m_health = 50f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ancient Skull");

            build.RequiredItems.Add("Stone", 10, true);
            build.Snapshot();
        };
        var piece_ashcrow = new Clone("AshCrow");
        piece_ashcrow.OnCreated += prefab =>
        {
            prefab.Remove<ZSyncTransform>();
            prefab.Remove<ZSyncAnimation>();
            prefab.Remove<RandomFlyingBird>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();

            var flying = prefab.transform.Find("crow_anim");
            DestroyImmediate(flying.gameObject);
            var sitting = prefab.transform.Find("crow_sitting");
            sitting.gameObject.SetActive(true);

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();

            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashcrow";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_crow_death", "sfx_crow_death").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_crow_death", "sfx_crow_death").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 50f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ashcrow");

            build.RequiredItems.Add("Feathers", 3, true);
            build.Snapshot();
        };
        var piece_seagal = new Clone("Seagal");
        piece_seagal.OnCreated += prefab =>
        {
            prefab.Remove<ZSyncTransform>();
            prefab.Remove<ZSyncAnimation>();
            prefab.Remove<RandomFlyingBird>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();

            var flying = prefab.transform.Find("crow_anim");
            DestroyImmediate(flying.gameObject);
            var sitting = prefab.transform.Find("crow_sitting");
            sitting.gameObject.SetActive(true);

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();

            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashcrow";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_crow_death", "sfx_crow_death").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_crow_death", "sfx_crow_death").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 50f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ashcrow");

            build.RequiredItems.Add("Feathers", 3, true);
            build.Snapshot();
        };
        var piece_barrell = new Clone("barrell");
        piece_barrell.OnCreated += prefab =>
        {
            prefab.Remove<Rigidbody>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<ZSyncTransform>();
            prefab.Remove<Floating>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_barrel";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_barrle_destroyed", "sfx_wood_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            var container = prefab.AddComponent<Container>();
            container.m_name = "$piece_chestbarrel";
            container.m_width = 5;
            container.m_height = 2;
            container.m_openEffects = new EffectListRef("sfx_chest_open").m_effectList;
            container.m_closeEffects = new EffectListRef("sfx_chest_close").m_effectList;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Storage);
            build.Name.English("Barrel");

            build.RequiredItems.Add("Wood", 10, true);
            build.RequiredItems.Add("BronzeNails", 1, true);
            build.Snapshot();
        };
        var piece_big_branch = new Clone("BigBranch");
        piece_big_branch.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_big_branch";
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
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Big Branch");

            build.RequiredItems.Add("Wood", 10, true);
            build.Snapshot();
        };
        var piece_bucket = new Clone("bucket");
        piece_bucket.OnCreated += prefab =>
        {
            prefab.Remove<Rigidbody>();
            prefab.Remove<ZSyncTransform>();
            prefab.Remove<Destructible>();
            var meshCollider = prefab.GetComponentInChildren<MeshCollider>();
            meshCollider.convex = false;
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_bucket";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_SawDust").m_effectList;
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
            build.Name.English("Bucket");

            build.RequiredItems.Add("Wood",1 ,true);
            build.Snapshot();
        };
        var piece_crow = new Clone("Crow");
        piece_crow.OnCreated += prefab =>
        {
            prefab.Remove<ZSyncTransform>();
            prefab.Remove<ZSyncAnimation>();
            prefab.Remove<RandomFlyingBird>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();

            var flying = prefab.transform.Find("crow_anim");
            DestroyImmediate(flying.gameObject);
            var sitting = prefab.transform.Find("crow_sitting");
            sitting.gameObject.SetActive(true);

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();

            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_crow";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_crow_death", "sfx_crow_death").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_crow_death", "sfx_crow_death").m_effectList;
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
            build.Name.English("Crow");

            build.RequiredItems.Add("Feathers", 3, true);
            build.Snapshot();
        };
        var piece_flying_core = new Clone("flying_core");
        piece_flying_core.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_flying_core";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_throne02", "sfx_build_hammer_crystal").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "fx_crystal_destruction").m_effectList;
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
            build.Name.English("Red Crystal");

            build.RequiredItems.Add("SurtlingCore", 1, true);
            build.RequiredItems.Add("Crystal", 10, true);
            build.Snapshot();
        };
        var piece_high_stone = new Clone("highstone");
        piece_high_stone.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_high_stone";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_stone", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_RockHit", "sfx_rock_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
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
            build.Name.English("High Stone");

            build.RequiredItems.Add("Stone", 5, true);
            build.Snapshot();
        };
        var piece_high_stone2 = new Clone("highstone_2");
        piece_high_stone2.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_high_stone";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_stone", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_RockHit", "sfx_rock_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
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
            build.Name.English("High Stone");

            build.RequiredItems.Add("Stone", 5, true);
            build.Snapshot();
        };
        var piece_leviathan = new Clone("Leviathan");
        piece_leviathan.OnCreated += prefab =>
        {
            prefab.Remove<Rigidbody>();
            prefab.Remove<ZSyncTransform>();
            prefab.Remove<MineRock>();
            prefab.Remove<ZSyncAnimation>();
            prefab.Remove<Leviathan>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_leviathan";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("fx_leviathan_reaction").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "fx_leviathan_leave").m_effectList;
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
            build.Name.English("Leviathan");

            build.RequiredItems.Add("Stone", 20, true);
            build.RequiredItems.Add("Chitin", 30, true);
            build.Snapshot();
        };
        var piece_minerock_copper = new Clone("MineRock_Copper");
        piece_minerock_copper.OnCreated += prefab =>
        {
            prefab.Remove<MineRock>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_copper_ore_pile";
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
                
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Copper Ore Pile");

            build.RequiredItems.Add("CopperOre", 30, true);
            build.Snapshot();
        };
        var piece_minerock_iron = new Clone("MineRock_Iron");
        piece_minerock_iron.OnCreated += prefab =>
        {
            prefab.Remove<MineRock>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_iron_ore_pile";
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
                
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Iron Ore Pile");

            build.RequiredItems.Add("IronScrap", 30, true);
            build.Snapshot();
        };
        var piece_minerock_meteorite = new Clone("MineRock_Meteorite");
        piece_minerock_meteorite.OnCreated += prefab =>
        {
            prefab.Remove<MineRock>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_meteorite_spire";
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
                
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Flametal Spire");

            build.RequiredItems.Add("FlametalOreNew", 30, true);
            build.Snapshot();
        };
        var piece_stone_pile = new Clone("MineRock_Stone");
        piece_stone_pile.OnCreated += prefab =>
        {
            prefab.Remove<MineRock>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_minerock_stone_pile";
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
                
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 1000f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Stone Pile");

            build.RequiredItems.Add("Stone", 50, true);
            build.Snapshot();
        };
        
        var piece_bog_iron = new Clone("Pickable_BogIronOre");
        piece_bog_iron.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();
            prefab.transform.localPosition = Vector3.zero;
            prefab.transform.localRotation = Quaternion.identity;
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
                
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_bog_iron";
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
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Bog Iron");

            build.RequiredItems.Add("IronScrap", 1, true);
            build.Snapshot();
        };
        var piece_meatpile = new Clone("Pickable_MeatPile");
        piece_meatpile.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_meat_pile";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bones_pick", "vfx_bones_pick").m_effectList;
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
            build.Name.English("Meat Pile");

            build.RequiredItems.Add("RottenMeat", 1, true);
            build.Snapshot();
        };
        var piece_meteorite = new Clone("Pickable_Meteorite");
        piece_meteorite.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            
            var c= prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_meteorite";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
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
            build.Name.English("Meteorite");

            build.RequiredItems.Add("FlametalOreNew", 1, true);
            build.Snapshot();
        };
        var piece_rock_3 = new Clone("Rock_3");
        piece_rock_3.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_rock_3";
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
            build.Name.English("Rock");

            build.RequiredItems.Add("Stone", 3, true);
            build.Snapshot();
        };
        var piece_rock_4 = new Clone("Rock_4");
        piece_rock_4.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_rock_3";
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
            build.Name.English("Rock");

            build.RequiredItems.Add("Stone", 3, true);
            build.Snapshot();
        };
        var piece_rock_7 = new Clone("Rock_7");
        piece_rock_7.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_rock_3";
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
            build.Name.English("Rock");

            build.RequiredItems.Add("Stone", 3, true);
            build.Snapshot();
        };
        
        var piece_large_rock = new Clone("rock1_mistlands");
        piece_large_rock.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_large_rock";
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
            build.Name.English("Large Rock");

            build.RequiredItems.Add("Stone", 30, true);
            build.Snapshot();
        };
        
        var piece_large_rock2 = new Clone("rock2_heath");
        piece_large_rock2.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_large_rock";
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
            build.Name.English("Large Rock");

            build.RequiredItems.Add("Stone", 30, true);
            build.Snapshot();
        };
        
        var piece_large_rock3 = new Clone("rock3_mountain");
        piece_large_rock3.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_large_rock";
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
            build.Name.English("Large Rock");

            build.RequiredItems.Add("Stone", 30, true);
            build.Snapshot();
        };
        
        var piece_large_rock4 = new Clone("rock3_mountain_1");
        piece_large_rock4.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_large_rock";
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
            build.Name.English("Large Rock");

            build.RequiredItems.Add("Stone", 30, true);
            build.Snapshot();
        };
        
        var piece_large_rock5 = new Clone("rock4_coast");
        piece_large_rock5.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_large_rock";
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
            build.Name.English("Large Rock");

            build.RequiredItems.Add("Stone", 30, true);
            build.Snapshot();
        };
        
        var piece_large_rock6 = new Clone("rock4_forest");
        piece_large_rock6.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_large_rock";
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
            build.Name.English("Large Rock");

            build.RequiredItems.Add("Stone", 30, true);
            build.Snapshot();
        };
        var piece_rock_silver = new Clone("rock3_silver");
        piece_rock_silver.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            prefab.Remove<HoverText>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_rock_silver";
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
            build.Name.English("Silver Rock");

            build.RequiredItems.Add("Stone", 30, true);
            build.RequiredItems.Add("SilverOre", 1, true);
            build.Snapshot();
        };
        var piece_dolmen1 = new Clone("RockDolmen_1");
        piece_dolmen1.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_dolmen";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
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
            build.Name.English("Dolmen Rock");

            build.RequiredItems.Add("Stone", 4, true);
            build.Snapshot();
        };
        var piece_dolmen2 = new Clone("RockDolmen_2");
        piece_dolmen2.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_dolmen";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
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
            build.Name.English("Dolmen Rock");

            build.RequiredItems.Add("Stone", 4, true);
            build.Snapshot();
        };
        var piece_dolmen3 = new Clone("RockDolmen_3");
        piece_dolmen3.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_dolmen";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
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
            build.Name.English("Dolmen Rock");

            build.RequiredItems.Add("Stone", 4, true);
            build.Snapshot();
        };

        var piece_sapling_barley = new Clone("sapling_barley");
        piece_sapling_barley.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_barley_bn";
            piece.m_description = "$piece_sapling_barley_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_barley_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_barley_hit", "vfx_barley_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Barley Sapling");
            build.Description.English("");
            build.RequiredItems.Add("Barley", 1, true);
        };

        var piece_sapling_carrot = new Clone("sapling_carrot");
        piece_sapling_carrot.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_carrot_bn";
            piece.m_description = "$piece_sapling_carrot_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Carrot Sapling");
            build.Description.English("");
            build.RequiredItems.Add("CarrotSeeds", 1, true);
        };
        var piece_sapling_flax = new Clone("sapling_flax");
        piece_sapling_flax.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_flax_bn";
            piece.m_description = "$piece_sapling_flax_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_barley_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_barley_hit", "vfx_barley_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Flax Sapling");
            build.Description.English("");
            build.RequiredItems.Add("Flax", 1, true);
        };
        var piece_sapling_jotunn_puff = new Clone("sapling_jotunpuffs");
        piece_sapling_jotunn_puff.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_jotunn_puff_bn";
            piece.m_description = "$piece_sapling_jotunn_puff_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Jotunn Puff Sapling");
            build.Description.English("");
            build.RequiredItems.Add("MushroomJotunPuffs", 1, true);
        };
        var piece_sapling_kale = new Clone("sapling_Kale");
        piece_sapling_kale.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_kale_bn";
            piece.m_description = "$piece_sapling_kale_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Kale Sapling");
            build.Description.English("");
            build.RequiredItems.Add("Kale", 1, true);
        };
        var piece_sapling_magecap = new Clone("sapling_magecap");
        piece_sapling_magecap.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_magecap_bn";
            piece.m_description = "$piece_sapling_magecap_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Magecap Sapling");
            build.Description.English("");
            build.RequiredItems.Add("MushroomMagecap", 1, true);
        };
        var piece_sapling_oat = new Clone("sapling_oat");
        piece_sapling_oat.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_oat_bn";
            piece.m_description = "$piece_sapling_oat_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Oat Sapling");
            build.Description.English("");
            build.RequiredItems.Add("OatSeeds", 1, true);
        };
        var piece_sapling_onion = new Clone("sapling_onion");
        piece_sapling_onion.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_onion_bn";
            piece.m_description = "$piece_sapling_onion_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Onion Sapling");
            build.Description.English("");
            build.RequiredItems.Add("OnionSeeds", 1, true);
        };
        var piece_sapling_poteitr = new Clone("sapling_poteitr");
        piece_sapling_poteitr.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_poteitr_bn";
            piece.m_description = "$piece_sapling_poteitr_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Poteir Sapling");
            build.Description.English("");
            build.RequiredItems.Add("OnionSeeds", 1, true);
        };
        var piece_sapling_carrotseeds = new Clone("sapling_seedcarrot");
        piece_sapling_carrotseeds.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_carrotseeds_bn";
            piece.m_description = "$piece_sapling_carrotseeds_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Carrot Seeds Sapling");
            build.Description.English("");
            build.RequiredItems.Add("CarrotSeeds", 1, true);
        };
        var piece_sapling_kaleseeds = new Clone("sapling_seedkale");
        piece_sapling_kaleseeds.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_kaleseeds_bn";
            piece.m_description = "$piece_sapling_kaleseeds_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Kale Seeds Sapling");
            build.Description.English("");
            build.RequiredItems.Add("KaleSeeds", 1, true);
        };
        var piece_sapling_onionseeds = new Clone("sapling_seedonion");
        piece_sapling_onionseeds.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_onionseeds_bn";
            piece.m_description = "$piece_sapling_onionseeds_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Onion Seeds Sapling");
            build.Description.English("");
            build.RequiredItems.Add("OnionSeeds", 1, true);
        };
        var piece_sapling_turnipseeds = new Clone("sapling_seedturnip");
        piece_sapling_turnipseeds.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_turnipseeds_bn";
            piece.m_description = "$piece_sapling_turnipseeds_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Turnip Seeds Sapling");
            build.Description.English("");
            build.RequiredItems.Add("TurnipSeeds", 1, true);
        };
        var piece_sapling_turnip = new Clone("sapling_turnip");
        piece_sapling_turnip.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_turnip_bn";
            piece.m_description = "$piece_sapling_turnip_desc_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Turnip Sapling");
            build.Description.English("");
            build.RequiredItems.Add("TurnipSeeds", 1, true);
        };
        var piece_simmering_sand_rock = new Clone("ShimmeringSand_rock");
        piece_simmering_sand_rock.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_shimmering_sand";
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
            build.Name.English("Shimmering Sand Rock");

            build.RequiredItems.Add("Ice", 4, true);
            build.Snapshot();
        };
        
        var piece_shrub_2 = new Clone("shrub_2");
        piece_shrub_2.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();
            
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
            piece.m_name = "$piece_shrub_2";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_shrub_2_hit", "sfx_bush_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_shrub_2_destroyed").m_effectList;
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
            build.Name.English("Shrub");

            build.RequiredItems.Add("Wood",1 ,true);
            build.Snapshot();
        };
        var piece_shrub_2_plains = new Clone("shrub_2_heath");
        piece_shrub_2_plains.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();
            
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
            piece.m_name = "$piece_shrub_2";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_shrub_2_heath_hit", "sfx_bush_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_shrub_2_heath_destroyed").m_effectList;
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
            build.Name.English("Shrub");

            build.RequiredItems.Add("Wood",1 ,true);
            build.Snapshot();
        };
        var piece_stone_wall = new Clone("stonewall_2");
        piece_stone_wall.OnCreated += prefab =>
        {
            prefab.Remove<MaterialVariation>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_stone_wall";
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
            build.Name.English("Stone Wall");

            build.RequiredItems.Add("Stone", 4, true);
            build.RequiredItems.Add("AncientCoin", 1, true);
            build.Snapshot();
        };
        var piece_stone_wall2 = new Clone("stonewall_3");
        piece_stone_wall2.OnCreated += prefab =>
        {
            prefab.Remove<MaterialVariation>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_stone_wall";
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
            build.Name.English("Stone Wall");

            build.RequiredItems.Add("Stone", 4, true);
            build.RequiredItems.Add("AncientCoin", 1, true);
            build.Snapshot();
        };
        var piece_stubbe = new Clone("stubbe");
        piece_stubbe.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.99f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_stub";
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
            build.Name.English("Stub");

            build.RequiredItems.Add("Wood", 1, true);
            build.Snapshot();
        };
        
        var piece_tar_lump = new Clone("tarlump1");
        piece_tar_lump.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_tar_lump";
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
            build.Name.English("Tar Lump");

            build.RequiredItems.Add("Tar", 1, true);
            build.Snapshot();
        };
        
        var piece_trader_wagon = new Clone("trader_wagon_destructable");
        piece_trader_wagon.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider())
            {
                var c = prefab.AddCollider();
                c.excludeLayers = LayerMask.GetMask("character");
            }
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_trader_wagon_bn";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_wood_hit");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed");
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
            build.Name.English("Wagon");

            build.RequiredItems.Add("Wood", 10, true);
            build.RequiredItems.Add("BronzeNails", 6, true);
            build.RequiredItems.Add("YmirRemains", 1, true);
            build.Snapshot();
        };
        var piece_vine = new Clone("VineGreen");
        piece_vine.OnCreated += prefab =>
        {
            prefab.Remove<Vine>();
            prefab.Remove<Pickable>();
                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_vine";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Vine");

            build.RequiredItems.Add("VineGreenSeeds", 1, true);
            build.Snapshot();
        };
        var piece_vine_sapling = new Clone("VineGreen_sapling");
        piece_vine_sapling.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
                
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_vine";
            piece.m_description = "$piece_sapling_vine_desc";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_cultivatedGroundOnly = false;
            piece.m_canBeRemoved = true;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit", "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Vine Sapling");
            build.Description.English("");
            build.RequiredItems.Add("VineGreenSeeds", 1, true);
        };
        var piece_wide_stone = new Clone("widestone");
        piece_wide_stone.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_wide_stone";
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
            wnt.m_health = 100f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Wide Stone");

            build.RequiredItems.Add("Stone", 4, true);
            build.Snapshot();
        };
        var piece_wide_stone2 = new Clone("widestone_2");
        piece_wide_stone2.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_wide_stone";
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
            wnt.m_health = 100f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Wide Stone");

            build.RequiredItems.Add("Stone", 4, true);
            build.Snapshot();
        };
        var piece_chest_hildir = new Clone("chest_hildir1");
        piece_chest_hildir.OnCreated += prefab =>
        {
            prefab.Remove<Rigidbody>();
            prefab.Remove<Floating>();
            var icon = prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_icons[0];
            prefab.Remove<ItemDrop>();
            prefab.Remove<ParticleSystem>();
            prefab.Remove<MeshCollider>();

            var box = prefab.transform.Find("attach/default");
            var boxC = box.gameObject.AddComponent<BoxCollider>();
            
            var closed = prefab.transform.Find("attach/lid").gameObject;
            closed.AddComponent<BoxCollider>();
            var open = Instantiate(closed, closed.transform.parent);
            open.SetActive(false);
            open.transform.localPosition = new Vector3(-0.223f, 0.35f, 0f);
            open.transform.localRotation = Quaternion.Euler(0f, 0f, -30.783f);
            
            var container = prefab.AddComponent<Container>();
            container.m_name = "$item_chest_hildir1";
            container.m_width = 8;
            container.m_height = 4;
            container.m_openEffects = new EffectListRef("sfx_chest_open");
            container.m_closeEffects = new EffectListRef("sfx_chest_close");
            container.m_closed = closed;
            container.m_open = open;
        
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            
            if (!prefab.HasCollider()) prefab.AddCollider();

            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_chest_hildir";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_metal");
            piece.m_icon = icon;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_wood_hit");
            wnt.m_destroyedEffect = new EffectListRef("vfx_SawDust", "sfx_wood_destroyed");
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 50f;
            wnt.m_supports = false;
        
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Storage);
            build.Name.English("Hildir Chest 1");
            build.RequiredItems.Add("chest_hildir1", 1, true);
        };
        
        var piece_chest_hildir2 = new Clone("chest_hildir2");
        piece_chest_hildir2.OnCreated += prefab =>
        {
            prefab.Remove<Rigidbody>();
            prefab.Remove<Floating>();
            var icon = prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_icons[0];
            prefab.Remove<ItemDrop>();
            prefab.Remove<ParticleSystem>();
            prefab.Remove<MeshCollider>();
            
            var box = prefab.transform.Find("attach/default");
            var boxC = box.gameObject.AddComponent<BoxCollider>();
            var closed = prefab.transform.Find("attach/lid").gameObject;
            closed.AddComponent<BoxCollider>();
            var open = Instantiate(closed, closed.transform.parent);
            open.SetActive(false);
            open.transform.localPosition = new Vector3(-0.223f, 0.35f, 0f);
            open.transform.localRotation = Quaternion.Euler(0f, 0f, -30.783f);
            
            var container = prefab.AddComponent<Container>();
            container.m_name = "$item_chest_hildir2";
            container.m_width = 8;
            container.m_height = 4;
            container.m_openEffects = new EffectListRef("sfx_chest_open");
            container.m_closeEffects = new EffectListRef("sfx_chest_close");
            container.m_closed = closed;
            container.m_open = open;
        
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();

            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_chest_hildir2";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Storage;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_metal");
            piece.m_icon = icon;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_wood_hit");
            wnt.m_destroyedEffect = new EffectListRef("vfx_SawDust", "sfx_wood_destroyed");
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
            build.Name.English("Hildir Chest 2");
            build.RequiredItems.Add("chest_hildir2", 1, true);
        };
        
        var piece_chest_hildir3 = new Clone("chest_hildir3");
        piece_chest_hildir3.OnCreated += prefab =>
        {
            prefab.Remove<Rigidbody>();
            prefab.Remove<Floating>();
            var icon = prefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_icons[0];
            prefab.Remove<ItemDrop>();
            prefab.Remove<ParticleSystem>();
            prefab.Remove<MeshCollider>();
            var box = prefab.transform.Find("attach/default");
            var boxC = box.gameObject.AddComponent<BoxCollider>();
            var closed = prefab.transform.Find("attach/lid").gameObject;
            closed.AddComponent<BoxCollider>();
            var open = Instantiate(closed, closed.transform.parent);
            open.SetActive(false);
            open.transform.localPosition = new Vector3(-0.223f, 0.35f, 0f);
            open.transform.localRotation = Quaternion.Euler(0f, 0f, -30.783f);
            
            var container = prefab.AddComponent<Container>();
            container.m_name = "$item_chest_hildir3";
            container.m_width = 8;
            container.m_height = 4;
            container.m_openEffects = new EffectListRef("sfx_chest_open");
            container.m_closeEffects = new EffectListRef("sfx_chest_close");
            container.m_closed = closed;
            container.m_open = open;
        
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();

            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_chest_hildir3";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Storage;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_metal");
            piece.m_icon = icon;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_wood_hit");
            wnt.m_destroyedEffect = new EffectListRef("vfx_SawDust", "sfx_wood_destroyed");
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
            build.Name.English("Hildir Chest 3");
            build.RequiredItems.Add("chest_hildir3", 1, true);
        };
        var piece_chest_old = new Clone("Chest");
        piece_chest_old.OnCreated += prefab =>
        {
            prefab.Remove<Rigidbody>();
            prefab.Remove<ZSyncTransform>();
            
            var c = prefab.transform.Find("Chest").gameObject;
            var closed = prefab.transform.Find("Chest_cover").gameObject;
            var open = Instantiate(closed, closed.transform.parent);
            open.transform.localRotation = Quaternion.Euler(-28.757f, 0f, 0f);
            open.SetActive(false);
            var container = prefab.GetComponent<Container>();
            container.m_openEffects = new EffectListRef("sfx_chest_open");
            container.m_closeEffects = new EffectListRef("sfx_chest_close");
            container.m_open = open;
            container.m_closed = closed;
            prefab.AddCollider();
            prefab.layer = 10;
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_chest_old";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust", "sfx_wood_hit");
            wnt.m_destroyedEffect = new EffectListRef("vfx_SawDust", "sfx_wood_destroyed");
            wnt.m_new = c;
            wnt.m_worn = c;
            wnt.m_wet = c;
            wnt.m_broken = c;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 50f;
            wnt.m_supports = false;
    
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Storage);
            build.Name.English("Chest");
            build.RequiredItems.Add("Wood", 10, true);
            build.RequiredItems.Add("BronzeNails", 4, true);
            build.Snapshot();
        };
    }    
}