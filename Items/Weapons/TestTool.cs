using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
	
    public class TestTool : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Testing Tool");
		}
		public override void SetDefaults()    
		{
              
			item.damage = 99;   
			item.crit = 99;           
			item.width = 174;    		
			item.height = 47;          
			item.useTime = 20;                                
			item.useAnimation = 20; 
			item.channel = false;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 100000;                        
			item.rare = 8;
			item.noUseGraphic = false;
			item.maxStack = 1;                 
			item.autoReuse = false;  
			item.scale = 1;
			item.reuseDelay = 200;
			item.shoot = mod.ProjectileType("MShot");                     
			item.shootSpeed = 10f; 
			item.UseSound = SoundID.Item13;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			item.channel = true;
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("MagicShoot"), damage, knockBack, player.whoAmI);
			return true;
			
		}



}
}