using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class CursedBloodBar : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Blood Bar");
			Tooltip.SetDefault("Used for advanced cursed crafting"
			+"\nNeeds both Furnace and Demon Altar to be crafted");
		}
		public override void SetDefaults()    
		{                                 
			item.width = 30; 
			item.height = 24; 
			item.consumable = false;
			item.maxStack = 99;                                         
			item.value = 10000;                        
			item.rare = 8;   
		}
	
	public override void AddRecipes()
	
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.Furnaces);
		recipe.AddTile(TileID.DemonAltar);
		recipe.AddIngredient(null, "OvercoaledSteel", 5);
		recipe.AddIngredient(null, "KBar", 4);
		recipe.AddIngredient(null, "EasymodeBar", 3);
		recipe.AddIngredient(null, "HardmodeBar", 1);
		recipe.AddIngredient(null, "ShinyMetalBar", 2);
		recipe.AddIngredient(null, "CursedBlood", 5);
		recipe.SetResult(this, 3);
		recipe.AddRecipe();
	}
  }

}