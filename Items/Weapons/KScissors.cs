using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
	
    public class KScissors : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Scissors of The Heavenly Host");
			Tooltip.SetDefault("Overcursed!"
			+"\nRight Click to shoot Blades");
		}
		public override void SetDefaults()    
		{
              
			item.damage = 99;
			item.magic = true;
			item.crit = 13;           
			item.width = 67;    		
			item.height = 36;          
			item.useTime = 25;                                
			item.useAnimation = 25; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 10000000;                        
			item.rare = 10;
			item.noUseGraphic = true;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = mod.ProjectileType("Kslash");                     
			item.shootSpeed = 40f; 
			item.UseSound = SoundID.Item13;
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.damage = 200;
			item.magic = true;
			item.crit = 13;           
			item.width = 67;    		
			item.height = 36;          
			item.useTime = 3;                                
			item.useAnimation = 25; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 10000000;                        
			item.rare = 10;
			item.noUseGraphic = true;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = mod.ProjectileType("KS");                     
			item.shootSpeed = 40f; 
			item.UseSound = SoundID.Item1;
				
				
			}
			else
			{              
			item.damage = 99;
			item.magic = true;
			item.crit = 13;           
			item.width = 67;    		
			item.height = 36;          
			item.useTime = 10;                                
			item.useAnimation = 25; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 10000000;                        
			item.rare = 10;
			item.noUseGraphic = true;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = mod.ProjectileType("KSlash");                     
			item.shootSpeed = 40f; 
			item.UseSound = SoundID.Item1; 
			}
			return base.CanUseItem(player);




		}
		
		public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.DemonAltar);
		recipe.AddIngredient(null, "OldScissors", 1);
		recipe.AddIngredient(null, "KKnife", 1);
		recipe.AddIngredient(null, "CurseofNirvana", 1);
		recipe.AddIngredient(null, "KLiquid", 50);
		recipe.AddIngredient(null, "OvercoaledSteel", 10);
		recipe.AddIngredient(ItemID.TerraBlade, 1);
		recipe.AddIngredient(ItemID.SoulofNight, 100);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}
	

}
}