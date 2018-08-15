using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class KBar : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kramnium Bar");
			Tooltip.SetDefault("I don't think it's useful");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 32; 
			item.height = 26; 
			item.consumable = false;
			item.maxStack = 99;
			                                         
			item.value = 100000;                        
			item.rare = 10;                                   
		}

	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.WorkBenches);
		recipe.AddIngredient(null, "KramniumCrystal", 5);
		recipe.AddIngredient(null, "ShinyMetalBar", 1);
		recipe.AddIngredient(null, "EasymodeBar", 1);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}
  }

}