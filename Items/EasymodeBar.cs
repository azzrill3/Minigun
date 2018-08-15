using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class EasymodeBar : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Easymode Bar");
			Tooltip.SetDefault("Looking at it makes you feel.. Strange?");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 30; 
			item.height = 24; 
			item.consumable = false;
			item.maxStack = 99;
			                                         
			item.value = 100000;                        
			item.rare = 3;                                   
		}

	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.Furnaces);
		recipe.AddRecipeGroup(" Copper Bar", 1);
		recipe.AddIngredient(ItemID.IronBar, 1);
		recipe.AddRecipeGroup(" Silver Bar", 1);
		recipe.AddRecipeGroup(" Gold Bar", 1);
		recipe.AddRecipeGroup(" Demonite Bar", 1);
		recipe.AddIngredient(ItemID.MeteoriteBar, 1);
		recipe.AddIngredient(ItemID.HellstoneBar, 1);
		recipe.anyIronBar = true;
		recipe.SetResult(this);
		recipe.AddRecipe();
		

	}
  }

}