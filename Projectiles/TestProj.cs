using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class TestProj : ModProjectile
	{
		
		int n = 0;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("TestProj");
		}
		public override void SetDefaults()
		{
		
					
            projectile.width = 1;
            projectile.height = 1;
			projectile.aiStyle = 1;
            projectile.friendly = true; 
            projectile.penetrate = -1;  
            projectile.tileCollide = true; 
            projectile.ranged = true;
            projectile.hide = false;
			aiType = 405;
			projectile.timeLeft = 1000;
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 100;
			ProjectileID.Sets.TrailingMode[projectile.type] = 75;
		}
		public override void AI()
{
	
	
	
	int num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 0.5f + 1f, projectile.position.Y + 1f - projectile.velocity.Y * 0.5f), 1, 1, 107, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
Main.dust[num309].velocity *= -0.25f;
num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 0.5f + 1f, projectile.position.Y + 1f - projectile.velocity.Y * 0.5f), 1, 1, 107, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
Main.dust[num309].velocity *= -0.25f;
Main.dust[num309].position -= projectile.velocity * 0.5f;
/*num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 1, 1, 75, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
Main.dust[num309].noGravity = true;
Main.dust[num309].velocity *= -0.25f;
Main.dust[num309].position -= projectile.velocity * 0.6f;
num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 1, 1, 75, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
Main.dust[num309].noGravity = true;
Main.dust[num309].velocity *= -0.25f;
Main.dust[num309].position -= projectile.velocity * 0.4f;
num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 1, 1, 75, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
Main.dust[num309].noGravity = true;
Main.dust[num309].velocity *= -0.25f;
Main.dust[num309].position -= projectile.velocity * 0.3f;
num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 1, 1, 75, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
Main.dust[num309].noGravity = true;
Main.dust[num309].velocity *= -0.25f;
Main.dust[num309].position -= projectile.velocity * 0.2f;
num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 1, 1, 75, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
Main.dust[num309].noGravity = true;
Main.dust[num309].velocity *= -0.25f;
Main.dust[num309].position -= projectile.velocity * 0.1f;
num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 1, 1, 75, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
Main.dust[num309].noGravity = true;
Main.dust[num309].velocity *= -0.25f;
Main.dust[num309].position -= projectile.velocity * 0.7f;
num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 1, 1, 75, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
Main.dust[num309].noGravity = true;
Main.dust[num309].velocity *= -0.25f;
Main.dust[num309].position -= projectile.velocity * 0.15f;
num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 1, 1, 75, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
Main.dust[num309].noGravity = true;
Main.dust[num309].velocity *= -0.25f;
Main.dust[num309].position -= projectile.velocity * 0.25f;
num309 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X * 4f + 2f, projectile.position.Y + 2f - projectile.velocity.Y * 4f), 1, 1, 75, projectile.oldVelocity.X, projectile.oldVelocity.Y, 100, default(Color), 1.25f);
Main.dust[num309].noGravity = true;
Main.dust[num309].velocity *= -0.25f;
Main.dust[num309].position -= projectile.velocity * 0.35f;*/
    Main.dust[num309].noGravity = true;
	projectile.velocity.X = projectile.velocity.X * 1.055f;
    projectile.velocity.Y = projectile.velocity.Y * 1.055f;	
    projectile.rotation += 0.0f;
	
	projectile.ai[1]++;
	if(projectile.ai[1] % 10 == 0)
{
    for(int i = 0; i < 200; i++)
    {
       NPC target = Main.npc[i];
       //If the npc is hostile
       if(!target.friendly)
       {
           //Get the shoot trajectory from the projectile and target
           float shootToX = target.position.X + (float)target.width * 0.5f - projectile.Center.X;
           float shootToY = target.position.Y - projectile.Center.Y;
           float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

           //If the distance between the live targeted npc and the projectile is less than 480 pixels
           if(distance < 400f && !target.friendly && target.active && distance > 50f)
           {
               //Divide the factor, 3f, which is the desired velocity
               distance = 30f / distance;
   
               //Multiply the distance by a multiplier if you wish the projectile to have go faster
               shootToX *= distance * 1;
               shootToY *= distance * 1;

               //Set the velocities to the shoot values
               projectile.velocity.X = shootToX;
               projectile.velocity.Y = shootToY;
           }
       }
    }
}
}	
		
	}
}