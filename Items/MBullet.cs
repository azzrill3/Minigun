using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class MBullet : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Bullet");
			Tooltip.SetDefault("Destruction");
		}
		public override void SetDefaults()    
		{                                 
			item.width = 16; 
			item.height = 26; 
			item.consumable = true;
			item.maxStack = 9999;                                         
			item.value = 5000;                        
			item.rare = 8;   
			item.ammo = item.type;
		}
	
	public override void AddRecipes()
	
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.Anvils);
		recipe.AddIngredient(null, "GemDust", 2);
		recipe.AddIngredient(null, "Cell", 1);
		recipe.AddIngredient(null, "ADust", 3);
		recipe.AddIngredient(null, "SilverShell", 1);
		recipe.SetResult(this, 1);
		recipe.AddRecipe();
	}
  }

}