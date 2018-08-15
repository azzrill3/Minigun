using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class AllSeeingEye : ModItem          
	{
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("All-Seeing Eye");
			Tooltip.SetDefault("Dispays nearby enemies, treasure and hazards"
			+"\nNeeds both Demon Altar and Glass Kiln to be crafted");
		}
		
		public override void SetDefaults()    
		{                    
			item.width = 46; 
			item.height = 32; 
			item.consumable = false;
			item.accessory = true;
			item.maxStack = 1;                                        
			item.value = 100000; 
			item.useTime = 10;
			item.useAnimation = 10;
			item.rare = 9;
			item.useStyle = 1;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
{
	player.findTreasure = true;
	player.detectCreature = true;
	player.dangerSense = true;
}
		
public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.DemonAltar);
		recipe.AddTile(TileID.GlassKiln);
		recipe.AddIngredient(null, "CursedBlood", 2);
		recipe.AddIngredient(ItemID.SuspiciousLookingEye, 3);
		recipe.AddIngredient(ItemID.Lens, 5);
		recipe.AddIngredient(null, "KLens", 3);
		recipe.AddIngredient(ItemID.BlackLens, 1);
		recipe.AddIngredient(ItemID.SpelunkerPotion, 7);
		recipe.AddIngredient(2329, 7);
		recipe.AddIngredient(ItemID.HunterPotion, 7);
		recipe.SetResult(this);
		recipe.AddRecipe();
	
	}
  }

}