using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class KMagic : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("KMagic");
		}
		public override void SetDefaults()
		{
            projectile.width = 10;
            projectile.height = 10;
            projectile.friendly = true;     //this defines if the projectile is frendly
            projectile.penetrate = -1;  //this defines the projectile penetration, -1 = infinity
            projectile.tileCollide = true;   //this defines if the tile can colide with walls
            projectile.magic = true;
			projectile.idStaticNPCHitCooldown = -1;
            projectile.hide = true;
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