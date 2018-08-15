using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
	[AutoloadEquip(EquipType.Body)]
	
    public class KRaincoat : ModItem          
	{
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vantablack Raincoat");
			Tooltip.SetDefault("Solar Armor, huh?"
			+"\nGives immunity to most debuffs"
			+"\nAllows to control gravity"
			+"\nGives ability to walk on fire blocks and knockback resistance");
		}
		
		public override void SetDefaults()    
		{                    
			item.width = 38; 
			item.height = 20; 
			item.consumable = false;
			item.maxStack = 1;                                        
			item.value = 1000000; 
			item.rare = 10;
			item.defense = 42;
			
		}
		
		public override bool DrawBody()
		{
			return true;
		}
		public override void UpdateEquip(Player player)
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
		public override void AddRecipes()
		{
		ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CBreast", 1);
			recipe.AddIngredient(null, "CharmofReality", 1);
			recipe.AddIngredient(ItemID.RainCoat, 1);
			recipe.AddRecipeGroup(" Cobalt Breastplate", 1);
			recipe.AddRecipeGroup(" Mythril Chainmail", 1);
			recipe.AddRecipeGroup(" Adamantite Breastplate", 1);
			recipe.AddIngredient(null, "SinSoul", 20);
			recipe.AddIngredient(null, "SinSoul1", 20);
			recipe.AddIngredient(null, "SinSoul2", 20);
			recipe.AddIngredient(null, "SinSoul3", 20);
			recipe.AddIngredient(null, "SinSoul4", 20);
			recipe.AddIngredient(null, "SinSoul5", 20);
			recipe.AddIngredient(null, "SinSoul6", 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		

  }

}