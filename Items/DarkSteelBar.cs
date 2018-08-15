using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class DarkSteelBar : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Steel Bar");
			Tooltip.SetDefault("Wery hard and strong");
		}
		public override void SetDefaults()    
		{

			        
			item.width = 12; 
			item.height = 18; 
			item.consumable = false;
			item.maxStack = 999;
			                             
			item.value = 10000;                        
			item.rare = -1;                                   
		}

public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.IronBar, 2);
		recipe.anyIronBar = true;
		recipe.AddIngredient(ItemID.LunarBar, 1);
		recipe.AddIngredient(ItemID.Obsidian, 5);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}
	
  }

}