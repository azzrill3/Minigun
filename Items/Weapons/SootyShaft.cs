using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class SootyShaft : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sooty Shaft");
			Tooltip.SetDefault("Has Autoattack");
		}
		public override void SetDefaults()    
		{
               
			item.damage = 9;   
			item.crit = 20;
			item.melee = true;           
			item.width = 48;    		
			item.height = 48;          
			item.useTime = 13;                                
			item.useAnimation = 13; 
			item.noMelee = false;                      
			item.useStyle = 1; 			
			item.knockBack = 4;                    
			item.value = 5000;                        
			item.rare = -1;
			item.maxStack = 1;                 
			item.autoReuse = true;  
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
				item.useTime = 9;
				item.useAnimation = 9;
				item.damage = 9;
				item.autoReuse = true;
			}
			else
			{
				item.useStyle = 1;
				item.useTime = 13;
				item.useAnimation = 13;
				item.damage = 9;
				item.autoReuse = true;
			}
			return base.CanUseItem(player);
		}

public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "WoodShaft", 1);
		recipe.AddTile(TileID.Campfire);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}

}
}