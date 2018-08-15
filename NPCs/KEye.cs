using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace Minigun.NPCs            //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	
    public class KEye : ModNPC
    {
		int projectileTimer9 = 0;
	
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kramnium Eye");
		
		}
        
        public override void SetDefaults()
        {
  //the name displayed when hovering over the npc ingame.
            npc.friendly = false;  //this defines if the npc can hur you or not()
			npc.damage = 50;
			npc.scale = 0.75f;
            npc.width = 76; //the npc sprite width
            npc.height = 48;  //the npc sprite height
            npc.aiStyle = 2; //this is the npc ai style, 7 is Pasive Ai
            npc.defense = 10;  //the npc defense
            npc.lifeMax = 250;// the npc life
            npc.HitSound = SoundID.NPCHit1;  //the npc sound when is hit
            npc.DeathSound = SoundID.NPCDeath1;  //the npc sound when he dies
            npc.knockBackResist = 0.5f;  //the npc knockback resistance
            Main.npcFrameCount[npc.type] = 2; //this defines how many frames the npc sprite sheet has
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 150; //this defines the npc danger detect range
            NPCID.Sets.AttackType[npc.type] = 2; //this is the attack type,  0 (throwing), 1 (shooting), or 2 (magic). 3 (melee)
            NPCID.Sets.AttackTime[npc.type] = 30; //this defines the npc attack speed
            NPCID.Sets.AttackAverageChance[npc.type] = 10;//this defines the npc atack chance
            animationType = NPCID.DemonEye;  //this copy the guide animation
        }
		
		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 235, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 2.0f);
				}
			}
		}
		
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
{
	if (!Main.dayTime)
	{
	return .1f;
	}
else
	{
	return 0f;
	}
}

		public override void NPCLoot()
{
	if (Main.rand.NextFloat() < .25f)
	{
	Item.NewItem(npc.getRect(), mod.ItemType("KLens"),Main.rand.Next(1, 4));
	}
}
       public override void AI()
	   {
		if(projectileTimer9++ == 350)
                    {
                        Main.PlaySound(SoundID.Item33, npc.position); // plays a sound
                           
                        Player player = Main.player[npc.target];
                           
                        float projectileSpeed = 12f;  // The speed of your projectile (in pixels per second).
                        int damage = 35;  // The damage your projectile deals.
                        float knockBack = 10;
                        int type = 100; // The type of the projectile you want to shoot.
                           
                        Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) -
                            new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
                       
                        Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
                       
                        projectileTimer9 = 0;
						int numberProjectiles = 4 + Main.rand.Next(4); // 4 or 5 shots
					for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) -
                            new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2).RotatedByRandom(MathHelper.ToRadians(1)); // 30 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				// float scale = 1f - (Main.rand.NextFloat() * .3f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, Main.myPlayer);
			}
			
                    }
	   }
 
    }
}