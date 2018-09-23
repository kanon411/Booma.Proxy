﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booma
{
	/// <summary>
	/// From QEdit's source: itemsname.ini
	/// Enumeration of object types
	/// </summary>
	public enum MapDatFormatEntityObjectType : short //wiki says this is a uint16
	{
		PlayerSet = 0,
		Particle = 1,
		Teleporter = 2,
		Warp = 3,
		LightCollision = 4,
		Item = 5,
		EnvSound = 6,
		FogCollision = 7,
		EventCollision = 8,
		CharaCollision = 9,
		ElementalTrap = 10,
		StatusTrap = 11,
		HealTrap = 12,
		LargeElementalTrap = 13,
		ObjRoomID = 14,
		Sensor = 15,
		UnknownItem_16_ = 16,
		Lensflare = 17,
		ScriptCollision = 18,
		HealRing = 19,
		MapCollision = 20,
		ScriptCollisionA = 21,
		ItemLight = 22,
		RadarCollision = 23,
		FogCollisionSW = 24,
		BossTeleporter = 25,
		ImageBoard = 26,
		QuestWarp = 27,
		Epilogue = 28,
		UnknownItem_29_ = 29,
		UnknownItem_30_ = 30,
		UnknownItem_31_ = 31,
		BoxDetectObject = 32,
		SymbolChatObject = 33,
		TouchplateObject = 34,
		TargetableObject = 35,
		Effectobject = 36,
		CountDownObject = 37,
		UnknownItem_38_ = 38,
		UnknownItem_39_ = 39,
		UnknownItem_40_ = 40,
		UnknownItem_41_ = 41,
		Menuactivation = 64,
		TelepipeLocation = 65,
		BGMCollision = 66,
		MainRagolTeleporter = 67,
		LobbyTeleporter = 68,
		Principalwarp = 69,
		ShopDoor = 70,
		Hunter_sGuildDoor = 71,
		TeleporterDoor = 72,
		MedicalCenterDoor = 73,
		Elevator = 74,
		EasterEgg = 75,
		ValentinesHeart = 76,
		ChristmasTree = 77,
		ChristmasWreath = 78,
		HalloweenPumpkin = 79,
		_21stCentury = 80,
		Sonic = 81,
		WelcomeBoard = 82,
		Firework = 83,
		LobbyScreenDoor = 84,
		MainRagolTeleporter_Battleinnextarea_ = 85,
		LabTeleporterDoor = 86,
		Pioneer2InvisibleTouchplate = 87,
		ForestDoor = 128,
		ForestSwitch = 129,
		LaserFence = 130,
		LaserSquareFence = 131,
		ForestLaserFenceSwitch = 132,
		Lightrays = 133,
		BlueButterfly = 134,
		Probe = 135,
		RandomTypeBox1 = 136,
		ForestWeatherStation = 137,
		Battery = 138,
		ForestConsole = 139,
		BlackSlidingDoor = 140,
		RicoMessagePod = 141,
		EnergyBarrier = 142,
		ForestRisingBridge = 143,
		Switch_nonedoor_ = 144,
		EnemyBox_Grey_ = 145,
		FixedTypeBox = 146,
		EnemyBox_Brown_ = 147,
		EmptyTypeBox = 149,
		LaserFenseEx = 150,
		LaserSquareFenceEx = 151,
		FloorPanel1 = 192,
		Caves4Buttondoor = 193,
		CavesNormaldoor = 194,
		CavesSmashingPillar = 195,
		CavesSign1 = 196,
		CavesSign2 = 197,
		CavesSign3 = 198,
		HexagalTank = 199,
		BrownPlatform = 200,
		WarningLightObject = 201,
		Rainbow = 203,
		FloatingJelifish = 204,
		FloatingDragonfly = 205,
		CavesSwitchDoor = 206,
		RobotRechargeStation = 207,
		CavesCakeShop = 208,
		Caves1SmallRedRock = 209,
		Caves1MediumRedRock = 210,
		Caves1LargeRedRock = 211,
		Caves2SmallRock1 = 212,
		Caves2MediumRock1 = 213,
		Caves2LargeRock1 = 214,
		Caves2SmallRock2 = 215,
		Caves2MediumRock2 = 216,
		Caves2LargeRock2 = 217,
		Caves3SmallRock = 218,
		Caves3MediumRock = 219,
		Caves3LargeRock = 220,
		FloorPanel2 = 222,
		DestructableRock_Caves1_ = 223,
		DestructableRock_Caves2_ = 224,
		DestructableRock_Caves3_ = 225,
		MinesDoor = 256,
		FloorPanel3 = 257,
		MinesSwitchDoor = 258,
		LargeCryo_Tube = 259,
		Computer_likecalus_ = 260,
		GreenScreenopeningandclosing = 261,
		FloatingRobot = 262,
		FloatingBlueLight = 263,
		SelfDestructingObject1 = 264,
		SelfDestructingObject2 = 265,
		SelfDestructingObject3 = 266,
		SparkMachine = 267,
		MinesLargeFlashingCrate = 268,
		RuinsSeal = 304,
		RuinsTeleporter = 320,
		RuinsWarp_Sitetosite_ = 321,
		RuinsSwitch = 322,
		FloorPanel4 = 323,
		Ruins1Door = 324,
		Ruins3Door = 325,
		Ruins2Door = 326,
		Ruins1_1ButtonDoor = 327,
		Ruins2_1ButtonDoor = 328,
		Ruins3_1ButtonDoor = 329,
		Ruins4_ButtonDoor = 330,
		Ruins2_ButtonDoor = 331,
		RuinsSensor = 332,
		RuinsFenceSwitch = 333,
		RuinsLaserFence4x2 = 334,
		RuinsLaserFence6x2 = 335,
		RuinsLaserFence4x4 = 336,
		RuinsLaserFence6x4 = 337,
		RuinspoisonBlob = 338,
		RuinsPilarTrap = 339,
		PopupTrap_NoTech_ = 340,
		RuinsCrystal = 341,
		Monument = 342,
		RuinsRock1 = 345,
		RuinsRock2 = 346,
		RuinsRock3 = 347,
		RuinsRock4 = 348,
		RuinsRock5 = 349,
		RuinsRock6 = 350,
		RuinsRock7 = 351,
		Poison = 352,
		FixedBoxType_Ruins_ = 353,
		RandomBoxType_Ruins_ = 354,
		EnemyTypeBox_Yellow_ = 355,
		EnemyTypeBox_Blue_ = 356,
		EmptyTypeBox_Blue_ = 357,
		DestructableRock = 358,
		PopupTraps_techs_ = 359,
		FlyingWhiteBird = 368,
		Tower = 369,
		FloatingRocks = 370,
		FloatingSoul = 371,
		Butterfly = 372,
		LobbyGamemenu = 384,
		LobbyWarpObject = 385,
		Lobby1EventObject_DefaultTree_ = 386,
		UnknownItem_387_ = 387,
		UnknownItem_388_ = 388,
		UnknownItem_389_ = 389,
		LobbyEventObject_StaticPumpkin_ = 390,
		LobbyEventObject_3ChristmasWindows_ = 391,
		LobbyEventObject_RedandWhiteCurtain_ = 392,
		UnknownItem_393_ = 393,
		UnknownItem_394_ = 394,
		LobbyFishTank = 395,
		LobbyEventObject_Butterflies_ = 396,
		UnknownItem_400_ = 400,
		greywalllow = 401,
		SpaceshipDoor = 402,
		greywallhigh = 403,
		TempleNormalDoor = 416,
		_breakablewallwall_butunbreakable_ = 417,
		Brokencilinderandrubble = 418,
		_3brokenwallpiecesonfloor = 419,
		highbrickcilinder = 420,
		lyingcilinder = 421,
		brickconewithflattop = 422,
		breakabletemplewall = 423,
		TempleMapDetect = 424,
		smallbrownbrickrisingbridge = 425,
		longrisingbridge_withpinkhighedges_ = 426,
		_4switchtempledoor = 427,
		_4buttonspaceshipdoor = 448,
		itemboxcca = 512,
		Teleporter_Ep2_ = 513,
		CCADoor = 514,
		SpecialBoxCCA = 515,
		BigCCADoor = 516,
		BigCCADoorSwitch = 517,
		LittleRock = 518,
		Little3StoneWall = 519,
		Medium3stonewall = 520,
		SpiderPlant = 521,
		CCAAreaTeleporter = 522,
		UnknownItem_523_ = 523,
		WhiteBird = 524,
		OrangeBird = 525,
		Saw = 527,
		LaserDetect = 528,
		UnknownItem_529_ = 529,
		UnknownItem_530_ = 530,
		Seagull = 531,
		Fish = 544,
		SeabedDoor_withblueedges_ = 545,
		_SeabedDoor_alwaysopen_non_triggerable_ = 546,
		LittleCryotube = 547,
		WideGlassWall_breakable_ = 548,
		Bluefloatingrobot = 549,
		Redfloatingrobot = 550,
		Dolphin = 551,
		CaptureTrap = 552,
		VRlink = 553,
		UnknownItem_576_ = 576,
		WarpinBarbaRayRoom = 640,
		UnknownItem_672_ = 672,
		GeeNest = 688,
		LabComputerConsole = 689,
		LabComputerConsole_GreenScreen_ = 690,
		Chair_YelllowPillow = 691,
		orangewallwithholeinmiddle = 692,
		greywallwithholeinmiddle = 693,
		longtable = 694,
		GBAStation = 695,
		Talk_linktosupport_ = 696,
		insta_warp = 697,
		LabInvisibleObject = 698,
		LabGlasswindowDoor = 699,
		UnknownItem_700_ = 700,
		LabCelingWarp = 701,
		Ep4LightSource = 768,
		cacti = 769,
		BigBrownRock = 770,
		BreakableBrownRock = 771,
		UnknownItem_832_ = 832,
		UnknownItem_833_ = 833,
		PoisonPlant = 896,
		UnknownItem_897_ = 897,
		UnknownItem_898_ = 898,
		OozingDesertPlant = 899,
		UnknownItem_901_ = 901,
		bigblackrocks = 902,
		UnknownItem_903_ = 903,
		UnknownItem_904_ = 904,
		UnknownItem_905_ = 905,
		UnknownItem_906_ = 906,
		FallingRock = 907,
		DesertPlant_hascollision_ = 908,
		DesertFixedTypeBox_BreakableCrystals_ = 909,
		UnknownItem_910_ = 910,
		BeeHive = 911,
		UnknownItem_912_ = 912,
		Heat = 913,
		Topofsaintmillionegg = 960,
		UnknownItem_961_ = 961
	}
}