using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class GScythe : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gula Scythe");
		}
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.DeathSickle);
			aiType = ProjectileID.DeathSickle;
			projectile.friendly = false;
            projectile.hostile = true;
			
		}
		public override void AI()
{
	Lighting.AddLight(projectile.position, 1f, 1f, 0f);
	projectile.alpha = 50;
	
	/*int dust = Dust.NewDust(
    projectile.position,					//position
    projectile.width,                                           //box width
    projectile.height,                                          //box height
    56,                                                          //type
    projectile.velocity.X,					//X velocity
    projectile.velocity.Y,		                        //Y velocity
    60,                                                         //alpha
    new Color(),                                                //Color override
    1.1f                                                        //scale
    );
    Main.dust[dust].noGravity = true;*/
}
}
}