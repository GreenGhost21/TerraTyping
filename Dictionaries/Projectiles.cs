﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraTyping
{
    public class Projectiles
    {
        public static Dictionary<int, Element> Type = new Dictionary<int, Element>
        {
            {ProjectileID.Tombstone , Element.ground },
            {ProjectileID.GraveMarker , Element.grass },
            {ProjectileID.CrossGraveMarker , Element.grass },
            {ProjectileID.Headstone , Element.ground },
            {ProjectileID.Gravestone , Element.ground },
            {ProjectileID.Obelisk , Element.rock },
            {ProjectileID.RichGravestone1 , Element.steel },
            {ProjectileID.RichGravestone2 , Element.steel },
            {ProjectileID.RichGravestone3 , Element.steel },
            {ProjectileID.RichGravestone4 , Element.steel },
            {ProjectileID.RichGravestone5 , Element.steel },

            {ProjectileID.WoodenArrowFriendly, Element.normal },
            {ProjectileID.FireArrow, Element.fire },
            {ProjectileID.Shuriken, Element.fighting },
            {ProjectileID.UnholyArrow, Element.dark },
            {ProjectileID.JestersArrow, Element.flying },
            {ProjectileID.EnchantedBoomerang, Element.electric },
            {ProjectileID.VilethornBase, Element.dark },
            {ProjectileID.VilethornTip, Element.dark },
            {ProjectileID.Starfury, Element.flying },
            //{ProjectileID.PurificationPowder, Items.Type[ItemID.PurificationPowder] },
            //{ProjectileID.VilePowder, Items.Type[ItemID.VilePowder] },
            {ProjectileID.FallingStar, Element.flying },
            //{ProjectileID.Hook, Items.Type[ItemID.GrapplingHook] },
            {ProjectileID.Bullet, Element.normal },
            {ProjectileID.BallofFire, Element.fire },
            {ProjectileID.MagicMissile, Element.psychic },
            //{ProjectileID.DirtBall, Items.Type[ItemID.DirtRod] },
            //{ProjectileID.ShadowOrb, Items.Type[ItemID.ShadowOrb] },
            {ProjectileID.Flamarang, Element.fire },
            {ProjectileID.GreenLaser, Element.electric },
            {ProjectileID.Bone, Element.bone },
            {ProjectileID.WaterStream, Element.water },
            {ProjectileID.Harpoon, Element.normal },
            {ProjectileID.SpikyBall, Element.normal },
            {ProjectileID.BallOHurt, Element.dark },
            {ProjectileID.BlueMoon, Element.dark },
            {ProjectileID.WaterBolt, Element.water },
            {ProjectileID.Bomb, Element.normal },
            {ProjectileID.Dynamite, Element.normal },
            {ProjectileID.Grenade, Element.normal },
            {ProjectileID.SandBallFalling, Element.ground },
            //{ProjectileID.IvyWhip, Items.Type[ItemID.IvyWhip] },
            {ProjectileID.ThornChakram, Element.grass },
            {ProjectileID.Flamelash, Element.fire },
            {ProjectileID.Sunfury, Element.fire },
            {ProjectileID.MeteorShot, Element.rock },
            {ProjectileID.StickyBomb, Element.normal },
            {ProjectileID.HarpyFeather, Element.flying }, // attack
            {ProjectileID.MudBall, Element.ground },
            {ProjectileID.AshBallFalling, Element.ground },
            {ProjectileID.HellfireArrow, Element.fire },
            {ProjectileID.SandBallGun, Element.ground },
            //{ProjectileID.Tombstone, Items.Type[ItemID.Tombstone] },
            {ProjectileID.DemonSickle, Element.dark }, // demon
            {ProjectileID.DemonScythe, Element.dark },
            {ProjectileID.DarkLance, Element.dark },
            {ProjectileID.Trident, Element.water },
            {ProjectileID.ThrowingKnife, Element.fighting },
            {ProjectileID.Spear, Element.normal },
            //{ProjectileID.Glowstick, Items.Type[ItemID.Glowstick] },
            {ProjectileID.Seed, Element.grass },
            {ProjectileID.WoodenBoomerang, Element.normal },
            //{ProjectileID.StickyGlowstick, Items.Type[ItemID.StickyGlowstick] },
            {ProjectileID.PoisonedKnife, Element.poison },
            {ProjectileID.EbonsandBallFalling, Element.ground },
            {ProjectileID.CobaltChainsaw, Element.steel },
            {ProjectileID.MythrilChainsaw, Element.dragon },
            {ProjectileID.CobaltDrill, Element.steel },
            {ProjectileID.MythrilDrill, Element.dragon },
            {ProjectileID.AdamantiteChainsaw, Element.dragon },
            {ProjectileID.AdamantiteDrill, Element.dragon },
            {ProjectileID.TheDaoofPow, Element.psychic },
            {ProjectileID.MythrilHalberd, Element.dragon },
            {ProjectileID.EbonsandBallGun, Element.ground },
            {ProjectileID.AdamantiteGlaive, Element.dragon },
            {ProjectileID.PearlSandBallFalling, Element.ground },
            {ProjectileID.PearlSandBallGun, Element.ground },
            {ProjectileID.HolyWater, Element.water },
            {ProjectileID.UnholyWater, Element.dark },
            {ProjectileID.SiltBall, Element.ground },
            //{ProjectileID.BlueFairy, Items.Type[ItemID.FairyBell] },
            //{ProjectileID.DualHookBlue, Items.Type[ItemID.DualHook] },
            //{ProjectileID.DualHookRed, Items.Type[ItemID.DualHook] },
            {ProjectileID.HappyBomb, Element.normal },
            {ProjectileID.QuarterNote, Element.normal },
            {ProjectileID.EighthNote, Element.normal },
            {ProjectileID.TiedEighthNote, Element.normal },
            {ProjectileID.RainbowRodBullet, Element.fairy },
            {ProjectileID.IceBlock, Element.ice },
            {ProjectileID.WoodenArrowHostile, Element.normal }, // goblin archer
            {ProjectileID.FlamingArrow, Element.fire }, // skeleton archer
            {ProjectileID.EyeLaser, Element.electric }, // retinazer
            {ProjectileID.PinkLaser, Element.psychic }, // gastropod
            {ProjectileID.Flames, Element.fire },

            //{ProjectileID.PinkFairy, Items.Type[ItemID.FairyBell] },
            //{ProjectileID.GreenFairy, Items.Type[ItemID.FairyBell] },
            {ProjectileID.PurpleLaser, Element.electric },
            {ProjectileID.CrystalBullet, Element.fairy },
            {ProjectileID.CrystalShard, Element.fairy },
            {ProjectileID.HolyArrow, Element.fairy },
            {ProjectileID.HallowStar, Element.flying }, // Holy Arrows, Bee Cloak, Star Cloak, Star Veil
            {ProjectileID.MagicDagger, Element.fighting },
            {ProjectileID.CrystalStorm, Element.fairy },
            {ProjectileID.CursedFlameFriendly, Element.ghost },
            {ProjectileID.CursedFlameHostile, Element.ghost }, // spazmatism
            {ProjectileID.CobaltNaginata , Element.steel },
            {ProjectileID.PoisonDart , Element.poison },
            {ProjectileID.Boulder , Element.rock },
            {ProjectileID.DeathLaser , Element.electric },
            {ProjectileID.EyeFire , Element.ghost }, // spaz
            {ProjectileID.BombSkeletronPrime , Element.normal },
            {ProjectileID.CursedArrow , Element.ghost },
            {ProjectileID.CursedBullet , Element.ghost },
            {ProjectileID.Gungnir , Element.fighting },
            {ProjectileID.LightDisc , Element.electric },
            {ProjectileID.Hamdrax , Element.fighting },
            {ProjectileID.Explosives , Element.normal },
            {ProjectileID.SnowBallHostile , Element.ice },
            {ProjectileID.BulletSnowman , Element.normal },
            {ProjectileID.IceBoomerang , Element.ice },
            {ProjectileID.UnholyTridentFriendly , Element.dark },
            {ProjectileID.UnholyTridentHostile , Element.dark },
            {ProjectileID.SwordBeam , Element.electric },
            {ProjectileID.BoneArrow , Element.bone },
            {ProjectileID.IceBolt , Element.ice },
            {ProjectileID.FrostBoltSword , Element.ice },
            {ProjectileID.FrostArrow , Element.ice },
            {ProjectileID.AmethystBolt , Element.psychic },
            {ProjectileID.TopazBolt , Element.psychic },
            {ProjectileID.SapphireBolt , Element.psychic },
            {ProjectileID.EmeraldBolt , Element.psychic },
            {ProjectileID.RubyBolt , Element.psychic },
            {ProjectileID.DiamondBolt , Element.psychic },
            {ProjectileID.FrostBlastHostile , Element.ice },
            {ProjectileID.RuneBlast , Element.fire },
            {ProjectileID.MushroomSpear , Element.grass },
            {ProjectileID.Mushroom , Element.grass },
            {ProjectileID.TerraBeam , Element.normal },
            {ProjectileID.GrenadeI , Element.normal },
            {ProjectileID.RocketI, Element.normal },
            {ProjectileID.ProximityMineI , Element.normal },
            {ProjectileID.GrenadeII , Element.normal },
            {ProjectileID.RocketII, Element.normal },
            {ProjectileID.ProximityMineII , Element.normal },
            {ProjectileID.GrenadeIII , Element.normal },
            {ProjectileID.RocketIII , Element.normal },
            {ProjectileID.ProximityMineIII , Element.normal },
            {ProjectileID.GrenadeIV , Element.normal },
            {ProjectileID.RocketIV , Element.normal },
            {ProjectileID.ProximityMineIV , Element.normal },

            {ProjectileID.NettleBurstRight , Element.grass },
            {ProjectileID.NettleBurstLeft , Element.grass },
            {ProjectileID.NettleBurstEnd , Element.grass },
            {ProjectileID.TheRottedFork , Element.blood },
            {ProjectileID.TheMeatball , Element.blood },
            {ProjectileID.LightBeam , Element.fairy },
            {ProjectileID.NightBeam , Element.dark },
            {ProjectileID.CopperCoin , Element.normal },
            {ProjectileID.SilverCoin , Element.normal },
            {ProjectileID.GoldCoin , Element.normal },
            {ProjectileID.PlatinumCoin , Element.normal },
            {ProjectileID.CannonballFriendly , Element.steel },
            {ProjectileID.Flare , Element.fire },
            {ProjectileID.Landmine , Element.normal },
            {ProjectileID.SnowBallFriendly , Element.ice },
            {ProjectileID.RocketFireworkRed , Element.normal },
            {ProjectileID.RocketFireworkGreen , Element.normal },
            {ProjectileID.RocketFireworkBlue , Element.normal },
            {ProjectileID.RocketFireworkYellow , Element.normal },
            {ProjectileID.FrostburnArrow , Element.ice },

            {ProjectileID.EnchantedBeam , Element.electric },
            {ProjectileID.IceSpike , Element.ice },
            {ProjectileID.JungleSpike , Element.poison },
            {ProjectileID.IcewaterSpit , Element.ice },
            {ProjectileID.SlushBall , Element.ground },
            {ProjectileID.BulletDeadeye , Element.normal },
            {ProjectileID.Bee , Element.bug },
            {ProjectileID.PossessedHatchet , Element.rock },
            {ProjectileID.Beenade , Element.normal },
            {ProjectileID.SpikyBallTrap , Element.rock },
            {ProjectileID.SpearTrap , Element.normal },
            {ProjectileID.FlamethrowerTrap , Element.fire },
            {ProjectileID.FlamesTrap , Element.fire },
            {ProjectileID.Wasp , Element.bug },
            {ProjectileID.MechanicalPiranha , Element.water },
            {ProjectileID.PygmySpear , Element.grass },
            {ProjectileID.Leaf , Element.grass },

            {ProjectileID.ChlorophyteBullet , Element.grass },
            {ProjectileID.PalladiumPike , Element.fighting },
            {ProjectileID.PalladiumDrill , Element.fighting },
            {ProjectileID.PalladiumChainsaw , Element.fighting },
            {ProjectileID.OrichalcumHalberd , Element.fairy },
            {ProjectileID.OrichalcumDrill , Element.fairy },
            {ProjectileID.OrichalcumChainsaw , Element.fairy },
            {ProjectileID.TitaniumTrident , Element.steel },
            {ProjectileID.TitaniumDrill , Element.steel },
            {ProjectileID.TitaniumChainsaw , Element.steel },
            {ProjectileID.FlowerPetal , Element.fairy },
            {ProjectileID.ChlorophytePartisan , Element.grass },
            {ProjectileID.ChlorophyteDrill , Element.grass },
            {ProjectileID.ChlorophyteChainsaw , Element.grass },
            {ProjectileID.ChlorophyteArrow , Element.grass },
            {ProjectileID.CrystalLeafShot , Element.grass },
            {ProjectileID.SporeCloud , Element.grass },
            {ProjectileID.ChlorophyteOrb , Element.grass },
            {ProjectileID.RainFriendly , Element.water },
            {ProjectileID.CannonballHostile , Element.steel },
            {ProjectileID.CrimsandBallFalling , Element.ground },
            {ProjectileID.BulletHighVelocity , Element.fighting },
            {ProjectileID.BloodRain , Element.blood },
            {ProjectileID.Stynger , Element.fighting },

            {ProjectileID.FlowerPow , Element.grass },
            {ProjectileID.FlowerPowPetal , Element.grass },
            {ProjectileID.StyngerShrapnel , Element.rock },
            {ProjectileID.RainbowBack , Element.fairy },
            {ProjectileID.RainbowFront , Element.fairy },
            {ProjectileID.ChlorophyteJackhammer , Element.grass },
            {ProjectileID.BallofFrost , Element.ice },
            {ProjectileID.MagnetSphereBall , Element.electric },
            {ProjectileID.MagnetSphereBolt , Element. electric},
            {ProjectileID.FrostBeam , Element.ice },
            {ProjectileID.Fireball , Element.fire },
            {ProjectileID.EyeBeam , Element.electric },
            {ProjectileID.HeatRay , Element.fire },
            {ProjectileID.BoulderStaffOfEarth , Element.ground },
            {ProjectileID.GolemFist , Element.fighting },
            {ProjectileID.IceSickle , Element.ice },
            {ProjectileID.RainNimbus , Element.water },
            {ProjectileID.PoisonFang , Element.poison },
            {ProjectileID.PoisonDartBlowgun , Element.poison },
            {ProjectileID.Skull , Element.bone },
            {ProjectileID.BoxingGlove , Element.fighting },
            {ProjectileID.Bananarang , Element.normal },
            {ProjectileID.ChainKnife , Element.steel },
            {ProjectileID.DeathSickle , Element.dark },
            {ProjectileID.SeedPlantera , Element.grass },
            {ProjectileID.PoisonSeedPlantera , Element.poison },
            {ProjectileID.ThornBall , Element.grass },
            {ProjectileID.IchorArrow , Element.blood },
            {ProjectileID.IchorBullet , Element.blood },
            {ProjectileID.GoldenShowerFriendly , Element.blood },
            {ProjectileID.ExplosiveBunny , Element.normal },
            {ProjectileID.VenomArrow , Element.poison },
            {ProjectileID.VenomBullet , Element.poison },

            {ProjectileID.PartyBullet , Element.fairy },
            {ProjectileID.NanoBullet , Element.psychic },
            {ProjectileID.ExplosiveBullet , Element.normal },
            {ProjectileID.GoldenBullet , Element.steel },
            {ProjectileID.GoldenShowerHostile , Element.blood },
            {ProjectileID.ShadowBeamHostile , Element.dark },
            {ProjectileID.InfernoHostileBolt , Element.fire },
            {ProjectileID.InfernoHostileBlast , Element.fire },
            {ProjectileID.LostSoulHostile , Element.ghost },
            {ProjectileID.ShadowBeamFriendly , Element.dark },
            {ProjectileID.InfernoFriendlyBolt , Element.fire },
            {ProjectileID.InfernoFriendlyBlast , Element.fire },
            {ProjectileID.LostSoulFriendly , Element.ghost },
            {ProjectileID.PaladinsHammerHostile , Element.steel },
            {ProjectileID.PaladinsHammerFriendly , Element.steel },
            {ProjectileID.SniperBullet , Element.fighting },
            {ProjectileID.RocketSkeleton , Element.normal },
            {ProjectileID.VampireKnife , Element.blood },
            {ProjectileID.VampireHeal , Element.blood },
            {ProjectileID.EatersBite , Element.dark },
            {ProjectileID.TinyEater , Element.dark },
            {ProjectileID.FrostHydra , Element.ice },
            {ProjectileID.FrostBlastFriendly , Element.ice },
            {ProjectileID.BlueFlare , Element.fire },
            {ProjectileID.CandyCorn , Element.normal },
            {ProjectileID.Bat , Element.flying },
            {ProjectileID.Raven , Element.flying },
            {ProjectileID.RottenEgg , Element.poison },
            {ProjectileID.BloodyMachete , Element.normal },
            {ProjectileID.FlamingJack , Element.ghost },
            {ProjectileID.Stake , Element.normal },
            {ProjectileID.FlamingWood , Element.fire },

            {ProjectileID.GreekFire1 , Element.fire },
            {ProjectileID.GreekFire2 , Element.fire },
            {ProjectileID.GreekFire3 , Element.fire },
            {ProjectileID.FlamingScythe , Element.fire },
            {ProjectileID.StarAnise , Element.normal },
            {ProjectileID.FruitcakeChakram , Element.normal },
            {ProjectileID.OrnamentFriendly , Element.normal },
            {ProjectileID.PineNeedleFriendly , Element.grass },
            {ProjectileID.RocketSnowmanI , Element.ice },
            {ProjectileID.RocketSnowmanII , Element.ice },
            {ProjectileID.RocketSnowmanIII , Element.ice },
            {ProjectileID.RocketSnowmanIV , Element.ice },
            {ProjectileID.NorthPoleWeapon , Element.ice },
            {ProjectileID.NorthPoleSpear , Element.ice },
            {ProjectileID.NorthPoleSnowflake , Element.ice },
            {ProjectileID.PineNeedleHostile , Element.grass },
            {ProjectileID.OrnamentHostile , Element.normal },
            {ProjectileID.OrnamentHostileShrapnel , Element.normal },
            {ProjectileID.FrostWave , Element.ice },
            {ProjectileID.FrostShard , Element.ice },
            {ProjectileID.Missile , Element.normal },
            {ProjectileID.Present , Element.normal },
            {ProjectileID.Spike , Element.steel },
            {ProjectileID.CrimsandBallGun , Element.ground },
            {ProjectileID.VenomFang , Element.poison },

            {ProjectileID.PulseBolt , Element.normal },
            {ProjectileID.FrostBoltStaff , Element.ice },
            {ProjectileID.ObsidianSwordfish , Element.rock },
            {ProjectileID.Swordfish , Element.water },
            {ProjectileID.SawtoothShark , Element.water },
            {ProjectileID.Hornet , Element.bug },

            {ProjectileID.HornetStinger , Element.poison },
            {ProjectileID.FlyingImp , Element.fire },
            {ProjectileID.ImpFireball , Element.fire },
            {ProjectileID.SpiderHiver , Element.bug },
            {ProjectileID.SpiderEgg , Element.bug },

            {ProjectileID.BabySpider , Element.bug },
            {ProjectileID.Anchor , Element.water },
            {ProjectileID.Sharknado , Element.water },
            {ProjectileID.SharknadoBolt , Element.water },

            {ProjectileID.Cthulunado , Element.water },
            {ProjectileID.Spazmamini, Element.steel },
            {ProjectileID.MiniRetinaLaser , Element.electric },
            {ProjectileID.VenomSpider , Element.poison },
            {ProjectileID.JumperSpider , Element.bug },
            {ProjectileID.DangerousSpider , Element.poison },
            {ProjectileID.OneEyedPirate , Element.water },
            {ProjectileID.SoulscourgePirate , Element.water },
            {ProjectileID.PirateCaptain , Element.water },
            {ProjectileID.StickyGrenade , Element.normal },
            {ProjectileID.MolotovCocktail , Element.water },

            {ProjectileID.MolotovFire , Element.fire },
            {ProjectileID.MolotovFire2 , Element.fire },
            {ProjectileID.MolotovFire3 , Element.fire },
            {ProjectileID.Flairon , Element.dragon },
            {ProjectileID.FlaironBubble , Element.water },
            {ProjectileID.Typhoon , Element.water },
            {ProjectileID.Bubble , Element.water },
            {ProjectileID.Meteor1 , Element.rock },
            {ProjectileID.Meteor2 , Element.rock },
            {ProjectileID.Meteor3 , Element.rock },
            {ProjectileID.VortexChainsaw , Element.electric },
            {ProjectileID.VortexDrill , Element.electric },
            {ProjectileID.NebulaChainsaw , Element.psychic },

            {ProjectileID.NebulaDrill , Element.psychic },
            {ProjectileID.SolarFlareChainsaw , Element.fire },
            {ProjectileID.SolarFlareDrill , Element.fire },
            {ProjectileID.UFOLaser , Element.electric },
            {ProjectileID.ScutlixLaserFriendly , Element.electric },
            {ProjectileID.MartianTurretBolt , Element.electric },
            {ProjectileID.BrainScramblerBolt , Element.psychic },
            {ProjectileID.GigaZapperSpear , Element.electric },
            {ProjectileID.RayGunnerLaser , Element.electric },
            {ProjectileID.LaserMachinegun , Element.electric },
            {ProjectileID.LaserMachinegunLaser , Element.electric },
            {ProjectileID.ScutlixLaserCrosshair , Element.electric },
            {ProjectileID.ElectrosphereMissile , Element.electric },
            {ProjectileID.Electrosphere , Element.electric },
            {ProjectileID.LaserDrill , Element.electric },
            {ProjectileID.SaucerDeathray , Element.electric },
            {ProjectileID.SaucerMissile , Element.normal },
            {ProjectileID.SaucerLaser , Element.electric },

            {ProjectileID.SaucerScrap , Element.fire },
            {ProjectileID.InfluxWaver , Element.electric },

            {ProjectileID.PhantasmalEye , Element.ghost }, // moonlord
            {ProjectileID.DrillMountCrosshair , Element.normal },
            {ProjectileID.PhantasmalSphere , Element.psychic }, // moonlord
            {ProjectileID.PhantasmalDeathray , Element.electric }, // moonlord

            {ProjectileID.MoonLeech , Element.dark }, // moonlord
            {ProjectileID.ChargedBlasterOrb , Element.electric },
            {ProjectileID.ChargedBlasterCannon , Element.electric },

            {ProjectileID.PhantasmalBolt , Element.normal }, // moonlord
            {ProjectileID.CultistBossIceMist , Element.ice },
            {ProjectileID.CultistBossLightningOrb , Element.electric },

            {ProjectileID.CultistBossLightningOrbArc , Element.electric },
            {ProjectileID.CultistBossFireBall , Element.fire },
            {ProjectileID.CultistBossFireBallClone , Element.dark },

            {ProjectileID.BeeArrow , Element.bug },
            {ProjectileID.StickyDynamite , Element.normal },
            {ProjectileID.WebSpit , Element.bug },

            {ProjectileID.BoneArrowFromMerchant , Element.bone },
            {ProjectileID.SoulDrain , Element.blood },
            {ProjectileID.CrystalDart , Element.fairy },
            {ProjectileID.CursedDart , Element.ghost },
            {ProjectileID.IchorDart , Element.blood },
            {ProjectileID.ChainGuillotine , Element.steel },
            {ProjectileID.SeedlerNut , Element.grass },
            {ProjectileID.SeedlerThorn , Element.grass },
            {ProjectileID.Hellwing , Element.fire },
            {ProjectileID.FlyingKnife , Element.flying },
            {ProjectileID.CrystalVileShardHead , Element.fairy },
            {ProjectileID.CrystalVileShardShaft , Element.fairy },

            {ProjectileID.ShadowFlameArrow , Element.dark },
            {ProjectileID.ShadowFlame , Element.ghost },
            {ProjectileID.ShadowFlameKnife , Element.dark },
            {ProjectileID.Nail , Element.steel },
            {ProjectileID.DrManFlyFlask , Element.poison },
            {ProjectileID.Meowmere , Element.fairy },
            {ProjectileID.StarWrath , Element.dragon },
            {ProjectileID.Spark , Element.fire },
            {ProjectileID.JavelinFriendly , Element.fighting },
            {ProjectileID.JavelinHostile , Element.fighting },
            {ProjectileID.ButchersChainsaw , Element.normal },
            {ProjectileID.ToxicFlask , Element.poison },
            {ProjectileID.ToxicCloud , Element.poison },
            {ProjectileID.ToxicCloud2 , Element.poison },
            {ProjectileID.ToxicCloud3 , Element.poison },
            {ProjectileID.NailFriendly , Element.steel },
            {ProjectileID.BouncyGlowstick , Element.normal },
            {ProjectileID.BouncyBomb , Element.normal },
            {ProjectileID.BouncyGrenade , Element.normal },
            {ProjectileID.BombFish , Element.water },
            {ProjectileID.FrostDaggerfish , Element.ice },
            {ProjectileID.CrystalPulse , Element.fairy },
            {ProjectileID.CrystalPulse2 , Element.fairy },
            {ProjectileID.ToxicBubble , Element.poison },
            {ProjectileID.IchorSplash , Element.blood },
            {ProjectileID.CultistBossParticle , Element.electric },
            {ProjectileID.BoneGloveProj , Element.bone },
            {ProjectileID.DeadlySphere , Element.steel },
            {ProjectileID.Code1 , Element.normal },
            {ProjectileID.MedusaHead , Element.rock },
            {ProjectileID.MedusaHeadRay , Element.rock },
            {ProjectileID.StardustSoldierLaser , Element.electric },
            {ProjectileID.Twinkle , Element.dragon },
            {ProjectileID.StardustJellyfishSmall , Element.dragon },
            {ProjectileID.StardustTowerMark , Element.electric },
            {ProjectileID.WoodYoyo , Element.normal },
            {ProjectileID.CorruptYoyo , Element.dark },

            {ProjectileID.CrimsonYoyo , Element.blood },
            {ProjectileID.JungleYoyo , Element.grass },
            {ProjectileID.Cascade , Element.fire },
            {ProjectileID.Chik , Element.fairy },
            {ProjectileID.Code2 , Element.normal },
            {ProjectileID.Rally , Element.rock },
            {ProjectileID.Yelets , Element.grass },
            {ProjectileID.RedsYoyo , Element.normal }, // fix
            {ProjectileID.ValkyrieYoyo , Element.normal }, // fix
            {ProjectileID.Amarok , Element.ice },
            {ProjectileID.HelFire , Element.fire },
            {ProjectileID.Kraken , Element.dragon },
            {ProjectileID.TheEyeOfCthulhu , Element.flying },
            {ProjectileID.BlackCounterweight , Element.normal },
            {ProjectileID.BlueCounterweight , Element.normal },
            {ProjectileID.GreenCounterweight , Element.normal },
            {ProjectileID.PurpleCounterweight , Element.normal },
            {ProjectileID.RedCounterweight , Element.normal },
            {ProjectileID.YellowCounterweight , Element.normal },
            {ProjectileID.FormatC , Element.normal },
            {ProjectileID.Gradient , Element.normal },
            {ProjectileID.Valor , Element.rock },
            {ProjectileID.BrainOfConfusion , Element.psychic },
            {ProjectileID.GiantBee , Element.bug },
            {ProjectileID.SporeTrap , Element.grass },
            {ProjectileID.SporeTrap2 , Element.grass },
            {ProjectileID.SporeGas , Element.grass },
            {ProjectileID.SporeGas2 , Element.grass },
            {ProjectileID.SporeGas3 , Element.grass },
            {ProjectileID.SalamanderSpit , Element.poison },
            {ProjectileID.NebulaBolt , Element.psychic },
            {ProjectileID.NebulaEye , Element.psychic },
            {ProjectileID.NebulaSphere , Element.psychic },
            {ProjectileID.NebulaLaser , Element.psychic },
            {ProjectileID.VortexLaser , Element.electric },
            {ProjectileID.VortexVortexLightning , Element.electric },
            {ProjectileID.VortexVortexPortal , Element.electric },
            {ProjectileID.VortexLightning , Element.electric },
            {ProjectileID.VortexAcid , Element.electric },
            {ProjectileID.MechanicWrench , Element.normal },
            {ProjectileID.NurseSyringeHurt, Element.poison },
            {ProjectileID.NurseSyringeHeal , Element.poison },
            {ProjectileID.ClothiersCurse , Element.ghost },
            {ProjectileID.DryadsWardCircle , Element.grass },
            {ProjectileID.PainterPaintball , Element.normal },
            {ProjectileID.PartyGirlGrenade , Element.fairy },
            {ProjectileID.SantaBombs , Element.normal },
            {ProjectileID.TruffleSpore , Element.grass },
            {ProjectileID.MinecartMechLaser , Element.electric },
            {ProjectileID.MartianWalkerLaser , Element.electric },
            {ProjectileID.AncientDoomProjectile , Element.dark },
            {ProjectileID.Arkhalis , Element.dark },
            {ProjectileID.DesertDjinnCurse , Element.ghost },

            {ProjectileID.AmberBolt , Element.psychic },
            {ProjectileID.BoneJavelin , Element.bone },
            {ProjectileID.BoneDagger , Element.bone },
            {ProjectileID.Terrarian , Element.normal },
            {ProjectileID.TerrarianBeam , Element.normal },
            {ProjectileID.SpikedSlimeSpike , Element.water },
            {ProjectileID.ScutlixLaser , Element.electric },
            {ProjectileID.SolarFlareRay , Element.fire },
            {ProjectileID.SolarCounter , Element.fire },
            {ProjectileID.StardustDrill , Element.dragon },
            {ProjectileID.StardustChainsaw , Element.dragon },
            {ProjectileID.SolarWhipSword , Element.fire },
            {ProjectileID.SolarWhipSwordExplosion , Element.fire },
            {ProjectileID.StardustCellMinion , Element.dragon },
            {ProjectileID.StardustCellMinionShot , Element.dragon },
            {ProjectileID.VortexBeater , Element.electric },
            {ProjectileID.VortexBeaterRocket , Element.electric },
            {ProjectileID.NebulaArcanum , Element.psychic },
            {ProjectileID.NebulaArcanumSubshot , Element.psychic },
            {ProjectileID.NebulaArcanumExplosionShot , Element.psychic },
            {ProjectileID.NebulaArcanumExplosionShotShard , Element.psychic },
            {ProjectileID.BloodWater , Element.blood },
            {ProjectileID.StardustGuardian , Element.dragon },
            {ProjectileID.StardustGuardianExplosion , Element.dragon },
            {ProjectileID.StardustDragon1 , Element.dragon },
            {ProjectileID.StardustDragon2 , Element.dragon },
            {ProjectileID.StardustDragon3 , Element.dragon },
            {ProjectileID.StardustDragon4 , Element.dragon },
            {ProjectileID.TowerDamageBolt , Element.dragon },
            {ProjectileID.Phantasm , Element.electric },
            {ProjectileID.PhantasmArrow , Element.electric },
            {ProjectileID.LastPrismLaser , Element.psychic },
            {ProjectileID.LastPrism , Element.psychic },
            {ProjectileID.NebulaBlaze1 , Element.psychic },
            {ProjectileID.NebulaBlaze2 , Element.psychic },
            {ProjectileID.Daybreak , Element.psychic },
            {ProjectileID.BouncyDynamite , Element.normal },
            {ProjectileID.MoonlordBullet , Element.electric },
            {ProjectileID.MoonlordArrow , Element.electric },
            {ProjectileID.MoonlordArrowTrail , Element.electric },
            {ProjectileID.MoonlordTurret , Element.electric },
            {ProjectileID.MoonlordTurretLaser , Element.electric },
            {ProjectileID.RainbowCrystal , Element.fairy },
            {ProjectileID.RainbowCrystalExplosion , Element.fairy },
            {ProjectileID.LunarFlare , Element.dragon },
            {ProjectileID.GeyserTrap , Element.fire },
            {ProjectileID.BeeHive , Element.bug },
            {ProjectileID.SandnadoFriendly , Element.ground },
            {ProjectileID.SandnadoHostile , Element.ground },
            {ProjectileID.SandnadoHostileMark , Element.ground },
            {ProjectileID.SpiritFlame , Element.ghost },
            {ProjectileID.SkyFracture , Element.flying },
            {ProjectileID.BlackBolt , Element.dark },
            {ProjectileID.DD2JavelinHostile , Element.normal },

            {ProjectileID.DD2FlameBurstTowerT1Shot , Element.fire },
            {ProjectileID.DD2FlameBurstTowerT2Shot , Element.fire },
            {ProjectileID.DD2FlameBurstTowerT3Shot , Element.fire },
            {ProjectileID.Ale , Element.fighting },
            {ProjectileID.DD2OgreStomp , Element.normal },
            {ProjectileID.DD2DrakinShot , Element.dragon },
            {ProjectileID.DD2DarkMageRaise , Element.dark },
            {ProjectileID.DD2DarkMageHeal , Element.dark },
            {ProjectileID.DD2DarkMageBolt , Element.dark },
            {ProjectileID.DD2OgreSpit , Element.normal },
            {ProjectileID.DD2BallistraProj , Element.fighting },
            {ProjectileID.DD2GoblinBomb , Element.normal },
            {ProjectileID.DD2LightningBugZap , Element.electric },
            {ProjectileID.DD2OgreSmash , Element.normal },
            {ProjectileID.DD2SquireSonicBoom , Element.flying },
            {ProjectileID.DD2JavelinHostileT3 , Element.normal },
            {ProjectileID.DD2BetsyFireball , Element.fire },
            {ProjectileID.DD2BetsyFlameBreath , Element.fire },
            {ProjectileID.DD2LightningAuraT1 , Element.electric },
            {ProjectileID.DD2LightningAuraT2 , Element.electric },
            {ProjectileID.DD2LightningAuraT3 , Element.electric },
            {ProjectileID.DD2ExplosiveTrapT1Explosion , Element.normal },
            {ProjectileID.DD2ExplosiveTrapT2Explosion , Element.normal },
            {ProjectileID.DD2ExplosiveTrapT3Explosion , Element.normal },
            {ProjectileID.MonkStaffT1 , Element.fighting },
            {ProjectileID.MonkStaffT1Explosion , Element.fighting },
            {ProjectileID.MonkStaffT2 , Element.dragon },
            {ProjectileID.MonkStaffT2Ghast , Element.dragon },
            {ProjectileID.DD2ApprenticeStorm , Element.psychic },
            {ProjectileID.DD2PhoenixBow , Element.fire },
            {ProjectileID.DD2PhoenixBowShot, Element.fire },
            {ProjectileID.MonkStaffT3 , Element.dragon },
            {ProjectileID.MonkStaffT3_Alt , Element.dragon },
            {ProjectileID.MonkStaffT3_AltShot , Element.dragon },
            {ProjectileID.DD2BetsyArrow , Element.dragon },
            {ProjectileID.ApprenticeStaffT3Shot , Element.dragon },
            {ProjectileID.BookStaffShot , Element.psychic }
        };
    }
}
