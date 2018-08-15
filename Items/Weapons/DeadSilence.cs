using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class DeadSilence : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dead Silence");
			Tooltip.SetDefault("I hear the pitter patter of your feeeEEEEEAAAAAHHH GASP t"
			+"\nConsumes every bullet"
			+ "\nCan Shoot through the walls"
			+"\nShoots super fast invisible projectile");
		}
		public override void SetDefaults()    
		{
                
			item.damage = 70;   
			item.crit = 21;
			item.ranged = true;           
			item.width = 80;    		
			item.useAmmo = AmmoID.Bullet; 
			item.height = 22;          
			item.useTime = 15;                                
			item.useAnimation = 15;                                                                               
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 1000000;                        
			item.rare = 5;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = 10;                     
			item.shootSpeed = 30f; 
			item.UseSound = SoundID.Item11;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, 0);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 800f;
			if (type != mod.ProjectileType("Silence"))
			{
				type = mod.ProjectileType("Silence");
			}
			
			return true;
		} // return false because we don't want tmodloader to shoot projectile
		

		
public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ClockworkAssaultRifle, 1);
			recipe.AddIngredient(ItemID.LaserRifle, 1);
			recipe.AddIngredient(ItemID.Cog, 15);
			recipe.AddIngredient(ItemID.SoulofFright, 30);
			recipe.AddIngredient(ItemID.SoulofFlight, 15);
			recipe.AddIngredient(null , "KLiquid", 5);
			recipe.AddIngredient(null , "LensAssemblage", 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddTile(TileID.Pearlstone);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
		}



	}

}