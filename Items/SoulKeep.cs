using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class SoulKeep : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul Keeper's Tablet");
			Tooltip.SetDefault("Eqip to become a ghost");
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
			item.rare = 8;
			item.useStyle = 1;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
{
	player.ghost = true;
}
		
public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.DemonAltar);
		recipe.AddIngredient(null, "CursedBlood", 4);
		recipe.AddIngredient(null, "OvercoaledSteel", 11);
		recipe.AddIngredient(ItemID.SolarTablet, 5);
		recipe.AddIngredient(ItemID.SoulofFright, 10);
		recipe.SetResult(this);
		recipe.AddRecipe();
	
	}
  }

}