using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Windows.Forms;
using System.Timers;

namespace Minigun.Items
{
    public class ShinyBlade : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shiny Blade");
			Tooltip.SetDefault("Only one thing that hasn't burnt in a furnace");
		}

		public override void SetDefaults()    
		{

                                
			item.width = 38; 
			item.height = 18; 
			item.consumable = false;
			item.maxStack = 64;
 			
			item.value = 10000;                        
			item.rare = 2;                                   
		}

public override void AddRecipes()
	
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.Furnaces);
		recipe.AddIngredient(null, "ShortSword", 1);
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
   }

}