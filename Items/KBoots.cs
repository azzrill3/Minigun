using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
	[AutoloadEquip(EquipType.Legs)]
    public class KBoots : ModItem          
	{
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Boots of The Insanity");
			Tooltip.SetDefault("Insane Speed for Insane Users!");
		}
		
		public override void SetDefaults()    
		{                    
			item.width = 22; 
			item.height = 18; 
			item.consumable = false;
			item.maxStack = 1;                                        
			item.value = 1000000; 
			item.rare = 10;
			item.defense = 24;
			
		}
		public override void UpdateEquip(Player player)
		{
	if (player.controlLeft)
	{
		if (player.velocity.X > -5) player.velocity.X -= 0.7f;
		if (player.velocity.X < -5 && player.velocity.X > -25)
		{
			player.velocity.X -= 0.7f;
		}
	}
	if (player.controlRight)
	{
		if (player.velocity.X < 5) player.velocity.X += 0.7f;
		if (player.velocity.X > 5 && player.velocity.X < 25)
		{
			player.velocity.X += 0.7f;
		}
	}
		}
		public override void AddRecipes()
		{
		ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CGreaves", 1);
			recipe.AddIngredient(3353, 1);
			recipe.AddIngredient(ItemID.BeePants, 1);
			recipe.AddRecipeGroup(" Cobalt Leggings", 1);
			recipe.AddRecipeGroup(" Mythril Greaves", 1);
			recipe.AddRecipeGroup(" Adamantite Leggings", 1);
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