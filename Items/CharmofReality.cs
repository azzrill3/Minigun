using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class CharmofReality : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Charm of Reality");
			Tooltip.SetDefault("Really powerul thing"
			+"\nImmunity to ALL debuffs (exept Potion Sickness and Water Candle)"
			+"\nAllows to conrtol gravity + knockback resistance");
		}
		
		public override void SetDefaults()    
		{                    
			item.width = 14; 
			item.height = 40; 
			item.consumable = false;
			item.accessory = true;
			item.defense = 5;
			item.maxStack = 1;                                        
			item.value = 100000; 
			item.useTime = 10;
			item.useAnimation = 10;
			item.rare = 7;
			item.useStyle = 1;
		}
		public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(101);
		recipe.AddIngredient(ItemID.AnkhShield, 1);
		recipe.AddIngredient(ItemID.SoulofFright, 10);
		recipe.AddIngredient(ItemID.SoulofSight, 10);
		recipe.AddIngredient(ItemID.SoulofMight, 10);
		recipe.AddIngredient(ItemID.SoulofLight, 20);
		recipe.AddIngredient(null, "RealityFabric", 5);
		recipe.AddIngredient(null, "TCompensator", 1);
		recipe.AddIngredient(null, "Gravitator", 1);
		recipe.AddIngredient(null, "UVaccine", 1);
		recipe.AddIngredient(null, "RottenEye", 1);
		recipe.AddIngredient(null, "MechanicalCore", 1);
		recipe.AddIngredient(null, "OFlask", 1);
		recipe.anyIronBar = true;
		recipe.SetResult(this);
		recipe.AddRecipe();
		

	}
		public override void UpdateAccessory(Player player, bool hideVisual)
{
	player.buffImmune[38] = true;
	player.buffImmune[37] = true;
	player.buffImmune[80] = true;
	player.buffImmune[120] = true;
	player.buffImmune[145] = true;
	player.buffImmune[163] = true;
	player.buffImmune[68] = true;
	player.buffImmune[148] = true;
	player.buffImmune[70] = true;
	player.buffImmune[69] = true;
	player.buffImmune[20] = true;
	player.buffImmune[164] = true;
	player.gravControl = true;
	player.fireWalk = true;
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
	player.buffImmune[24] = true;
	player.buffImmune[44] = true;
	player.buffImmune[46] = true;
	player.buffImmune[47] = true;
	player.buffImmune[67] = true;
	player.buffImmune[144] = true;
	player.buffImmune[39] = true;
	player.buffImmune[153] = true;
	player.buffImmune[22] = true;
	player.buffImmune[23] = true;
	player.buffImmune[35] = true;
	player.buffImmune[33] = true;
	player.buffImmune[36] = true;
	player.buffImmune[30] = true;
	player.buffImmune[25] = true;
	player.buffImmune[72] = true;
	player.buffImmune[94] = true;
	player.buffImmune[169] = true;
	player.buffImmune[195] = true;
	player.buffImmune[196] = true;
	player.buffImmune[199] = true;
	player.noKnockback = true;
}
		

  }

}