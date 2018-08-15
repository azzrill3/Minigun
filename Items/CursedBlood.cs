using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class CursedBlood : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Blood");
			Tooltip.SetDefault("Used for cursed crafting"
			+"\nNeeds both Extractinator and Demon Altar to be crafted");
		}
		public override void SetDefaults()    
		{                                 
			item.width = 30; 
			item.height = 24; 
			item.consumable = false;
			item.maxStack = 9999;                                         
			item.value = 1000;                        
			item.rare = 8;   
		}
	
	public override void AddRecipes()
	
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.Extractinator);
		recipe.AddTile(TileID.DemonAltar);
		recipe.AddIngredient(ItemID.CursedFlame, 10);
		recipe.AddIngredient(ItemID.Ichor, 10);
		recipe.AddIngredient(ItemID.SoulofNight, 7);
		recipe.AddIngredient(ItemID.SoulofMight, 7);
		recipe.AddIngredient(ItemID.SoulofFright, 7);
		recipe.AddIngredient(ItemID.SoulofSight, 7);
		recipe.AddIngredient(ItemID.SoulofLight, 7);
		recipe.AddIngredient(null, "KLiquid", 5);
		recipe.SetResult(this, 2);
		recipe.AddRecipe();
	}
  }

}