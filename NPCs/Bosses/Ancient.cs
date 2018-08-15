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
    public class Ancient : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Mummy");
		}
        public override void SetDefaults()
        {
  
            npc.aiStyle = 3;  //5 is the flying AI
            npc.lifeMax = 42000;   //boss life
            npc.damage = 100;  //boss damage
            npc.defense = 40;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 40;
            npc.height = 56;
            animationType = NPCID.Mummy;   //this boss will behavior like the DemonEye
            Main.npcFrameCount[npc.type] = 15;    //boss frame/animation 
            npc.value = Item.buyPrice(2, 40, 75, 45);
            npc.npcSlots = 10f;
            npc.boss = true;  
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.buffImmune[24] = true;
            music = MusicID.Boss2;
            npc.netAlways = false;
        }
       
        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.GreaterHealingPotion;   //boss drops
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SunAlloy"), 20);
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AncientWind"));
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
            if (npc.ai[1] >= 230)  // 230 is projectile fire rate
            {
                float Speed = 20f;  //projectile speed
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 100;  //projectile damage
                int type = mod.ProjectileType("AncientWindHostile");  //put your projectile
                Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 0;
            }
		
    }
}
}