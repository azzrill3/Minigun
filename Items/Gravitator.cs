using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class Gravitator : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gravitator");
			Tooltip.SetDefault("Allows to control gravity + immunity to Distored");
		}
		
		public override void SetDefaults()    
		{                    
			item.width = 14; 
			item.height = 40; 
			item.consumable = false;
			item.accessory = true;
			item.maxStack = 1;                                        
			item.value = 100000; 
			item.useTime = 10;
			item.useAnimation = 10;
			item.rare = 6;
			item.useStyle = 1;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
{
	player.buffImmune[164] = true;
	player.gravControl = true;
	
}
		
public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.DemonAltar);
		recipe.AddIngredient(null, "OvercoaledSteel", 10);
		recipe.AddIngredient(null, "ShinyMetalBar", 9);
		recipe.AddIngredient(ItemID.Wire, 12);
		recipe.AddIngredient(ItemID.SoulofSight, 20);
		recipe.AddIngredient(ItemID.ChlorophyteBar, 7);
		recipe.AddIngredient(ItemID.GravitationPotion, 10);
		recipe.SetResult(this);
		recipe.AddRecipe();
	
	}
  }

}