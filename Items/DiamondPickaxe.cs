using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class DiamondPickaxe : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diamond Pickaxe");
			Tooltip.SetDefault("It is harmless, but fast!");
		}
		public override void SetDefaults()    
		{
                                 
			item.width = 32;  
			item.pick = 50;
			item.consumable = false;
			item.maxStack = 1;
			item.height = 32;       
			item.useTime = 3;                                
			item.useAnimation = 10;                                                                                  
			item.useStyle = 1;                        
			item.value = 10000;                        
			item.rare = 2;                      
			item.UseSound = SoundID.Item1;                  
			item.autoReuse = true;                                    
		}

public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.CopperPickaxe, 1);
		recipe.AddIngredient(ItemID.Diamond, 15);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(this);
		recipe.AddRecipe();

		recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.TinPickaxe, 1);
		recipe.AddIngredient(ItemID.Diamond, 15);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
	
  }

}