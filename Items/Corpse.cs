using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class Corpse : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pistol Corpse");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 100; 
			item.height = 100; 
			item.consumable = false;
			item.maxStack = 999;
			                                         
			item.value = 10000;                        
			item.rare = 10;                                   
		}

	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.Anvils);
		recipe.AddIngredient(ItemID.Wire, 5);
		recipe.AddIngredient(null, "OvercoaledSteel", 10);
		recipe.AddIngredient(ItemID.IronBar, 5);
		recipe.AddIngredient(ItemID.ManaCrystal, 1);
		recipe.anyIronBar = true;
		recipe.SetResult(this);
		recipe.AddRecipe();

	}
  }

}