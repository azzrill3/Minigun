using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class AncientWindHostile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Wind Hostile");
		}
		public override void SetDefaults()
		{
			projectile.velocity.X = 5;
            projectile.velocity.Y = 5;			
            projectile.width = 10;
            projectile.height = 10;
			projectile.aiStyle = 1;
            projectile.friendly = false;
			projectile.hostile = true;
            projectile.penetrate = 1;  
            projectile.tileCollide = false; 
            projectile.magic = true;
            projectile.hide = true;

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