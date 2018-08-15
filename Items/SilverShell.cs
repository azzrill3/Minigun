using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class SilverShell : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Silver Shell");
			Tooltip.SetDefault("Very Big");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 12; 
			item.height = 26; 
			item.consumable = false;
			item.maxStack = 999;
			                                         
			item.value = 10000;                        
			item.rare = 3;                                   
		}

	public override void AddRecipes()
		{
		ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup(" Silver Bar", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
  }

}