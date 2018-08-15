using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class Silence : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Silence");
		}
		public override void SetDefaults()
		{
		
					
            projectile.CloneDefaults(ProjectileID.BulletHighVelocity);
			aiType = ProjectileID.BulletHighVelocity;
			projectile.penetrate = -1;  
            projectile.tileCollide = false; 
			projectile.light = 0;
		}

		public override void AI()
{

	projectile.alpha = 255;
	
	

}	
		
	}
}