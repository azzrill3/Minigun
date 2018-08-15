using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class HardmodeBar : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hardmode Bar");
			Tooltip.SetDefault("Unicorns and adamantite!");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 30; 
			item.height = 24; 
			item.consumable = false;
			item.maxStack = 99;
			                                         
			item.value = 100000;                        
			item.rare = 4;                                   
		}

	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.Furnaces);
		recipe.AddRecipeGroup(" Cobalt Bar", 1);
		recipe.AddRecipeGroup(" Mythril Bar", 1);
		recipe.AddRecipeGroup(" Adamantite Bar", 1);
		recipe.AddIngredient(ItemID.HallowedBar, 1);
		recipe.AddRecipeGroup(" Cursed Flame", 1);
		recipe.AddIngredient(ItemID.PixieDust, 1);
		recipe.SetResult(this);
		recipe.AddRecipe();
		

	}
  }

}