using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.NPCs.Bosses
{
	[AutoloadBossHead]
    public class PEye : ModNPC
    {
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eye of Pain");
		}
        public override void SetDefaults()
        {
  
            npc.aiStyle = 5;  //5 is the flying AI
            npc.lifeMax = 105000;   //boss life
            npc.damage = 100;  //boss damage
            npc.defense = 40;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 166;
            npc.height = 110;
            animationType = NPCID.DemonEye;   //this boss will behavior like the DemonEye
            Main.npcFrameCount[npc.type] = 3;    //boss frame/animation 
            npc.value = Item.buyPrice(2, 40, 75, 45);
            npc.npcSlots = 10f;
            npc.boss = true;  
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.buffImmune[24] = true;
            music = MusicID.Boss2;
            npc.netAlways = false;
			bossBag = mod.ItemType("TBagEye");
        }
       
        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.GreaterHealingPotion;
			if (Main.expertMode)
			{
				npc.DropBossBags();
			}
			else
			{
			switch (Main.rand.Next(0,6))
			{
				case 0:
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SinSoul"), Main.rand.Next(20,30));
			break;
			case 1:
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SinSoul1"), Main.rand.Next(20,30));
			break;
			case 2:
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SinSoul2"), Main.rand.Next(20,30));
			break;
			case 3:
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SinSoul3"), Main.rand.Next(20,30));
			break;
			case 4:
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SinSoul4"), Main.rand.Next(20,30));
			break;
			case 5:
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SinSoul5"), Main.rand.Next(20,30));
			break;
			case 6:
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SinSoul6"), Main.rand.Next(20,30));
			break;
			}
			int Chance = Main.rand.Next(0,99);
			
			if (Chance <= 9)
			{
				switch (Main.rand.Next(0,1))
				{
					case 0:
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RockCannon"), 1);
					break;
					case 1:
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BGSaw"), 1);
					break;
				}
			}
			}
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);  //boss life scale in expertmode
            npc.damage = (int)(npc.damage * 0.6f);  //boss damage increase in expermode
        }
		public override void AI()
        {
            npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;
			
		npc.ai[1]++;
            if (npc.ai[1] >= 50 && npc.ai[1] <= 60)  // 230 is projectile fire rate
			{
            
                float Speed = 20f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 60;  //projectile damage
                int type = 100;  //put your projectile
                Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                
			
			}
            
			if (npc.ai[1] >= 100 && npc.ai[1] <= 100)
			{
                float Speed = 60f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 50;  //projectile damage
                int type = mod.ProjectileType("GScythe");  //put your projectile
                Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
					int numberProjectiles = 10; // 4 or 5 shots
					for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2) -
                            new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2).RotatedByRandom(MathHelper.ToRadians(3)); // 30 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				// float scale = 1f - (Main.rand.NextFloat() * .3f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, perturbedSpeed.X, perturbedSpeed.Y, type, damage, 0, Main.myPlayer);
			}
			}
			if (npc.ai[1] >= 150 && npc.ai[1] <= 150)
			{
                float Speed = 20f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 200;  //projectile damage
                int type = mod.ProjectileType("IShoot");  //put your projectile
                Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
					int numberProjectiles = 7; // 4 or 5 shots
					for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2) -
                            new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2).RotatedByRandom(MathHelper.ToRadians(1)); // 30 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				// float scale = 1f - (Main.rand.NextFloat() * .3f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, perturbedSpeed.X, perturbedSpeed.Y, type, damage, 0, Main.myPlayer);
			}
			}
			if (npc.ai[1] >= 200 && npc.ai[1] <= 200)
			{
                float Speed = 20f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 50;  //projectile damage
                int type = mod.ProjectileType("BLaserH");  //put your projectile
                Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
					int numberProjectiles = 5; // 4 or 5 shots
					for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2) -
                            new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2).RotatedByRandom(MathHelper.ToRadians(1)); // 30 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				// float scale = 1f - (Main.rand.NextFloat() * .3f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, perturbedSpeed.X, perturbedSpeed.Y, type, damage, 0, Main.myPlayer);
			}
				
			}
			 if (npc.ai[1] >= 250 && npc.ai[1] <= 253)  // 230 is projectile fire rate
			{
            
                float Speed = 20f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 60;  //projectile damage
                int type = 684;  //put your projectile
                Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 0;
			
			}
		
    }
}
}