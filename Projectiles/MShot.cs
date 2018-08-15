using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class MShot : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Shot");
		}
		public override void SetDefaults()
		{
		
					
            projectile.CloneDefaults(ProjectileID.BulletHighVelocity);
			aiType = ProjectileID.BulletHighVelocity;
			projectile.penetrate = -1;  
            projectile.tileCollide = true; 
			projectile.light = 0;
		}

		public override void AI()
{

	projectile.alpha = 255;
	Lighting.AddLight(projectile.position, 1f, 0f, 1f);
	
	

}	
		
	}
}