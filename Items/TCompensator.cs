using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class TCompensator : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Temperature Compensator");
			Tooltip.SetDefault("Immunity to all tempetature debuffs + immunity to Electified");
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
			item.rare = 5;
			item.useStyle = 1;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
{
	player.buffImmune[24] = true;
	player.buffImmune[44] = true;
	player.buffImmune[46] = true;
	player.buffImmune[47] = true;
	player.buffImmune[67] = true;
	player.buffImmune[144] = true;
	player.buffImmune[39] = true;
	player.buffImmune[153] = true;
}
		
public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.DemonAltar);
		recipe.AddIngredient(null, "EasymodeBar", 4);
		recipe.AddIngredient(null, "ShinyMetalBar", 11);
		recipe.AddIngredient(ItemID.Wire, 15);
		recipe.AddIngredient(ItemID.SoulofFright, 15);
		recipe.AddIngredient(ItemID.WaterBucket, 3);
		recipe.AddIngredient(ItemID.LavaBucket, 3);
		recipe.SetResult(this);
		recipe.AddRecipe();
	
	}
  }

}