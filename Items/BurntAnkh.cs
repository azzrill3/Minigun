using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class BurntAnkh : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Burnt Ankh");
			Tooltip.SetDefault("It was hard");
		}
		public override void SetDefaults()    
		{                                 
			item.width = 22; 
			item.height = 34; 
			item.consumable = false;
			item.maxStack = 1;                                         
			item.value = 10000;                        
			item.rare = -1;                                   
		}
	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.GlassKiln);
		recipe.AddIngredient(ItemID.AnkhCharm, 1);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}
  }

}