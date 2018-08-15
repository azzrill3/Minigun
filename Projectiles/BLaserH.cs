using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class BLaserH : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Laser");
		}
		public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;
			projectile.penetrate = -1;
            projectile.timeLeft = 1000;
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
			projectile.hide = true;
            projectile.extraUpdates = 20; //You can change this value to 100 to get a full laser effect
        }
        public override void AI()
        {
            //Projectile appears at 4 ticks
            if(projectile.ai[0] > 3f)
            {
                for(int i = 0; i < 3; i++)
                {
                    int DustID = Dust.NewDust(projectile.position, 1, 1, 113, 0, 0, 0, new Color(0,0,255), 1f);
                    Main.dust[DustID].noGravity = true;
                    Main.dust[DustID].scale *= 1.25f;
                }
            }
            projectile.ai[0] += 1f;
        }
		
	}
}