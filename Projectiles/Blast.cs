using Microsoft.Xna.Framework;
using Terraria;
using Microsoft.Xna.Framework.Graphics;
using System.IO;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class Blast : ModProjectile
	{
		public override void SetStaticDefaults()
{
Main.projFrames[projectile.type] = 3;
}

public override void SetDefaults()
{
projectile.width = 4;
projectile.height = 4;
projectile.aiStyle = 1;
projectile.scale = 1.5f;
projectile.friendly = true;
projectile.penetrate = -1;
projectile.tileCollide = false;
projectile.hide = false;
projectile.timeLeft = 5;
projectile.ownerHitCheck = true; //so you can't hit enemies through walls
projectile.melee = true;
}


public override void AI()
{
	if (++projectile.frameCounter >= 5)
			{
				projectile.frameCounter = 0;
				if (++projectile.frame >= 3)
				{
					projectile.frame = 0;
				}
			}
projectile.velocity.X = projectile.velocity.X*0.001f;
projectile.velocity.Y = projectile.velocity.Y*0.001f;
}
}
}