using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class ObscureSickle : ModItem          
	{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Obscure Sickle");
			Tooltip.SetDefault("Ooow, Gloomy!");
		}
		public override void SetDefaults()    
		{
               
			item.damage = 20;   
			item.crit = 30;
			item.melee = true;           
			item.width = 60;    		
			item.height = 48;          
			item.useTime = 15;                                
			item.useAnimation = 15; 
			item.noMelee = false;                      
			item.useStyle = 1; 			
			item.knockBack = 5;                    
			item.value = 70000;                        
			item.rare = -1;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;                     
			item.UseSound = SoundID.Item71;
		}
		
		public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "SootyShaft", 1);
		recipe.AddIngredient(null, "ShinyBlade", 1);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}

	}
}