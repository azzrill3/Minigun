using System;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.IO;



namespace Minigun 
{         

public class Minigun : Mod          

{
	public override void AddRecipeGroups()
	{
		RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Vanilla Wings", new int[]
		{
			492,493,2494,748,1515,749,761,1165,785,786,1584,1585,1583,1586,3228,3580,
			3592,3582,3588,665,3924,3928,2770,1162,822,821,823,2280,1866,1871,1830,
			1797,3883,948,2609,3470,3469,3471,3468
		});
		RecipeGroup.RegisterGroup(" Vanilla Wings", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Copper Bar", new int[]
		{
			ItemID.CopperBar,
			ItemID.TinBar
			
		});
		RecipeGroup.RegisterGroup(" Copper Bar", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Silver Bar", new int[]
		{
			ItemID.SilverBar,
			ItemID.TungstenBar
			
		});
		RecipeGroup.RegisterGroup(" Silver Bar", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Gold Bar", new int[]
		{
			ItemID.GoldBar,
			ItemID.PlatinumBar
			
		});
		RecipeGroup.RegisterGroup(" Gold Bar", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Demonite Bar", new int[]
		{
			ItemID.DemoniteBar,
			ItemID.CrimtaneBar
			
		});
		RecipeGroup.RegisterGroup(" Demonite Bar", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Cobalt Bar", new int[]
		{
			ItemID.CobaltBar,
			ItemID.PalladiumBar
			
		});
		RecipeGroup.RegisterGroup(" Cobalt Bar", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Mythril Bar", new int[]
		{
			ItemID.MythrilBar,
			ItemID.OrichalcumBar
			
		});
		RecipeGroup.RegisterGroup(" Mythril Bar", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Adamantite Bar", new int[]
		{
			ItemID.AdamantiteBar,
			ItemID.TitaniumBar
			
		});
		RecipeGroup.RegisterGroup(" Adamantite Bar", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Cursed Flame", new int[]
		{
			ItemID.CursedFlame,
			ItemID.Ichor
			
		});
		RecipeGroup.RegisterGroup(" Cursed Flame", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Cobalt Breastplate", new int[]
		{
			ItemID.CobaltBreastplate,
			ItemID.PalladiumBreastplate
			
		});
		RecipeGroup.RegisterGroup(" Cobalt Breastplate", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Cobalt Helmet", new int[]
		{
			ItemID.CobaltHelmet,
			ItemID.CobaltHat,
			ItemID.CobaltMask,
			ItemID.PalladiumHelmet,
			ItemID.PalladiumHeadgear,
			ItemID.PalladiumMask
			
		});
		RecipeGroup.RegisterGroup(" Cobalt Helmet", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Cobalt Leggings", new int[]
		{
			ItemID.CobaltLeggings,
			ItemID.PalladiumLeggings
			
		});
		RecipeGroup.RegisterGroup(" Cobalt Leggings", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Mythril Chainmail", new int[]
		{
			ItemID.MythrilChainmail,
			ItemID.OrichalcumBreastplate
			
		});
		RecipeGroup.RegisterGroup(" Mythril Chainmail", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Mythril Greaves", new int[]
		{
			ItemID.MythrilGreaves,
			ItemID.OrichalcumLeggings
			
		});
		RecipeGroup.RegisterGroup(" Mythril Greaves", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Mythril Helmet", new int[]
		{
			ItemID.MythrilHood,
			ItemID.MythrilHelmet,
			ItemID.MythrilHat,
			ItemID.OrichalcumHeadgear,
			ItemID.OrichalcumHelmet,
			ItemID.OrichalcumMask
			
		});
		RecipeGroup.RegisterGroup(" Mythril Helmet", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Adamantite Breastplate", new int[]
		{
			ItemID.AdamantiteBreastplate,
			ItemID.TitaniumBreastplate
			
		});
		RecipeGroup.RegisterGroup(" Adamantite Breastplate", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Adamantite Leggings", new int[]
		{
			ItemID.AdamantiteLeggings,
			ItemID.TitaniumLeggings
			
		});
		RecipeGroup.RegisterGroup(" Adamantite Leggings", group);
		group = new RecipeGroup(() => Lang.misc[37] + " Adamantite Helmet", new int[]
		{
			ItemID.AdamantiteHelmet,
			ItemID.AdamantiteHeadgear,
			ItemID.AdamantiteMask,
			ItemID.TitaniumHeadgear,
			ItemID.TitaniumHelmet,
			ItemID.TitaniumMask
			
		});
		RecipeGroup.RegisterGroup(" Adamantite Helmet", group);
	}

public Minigun()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true,
				AutoloadBackgrounds = true
			};
		}
		
		public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(this);
		recipe.AddIngredient(null, "KramniumCrystal", 1);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(ItemID.Amethyst, 8);
		recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
		recipe.AddIngredient(null, "KramniumCrystal", 1);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(ItemID.Topaz, 7);
		recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
		recipe.AddIngredient(null, "KramniumCrystal", 1);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(ItemID.Sapphire, 6);
		recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
		recipe.AddIngredient(null, "KramniumCrystal", 1);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(ItemID.Emerald, 5);
		recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
		recipe.AddIngredient(null, "KramniumCrystal", 1);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(ItemID.Ruby, 4);
		recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
		recipe.AddIngredient(null, "KramniumCrystal", 1);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(ItemID.Diamond, 3);
		recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
		recipe.AddIngredient(null, "KramniumCrystal", 1);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(ItemID.Amber, 2);
		recipe.AddRecipe();
	}

}

}