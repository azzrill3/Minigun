using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class Circuit : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pistol Circuit");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 17; 
			item.height = 26; 
			item.consumable = false;
			item.maxStack = 999;
			                                         
			item.value = 10000;                        
			item.rare = 10;                                   
		}

	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.Anvils);
		recipe.AddIngredient(ItemID.Wire, 10);
		recipe.AddIngredient(null, "OvercoaledSteel", 1);
		recipe.AddIngredient(ItemID.IronBar, 1);
		recipe.anyIronBar = true;
		recipe.SetResult(this);
		recipe.AddRecipe();

	}
  }

}