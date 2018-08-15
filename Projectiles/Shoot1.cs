using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class Shoot1 : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Projectile");
		}
		public override void SetDefaults()
		{
		
			projectile.velocity.X = 5;
            projectile.velocity.Y = 5;			
            projectile.width = 21;
            projectile.height = 28;
			projectile.aiStyle = 1;
			projectile.scale = 0.5f;
            projectile.friendly = true; 
            projectile.penetrate = -1;  
            projectile.tileCollide = true; 
			projectile.ownerHitCheck = false;
            projectile.magic = true;
            projectile.hide = false;
			aiType = ProjectileID.Bullet;
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
{
target.immune[projectile.owner] = 1;
}
		public override void AI()
{
	Lighting.AddLight(projectile.position, 1f, 0f, 0f);
	projectile.alpha = 0;
	
	

}	
		
	}
}