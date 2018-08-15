using Microsoft.Xna.Framework;
using Microsoft.Win32;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Terraria.Achievements;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Events;
using Terraria.GameContent.Liquid;
using Terraria.GameContent.Skies;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.States;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.Map;
using Terraria.Net;
using Terraria.ObjectData;
using Terraria.Social;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.UI.Gamepad;
using Terraria.Utilities;
using Terraria.World.Generation;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

using Terraria.ModLoader;

namespace Minigun.Items
{
	[AutoloadEquip(EquipType.Wings)]
    public class KinecticBoots : ModItem          
	{
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kinectic Boots");
			Tooltip.SetDefault("Hypersonic speed!"
			+"\nYou feel bad when you look at the boots' name"
			+"\nAllows to walk on a hot blocks, grants immunity to lava and 'On Fire'"
			+"\n+30% to all damage, +20% crit"
			+"\nProlongs invincibility after taking damage"
			+"\nSightly increases life regeneration"
			+"\n+200 Max Mana, allows to walk on water and lava"
			+"\nGrants Night Vision, but your eyes are now red forever"
			+"\n20% to not consume ammo"
			+"\nIncreased jump height"
			+"\nAllows flight and slow fall"
			+"\nGives ability to swim and infinite breathe"
			+"\n+30% melee speed"
			+"\nPhilosopher's stone effect and +100 max life"
			+"\nAll-Seeing Eye's effects"
			+"\nCan imitate death by pressing control Up and Down at the same time (W and S by deafult)");
		}
		public override void SetDefaults()    
		{                                 
			item.width = 22; 
			item.height = 34; 
			item.accessory = true;
			item.consumable = false;
			item.defense = 17;
			item.maxStack = 1;                                         
			item.value = 10000000;                        
			item.rare = 11;                                   
		}
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.DemonAltar);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.AddTile(TileID.Loom);
		recipe.AddIngredient(null, "CurseofNirvana", 1);
		recipe.AddIngredient(null, "CursedBlood", 5);
		recipe.AddIngredient(null, "StableFabric", 5);
		recipe.AddIngredient(null, "KLiquid", 15);
		recipe.AddIngredient(null, "AllSeeingEye", 1);
		recipe.AddIngredient(null, "SoulKeep", 1);
		recipe.AddIngredient(null, "BookofAccurancy", 1);
		recipe.AddIngredient(ItemID.FeralClaws, 1);
		recipe.AddIngredient(ItemID.NeptunesShell, 1);
		recipe.AddIngredient(ItemID.CharmofMyths, 1);
		recipe.AddIngredient(ItemID.FrostsparkBoots, 1);
		recipe.AddIngredient(ItemID.LavaWaders, 1);
		recipe.AddIngredient(ItemID.MagicQuiver, 1);
		recipe.AddRecipeGroup(" Vanilla Wings");
		recipe.SetResult(this);
		recipe.AddRecipe();

	}
	public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 15f;
			acceleration *= 2.5f;
		}
	
	public override void UpdateAccessory(Player player, bool hideVisual)
{
	player.magicDamage += 0.5f;
	player.lavaImmune = true;
	player.fireWalk = true;
	player.meleeDamage += 0.5f;
	player.rangedDamage += 0.5f;
	player.minionDamage += 0.5f;
	player.thrownDamage += 0.5f;
	player.lifeRegen += 19;
	player.longInvince = true;
	player.eyeColor = new Color(255f, 0f, 0f, 100f);
	player.statManaMax2 += 200;
	player.nightVision = true;
	player.name ="Fate Can't Be Changed Fate Can Be Changed Fate Can't Be Changed Fate Can Be Changed Fate Can't Be Changed Fate Can Be Changed Fate Can't Be Changed";
	player.respawnTimer = 0;
	player.meleeCrit += 20;
	player.rangedCrit += 20;
	player.magicCrit += 20;
	player.thrownCrit += 20;
	player.meleeSpeed += 0.30f;
	player.noFallDmg = true;
	player.jumpBoost = true;
	player.wingTimeMax = 400;
	player.accFlipper = true;
	player.ammoCost80 = true;
	player.pStone = true;
	player.statLifeMax2 += 100;
	player.findTreasure = true;
	player.detectCreature = true;
	player.dangerSense = true;
	player.onFire = false;
	player.accMerman = true;
	player.waterWalk = true;
	if (player.controlUp)
	{
		if (player.controlDown)
		{
		player.dead = true;
		}	
	}
	if (player.controlLeft)
	{
		if (player.velocity.X > -7) player.velocity.X -= 0.31f;
		if (player.velocity.X < -7 && player.velocity.X > -14)
		{
			player.velocity.X -= 0.29f;
		}
	}
	if (player.controlRight)
	{
		if (player.velocity.X < 7) player.velocity.X += 0.31f;
		if (player.velocity.X > 7 && player.velocity.X < 14)
		{
			player.velocity.X += 0.31f;
		}
	}
	if (player.velocity.X > 6 || player.velocity.X < -6)
	{
		Color color = new Color();
		int dust = Dust.NewDust(new Vector2((float) player.position.X, (float) player.position.Y), player.width, player.height, 235, Main.rand.Next(-1,1), Main.rand.Next(-1,1), 0, color, 2.0f);
		Main.dust[dust].noGravity = true;
	}
	
}
  }

}