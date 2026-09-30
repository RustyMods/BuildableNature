using ClassSystem;
using PieceManager;
using UnityEngine;
using static UnityEngine.Object;

namespace BuildableNature;

public static partial class Assets
{
    public static void Mountains()
    {
        var piece_cave_rock_ice_pillar_wall = new Clone("caverock_ice_pillar_wall");
        piece_cave_rock_ice_pillar_wall.OnCreated += prefab =>
        {
            prefab.Remove<MaterialVariation>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_caverock_ice_pillar_wall";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_ice_hit", "vfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_ice_destroyed", "sfx_ice_destroyed").m_effectList;
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
            build.Name.English("Ice Wall");

            build.RequiredItems.Add("Ice",5 ,true);
            build.Snapshot();
        };
        var piece_caverock_stalagmite = new Clone("caverock_ice_stalagmite");
        piece_caverock_stalagmite.OnCreated += prefab =>
        {
            prefab.Remove<MaterialVariation>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_caverock_stalagmite";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_ice_hit", "vfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_ice_destroyed", "sfx_ice_destroyed").m_effectList;
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
            build.Name.English("Stalagmite");

            build.RequiredItems.Add("Ice",5 ,true);
            build.Snapshot();
        };
        var piece_caverock_stalgtite = new Clone("caverock_ice_stalagtite");
        piece_caverock_stalgtite.OnCreated += prefab =>
        {
            prefab.Remove<MaterialVariation>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_caverock_stalagtite";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_ice").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_ice_hit", "vfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_ice_destroyed", "sfx_ice_destroyed").m_effectList;
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
            build.Name.English("Stalagtite");

            build.RequiredItems.Add("Ice",5 ,true);
            build.Snapshot();
        };
        var piece_cloth_hanging_door = new Clone("cloth_hanging_long");
        piece_cloth_hanging_door.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var c = prefab.GetComponentInChildren<Collider>();
            DestroyImmediate(c);
            var collider = prefab.AddCollider(0.7f);
            collider?.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_cloth_hanging_door";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_comfort = 2;
            piece.m_comfortGroup = Piece.ComfortGroup.Banner;
            piece.m_notOnFloor = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_wall", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef( "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed", "vfx_SawDust").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Hanging Red Jute");

            build.RequiredItems.Add("JuteRed", 4, true);
            build.Snapshot();
        };
        var piece_hanging_fenrir_hide = new Clone("fenrirhide_hanging");
        piece_hanging_fenrir_hide.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<HoverText>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var c = prefab.GetComponentInChildren<Collider>();
            DestroyImmediate(c);
            var collider = prefab.AddCollider(0.7f);
            collider?.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_hanging_fenrir_hide";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_comfort = 2;
            piece.m_comfortGroup = Piece.ComfortGroup.Banner;
            piece.m_notOnFloor = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_wall", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef( "vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_fenrirhide_hanging_destroyed", "vfx_SawDust").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Hanging Wolf Hair");

            build.RequiredItems.Add("WolfHairBundle", 4, true);
            build.Snapshot();
        };
        var piece_hair_stands = new Clone("hanging_hairstrands");
        piece_hair_stands.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<Pickable>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_wolf_hair_stands";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "vfx_SawDust").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
            wnt.m_noSupportWear = true;

            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Wolf Hair Stands");

            build.RequiredItems.Add("WolfHairBundle", 1, true);
            build.Snapshot();
        };
        var piece_marker1 = new Clone("marker01");
        piece_marker1.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_stone_marker";
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
            build.Name.English("Stone Marker");

            build.RequiredItems.Add("Stone", 3, true);
            build.Snapshot();
        };
        var piece_marker2 = new Clone("marker02");
        piece_marker2.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_stone_marker";
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
            build.Name.English("Stone Marker");

            build.RequiredItems.Add("Stone", 3, true);
            build.Snapshot();
        };
        var piece_minerock_obsidian = new Clone("MineRock_Obsidian");
        piece_minerock_obsidian.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<HoverText>();
            prefab.Remove<StaticPhysics>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_obsidian_deposit";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit_Obsidian").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_RockDestroyed_Obsidian", "vfx_RockDestroyed").m_effectList;
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
            build.Name.English("Obsidian Deposit");

            build.RequiredItems.Add("Obsidian", 10, true);
            build.Snapshot();
        };
        
        var piece_mountain_gravestone = new Clone("MountainGraveStone01");
        piece_mountain_gravestone.OnCreated += prefab =>
        {
            var p = new GameObject(prefab.name);
            p.transform.SetParent(BuildableNaturePlugin.m_root.transform);
            p.AddComponent<ZNetView>().m_persistent = true;
            var model = new GameObject("model");
            model.transform.SetParent(p.transform);
            prefab.transform.SetParent(model.transform);
            p.layer = 10;
            
            prefab.Remove<StaticPhysics>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<ZNetView>();
            prefab.transform.localPosition = Vector3.zero;
            prefab.transform.localRotation = Quaternion.identity;
            var c= p.AddCollider(0.9f);
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = p.AddComponent<Piece>();
            piece.m_name = "$piece_mountain_gravestone";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = p.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_RockHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_RockDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_supports = false;
        
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 500f;
            BuildPiece build = new BuildPiece(p);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Mountain Gravestone");

            build.RequiredItems.Add("Stone", 4, true);
            build.Snapshot();
        };
        var piece_cave_crystal = new Clone("Pickable_MountainCaveCrystal");
        piece_cave_crystal.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);

            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_cave_crystal";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_ice_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_ice_destroyed").m_effectList;
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
            build.Name.English("Crystal");

            build.RequiredItems.Add("Crystal", 2, true);
            build.Snapshot();
        };
        var piece_cave_obsidian = new Clone("Pickable_MountainCaveObsidian");
        piece_cave_obsidian.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_cave_obsidian";
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
            build.Name.English("Obsidian");

            build.RequiredItems.Add("Obsidian", 1, true);
            build.Snapshot();
        };
        
        var piece_silver_vein = new Clone("silvervein");
        piece_silver_vein.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            prefab.Remove<HoverText>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_silver_vein";
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
            build.Name.English("Silver Vein");

            build.RequiredItems.Add("Stone", 30, true);
            build.RequiredItems.Add("SilverOre", 1, true);
            build.Snapshot();
        };
    }
}