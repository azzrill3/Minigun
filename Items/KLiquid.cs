using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class KLiquid : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kramnium Cell");
			Tooltip.SetDefault("Pure Power");
		}
		public override void SetDefaults()    
		{                                 
			item.width = 30; 
			item.height = 24; 
			item.consumable = true;
			item.maxStack = 9999;                                         
			item.value = 5000;                        
			item.rare = 8;   
			item.ammo = item.type;
		}
	
	public override void AddRecipes()
	
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.Extractinator);
		recipe.AddIngredient(null, "Cell", 2);
		recipe.AddIngredient(null, "KramniumCrystal", 3);
		recipe.SetResult(this, 2);
		recipe.AddRecipe();
	}
  }

}