using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class MechanicalCore : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mechanical Core");
			Tooltip.SetDefault("Immunity to all slowing and stopping debuffs");
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
	player.buffImmune[197] = true;
	player.buffImmune[194] = true;
	player.buffImmune[164] = true;
	player.buffImmune[160] = true;
	player.buffImmune[192] = true;
	player.buffImmune[154] = true;
	player.buffImmune[149] = true;
	player.buffImmune[137] = true;
	player.buffImmune[103] = true;
	player.buffImmune[46] = true;
	player.buffImmune[47] = true;
	player.buffImmune[32] = true;
	player.buffImmune[31] = true;
	player.buffImmune[137] = true;
	
}
		
public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.DemonAltar);
		recipe.AddIngredient(null, "EasymodeBar", 6);
		recipe.AddIngredient(null, "ShinyMetalBar", 15);
		recipe.AddIngredient(ItemID.Wire, 25);
		recipe.AddIngredient(ItemID.SoulofMight, 15);
		recipe.AddIngredient(ItemID.SoulofSight, 15);
		recipe.AddIngredient(ItemID.HallowedBar, 7);
		recipe.SetResult(this);
		recipe.AddRecipe();
	
	}
  }

}