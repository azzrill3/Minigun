using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
	[AutoloadEquip(EquipType.Head)]
    public class KHat : ModItem          
	{
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gambler's Hat");
			Tooltip.SetDefault("Great deal!"
			+"\nGives discount and grants extra coins for killing mobs"
			+"\nGrants Sniper Scope effects");
		}
		
		public override void SetDefaults()    
		{                    
			item.width = 30; 
			item.height = 22; 
			item.consumable = false;
			item.maxStack = 1;                                        
			item.value = 1000000; 
			item.rare = 10;
			item.defense = 27;
			
		}
		
		public override bool DrawHead()
		{
			return true;
		}
		public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		{
			drawAltHair = true;
		}
		
		public override void UpdateEquip(Player player)
		{
		player.discount = true;
		player.scope = true;
		player.coins = true;
		player.magicDamage += 0.1f;
		player.meleeDamage += 0.1f;
		player.rangedDamage += 0.1f;
		player.minionDamage += 0.1f;
		player.thrownDamage += 0.1f;
		player.magicCrit += 10;
		player.meleeCrit += 10;
		player.rangedCrit += 10;
		player.thrownCrit += 10;
		}
		public override void AddRecipes()
		{
		ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CHelmet", 1);
			recipe.AddIngredient(ItemID.SniperScope, 1);
			recipe.AddIngredient(ItemID.GreedyRing, 1);
			recipe.AddIngredient(ItemID.PeddlersHat, 1);
			recipe.AddRecipeGroup(" Cobalt Helmet", 1);
			recipe.AddRecipeGroup(" Mythril Helmet", 1);
			recipe.AddRecipeGroup(" Adamantite Helmet", 1);
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