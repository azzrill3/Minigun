using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class StableFabric : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stable Fabric");
			Tooltip.SetDefault("It belongs to another dimension"
			+"\nNeeds both Demon Altar and Loom to be crafted");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 28; 
			item.height = 26; 
			item.consumable = false;
			item.maxStack = 999;
			                                         
			item.value = 10000;                        
			item.rare = 7;                                   
		}

	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.DemonAltar);
		recipe.AddTile(TileID.Loom);
		recipe.AddIngredient(ItemID.Silk, 2);
		recipe.AddIngredient(ItemID.HallowedBar, 3);
		recipe.AddIngredient(ItemID.ChlorophyteBar, 1);
		recipe.AddIngredient(ItemID.SoulofFlight, 2);
		recipe.AddIngredient(null, "CursedBlood", 1);
		recipe.AddIngredient(null, "OvercoaledSteel", 2);
		recipe.AddIngredient(ItemID.Ectoplasm, 3);
		recipe.anyIronBar = true;
		recipe.SetResult(this);
		recipe.AddRecipe();

	}
  }

}