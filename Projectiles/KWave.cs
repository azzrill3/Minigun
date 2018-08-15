using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class KWave : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kramnium Wave");
		}
		public override void SetDefaults()
		{
		
			projectile.velocity.X = 5;
            projectile.velocity.Y = 5;			
            projectile.width = 56;
            projectile.height = 24;
			projectile.aiStyle = 1;
            projectile.friendly = true; 
            projectile.penetrate = -1;  
            projectile.tileCollide = false; 
			projectile.ownerHitCheck = false;
            projectile.magic = true;
            projectile.hide = false;
			aiType = ProjectileID.Bullet;
		}
		public override void AI()
{
	Lighting.AddLight(projectile.position, 1f, 0f, 0f);
	projectile.alpha = 40;
	int dust = Dust.NewDust(
    projectile.position,					//position
    projectile.width,                                           //box width
    projectile.height,                                          //box height
    235,                                                          //type
    projectile.velocity.X,					//X velocity
    projectile.velocity.Y,		                        //Y velocity
    60,                                                         //alpha
    new Color(),                                                //Color override
    0.8f                                                        //scale
    );
    Main.dust[dust].noGravity = true;

    projectile.rotation += 0.0f;
	

}	
		
	}
}