using Microsoft.Xna.Framework;
using Terraria;
using Microsoft.Xna.Framework.Graphics;
using System.IO;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class Test : ModProjectile
	{
		public override void SetStaticDefaults()
{
Main.projFrames[projectile.type] = 6;
}

public override void SetDefaults()
{
projectile.width = 90;
projectile.height = 90;
projectile.aiStyle = 20;
projectile.friendly = true;
projectile.penetrate = -1;
projectile.tileCollide = false;
projectile.hide = true;
projectile.ownerHitCheck = true; //so you can't hit enemies through walls
projectile.melee = true;
}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
{
target.immune[projectile.owner] = 1;
}

public override Color? GetAlpha(Color lightColor)
{
//return Color.White;
return new Color(255, 255, 255, 0) * (1f - (float)projectile.alpha / 255f);
}

public override void AI()
{
	Lighting.AddLight(projectile.position, 3f, 0f, 0f);
	projectile.alpha = 0;
// Slow down
projectile.velocity *= 0.98f;
// Loop through the 4 animation frames, spending 5 ticks on each.
if (++projectile.frameCounter >= 2)
{
projectile.frameCounter = 0;
if (++projectile.frame >= 6)
{
projectile.frame = 0;
}
}

projectile.direction = (projectile.spriteDirection = ((projectile.velocity.X > 0f) ? 1 : -1));
projectile.rotation = projectile.velocity.ToRotation();
if (projectile.velocity.Y > 16f)
{
projectile.velocity.Y = 16f;
}
// Since our sprite has an orientation, we need to adjust rotation to compensate for the draw flipping.
if (projectile.spriteDirection == -1)
projectile.rotation += MathHelper.Pi;
}

// Some advanced drawing because the texture image isn't centered or symetrical.
public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
{
SpriteEffects spriteEffects = SpriteEffects.None;
if (projectile.spriteDirection == -1)
{
spriteEffects = SpriteEffects.FlipHorizontally;
}
Texture2D texture = Main.projectileTexture[projectile.type];
int frameHeight = Main.projectileTexture[projectile.type].Height / Main.projFrames[projectile.type];
int startY = frameHeight * projectile.frame;
Rectangle sourceRectangle = new Rectangle(0, startY, texture.Width, frameHeight);
Vector2 origin = sourceRectangle.Size() / 2f;
origin.X = (float)((projectile.spriteDirection == 1) ? (sourceRectangle.Width - 40) : 40);

Color drawColor = projectile.GetAlpha(lightColor);
Main.spriteBatch.Draw(texture,
projectile.Center - Main.screenPosition + new Vector2(0f, projectile.gfxOffY),
sourceRectangle, drawColor, projectile.rotation, origin, projectile.scale, spriteEffects, 0f);

return false;
}
}
}