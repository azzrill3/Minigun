using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class RShoot : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rock Bullet");
		}
		public override void SetDefaults()
		{
		
	
            projectile.CloneDefaults(ProjectileID.BulletHighVelocity);
			aiType = ProjectileID.BulletHighVelocity;
			projectile.width = 4;
			projectile.height = 4;
			projectile.magic = true;
		}
		public override void AI()
{
	Lighting.AddLight(projectile.position, 0f, 0f, 1f);
	projectile.alpha = 10;
	
	

}	
		
	}
}