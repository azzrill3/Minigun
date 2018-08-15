using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class Cell : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Empty Cell");
			Tooltip.SetDefault("Filled in extractor");
		}
		public override void SetDefaults()    
		{                                 
			item.width = 24; 
			item.height = 24; 
			item.consumable = false;
			item.maxStack = 999;                                         
			item.value = 10000;                        
			item.rare = 8;                                   
		}
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.Furnaces);
		recipe.AddIngredient(null, "OvercoaledSteel", 3);
		recipe.SetResult(this, 5);
		recipe.AddRecipe();

	}
  }

}