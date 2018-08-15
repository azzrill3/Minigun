using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class CorruptDL : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corrupt Death Laser");
		
		}
		public override void SetDefaults()    
		{

	               
			item.damage = 25;   
			item.crit = 60;
			item.ranged = true;           
			item.width = 174;    		
			item.height = 47;          
			item.useTime = 9;                                
			item.useAnimation = 6; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 20000;                        
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = mod.ProjectileType("CoDL");                     
			item.shootSpeed = 67f; 
			item.UseSound = SoundID.Item13;
		}

public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WeakDeathLaser", 1);
			recipe.AddIngredient(ItemID.DemoniteBar, 12);
			recipe.AddIngredient(ItemID.ShadowScale, 8);
			recipe.AddIngredient(ItemID.RottenChunk, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WeakDeathLaser", 1);
			recipe.AddIngredient(ItemID.CrimtaneBar, 12);
			recipe.AddIngredient(ItemID.TissueSample, 8);
			recipe.AddIngredient(ItemID.Vertebrae, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
		}



	}

}