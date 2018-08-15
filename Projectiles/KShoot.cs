using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class KShoot : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kramnium Bullet");
		}
		public override void SetDefaults()
		{
		
	
            projectile.CloneDefaults(ProjectileID.BulletHighVelocity);
			aiType = ProjectileID.BulletHighVelocity;
		}
		public override void AI()
{
	Lighting.AddLight(projectile.position, 1f, 0f, 0f);
	projectile.alpha = 10;
	
	

}	
		
	}
}