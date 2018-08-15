using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class KarosRockmaul : ModItem          
	{
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Karos Rockmaul");

		}
		public override void SetDefaults()    
		{

	               
			item.damage = 35;   
			item.crit = 60;
			item.ranged = true;           
			item.width = 174;    		
			item.height = 47;          
			item.useTime = 8;                                
			item.useAnimation = 6; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 30000;                        
			item.rare = 8;
			Item.staff[item.type] = true;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 0.75f;
			item.shoot = mod.ProjectileType("KRock");                     
			item.shootSpeed = 67f; 
			item.UseSound = SoundID.Item13;
		}

	
	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			item.channel = true;
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("KRock1"), damage, knockBack, player.whoAmI);
			return true;
			
		}

	}

}