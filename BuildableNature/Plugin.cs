using System.IO;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using Managers;
using PieceManager;
using ServerSync;
using UnityEngine;

namespace BuildableNature
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class BuildableNaturePlugin : BaseUnityPlugin
    {
        internal const string ModName = "BuildableNature";
        internal const string ModVersion = "1.0.9";
        internal const string Author = "RustyMods";
        private const string ModGUID = Author + "." + ModName;
        private static readonly string ConfigFileName = ModGUID + ".cfg";
        private static readonly string ConfigFileFullPath = Paths.ConfigPath + Path.DirectorySeparatorChar + ConfigFileName;
        internal static string ConnectionError = "";
        public readonly Harmony _harmony = new(ModGUID);
        public static readonly ManualLogSource BuildableNatureLogger = BepInEx.Logging.Logger.CreateLogSource(ModName);
        private static readonly ConfigSync ConfigSync = new(ModGUID) { DisplayName = ModName, CurrentVersion = ModVersion, MinimumRequiredVersion = ModVersion };
        public enum Toggle { On = 1, Off = 0 }

        public static GameObject m_root = null!;
        public static BuildableNaturePlugin instance = null!;
        private static ConfigEntry<Toggle> _serverConfigLocked = null!;



        public void Awake()
        {
            instance = this;
            _serverConfigLocked = config("1 - General", "Lock Configuration", Toggle.On,
                "If on, the configuration is locked and can be changed by server admins only.");
            _ = ConfigSync.AddLockingConfigEntry(_serverConfigLocked);            
            m_root = new GameObject("root");
            DontDestroyOnLoad(m_root);
            m_root.SetActive(false);

            PiecePrefabManager.Init = true;
            // ReadMeBuilder.Init(false);
            
            
            // ashlands_archroof
            // ashlands_floor_large
            // ashlands_fortress_wall_pillar
            // ashlands_fortress_wall_pillar_base
            // ashlands_fortress_wall_pillartop
            // ashlands_fortress_wall_pillartopstone
            // ashlands_ruins_wall_4x6
            // ashlands_ruins_wall_windows_broken_4x6
            // ashlands_wallblock

            Assets.Misc();
            Assets.DeepNorth();
            Assets.Ashlands();
            Assets.Meadows();
            Assets.BlackForest();
            Assets.Plains();
            Assets.Mistlands();
            Assets.Swamps();
            Assets.Mountains();
            
            // var piece_cargo_crate = new Clone("CargoCrate");
            // piece_cargo_crate.OnCreated += prefab =>
            // {
            //     // Keeps being placed 70 meters above placement????
            //     prefab.Remove<Rigidbody>();
            //     prefab.Remove<ZSyncTransform>();
            //     prefab.Remove<Floating>();
            //     prefab.Remove<Destructible>();
            //     var model = prefab.transform.Find("default (4)").gameObject;
            //     prefab.SetLayerRecursively(10);
            //     var piece = prefab.AddComponent<Piece>();
            //     piece.m_name = "$piece_cargo_crate";
            //     piece.m_category = Piece.PieceCategory.Misc;
            //     piece.m_usage = Piece.UsageTagFlags.Storage;
            //     piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");
            //     var wnt = prefab.AddComponent<WearNTear>();
            //     wnt.m_hitEffect = new EffectListRef("vfx_SawDust");
            //     wnt.m_destroyedEffect = new EffectListRef("vfx_SawDust", "sfx_wood_destroyed");
            //     wnt.m_new = model;
            //     wnt.m_worn = model;
            //     wnt.m_wet = model;
            //     wnt.m_broken = model;
            //     wnt.m_materialType = WearNTear.MaterialType.Wood;
            //     wnt.m_health = 80f;
            //     wnt.m_supports = false;
            //     BuildPiece build = new BuildPiece(prefab);
            //     build.Category.Set("Nature");
            //     build.Usage.Set(Piece.UsageTagFlags.Storage);
            //     build.Name.English("Cargo Crate");
            //     build.RequiredItems.Add("Wood", 10, true);
            //     build.RequiredItems.Add("BronzeNails", 1, true);
            //     build.Snapshot();
            // };
            
            // dungeon_sunkencrypt_irongate_rusty
            
            var piece_morkhalla_banner_1 = new Clone("Morkhalla_Banner1");
            piece_morkhalla_banner_1.OnCreated += prefab =>
            {
                // banner drifts from post ??
                prefab.Remove<DropOnDestroyed>();
                
                prefab.SetLayerRecursively(10);
                var piece = prefab.AddComponent<Piece>();
                piece.m_name = "$piece_morkhalla_banner_1";
                piece.m_category = Piece.PieceCategory.Misc;
                piece.m_usage = Piece.UsageTagFlags.Decor;
                piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");

                BuildPiece build = new BuildPiece(prefab);
                build.Category.Set("Nature");
                build.Usage.Set(Piece.UsageTagFlags.Decor);
                build.Name.English("Morkhalla Banner");
                build.RequiredItems.Add("FineWood", 10, true);
                build.RequiredItems.Add("BronzeNails", 5, true);
                build.Snapshot();
            };
            
            var piece_morkhalla_banner_2 = new Clone("Morkhalla_Banner2");
            piece_morkhalla_banner_2.OnCreated += prefab =>
            {
                prefab.Remove<DropOnDestroyed>();
                
                prefab.SetLayerRecursively(10);
                var piece = prefab.AddComponent<Piece>();
                piece.m_name = "$piece_morkhalla_banner_1";
                piece.m_category = Piece.PieceCategory.Misc;
                piece.m_usage = Piece.UsageTagFlags.Decor;
                piece.m_placeEffect = new EffectListRef("vfx_Place_workbench", "sfx_build_hammer_wood");

                BuildPiece build = new BuildPiece(prefab);
                build.Category.Set("Nature");
                build.Usage.Set(Piece.UsageTagFlags.Decor);
                build.Name.English("Morkhalla Banner");
                build.RequiredItems.Add("FineWood", 10, true);
                build.RequiredItems.Add("BronzeNails", 5, true);
                build.Snapshot();
            };

            
// ashland_pot1_green
// ashland_pot1_red
// ashland_pot2_green
// ashland_pot2_red
// ashland_pot3_green
// ashland_pot3_red
// Ashland_Stair
// Ashland_Steepstair
// Ashlands_Arch2_Broken1
// Ashlands_Arch2_Broken2
// Ashlands_ArchRoof
// Ashlands_ArchRoofDamaged
// Ashlands_ArchRoofDamaged_half1
// Ashlands_ArchRoofDamaged_half2
// Ashlands_ArchRoofLong_Damaged

// Ashlands_Floor
// Ashlands_floor_large
// Ashlands_floor_large_fractured
// Ashlands_Fortress_Floor
// Ashlands_Fortress_Gate
// Ashlands_Fortress_Gate_Door
// Ashlands_Fortress_Wall_Pillar
// Ashlands_Fortress_Wall_Pillar_base
// Ashlands_Fortress_Wall_Pillar_base_frac
// Ashlands_Fortress_Wall_Pillar_frac
// Ashlands_Fortress_Wall_PillarTop
// Ashlands_Fortress_Wall_PillarTop_frac
// Ashlands_Fortress_Wall_PillarTopStone
// Ashlands_Fortress_Wall_PillarTopStone_frac
// Ashlands_Fortress_Wall_Spikes
// Ashlands_Pillar4
// Ashlands_Pillar4_tip
// Ashlands_Pillar4_tip_broken1
// Ashlands_Pillar4_tip_broken2
// Ashlands_Pillar4_tip2
// Ashlands_Pillar4_tip2_broken1
// Ashlands_Pillar4_tip2_broken2
// Ashlands_Pillar4_tip3
// Ashlands_Pillar4_tip3_broken1
// Ashlands_Pillar4_tip3_broken2
// Ashlands_Pillar4_tip3_broken3
// Ashlands_PillarBase3_double
// Ashlands_Ramp
// Ashlands_Ruins_Floor_1point5x1point5
// Ashlands_Ruins_Floor_1point5x1point5_broken
// Ashlands_Ruins_Floor_3x3
// Ashlands_Ruins_Floor_3x3_broken1
// Ashlands_Ruins_Floor_3x3_broken2
// Ashlands_Ruins_Floor_3x3_broken3
// Ashlands_Ruins_Floor_6x6
// Ashlands_Ruins_Floor_6x6_broken1
// Ashlands_Ruins_Floor_6x6_broken2
// Ashlands_Ruins_Ramp
// Ashlands_Ruins_Ramp_Upsidedown
// Ashlands_Ruins_TopStone
// Ashlands_Ruins_twist_ArchBig
// Ashlands_Ruins_twist_PillarBase
// Ashlands_Ruins_twist_PillarBaseSmall
// Ashlands_Ruins_Wall_4x6
// Ashlands_Ruins_Wall_Broken3_4x6
// Ashlands_Ruins_Wall_Broken4_4x6
// Ashlands_Ruins_Wall_Broken5_4x6
// Ashlands_Ruins_Wall_Top_wHole
// Ashlands_Ruins_Wall_Window_4x6_broken2
// Ashlands_Ruins_Wall_Window_4x6_broken3
// Ashlands_Ruins_Wall_Window_4x6_broken4
// Ashlands_Ruins_Wall_Window_4x6_broken5
// Ashlands_Ruins_Wall_Window_4x6_broken6
// Ashlands_Ruins_Wall_Windows_Broken_4x6
// Ashlands_StairsBroad
// Ashlands_Wall_2x2
// Ashlands_Wall_2x2_cornerL
// Ashlands_Wall_2x2_cornerL_top
// Ashlands_Wall_2x2_cornerR
// Ashlands_Wall_2x2_cornerR_top
// Ashlands_Wall_2x2_edge
// Ashlands_Wall_2x2_edge_top
// Ashlands_Wall_2x2_edge2
// Ashlands_Wall_2x2_edge2_top
// Ashlands_Wall_2x2_top
// Ashlands_WallBlock
// AshlandsBush2
// AshlandsTreeLog1
// AshlandsTreeLog2
// AshlandsTreeLogHalf1
// AshlandsTreeLogHalf2

// beech_log
// beech_log_half

// blackmarble_altar_crystal_broken

// BossStone_Bonemass
// BossStone_DragonQueen
// BossStone_Eikthyr
// BossStone_Fader
// BossStone_TheElder
// BossStone_TheQueen
// BossStone_Yagluth


// CastleKit_braided_box01
// CastleKit_brazier
// CastleKit_groundtorch
// CastleKit_groundtorch_blue
// CastleKit_groundtorch_green
// CastleKit_groundtorch_unlit
// CastleKit_metal_groundtorch_unlit
// CastleKit_pot03

// caverock_ice_stalagmite_broken
// caverock_ice_stalagmite_destruction
// caverock_ice_stalagtite_destruction
// caverock_ice_stalagtite_falling
// caverock_ice_wall_destruction

// Charredfortress_LOD

// cloth_hanging_door
// cloth_hanging_door_double
// CreepProp_egg_hanging02

// dragoneggcup

// dungeon_forestcrypt_door
// dungeon_sunkencrypt_irongate

// dvergrprops_banner
// dvergrprops_bed
// dvergrprops_chair
// dvergrprops_crate
// dvergrprops_crate_ashlands
// dvergrprops_crate_long
// dvergrprops_curtain
// dvergrprops_hooknchain
// dvergrprops_lantern
// dvergrprops_lantern_standing
// dvergrprops_shelf
// dvergrprops_stool
// dvergrprops_table
// dvergrprops_wood_beam
// dvergrprops_wood_pole
// dvergrprops_wood_stake
// dvergrprops_wood_stakewall
// dvergrprops_wood_wall
// dvergrtown_arch
// dvergrtown_creep_door
// dvergrtown_secretdoor
// dvergrtown_slidingdoor
// dvergrtown_stair_corner_wood_left
// dvergrtown_wood_crane
// dvergrtown_wood_stake
// dvergrtown_wood_stakewall

// fader_bellholder

// FirTree_Big_log
// FirTree_big_log_half
// FirTree_log
// FirTree_log_half
// FirTree_oldLog_deepnorth
// FirTree_Snow_log
// FirTree_Snow_log_half

// FlametalRockstand_frac

// giant_brain_frac
// giant_helmet1_destruction
// giant_helmet2_destruction
// giant_ribs_frac
// giant_skull_frac
// giant_sword1_destruction
// giant_sword2_destruction
// gjall_egg_projectile
// gjall_spit_projectile
// GlowingMushroom

// goblin_banner
// goblin_fence
// goblin_pole
// goblin_pole_small
// goblin_roof_45d
// goblin_roof_45d_corner
// goblin_roof_cap
// goblin_stairs
// goblin_stepladder
// goblin_strawpile
// goblin_trashpile_destruction
// goblin_woodwall_1m
// goblin_woodwall_2m
// goblin_woodwall_2m_ribs

// goblinking_totemholder


// goldvein_frac

// GraveStone_Broken_CharredTwitcherNest
// GraveStone_Broken_World
// GraveStone_CharredFaderLocation
// GraveStone_CharredTwitcherNest
// GraveStone_Elite_Broken_CharredTwitcherNest
// GraveStone_Elite_CharredTwitcherNest
// Greydwarf_Surprise

// GreydwarfSurprise

// HeathRockPillar_frac

// highstone_2_frac
// highstone_frac
// HildirKey_forestcrypt
// HildirKey_mountaincave
// HildirKey_plainsfortress

// HoleRock_opening_znet
// HoleRock_root1
// HoleRock_root1_destruction
// HoleRock_rootBush1
// HoleRock_rootWall1_destruction

// horizontal_web

// Ice_floor
// Ice_floor_fractured
// ice_rock1_frac
// Ice_ship_1
// Ice_ship_2
// Ice_ship_3
// Ice_ship_4
// Ice_ship_5
// Ice_ship_6
// Ice_ship_7
// IceBlocker
// IcePond_rock_frac
// IceShelf_01
// IceShelf_02
// IceShelf_03
// IceShelf_04
// IceShelf_05
// IceShelf_06
// IceShelf_07
// IceShelf_08
// IceShelf_09
// IceShelf_10
// IceShoes
// IceShore
// IceShore_frac
// IceSkates
// IceWall

// Lantern_hooded
// LargeBone
// LargeBone_half01
// LargeBone_half02
// Larva
// LastBossGate_RuneTile
// lavabomb_projectile
// LeatherScraps
// Leatherstraps
// LinenThread
// lox_ribs
// LoxMeat
// LoxPelt
// LoxPieUncooked
// MaceBronze
// MaceEldner
// MaceEldnerBlood
// MaceEldnerLightning
// MaceEldnerNature
// MaceGold
// MaceGold_BloodLightning
// MaceGold_FrostFire
// MaceGoldUncooked
// MaceIron
// MaceNeedle
// MaceSilver
// MaceWood
// MagicallyStuffedShroomUncooked
// Mandible
// MeadBaseBugRepellent
// MeadBaseBzerker
// MeadBaseEitrLingering
// MeadBaseEitrMinor
// MeadBaseFrostResist
// MeadBaseHasty
// MeadBaseHealthLingering
// MeadBaseHealthMajor
// MeadBaseHealthMedium
// MeadBaseHealthMinor
// MeadBaseLightFoot
// MeadBasePoisonResist
// MeadBaseStaminaLingering
// MeadBaseStaminaMedium
// MeadBaseStaminaMinor
// MeadBaseStrength
// MeadBaseSwimmer
// MeadBaseTamer
// MeadBaseTasty
// MeatPlatterUncooked
// MechanicalSpring
// MemorialCoal
// MisthareSupremeUncooked
// MoldArmorGoldChest
// MoldArmorGoldHelmet
// MoldArmorGoldLegs
// MoldArmorMageChest
// MoldArmorMageHelmet
// MoldArmorMageLegs
// MoldArmormediumChest
// MoldArmorMediumHelmet
// MoldArmorMediumLegs
// MoldAtgeir
// MoldAxe
// MoldAxe2H
// MoldBow
// MoldCrossbow
// MoldFistweapon
// MoldKeys
// MoldKnife
// MoldMace
// MoldMace2H
// MoldShieldBuckler
// MoldShieldRound
// MoldShieldTower
// MoldSmallParts
// MoldSpear
// MoldStafffrostorbs
// MoldStaffOrbofAhri
// MoldStaffspiritcaller
// MoldStaffthunderblood
// MoldSword
// MoldSword2H
// MoleClaws
// MoltenCore
// MooseHide
// MooseMeat
// MooseSinew
// MorgenHeart
// MorgenSinew
// Morkborg_gate

// Morkhalla_Bench
// Morkhalla_Block
// Morkhalla_bridge_davinci
// Morkhalla_Chain
// Morkhalla_coal_pile_memorial
// Morkhalla_Drawbridge
// Morkhalla_Floor_2x2
// Morkhalla_Floor_4x4
// Morkhalla_Floor_4x4_broken01
// Morkhalla_Floor_4x4_broken02
// Morkhalla_giant_railing
// Morkhalla_giant_railing_corner
// Morkhalla_giant_railing_deco
// Morkhalla_giant_railing_half
// Morkhalla_giant_railing_single
// Morkhalla_giant_railing_torch
// Morkhalla_giant_railing_torch_unlit
// Morkhalla_jotun_gate
// Morkhalla_MetalBar
// Morkhalla_Rubble_Destroyed
// Morkhalla_rubble_trashpile_destruction
// Morkhalla_Rubble1_fall
// Morkhalla_Rubble2_fall
// Morkhalla_Rug_stair
// Morkhalla_Stairs_giant_railing
// Morkhalla_Stairs_giant_short
// Morkhalla_Stairs_giant_short_broken1
// Morkhalla_Stairs_giant_short_broken2
// Morkhalla_StatuePieceArmL_big
// Morkhalla_StatuePieceArmR_big
// Morkhalla_StatuePieceFace_big
// Morkhalla_StatuePieceFeet_big
// Morkhalla_StatuePieceHorn_big
// Morkhalla_StatuePieceHorn2_big
// Morkhalla_StatuePieceLegs_big
// Morkhalla_StatuePieceSword_big
// Morkhalla_StatuePieceTorso_big
// Morkhalla_StatueSword
// Morkhalla_StatueSword_hanging
// Morkhalla_Stool
// Morkhalla_Table
// Morkhalla_Trainingdummy1
// Morkhalla_Trainingdummy2
// Morkhalla_WallChain1
// Morkhalla_woodboards_Destroyed
// MountainKit_brazier
// MountainKit_brazier_blue
// MountainKit_brazier_purple
// mountainkit_chair
// mountainkit_table
// MountainKit_wood_gate
// mudpile_beacon
// mudpile_frac
// mudpile_old
// mudpile2_frac
// MushroomBlue
// NeckTail
// Needle
// NornThread
// Oak_log
// Oak_log_half
// OatFlour
// OatSeeds
// Obsidian
// odin
// offeraltar_FrozenKing_bossroom
// OnionSeeds
// Ooze
// oozebomb_projectile
// OozeMork
// OrbFrostFire
// OrbThunderBlood
// OvenPancakeUncooked
// Pickable_Barley
// Pickable_Barley_Wild
// Pickable_Branch
// Pickable_Branch_Snow
// Pickable_Carrot
// Pickable_DragonEgg
// Pickable_DvergerThing
// Pickable_DvergrLantern
// Pickable_DvergrMineTreasure
// Pickable_DvergrStein
// Pickable_Fiddlehead
// Pickable_Fishingrod
// Pickable_Flax
// Pickable_Flax_Wild
// Pickable_GlowWorm
// Pickable_Hairstrands01
// Pickable_Hairstrands02
// Pickable_HardRockOffspring
// Pickable_Kale
// Pickable_MountainRemains01_buried
// Pickable_Mushroom
// Pickable_Mushroom_blue
// Pickable_Mushroom_JotunPuffs
// Pickable_Mushroom_Magecap
// Pickable_Mushroom_yellow
// Pickable_Oat
// Pickable_Obsidian
// Pickable_Onion
// Pickable_Pot_Shard
// Pickable_Poteitr
// Pickable_RoyalJelly
// Pickable_SeedCarrot
// Pickable_SeedKale
// Pickable_SeedOnion
// Pickable_SeedTurnip
// Pickable_Snowball
// Pickable_Stone
// Pickable_StoneRock
// Pickable_SulfurRock
// Pickable_Swordpiece1
// Pickable_Swordpiece2
// Pickable_Swordpiece3
// Pickable_TarBig
// Pickable_Turnip
// PickaxeAntler
// PickaxeBlackMetal
// PickaxeBronze
// PickaxeIron
// PickaxeStone
// piece_Charred_Balista
// PineCone
// PineTree_log
// PineTree_log_half
// PineTree_log_halfOLD
// PineTree_logOLD
// Pinetree_Snow
// Pinetree_Snow_dead
// PineTree_Snow_log
// PineTree_Snow_log_half
// PineTree_Snow_log_half_frost_troll
// PineTree_Snow_log_XL
// PineTree_Snow_log_XL_half
// Pinetree_Snow_Stub
// PiquantPieUncooked
// Player_tombstone
// PlayerUnarmed
// Pot_Shard_Green
// Pot_Shard_Red
// PoteitrSeeds
// PowderedDragonEgg
// projectile_ashlandmeteor
// projectile_ashlandmeteor2
// projectile_chitinharpoon
// projectile_FimbulvinterMeteor
// Projectile_GrapplingHook
// Projectile_GrapplingHook_secondary
// projectile_meteor
// projectile_meteor_fader
// projectile_spikes_frozenking
// projectile_splitner
// projectile_splitner_blood
// projectile_splitner_lightning
// projectile_splitner_nature
// projectile_wolffang
// prop_ashwood_bed
// prop_bed02
// prop_bonfire
// prop_cauldron_ext1_spice
// prop_cauldron_ext3_butchertable
// prop_cauldron_ext5_mortarandpestle
// prop_cauldron_ext6_rollingpins
// prop_chest_warderobe
// prop_FeastAshlands
// prop_FeastMeadows
// prop_forge_ext2
// prop_forge_ext5
// prop_hearth
// prop_itemstand
// prop_itemstand_TrophyDraugrElite
// prop_itemstand_TrophyGoblinBrute
// prop_itemstand_TrophyGoblinShaman
// prop_itemstand_TrophyGreydwarf
// prop_itemstand_TrophyGreydwarfBrute
// prop_itemstand_TrophySeekerBrute
// prop_piece_bench_runed
// prop_piece_brazierfloor01
// prop_piece_cauldron
// prop_piece_chair03
// prop_piece_cookingstation
// prop_piece_MeadCauldron
// prop_piece_workbench_ext1
// prop_piece_workbench_ext2
// prop_piece_workbench_ext3
// prop_piece_workbench_ext4
// prop_preptable
// prop_Tankard
// prop_wood_stack
// PropFeastDeepNorth
// ProustitePowder
// PungentPebbles
// QueenBee
// QueenDrop
// radiation
// RawMeat
// Resin
// RoastedCrustPieUncooked
// Rock_3_deepnorth
// Rock_3_deepnorth_frac
// Rock_3_frac
// Rock_4_deepnorth
// Rock_4_plains
// Rock_7_deepnorth
// Rock_7_meadows
// Rock_destructible
// Rock_destructible_test
// rock_mistlands1_frac
// rock1_mountain
// rock1_mountain_frac
// rock2_heath_frac
// rock2_mountain
// rock2_mountain_frac
// rock3_ice
// rock3_ice_frac
// rock3_mountain_1_frac
// rock3_mountain_frac
// rock3_silver_frac
// rock4_ashlands_frac
// rock4_bigrock_frac
// rock4_coast_frac
// rock4_copper_frac
// rock4_forest_frac
// rock4_heath
// rock4_heath_frac
// RockFinger_frac
// RockFingerBroken_frac
// rockformation1
// RockThumb_frac
// Root
// RoundLog
// Ruby
// rug_bogwitch_deer
// rug_bogwitch_fur
// rug_bogwitch_wolf
// SaddleAsksvin
// SaddleLox
// SaddleMoose
// Sap
// ScaleHide
// Scythe
// ScytheHandle
// SealBlubber
// SealHide
// SeekerBrute_Taunt
// SeekerEgg_alwayshatch
// SerpentMeat
// SerpentScale
// SharpeningStone
// ShieldBanded
// ShieldBlackmetal
// ShieldBlackmetalTower
// ShieldBoneTower
// ShieldBronzeBuckler
// ShieldBucklerGoldUncooked
// ShieldCarapace
// ShieldCarapaceBuckler
// ShieldCore
// ShieldFlametal
// ShieldFlametalTower
// ShieldGold
// ShieldGoldBuckler
// ShieldGoldTower
// ShieldIronBuckler
// ShieldIronSquare
// ShieldIronTower
// ShieldKnight
// ShieldRoots
// ShieldRoundGoldUncooked
// ShieldSerpentscale
// ShieldSilver
// ShieldTowerGoldUncooked
// ShieldWood
// ShieldWoodTower
// ShimmeringSand_rock_frac
// shipwreck_karve_bottomboards
// shipwreck_karve_bow
// shipwreck_karve_chest
// shipwreck_karve_dragonhead
// shipwreck_karve_stern
// shipwreck_karve_sternpost
// shipwreck_vikingship_chest
// shipwreck_vikingship_front
// shipwreck_vikingship_frontpiece
// shipwreck_vikingship_mast1
// shipwreck_vikingship_rear
// Shovel
// siegebomb_projectile
// Silver
// SilverNecklace
// SilverOre
// silvervein_frac
// Skeleton
// Skeleton_aspect
// skeleton_bow
// skeleton_bow_meadows
// skeleton_bow_mountains
// skeleton_bow_swamps
// skeleton_bow2
// Skeleton_DeepNorth
// Skeleton_Friendly
// Skeleton_Hildir
// skeleton_hildir_firenova
// Skeleton_Hildir_nochest
// skeleton_mace
// skeleton_mace_DeepNorth
// Skeleton_Meadows
// Skeleton_Meadows_noarcher
// Skeleton_Mountains
// Skeleton_Mountains_noarcher
// Skeleton_NoArcher
// Skeleton_Poison
// Skeleton_Swamps
// Skeleton_Swamps_noarcher
// skeleton_sword
// skeleton_sword_hildir
// skeleton_sword_meadows
// skeleton_sword_mountains
// skeleton_sword_swamps
// skeleton_sword2
// Skull1
// Skull2
// SledgeCheat
// SledgeDemolisher
// SledgeGold
// SledgeGold_BloodLightning
// SledgeGold_FrostFire
// SledgeGoldUncooked
// SledgeIron
// SledgeStagbreaker
// SledgeWood
// SmallPartsGoldUncooked
// smokebomb_projectile
// Snowball
// snowball_projectile
// SnowballBig
// snowballbig_projectile
// SnowFirTree_small
// Softtissue
// SP_ArmorBronzeChest
// SP_ArmorBronzeLegs
// SP_ArmorDress1
// SP_ArmorFenringChest
// SP_ArmorFenringLegs
// SP_ArmorLeatherLegs
// SP_ArmorMageChest
// SP_ArmorMageChest_Ashlands
// SP_ArmorMageLegs
// SP_ArmorMageLegs_Ashlands
// SP_ArmorPaddedCuirass
// SP_ArmorPaddedGreaves
// SP_ArmorTrollLeatherChest
// SP_ArmorTrollLeatherLegs
// SP_ArmorTunic5
// SP_AxeBronze
// SP_BattleaxeCrystal
// SP_BowDraugrFang
// SP_CapeLinen
// SP_CapeTrollHide
// SP_CapeWolf
// SP_HelmetBronze
// SP_KnifeSilver
// SP_KnifeSkollAndHati
// SP_ShieldBlackmetalTower
// SP_StaffFireball
// SP_StaffLightning
// SP_SwordBlackmetal
// Sparkler
// Spawner_CharredStone_event
// Spawner_GreydwarfNest
// Spawner_Hole_double
// SpearBronze
// SpearCarapace
// SpearChitin
// SpearElderbark
// SpearFlint
// SpearGold
// SpearGold_BloodLightning
// SpearGold_FrostFire
// SpearGoldUncooked
// SpearSplitner
// SpearSplitner_Blood
// SpearSplitner_Lightning
// SpearSplitner_Nature
// SpearWolfFang
// SpearWood
// SpiceAshlands
// SpiceDeepNorth
// SpiceForests
// SpiceMistlands
// SpiceMountains
// SpiceOceans
// SpicePlains
// staff_fireball_projectile
// staff_FrostOrbs_projectile
// staff_greenroots_projectile
// staff_iceshard_projectile
// staff_OrbofAhri_projectile
// staff_OrbofAhri_projectile_return
// staff_skeleton_projectile
// StaffClusterbomb
// StaffFireball
// StaffFrostOrbs
// StaffFrostOrbsUncooked
// StaffGreenRoots
// StaffIceShards
// StaffLightning
// StaffOrbofAhri
// StaffOrbofAhriUncooked
// StaffRedTroll
// StaffShield
// StaffSkeleton
// StaffSpiritCaller
// StaffSpiritCallerUncooked
// StaffThunderBlood
// StaffThunderbloodUncooked
// StaminaUpgrade_Greydwarf
// StaminaUpgrade_Troll
// StaminaUpgrade_Wraith
// StartPlatform
// StatueCorgi
// StatueDeer
// StatueEvil
// StatueFreya
// StatueFreya_broken_left
// StatueFreya_broken_right
// StatueHare
// StatueSeed
// StatueThor
// StatueThor_broken_bottom
// StatueThor_broken_top
// Stone
// stone_wall_1x1_ruin
// stone_wall_2x1_ruin
// stone_wall_ruin
// stone_wall_ruin_2
// stoneblock_fracture
// stonechest
// StoneRock
// stubbe_deepnorth
// stubbe_spawner
// StumpHole_destroyed
// StumpHut_frac
// SulfurStone
// sunken_crypt_gate
// SunkenKit_int_towerwall_LOD
// SurtlingCore
// SwampTree1_log
// SwampTree2
// SwampTree2_darkland
// SwampTree2_log
// Sword2h_JotunWarrior
// SwordBlackmetal
// SwordBronze
// SwordCheat
// SwordDyrnwyn
// SwordGold
// SwordGold_BloodLightning
// SwordGold_FrostFire
// SwordGoldUncooked
// SwordIron
// SwordIronFire
// SwordMistwalker
// SwordNiedhogg
// SwordNiedhoggBlood
// SwordNiedhoggLightning
// SwordNiedhoggNature
// SwordSilver
// SwordWood
// Tankard
// Tankard_dvergr
// TankardAnniversary
// TankardOdin
// Tar
// TarLiquid
// tarlump1_frac
// TheHive
// Thistle
// THSwordGold
// THSwordGold_BloodLightning
// THSwordGold_FrostFire
// THSwordGoldUncooked
// THSwordKrom
// THSwordSlayer
// THSwordSlayerBlood
// THSwordSlayerLightning
// THSwordSlayerNature
// THSwordWood
// Thunderstone
// Tin
// TinOre
// tolroko_flyer
// Torch
// TorchMist
// TrainingDummy
// TrainingDummy_throw_projectile
// TriggerSpawner_Brood
// TriggerSpawner_Seeker
// TrinketBlackDamageHealth
// TrinketBlackStamina
// TrinketBloodGoldHealth
// TrinketBloodGoldStamina
// TrinketBronzeHealth
// TrinketBronzeStamina
// TrinketCarapaceEitr
// TrinketChitinSwim
// TrinketFlametalEitr
// TrinketFlametalStaminaHealth
// TrinketIronHealth
// TrinketIronStamina
// TrinketScaleStaminaDamage
// TrinketSilverDamage
// TrinketSilverResist
// troll_log_swing_h
// troll_log_swing_v
// troll_summoned_log_swing_h
// troll_summoned_log_swing_v
// troll_summoned_throw_projectile
// troll_throw_projectile
// TrollFrost_Frac
// TrollFrost_Frac_arm
// TrollFrost_Frac_legs
// TrollHide
// trollsnow_throw_projectile
// TrophyAbomination
// TrophyAsksvin
// TrophyBarka
// TrophyBjorn
// TrophyBjornUndead
// TrophyBlob
// TrophyBlob_Frost
// TrophyBlob_Lava
// TrophyBlob_Morkhalla
// TrophyBoar
// TrophyBonemass
// TrophyBonemawSerpent
// TrophyCharredArcher
// TrophyCharredMage
// TrophyCharredMelee
// TrophyCultist
// TrophyCultist_Hildir
// TrophyDeathsquito
// TrophyDeer
// TrophyDeerWhite
// TrophyDragonQueen
// TrophyDraugr
// TrophyDraugrElite
// TrophyDraugrFem
// TrophyDvergr
// TrophyEikthyr
// TrophyElaking
// TrophyFader
// TrophyFallenValkyrie
// TrophyFenring
// TrophyForestTroll
// TrophyFrostTroll
// TrophyGhost
// TrophyGjall
// TrophyGoblin
// TrophyGoblinBrute
// TrophyGoblinBruteBrosBrute
// TrophyGoblinBruteBrosShaman
// TrophyGoblinKing
// TrophyGoblinShaman
// TrophyGreydwarf
// TrophyGreydwarfBrute
// TrophyGreydwarfShaman
// TrophyGrowth
// TrophyHare
// TrophyHatchling
// TrophyJotunWarrior
// TrophyJotunWitch
// TrophyLeech
// TrophyLox
// TrophyMole
// TrophyMoose
// TrophyMorgen
// TrophyNeck
// TrophySeal
// TrophySeeker
// TrophySeekerBrute
// TrophySeekerQueen
// TrophySerpent
// TrophySGolem
// TrophySkeleton
// TrophySkeletonHildir
// TrophySkeletonPoison
// TrophySurtling
// TrophyTheElder
// TrophyTick
// TrophyUlv
// TrophyVolture
// TrophyWolf
// TrophyWraith
// TrophyWrithan
// tunnel_web
// Turnip
// TurnipSeeds
// Turret_projectile
// Turret_projectile_bloodgold
// Turret_projectilebone
// TurretBolt
// TurretBoltBloodgold
// TurretBoltBone
// TurretBoltFlametal
// TurretBoltWood
// UndeadBjornRibcage
// UnstableLavaRock
// Upgrader0Armor
// Upgrader0Weapon
// Upgrader1Armor
// Upgrader1Weapon
// Upgrader2Armor
// Upgrader2Weapon
// Upgrader3Armor
// Upgrader3Weapon
// Upgrader4Armor
// Upgrader4Weapon
// Upgrader5Armor
// Upgrader5Weapon
// Upgrader6Armor
// Upgrader6Weapon
// Upgrader7Armor
// Upgrader7Weapon
// UpgradeStation
// veg_skull_Ashlands
// VegvisirShard_Bonemass
// vertical_web

// VikingCupcakeUncooked
// VineberrySeeds
// VineGreenSeeds
// vines
// Voidplasm
// VoltureEgg
// VoltureMeat
// vx_ashland_pot1_green_destruction
// vx_ashland_pot1_red_destruction
// vx_ashland_pot2_green_destruction
// vx_ashland_pot2_red_destruction
// vx_ashland_pot3_green_destruction
// vx_ashland_pot3_red_destruction
// WallSnow1
// WallSnow2
// WallSnow3
// WallSnow4
// WaterLiquid
// widestone_2_frac
// widestone_frac
// Wishbone
// Wisp
// WitheredBone
// WolfClaw
// WolfFang
// WolfHairBundle
// WolfMeat
// WolfPelt
// Wood
// wooden_path
// WrithanRoots
// YagluthDrop
// yggashoot_log
// yggashoot_log_half
// YggdrasilRoot
// YggdrasilWood
// YmirRemains

            Assembly assembly = Assembly.GetExecutingAssembly();
            _harmony.PatchAll(assembly);
            SetupWatcher();
        }

        // [HarmonyPatch(typeof(ZNetScene), nameof(ZNetScene.Awake))]
        // private static class ZNS_Awake
        // {
        //     private static void Postfix(ZNetScene __instance)
        //     {
        //         for (int i = 0; i < __instance.m_prefabs.Count; ++i)
        //         {
        //             var prefab = __instance.m_prefabs[i];
        //             if (prefab.TryGetComponent(out Piece piece) && piece.enabled) continue;
        //             if (BuildPiece.clones.Exists(c => c.sourceId == prefab.name)) continue;
        //             if (prefab.GetComponentInChildren<MeshRenderer>() is { } mesh)
        //             {
        //                 Debug.LogWarning(prefab.name);
        //             }
        //         }
        //     }
        // }

        private void OnDestroy() => Config.Save();
        
        private void SetupWatcher()
        {
            FileSystemWatcher watcher = new(Paths.ConfigPath, ConfigFileName);
            watcher.Changed += ReadConfigValues;
            watcher.Created += ReadConfigValues;
            watcher.Renamed += ReadConfigValues;
            watcher.IncludeSubdirectories = true;
            watcher.SynchronizingObject = ThreadingHelper.SynchronizingObject;
            watcher.EnableRaisingEvents = true;
        }

        private void ReadConfigValues(object sender, FileSystemEventArgs e)
        {
            if (!File.Exists(ConfigFileFullPath)) return;
            try
            {
                BuildableNatureLogger.LogDebug("ReadConfigValues called");
                Config.Reload();
            }
            catch
            {
                BuildableNatureLogger.LogError($"There was an issue loading your {ConfigFileName}");
                BuildableNatureLogger.LogError("Please check your config entries for spelling and format!");
            }
        }

        public ConfigEntry<T> config<T>(string group, string name, T value, ConfigDescription description,
            bool synchronizedSetting = true)
        {
            ConfigDescription extendedDescription =
                new(
                    description.Description +
                    (synchronizedSetting ? " [Synced with Server]" : " [Not Synced with Server]"),
                    description.AcceptableValues, description.Tags);
            ConfigEntry<T> configEntry = Config.Bind(group, name, value, extendedDescription);
            //var configEntry = Config.Bind(group, name, value, description);

            SyncedConfigEntry<T> syncedConfigEntry = ConfigSync.AddConfigEntry(configEntry);
            syncedConfigEntry.SynchronizedConfig = synchronizedSetting;

            return configEntry;
        }

        public ConfigEntry<T> config<T>(string group, string name, T value, string description,
            bool synchronizedSetting = true)
        {
            return config(group, name, value, new ConfigDescription(description), synchronizedSetting);
        }
    }
}