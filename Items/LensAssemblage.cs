using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class LensAssemblage : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lens Assemblage");
			Tooltip.SetDefault("No, it's not a scope"
			+"\nUsed for advanced mechanisms");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 32; 
			item.height = 26; 
			item.consumable = false;
			item.maxStack = 1;
			                                         
			item.value = 1000000;                        
			item.rare = 10;                                   
		}

	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.WorkBenches);
		recipe.AddIngredient(ItemID.Lens, 20);
		recipe.AddIngredient(null, "KLens", 10);
		recipe.AddIngredient(ItemID.BlackLens, 1);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}
  }

}