using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class GathlingFury : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gathling's Fury");
			Tooltip.SetDefault("Die In A Fire"
			+"\nConsumes every bullet"
			+ "\nShots several projectiles at once");
		}
		public override void SetDefaults()    
		{
                
			item.damage = 35;   
			item.crit = 12;
			item.ranged = true;           
			item.width = 76;    		
			item.useAmmo = AmmoID.Bullet; 
			item.height = 34;          
			item.useTime = 8;                                
			item.useAnimation = 6;                                                                               
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 1000000;                        
			item.rare = 6;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = 10;                     
			item.shootSpeed = 20f; 
			item.UseSound = SoundID.Item11;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 75f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			int numberProjectiles = 4 + Main.rand.Next(4); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return true; // return false because we don't want tmodloader to shoot projectile
		}

		
public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PhoenixBlaster, 1);
			recipe.AddIngredient(ItemID.ClockworkAssaultRifle, 1);
			recipe.AddIngredient(ItemID.Gatligator, 1);
			recipe.AddIngredient(ItemID.SoulofMight, 30);
			recipe.AddIngredient(null , "OvercoaledSteel", 1);
			recipe.AddIngredient(null , "LensAssemblage", 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
		}



	}

}