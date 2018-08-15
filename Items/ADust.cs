using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class ADust : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arcane Dust");
			Tooltip.SetDefault("Filled with magic");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 26; 
			item.height = 22; 
			item.consumable = false;
			item.maxStack = 999;
			                                         
			item.value = 10000;                        
			item.rare = 2;                                   
		}

	public override void AddRecipes()
		{
		ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}
  }

}