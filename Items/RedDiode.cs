using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class RedDiode : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Diode");
			Tooltip.SetDefault("Basic diode");
		}
		public override void SetDefaults()    
		{
                                  
			item.width = 12; 
			item.height = 18; 
			item.consumable = false;
			item.maxStack = 999;                                         
			item.value = 10000;                        
			item.rare = 2;                                   
		}

public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.IronBar, 2);
		recipe.anyIronBar = true;
		recipe.AddIngredient(ItemID.Wire, 5);
		recipe.AddIngredient(ItemID.Glass, 5);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(this, 5);
		recipe.AddRecipe();

	}
	
  }

}