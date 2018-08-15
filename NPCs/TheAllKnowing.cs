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
	
	[AutoloadHead]
    public class TheAllKnowing : ModNPC
    {
	
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The All Knowing One");
		
		}
        
        public override void SetDefaults()
        {
  //the name displayed when hovering over the npc ingame.
            npc.townNPC = true; //This defines if the npc is a town Npc or not
            npc.friendly = true;  //this defines if the npc can hur you or not()
            npc.width = 18; //the npc sprite width
            npc.height = 46;  //the npc sprite height
            npc.aiStyle = 7; //this is the npc ai style, 7 is Pasive Ai
            npc.defense = 99;  //the npc defense
            npc.lifeMax = 999;// the npc life
            npc.HitSound = SoundID.NPCHit1;  //the npc sound when is hit
            npc.DeathSound = SoundID.NPCDeath1;  //the npc sound when he dies
            npc.knockBackResist = 0.5f;  //the npc knockback resistance
            Main.npcFrameCount[npc.type] = 26; //this defines how many frames the npc sprite sheet has
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 150; //this defines the npc danger detect range
            NPCID.Sets.AttackType[npc.type] = 2; //this is the attack type,  0 (throwing), 1 (shooting), or 2 (magic). 3 (melee)
            NPCID.Sets.AttackTime[npc.type] = 30; //this defines the npc attack speed
            NPCID.Sets.AttackAverageChance[npc.type] = 10;//this defines the npc atack chance
            NPCID.Sets.HatOffsetY[npc.type] = 4; //this defines the party hat position
            animationType = NPCID.Guide;  //this copy the guide animation
        }
       
		
		public override bool CanTownNPCSpawn(int numTownNPCs, int money) //Whether or not the conditions have been met for this town NPC to be able to move into town.
        {
            if (NPC.downedSlimeKing)  //so after the EoC is killed
            {
                return true;
            }
            return false;
        }
        public override bool CheckConditions(int left, int right, int top, int bottom)    //Allows you to define special conditions required for this town NPC's house
        {
            return true;  //so when a house is available the npc will  spawn
        }
		
        public override string TownNPCName()     //Allows you to give this town NPC any name when it spawns
        {
            switch (WorldGen.genRand.Next(6))
            {
                case 0:
                    return "G.L.A.S.S";
                case 1:
                    return "Lamp";
                case 2:
                    return "Heisenberg";
                case 3:
                    return "Space";
                case 4:
                    return "Dark";
                case 5:
                    return "Main";
                default:
                    return "Dude";
            }
        }
 
        public override void SetChatButtons(ref string button, ref string button2)  //Allows you to set the text for the buttons that appear on this town NPC's chat window.
        {
            button = "Shop";   //this defines the buy button name
        }
        public override void OnChatButtonClicked(bool firstButton, ref bool openShop) //Allows you to make something happen whenever a button is clicked on this town NPC's chat window. The firstButton parameter tells whether the first button or second button (button and button2 from SetChatButtons) was clicked. Set the shop parameter to true to open this NPC's shop.
        {
 
            if (firstButton)
            {
                openShop = true;   //so when you click on buy button opens the shop
            }
        }
 
        public override void SetupShop(Chest shop, ref int nextSlot)       //Allows you to add items to this town NPC's shop. Add an item by setting the defaults of shop.item[nextSlot] then incrementing nextSlot.
        {
			shop.item[nextSlot].SetDefaults(ItemID.Glass);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("TimeManip"));  //this is an example of how to add a modded item
            nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("BookofLife"));  //this is an example of how to add a modded item
            nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("ShortSword"));  //this is an example of how to add a modded item
            nextSlot++;
            if (NPC.downedBoss1)   //this make so when the king slime is killed the town npc will sell this
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("BookofLife2"));  //an example of how to add a vanilla terraria item
                nextSlot++;
            }
			
            if (NPC.downedBoss3)   //this make so when Skeletron is killed the town npc will sell this
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("BookofLife3"));
                nextSlot++;
				
            }
			if (Main.hardMode)   //this make so when Skeletron is killed the town npc will sell this
            {
				
                shop.item[nextSlot].SetDefaults(mod.ItemType("BookofLife4"));
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.AnkhCharm);
				nextSlot++;
				if (!Main.dayTime)   //this make so when Skeletron is killed the town npc will sell this
            {
                shop.item[nextSlot].SetDefaults(ItemID.SoulofNight);
                nextSlot++;
				
            }
			if (Main.dayTime)   //this make so when Skeletron is killed the town npc will sell this
            {
                shop.item[nextSlot].SetDefaults(ItemID.SoulofLight);
                nextSlot++;
				
            }
				
			}
			if (!Main.dayTime)   //this make so when Skeletron is killed the town npc will sell this
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("KKnife"));
                nextSlot++;
				
            }
			if (Main.hardMode)   //this make so when Skeletron is killed the town npc will sell this
            {
				if (Main.eclipse)
				{
                shop.item[nextSlot].SetDefaults(mod.ItemType("MiniHakkero"));
                nextSlot++;
				}
				if (Main.bloodMoon)
				{
				
						shop.item[nextSlot].SetDefaults(mod.ItemType("KLiquid"));
						nextSlot++;
			
                shop.item[nextSlot].SetDefaults(mod.ItemType("PrimalMana"));
                nextSlot++;
				
				}
            }
			if (!Main.hardMode)
			{
				if (Main.time > 54000 - 1799) 
				{
					if (Main.time < 54000 - 1750)
				{
					shop.item[nextSlot].SetDefaults(mod.ItemType("OldScissors"));
					nextSlot++;
				}
				}
			}
 
        }
 
        public override string GetChat()       //Allows you to give this town NPC a chat message when a player talks to it.
        {
            
            switch (Main.rand.Next(5))    //this are the messages when you talk to the npc
            {
                case 0:
                    return "My blade is made from Kramnium - the most powerful material";
                case 1:
                    return "My shaft is made from Dark Steel - the only material that can hold such a destructive power";
                case 2:
                    return "Kramnium is a red material that has enough power to kill the Moon Lord instantly, the only thing you should do is transfer this power into damage...";
                case 3:
                    return "Kramnium ore can light up half of a cave";
				case 4:
                    return "Want some glass XD?";
				default:
                    return "Hi)))";
 
            }
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)//  Allows you to determine the damage and knockback of this town NPC attack
        {
            damage = 329;  //npc damage
            knockback = 2f;   //npc knockback
        }
 
        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)  //Allows you to determine the cooldown between each of this town NPC's attack. The cooldown will be a number greater than or equal to the first parameter, and less then the sum of the two parameters.
        {
            cooldown = 5;
            randExtraCooldown = 10;
        }
        //------------------------------------This is an example of how to make the npc use a sward attack-------------------------------
        /*public override void DrawTownAttackSwing(ref Texture2D item, ref int itemSize, ref float scale, ref Vector2 offset)//Allows you to customize how this town NPC's weapon is drawn when this NPC is swinging it (this NPC must have an attack type of 3). Item is the Texture2D instance of the item to be drawn (use Main.itemTexture[id of item]), itemSize is the width and height of the item's hitbox
        {
            scale = 1f;
            item = Main.itemTexture[mod.ItemType("CustomSword")]; //this defines the item that this npc will use
            itemSize = 56;
        }
 
        public override void TownNPCAttackSwing(ref int itemWidth, ref int itemHeight) //  Allows you to determine the width and height of the item this town NPC swings when it attacks, which controls the range of this NPC's swung weapon.
        {
            itemWidth = 56;
            itemHeight = 56;
        }
		*/
 
        //----------------------------------This is an example of how to make the npc use a gun and a projectile ----------------------------------
        /*public override void DrawTownAttackGun(ref float scale, ref int item, ref int closeness) //Allows you to customize how this town NPC's weapon is drawn when this NPC is shooting (this NPC must have an attack type of 1). Scale is a multiplier for the item's drawing size, item is the ID of the item to be drawn, and closeness is how close the item should be drawn to the NPC.
          {
              scale = 1f;
              item = mod.ItemType("GunName");  
              closeness = 20;
          }
		  */
          public override void TownNPCAttackProj(ref int projType, ref int attackDelay)//Allows you to determine the projectile type of this town NPC's attack, and how long it takes for the projectile to actually appear
          {
              projType = mod.ProjectileType("KMagic");
              attackDelay = 1;
          }
 
          public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)//Allows you to determine the speed at which this town NPC throws a projectile when it attacks. Multiplier is the speed of the projectile, gravityCorrection is how much extra the projectile gets thrown upwards, and randomOffset allows you to randomize the projectile's velocity in a square centered around the original velocity
          {
              multiplier = 7f;
             // randomOffset = 4f;
 
          }  
 
    }
}