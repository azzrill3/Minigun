using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Projectiles
{
	public class CKnife : ModProjectile
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
            projectile.hide = false;
			
		}
		public override void AI()
{
	Lighting.AddLight(projectile.position, 1f, 0f, 0f);
  
    projectile.rotation += 0.2f;

}
		
		
	}
}