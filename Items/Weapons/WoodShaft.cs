using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class WoodShaft : ModItem          
	{
		public override void SetStaticDefaults()
		{
			
			DisplayName.SetDefault("Wooden Shaft");
			Tooltip.SetDefault("Why not?"
			 + "\nRight Click to use like a Shortsword");
		}
		public override void SetDefaults()    
		{
              
			item.damage = 10;   
			item.crit = 12;
			item.melee = true;           
			item.width = 48;    		
			item.height = 48;          
			item.useTime = 15;                                
			item.useAnimation = 15; 
			item.noMelee = false;                      
			item.useStyle = 1; 			
			item.knockBack = 4;                    
			item.value = 5000;                        
			item.rare = 0;
			item.maxStack = 1;                 
			item.autoReuse = false;  
			item.scale = 1;                     
			item.UseSound = SoundID.Item1;
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useStyle = 3;
				item.useTime = 11;
				item.useAnimation = 10;
				item.damage = 10;
				item.autoReuse = false;
			}
			else
			{
				item.useStyle = 1;
				item.useTime = 15;
				item.useAnimation = 15;
				item.damage = 10;
				item.autoReuse = false;
			}
			return base.CanUseItem(player);
		}

public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.Wood, 25);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}
	}
}