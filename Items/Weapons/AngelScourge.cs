using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class AngelScourge : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Angel's Scourge");
			Tooltip.SetDefault("What You Deserve..."
			+"\nConsumes every bullet"
			+ "\nTransforms all Bullets to Chlorophyte Bullets");
		}
		public override void SetDefaults()    
		{
                
			item.damage = 47;   
			item.crit = 17;
			item.ranged = true;           
			item.width = 94;    		
			item.useAmmo = AmmoID.Bullet; 
			item.height = 40;          
			item.useTime = 2;                                
			item.useAnimation = 2;                                                                               
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 7777777;                        
			item.rare = 7;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = 10;                     
			item.shootSpeed = 27f; 
			item.UseSound = SoundID.Item11;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 55f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			if (type != ProjectileID.ChlorophyteBullet)
			{
				type = ProjectileID.ChlorophyteBullet;
			}
			
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		} // return false because we don't want tmodloader to shoot projectile
		

		
public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChainGun, 1);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 17);
			recipe.AddIngredient(ItemID.SoulofSight, 30);
			recipe.AddIngredient(ItemID.SoulofLight, 50);
			recipe.AddIngredient(null , "OvercoaledSteel", 15);
			recipe.AddIngredient(null , "StableFabric", 3);
			recipe.AddIngredient(null , "IllegalWeaponInstructions", 1);
			recipe.AddIngredient(null , "LensAssemblage", 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddTile(TileID.Pearlstone);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
		}



	}

}