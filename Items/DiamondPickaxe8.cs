using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class DiamondPickaxe8 : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diamond Pickaxe Tier 8");
			Tooltip.SetDefault("It is harmless, but fast!");
		}
		public override void SetDefaults()    
		{
                                  
			item.width = 32;  
			item.pick = 220;
			item.consumable = false;
			item.maxStack = 1;
			item.height = 32;       
			item.useTime = 1;                                
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
		recipe.AddIngredient(null, "DiamondPickaxe7", 1);
		recipe.AddIngredient(ItemID.Picksaw, 1);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
	
  }

}