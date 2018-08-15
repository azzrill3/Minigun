using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class ASick : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Astral Sickle");
		}
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.DeathSickle);
			aiType = ProjectileID.DeathSickle;
			
			
		}
		public override void AI()
{
	
	int dust = Dust.NewDust(
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
    Main.dust[dust].noGravity = true;
}
}
}