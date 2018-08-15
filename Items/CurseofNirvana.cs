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
    public class CurseofNirvana : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Curse of Nirvana");
			Tooltip.SetDefault("The most powerful curse"
			+"\nAllows to walk on a hot blocks, grants immunity to lava"
			+"\n+30% to all damage"
			+"\nProlongs invincibility after taking damage"
			+"\nIncreases life regeneration"
			+"\n+200 Max Mana"
			+"\nGrants Night Vision, but your eyes are now red forever"
			+"\nDeath isn't an escape now");
		}
		public override void SetDefaults()    
		{                                 
			item.width = 22; 
			item.height = 34; 
			item.accessory = true;
			item.consumable = false;
			item.defense = 10;
			item.maxStack = 1;                                         
			item.value = 10000000;                        
			item.rare = 10;                                   
		}
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.DemonAltar);
		recipe.AddIngredient(null, "BurntAnkh", 1);
		recipe.AddIngredient(null, "CursedBlood", 5);
		recipe.AddIngredient(null, "KLiquid", 5);
		recipe.AddIngredient(null, "PrimalMana", 1);
		recipe.AddIngredient(ItemID.Shackle, 2);
		recipe.AddIngredient(ItemID.CrossNecklace, 1);
		recipe.AddIngredient(ItemID.CopperShortsword, 1);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}
	
	public override void UpdateAccessory(Player player, bool hideVisual)
{
	player.magicDamage += 0.3f;
	player.lavaImmune = true;
	player.fireWalk = true;
	player.meleeDamage += 0.3f;
	player.rangedDamage += 0.3f;
	player.minionDamage += 0.3f;
	player.thrownDamage += 0.3f;
	player.lifeRegen += 9;
	player.longInvince = true;
	player.eyeColor = new Color(255f, 0f, 0f, 100f);
	player.statManaMax2 += 200;
	player.nightVision = true;
	player.name ="Fate Can't Be Changed Fate Can Be Changed Fate Can't Be Changed Fate Can Be Changed Fate Can't Be Changed Fate Can Be Changed Fate Can't Be Changed";
	player.respawnTimer = 0;
}
  }

}