using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class KS : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kramnium Slash");
		}
		public override void SetDefaults()
		{
		
			projectile.velocity.X = 5;
            projectile.velocity.Y = 5;			
            projectile.width = 80;
            projectile.height = 32;
			projectile.timeLeft = 500;
			projectile.aiStyle = 1;
            projectile.friendly = true; 
            projectile.penetrate = -1;  
            projectile.tileCollide = false; 
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
	Lighting.AddLight(projectile.position, 2f, 0f, 0f);
	projectile.alpha = 80;
	
	

}	
		
	}
}