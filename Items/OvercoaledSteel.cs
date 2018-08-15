using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class OvercoaledSteel : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Overcoaled Steel");
			Tooltip.SetDefault("Easy to break");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 32; 
			item.height = 26; 
			item.consumable = false;
			item.maxStack = 999;
			                                         
			item.value = 10000;                        
			item.rare = 10;                                   
		}

	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.Furnaces);
		recipe.AddIngredient(ItemID.Wood, 25);
		recipe.AddIngredient(ItemID.IronBar, 1);
		recipe.anyIronBar = true;
		recipe.SetResult(this);
		recipe.AddRecipe();

	}
  }

}