using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class RealityFabric : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fabric of Reality");
			Tooltip.SetDefault("The Essence of Everything"
			+"\nNeeds both Sky Mill and Loom to be crafted");
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
		recipe.AddTile(TileID.SkyMill);
		recipe.AddTile(TileID.Loom);
		recipe.AddIngredient(ItemID.Silk, 2);
		recipe.AddIngredient(ItemID.DirtBlock, 100);
		recipe.AddIngredient(null, "EasymodeBar", 3);
		recipe.AddIngredient(ItemID.StoneBlock, 200);
		recipe.AddIngredient(ItemID.Wood, 100);
		recipe.AddIngredient(null, "KramniumCrystal", 5);
		recipe.AddIngredient(ItemID.GrassSeeds, 50);
		recipe.anyIronBar = true;
		recipe.SetResult(this);
		recipe.AddRecipe();
		

	}
  }

}