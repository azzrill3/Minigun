using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class ShinyMetalBar : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shiny Metal Bar");
			Tooltip.SetDefault("I think I need sunglasses");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 28; 
			item.height = 26; 
			item.consumable = false;
			item.maxStack = 99;
			                                         
			item.value = 10000;                        
			item.rare = 4;                                   
		}

	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.Furnaces);
		recipe.AddRecipeGroup(" Silver Bar", 1);
		recipe.AddRecipeGroup(" Gold Bar", 1);
		recipe.anyIronBar = true;
		recipe.SetResult(this);
		recipe.AddRecipe();
		

	}
  }

}