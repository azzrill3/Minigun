using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class BLaser : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Blue Laser");
			Tooltip.SetDefault("Rape your Mouse!");
		
		}
		public override void SetDefaults()    
		{

	               
			item.damage = 60;   
			item.crit = 15;
			item.ranged = true;           
			item.width = 58;    		
			item.height = 32;          
			item.useTime = 2;                                
			item.useAnimation = 2; 
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 20000;                        
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = false;  
			item.scale = 0.75f;
			item.shoot = mod.ProjectileType("BLaser");                     
			item.shootSpeed = 20f; 
			item.UseSound = SoundID.Item13;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 1);
		}

/*public override void AddRecipes()
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
		
		}*/



	}

}