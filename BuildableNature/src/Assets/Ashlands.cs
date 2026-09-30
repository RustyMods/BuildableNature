using ClassSystem;
using PieceManager;
using UnityEngine;
using static UnityEngine.Object;

namespace BuildableNature;

public static partial class Assets
{
    public static void Ashlands()
    {
        var piece_ashstone = new Clone("Pickable_Ashstone");
        piece_ashstone.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();
            var meshCollider = prefab.GetComponentInChildren<MeshCollider>();
            meshCollider.convex = false;
            var sphere = prefab.GetComponentInChildren<SphereCollider>();
            DestroyImmediate(sphere);

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
                
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashstone";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_break", "vfx_SawDust").m_effectList;
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
            build.Name.English("Ash Stone");

            build.RequiredItems.Add("Grausten", 1, true);
            build.Snapshot();
        };
        var piece_charred_skull = new Clone("Pickable_Charredskull");
        piece_charred_skull.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
                
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_charred_skull";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_CoalHit", "sfx_rock_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_CoalDestroyed", "sfx_rock_destroyed").m_effectList;
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
            build.Name.English("Charred Skull");

            build.RequiredItems.Add("Charredskull", 1, true);
            build.Snapshot();
        };
        var piece_molten_core_stand = new Clone("Pickable_MoltenCoreStand");
        piece_molten_core_stand.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.transform.localRotation = Quaternion.identity;
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
                
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_molten_core_stand";
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

            build.RequiredItems.Add("MoltenCore", 1, true);
            build.RequiredItems.Add("Iron", 1, true);
            build.Snapshot();
        };
        var piece_volture_egg = new Clone("Pickable_VoltureEgg");
        piece_volture_egg.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);

            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_volture_egg";
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
            build.Name.English("Volture Egg");

            build.RequiredItems.Add("VoltureEgg", 1, true);
            build.Snapshot();
        };
        var piece_smoke_puff = new Clone("Pickable_SmokePuff");
        piece_smoke_puff.OnCreated += prefab =>
        {
            prefab.Remove<Pickable>();
            prefab.Remove<StaticPhysics>();

            var sphere = prefab.GetComponentInChildren<SphereCollider>();
            DestroyImmediate(sphere);
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);

            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_smoke_puff";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_bush_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_bush_hit").m_effectList;
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
            build.Name.English("Smoke Puff");

            build.RequiredItems.Add("MushroomSmokePuff", 1, true);
            build.Snapshot();
        };
        SetupAshlandRocks();
        SetupAshlandsTrees();
        var piece_charred_altar_beam = new Clone("Charred_altar_bellfragment");
        piece_charred_altar_beam.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_charred_altar_bell_fragment";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_hit", "vfx_HitSparks").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("fx_altar_charred_destruction", "fx_Fading_Bellfragment_Beam");
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 80f;
            wnt.m_supports = false;

            var toggle = prefab.AddComponent<BeamToggle>();
            toggle.m_name = piece.m_name;
            toggle.m_disableEffects = new EffectListRef("fx_Fading_Bellfragment_Beam", "sfx_fader_bell");
            toggle.m_enableEffects = new EffectListRef("sfx_fader_bell");

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Charred Altar Fragment");

            build.RequiredItems.Add("BellFragment",1 ,true);
            build.Snapshot();
        };
        var piece_leviathan_lava = new Clone("LeviathanLava");
        piece_leviathan_lava.OnCreated += prefab =>
        {
            prefab.Remove<Rigidbody>();
            prefab.Remove<ZSyncTransform>();
            prefab.Remove<MineRock>();
            prefab.Remove<ZSyncAnimation>();
            prefab.Remove<Leviathan>();
            prefab.Remove<StaticPhysics>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_leviathan_lava";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_clipEverything = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("fx_leviathanLava_reaction").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "fx_leviathanLava_leave").m_effectList;
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
            build.Name.English("Flametal Rock Spire");

            build.RequiredItems.Add("Stone", 20, true);
            build.RequiredItems.Add("FlametalOreNew", 10, true);
            build.Snapshot();
        };
        var piece_lured_fader_ember = new Clone("LuredFaderEmber");
        piece_lured_fader_ember.OnCreated += prefab =>
        {
            prefab.Remove<ZSyncTransform>();
            prefab.Remove<LuredWisp>();
            prefab.Remove<Pickable>();

            var trail = prefab.GetComponentInChildren<TrailRenderer>();
            DestroyImmediate(trail);

            var sphere = prefab.GetComponentInChildren<SphereCollider>();
            DestroyImmediate(sphere);
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_lured_fader_ember";
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
            build.Name.English("Fader Ember");

            build.RequiredItems.Add("FaderEmber", 1, true);

            if (BuildPiece.TryGetPrefab("FaderEmber", out var ember) &&
                ember.TryGetComponent(out ItemDrop component))
            {
                piece.m_icon = component.m_itemData.m_shared.m_icons[0];
            }
        };
        var piece_morgen_pile = new Clone("morgenhole_pile");
        piece_morgen_pile.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            var meshCollider = prefab.GetComponentInChildren<MeshCollider>();
            meshCollider.convex = false;
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_morgen_hole_pile";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_MudHit", "vfx_MudHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_MudDestroyed", "vfx_morgenhole_pile_destroyed").m_effectList;
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
            build.Name.English("Morgen Hole Pile");

            build.RequiredItems.Add("RottenMeat", 10, true);
            build.Snapshot();
        };
        var piece_charred_cross = new Clone("Spawner_CharredCross");
        piece_charred_cross.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            prefab.Remove<SpawnArea>();
            prefab.Remove<HoverText>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_charred_cross";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_FireballHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_charredcross_spawner_destroyed", "sfx_wood_destroyed").m_effectList;
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
            build.Name.English("Charred Cross");
            
            build.RequiredItems.Add("Blackwood", 2, true);
            build.RequiredItems.Add("FlametalOreNew", 1, true);
            build.Snapshot();
        };
        var piece_charred_stone = new Clone("Spawner_CharredStone");
        piece_charred_stone.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            prefab.Remove<SpawnArea>();
            prefab.Remove<HoverText>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_charred_stone";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_RockHit", "sfx_rock_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("fx_CharredStone_Destruction", "sfx_charred_spawner_destroy").m_effectList;
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
            build.Name.English("Charred Stone");
        
            build.RequiredItems.Add("Grausten", 4, true);
            build.RequiredItems.Add("FlametalOreNew", 1, true);
            build.Snapshot();
        };
        var piece_charred_stone_elite = new Clone("Spawner_CharredStone_Elite");
        piece_charred_stone_elite.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            prefab.Remove<SpawnArea>();
            prefab.Remove<HoverText>();
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.9f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_charred_stone";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_RockHit", "sfx_rock_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("fx_CharredStone_Destruction", "sfx_charred_spawner_destroy", "fx_CharredStone_Gibs").m_effectList;
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
            build.Name.English("Charred Stone");
        
            build.RequiredItems.Add("Grausten", 4, true);
            build.RequiredItems.Add("FlametalOreNew", 1, true);
            build.Snapshot();
        };
    }
    
    private static void SetupAshlandRocks()
    {
        var piece_ashlands_rock1 = new Clone("Ashlands_rock1");
        piece_ashlands_rock1.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_rock1";
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
            build.Name.English("Ashlands Rock");

            build.RequiredItems.Add("Stone", 10, true);
            build.Snapshot();
        };
        
        var piece_ashlands_rock2 = new Clone("Ashlands_rock2");
        piece_ashlands_rock2.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_rock2";
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
            build.Name.English("Ashlands Rock");

            build.RequiredItems.Add("Stone", 10, true);
            build.Snapshot();
        };
        var piece_cliff_ashlands1 = new Clone("cliff_ashlands1");
        piece_cliff_ashlands1.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_cliff1";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_CoalHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_GraustenDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ashlands Cliff");

            build.RequiredItems.Add("Grausten", 10, true);
            build.Snapshot();
        };
        var piece_cliff_ashlands2 = new Clone("cliff_ashlands2");
        piece_cliff_ashlands2.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_cliff2";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_CoalHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_GraustenDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ashlands Boulder");

            build.RequiredItems.Add("Grausten", 10, true);
            build.Snapshot();
        };
        var piece_cliff_ashlands3_arch = new Clone("cliff_ashlands3_Arch_1");
        piece_cliff_ashlands3_arch.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_cliff3_arch";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_CoalHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_GraustenDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ashlands Arch");

            build.RequiredItems.Add("Grausten", 10, true);
            build.Snapshot();
        };
        var piece_cliff_ashlands4 = new Clone("cliff_ashlands4");
        piece_cliff_ashlands4.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_cliff4";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_CoalHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_GraustenDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ashlands Spire");

            build.RequiredItems.Add("Grausten", 10, true);
            build.Snapshot();
        };
        var piece_cliff_ashlands5 = new Clone("cliff_ashlands5");
        piece_cliff_ashlands5.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_cliff5";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_CoalHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_GraustenDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ashlands Boulder");

            build.RequiredItems.Add("Grausten", 10, true);
            build.Snapshot();
        };
        var piece_cliff_ashlands6 = new Clone("cliff_ashlands6");
        piece_cliff_ashlands6.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_cliff6";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_CoalHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_GraustenDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ashlands Boulder");

            build.RequiredItems.Add("Grausten", 10, true);
            build.Snapshot();
        };
        var piece_cliff_ashlands7_arch = new Clone("cliff_ashlands7_HalfArch");
        piece_cliff_ashlands7_arch.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.8f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_cliff7_arch";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_CoalHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_GraustenDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ashlands Half Arch");

            build.RequiredItems.Add("Grausten", 10, true);
            build.Snapshot();
        };
        var piece_cliff_ashlands8 = new Clone("cliff_ashlands8");
        piece_cliff_ashlands8.OnCreated += prefab =>
        {
            prefab.Remove<StaticPhysics>();
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_cliff8";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_CoalHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_GraustenDestroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Stone;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ashlands Boulder");

            build.RequiredItems.Add("Grausten", 10, true);
            build.Snapshot();
        };
        var piece_fern_ashlands = new Clone("FernAshlands");
        piece_fern_ashlands.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();

            var colliders = prefab.GetComponentsInChildren<Collider>();
            for (int i = 0; i < colliders.Length; ++i)
            {
                var collider = colliders[i];
                DestroyImmediate(collider);
            }
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_fern_ashlands";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_clipEverything = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_wall", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef( "vfx_FernAshlands_puff", "sfx_bush_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_FernAshlands_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ashlands Fern");

            build.RequiredItems.Add("Fiddleheadfern", 1, true);
            build.Snapshot();
        };
        var piece_fern_fiddlehead_ashlands = new Clone("FernFiddleHeadAshlands");
        piece_fern_fiddlehead_ashlands.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();

            var colliders = prefab.GetComponentsInChildren<Collider>();
            for (int i = 0; i < colliders.Length; ++i)
            {
                var collider = colliders[i];
                DestroyImmediate(collider);
            }
            
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_fern_fiddlehead_ashlands";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_clipEverything = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_wall", "sfx_build_hammer_default").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef( "vfx_FernAshlands_puff", "sfx_bush_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("vfx_FernAshlands_destroyed").m_effectList;
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;
            wnt.m_materialType = WearNTear.MaterialType.Wood;
            wnt.m_health = 30f;

            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Fiddlehead");

            build.RequiredItems.Add("Fiddleheadfern", 1, true);
            build.Snapshot();
        };
        var piece_ashlands_rockstand = new Clone("FlametalRockstand");
        piece_ashlands_rockstand.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.7f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_flametal_rockstand";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_throne02", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("sfx_rock_hit", "vfx_CoalHit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_rock_destroyed", "vfx_CoalDestroyed").m_effectList;
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
            build.Name.English("Ashlands Rock Stand");

            build.RequiredItems.Add("Grausten", 10, true);
            build.Snapshot();
        };
        var piece_lavabomb_rock = new Clone("lavabomb_rock1");
        piece_lavabomb_rock.OnCreated += prefab =>
        {
            prefab.Remove<ConditionalObject>();
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_lavabomb_rock";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_RockHit", "sfx_rock_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_CoalDestroyed").m_effectList;
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
            build.Name.English("Lava Bomb Platform");

            build.RequiredItems.Add("Grausten", 4, true);
            build.Snapshot();
        };
        var piece_lavarock_ashlands = new Clone("lavarock_ashlands1");
        piece_lavarock_ashlands.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
                
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_lavarock_ashlands";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_stone").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_RockHit", "sfx_rock_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef( "sfx_rock_destroyed", "vfx_CoalDestroyed").m_effectList;
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
            build.Name.English("Ashlands Rock Spire");

            build.RequiredItems.Add("Grausten", 4, true);
            build.Snapshot();
        };
    }
    
    private static void SetupAshlandsTrees()
    {
        var piece_ashlands_branch1 = new Clone("AshlandsBranch1");
        piece_ashlands_branch1.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_branch1";
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
            build.Name.English("Ashlands Log");

            build.RequiredItems.Add("Blackwood", 4, true);
            build.Snapshot();
        };
        var piece_ashlands_branch2 = new Clone("AshlandsBranch2");
        piece_ashlands_branch2.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_branch2";
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
            build.Name.English("Ashlands Branch");

            build.RequiredItems.Add("Blackwood", 1, true);
            build.Snapshot();
        };
        var piece_ashlands_branch3 = new Clone("AshlandsBranch3");
        piece_ashlands_branch3.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<HoverText>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_branch3";
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
            build.Name.English("Ashlands Log");

            build.RequiredItems.Add("Blackwood", 4, true);
            build.Snapshot();
        };
        var piece_ashlands_bush = new Clone("AshlandsBush1");
        piece_ashlands_bush.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_stub";
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
            build.Name.English("Ashlands Stub");

            build.RequiredItems.Add("Blackwood", 4, true);
            build.Snapshot();
        };
        var piece_ashlands_tree1 = new Clone("AshlandsTree1");
        piece_ashlands_tree1.OnCreated += prefab =>
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
            piece.m_name = "$piece_ashlands_tree";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust_Ashlands", "sfx_tree_hit").m_effectList;
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
            build.Name.English("Ashlands Tree");

            build.RequiredItems.Add("Blackwood", 10, true);
            build.Snapshot();
        };
        var piece_ashlands_tree3 = new Clone("AshlandsTree3");
        piece_ashlands_tree3.OnCreated += prefab =>
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
            piece.m_name = "$piece_ashlands_tree";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust_Ashlands", "sfx_tree_hit").m_effectList;
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
            build.Name.English("Ashlands Tree");

            build.RequiredItems.Add("Blackwood", 10, true);
            build.Snapshot();
        };
        var piece_ashlands_tree4 = new Clone("AshlandsTree4");
        piece_ashlands_tree4.OnCreated += prefab =>
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
            piece.m_name = "$piece_ashlands_tree";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust_Ashlands", "sfx_tree_hit").m_effectList;
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
            build.Name.English("Ashlands Tree");

            build.RequiredItems.Add("Blackwood", 10, true);
            build.Snapshot();
        };
        var piece_ashlands_tree5 = new Clone("AshlandsTree5");
        piece_ashlands_tree5.OnCreated += prefab =>
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
            piece.m_name = "$piece_ashlands_tree";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust_Ashlands", "sfx_tree_hit").m_effectList;
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
            build.Name.English("Ashlands Tree");

            build.RequiredItems.Add("Blackwood", 10, true);
            build.Snapshot();
        };
        var piece_ashlands_tree6 = new Clone("AshlandsTree6");
        piece_ashlands_tree6.OnCreated += prefab =>
        {
            prefab.Remove<TreeBase>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var capsule = prefab.GetComponentInChildren<CapsuleCollider>();
            DestroyImmediate(capsule);

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.85f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_tree";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust_Ashlands", "sfx_tree_hit").m_effectList;
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
            build.Name.English("Ashlands Tree");

            build.RequiredItems.Add("Blackwood", 10, true);
            build.Snapshot();
        };
        var piece_ashlands_tree_big = new Clone("AshlandsTree6_big");
        piece_ashlands_tree_big.OnCreated += prefab =>
        {
            prefab.Remove<TreeBase>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var capsule = prefab.GetComponentInChildren<CapsuleCollider>();
            DestroyImmediate(capsule);

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.85f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_tree_big";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust_Ashlands", "sfx_tree_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_break", "vfx_fir_oldlog").m_effectList;
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
            build.Name.English("Ashlands Large Tree");

            build.RequiredItems.Add("Blackwood", 20, true);
            build.Snapshot();
        };
        var piece_ashlands_tree_stump1 = new Clone("AshlandsTreeStump1");
        piece_ashlands_tree_stump1.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var meshCollider = prefab.GetComponentInChildren<MeshCollider>();
            meshCollider.convex = false;

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_stump";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust_Ashlands", "sfx_tree_hit").m_effectList;
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_break", "vfx_fir_oldlog").m_effectList;
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
            build.Name.English("Ashlands Stump");

            build.RequiredItems.Add("Blackwood", 2, true);
            build.Snapshot();
        };
        var piece_ashlands_tree_stump2 = new Clone("AshlandsTreeStump2");
        piece_ashlands_tree_stump2.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var meshCollider = prefab.GetComponentInChildren<MeshCollider>();
            meshCollider.convex = false;

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_stump";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust_Ashlands", "sfx_tree_hit").m_effectList;
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
            build.Name.English("Ashlands Stump");

            build.RequiredItems.Add("Blackwood", 2, true);
            build.Snapshot();
        };
        var piece_ashlands_tree_stump3 = new Clone("AshlandsTreeStump3");
        piece_ashlands_tree_stump3.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<Destructible>();
            prefab.Remove<StaticPhysics>();
            prefab.Remove<HoverText>();

            var meshCollider = prefab.GetComponentInChildren<MeshCollider>();
            meshCollider.convex = false;

            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            if (!prefab.HasCollider()) prefab.AddCollider(0.5f);
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_stump";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_groundOnly = true;
            piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood").m_effectList;
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust_Ashlands", "sfx_tree_hit").m_effectList;
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
            build.Name.English("Ashlands Stump");

            build.RequiredItems.Add("Blackwood", 2, true);
            build.Snapshot();
        };
        var piece_vine_ash = new Clone("VineAsh");
        piece_vine_ash.OnCreated += prefab =>
        {
            prefab.Remove<Vine>();
            prefab.Remove<Pickable>();
                
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ash_vine";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ash Vine");

            build.RequiredItems.Add("VineberrySeeds", 1, true);
            build.Snapshot();
        };
        var piece_vine_ash_sapling = new Clone("VineAsh_sapling");
        piece_vine_ash_sapling.OnCreated += prefab =>
        {
            prefab.Remove<Plant>();
            prefab.Remove<Destructible>();
                
            var c = prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var piece = prefab.GetComponent<Piece>();
            piece.m_name = "$piece_sapling_vine_ash";
            piece.m_description = "$piece_sapling_vine_ash_desc";
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
            build.Name.English("Vineberry Sapling");
            build.Description.English("");
            build.RequiredItems.Add("VineberrySeeds", 1, true);
        };
        var piece_volture_nest = new Clone("volture_strawpile");
        piece_volture_nest.OnCreated += prefab =>
        {
            prefab.Remove<Destructible>();
            var model = prefab.CreateAndSetUnderModel();
            prefab.SetLayerRecursively(10);
            var c = prefab.AddCollider(0.9f);
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_volture_straw_pile";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default");
            var wnt = prefab.AddComponent<WearNTear>();
            wnt.m_hitEffect = new EffectListRef("vfx_SawDust");
            wnt.m_destroyedEffect = new EffectListRef("vfx_SawDust");
            wnt.m_new = model;
            wnt.m_worn = model;
            wnt.m_wet = model;
            wnt.m_broken = model;

            wnt.m_materialType = WearNTear.MaterialType.Ancient;
            wnt.m_health = 80f;
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Volture Nest");

            build.RequiredItems.Add("Barley", 5, true);
            build.RequiredItems.Add("VoltureEgg", 1, true);
            build.Snapshot();
        };
        
        var piece_ashlands_altar = new Clone("Ashlands_Altar");
        piece_ashlands_altar.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_altar";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Ashlands Altar");

            build.RequiredItems.Add("Blackwood", 5, true);
            build.RequiredItems.Add("FlametalNew", 1, true);
            build.Snapshot();
        };
        
        var piece_ashlands_boss_pillar = new Clone("Ashlands_Boss_Pillar");
        piece_ashlands_boss_pillar.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_boss_pillar";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Fader Pillar");

            build.RequiredItems.Add("Blackwood", 5, true);
            build.RequiredItems.Add("Grausten", 5, true);
            build.Snapshot();
        };

        var piece_ashlands_boss_pillar_broken = new Clone("Ashlands_Boss_Pillar_Twist_broken1");
        piece_ashlands_boss_pillar_broken.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_boss_pillar";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Fader Pillar");

            build.RequiredItems.Add("Blackwood", 5, true);
            build.RequiredItems.Add("Grausten", 5, true);
            build.Snapshot();
        };
        
        
        var piece_ashlands_boss_pillar_broken2 = new Clone("Ashlands_Boss_Pillar_Twist_broken2");
        piece_ashlands_boss_pillar_broken2.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_boss_pillar";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Fader Pillar");

            build.RequiredItems.Add("Blackwood", 5, true);
            build.RequiredItems.Add("Grausten", 5, true);
            build.Snapshot();
        };
        
        var piece_ashlands_boss_pillar_broken3 = new Clone("Ashlands_Boss_Pillar_Twist_broken3");
        piece_ashlands_boss_pillar_broken3.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            if (!prefab.HasCollider()) prefab.AddCollider();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_ashlands_boss_pillar";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Fader Pillar");

            build.RequiredItems.Add("Blackwood", 5, true);
            build.RequiredItems.Add("Grausten", 5, true);
            build.Snapshot();
        };
        var piece_asksvin_carrion = new Clone("asksvin_carrion");
        piece_asksvin_carrion.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<StaticPhysics>();
            var c= prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_asksvin_carrion";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Asksvin Carrion");

            build.RequiredItems.Add("BoneFragments", 5, true);
            build.RequiredItems.Add("Grausten", 5, true);
            build.Snapshot();
        };
        
        var piece_asksvin_carrion2 = new Clone("asksvin_carrion2");
        piece_asksvin_carrion2.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            prefab.Remove<StaticPhysics>();
            var c= prefab.AddCollider();
            c.excludeLayers = LayerMask.GetMask("character");
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_asksvin_carrion";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Asksvin Carrion");

            build.RequiredItems.Add("BoneFragments", 5, true);
            build.RequiredItems.Add("Grausten", 5, true);
            build.Snapshot();
        };
        var piece_charred_banner = new Clone("CharredBanner1");
        piece_charred_banner.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_charred_banner";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_comfort = 1;
            piece.m_comfortGroup = Piece.ComfortGroup.Banner;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Charred Banner");

            build.RequiredItems.Add("Coal", 2, true);
            build.RequiredItems.Add("Blackwood", 4, true);
            build.Snapshot();
        };
        var piece_charred_banner2 = new Clone("CharredBanner2");
        piece_charred_banner2.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_charred_banner";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_comfort = 1;
            piece.m_comfortGroup = Piece.ComfortGroup.Banner;
            piece.m_placeEffect = new EffectListRef("vfx_Place_pole", "sfx_build_hammer_default");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Charred Banner");

            build.RequiredItems.Add("Coal", 2, true);
            build.RequiredItems.Add("Blackwood", 4, true);
            build.Snapshot();
        };
        var piece_charred_banner3 = new Clone("CharredBanner3");
        piece_charred_banner3.OnCreated += prefab =>
        {
            prefab.Remove<DropOnDestroyed>();
            var piece = prefab.AddComponent<Piece>();
            piece.m_name = "$piece_charred_banner";
            piece.m_category = Piece.PieceCategory.Misc;
            piece.m_usage = Piece.UsageTagFlags.Decor;
            piece.m_comfort = 1;
            piece.m_comfortGroup = Piece.ComfortGroup.Banner;
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            BuildPiece build = new BuildPiece(prefab);
            build.Category.Set("Nature");
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Name.English("Charred Banner");

            build.RequiredItems.Add("Coal", 2, true);
            build.RequiredItems.Add("Blackwood", 4, true);
            build.Snapshot();
        };
    }
}