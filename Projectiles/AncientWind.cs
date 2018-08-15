using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class AncientWind : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Wind");
		}
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ChlorophyteBullet);
		
		}
		public override void AI()
{
 
    int dust = Dust.NewDust(
    projectile.position,					//position
    projectile.width,                                           //box width
    projectile.height,                                          //box height
    102,                                                          //type
    projectile.velocity.X,					//X velocity
    projectile.velocity.Y,		                        //Y velocity
    60,                                                         //alpha
    new Color(),                                                //Color override
    5.0f                                                        //scale
    );
    Main.dust[dust].noGravity = true;

    projectile.rotation += 0.2f;

}
		
	}
}