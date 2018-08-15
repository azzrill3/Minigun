using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class TMan : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Strange Pocket Watch");
			Tooltip.SetDefault("Wait a bit, we're not in hurry...");
		}
		public override void SetDefaults()    
		{
                                  
			item.width = 30; 
			item.height = 30; 
			item.consumable = false;
			item.maxStack = 1;                                        
			item.value = 100000; 
			item.useTime = 3;
			item.autoReuse = true;
			item.channel = true;
			item.useAnimation = 10;
			item.rare = 8;
			item.useStyle = 1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "KramniumCrystal", 10);
			recipe.AddIngredient(null, "SunAlloy", 5);
			recipe.AddIngredient(null, "DarkSteelBar", 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

public override bool UseItem(Player player)
		{
			
					Main.time = Main.time - 100;
			return true;
		}
	
  }

}