using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class BrimK : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kramnium Brimstone");
		}
		public override void SetDefaults()
		{
			projectile.velocity.X = 5;
            projectile.velocity.Y = 5;			
            projectile.width = 12;
			projectile.timeLeft = 25;
            projectile.height = 32;
			projectile.aiStyle = 1;
            projectile.friendly = true; 
            projectile.penetrate = -1;  
            projectile.tileCollide = true; 
            projectile.magic = true;
            projectile.hide = true;
			aiType = ProjectileID.Bullet;
		}
		public override void AI()
{
	Lighting.AddLight(projectile.position, 1f, 0f, 0f);
    int dust = Dust.NewDust(
    projectile.position,					//position
    projectile.width,                                           //box width
    projectile.height,                                          //box height
    235,                                                          //type
    projectile.velocity.X,					//X velocity
    projectile.velocity.Y,		                        //Y velocity
    0,                                                         //alpha
    new Color(),                                                //Color override
    2.0f                                                        //scale
    );
    Main.dust[dust].noGravity = true;

    projectile.rotation += 0.2f;

}
		
	}
}