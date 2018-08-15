using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class CBlade : ModItem          
	{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed.. Sword?");
			Tooltip.SetDefault("I don't know what is it, but it's extremely sharp!");
		}
		public override void SetDefaults()    
		{
               
			item.damage = 100;   
			item.crit = 30;
			item.melee = true;           
			item.width = 60;    		
			item.height = 48;          
			item.useTime = 7;                                
			item.useAnimation = 7; 
			item.noMelee = false;                      
			item.useStyle = 1; 			
			item.knockBack = 5;                    
			item.value = 70000;                        
			item.rare = 7;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;                     
			item.UseSound = SoundID.Item1;
		}
		
		public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "OvercoaledSteel", 11);
		recipe.AddIngredient(null, "ShinyBlade", 1);
		recipe.AddIngredient(null, "RealityFabric", 5);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}

	}
}