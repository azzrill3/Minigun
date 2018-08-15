using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria;
//using Terraria;
using Terraria.ModLoader;

namespace Minigun.NPCs            //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	
    public class VanillaNPCShop : GlobalNPC
    {
		public static bool g;
		public void Item(Player player)
		{
			g = player.HasItem(mod.ItemType("MagicRifle"));
		}
		
	public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
			//var a = Player.HasItem(mod.ItemType("MagicRifle"));
                if (type == NPCID.ArmsDealer) 
				{
					if (g = true)
					{
						shop.item[nextSlot].SetDefaults(mod.ItemType("MagicRevolver"));
						nextSlot++;
					}
                    if (Main.hardMode) //if it's hardmode the NPC will sell this
                    {
						if (!Main.dayTime)   //this make so when Skeletron is killed the town npc will sell this
						{
							shop.item[nextSlot].SetDefaults(mod.ItemType("Circuit1"));
							nextSlot++;
							shop.item[nextSlot].SetDefaults(mod.ItemType("Circuit2"));
							nextSlot++;
							shop.item[nextSlot].SetDefaults(mod.ItemType("Corpse1"));
							nextSlot++;
							shop.item[nextSlot].SetDefaults(mod.ItemType("Corpse2"));
							nextSlot++;
						}
						if (Main.bloodMoon)
						{
							shop.item[nextSlot].SetDefaults(mod.ItemType("BookofAccurancy"));  //this is an example of how to add your item
							nextSlot++;
						}
						if (Main.eclipse)
						{
							shop.item[nextSlot].SetDefaults(mod.ItemType("IllegalWeaponInstructions"));  //this is an example of how to add your item
							nextSlot++;
						}
					}	
				}
				if (type == NPCID.Demolitionist)
					{
                    if (Main.hardMode) //if it's hardmode the NPC will sell this
                    {
						
						if (Main.bloodMoon)
						{
							shop.item[nextSlot].SetDefaults(mod.ItemType("OFlask"));  //this is an example of how to add your item
							nextSlot++;
						}
						
					}	
				}
				if (type == NPCID.WitchDoctor)
					{
                    if (Main.hardMode) //if it's hardmode the NPC will sell this
                    {
						
						if (Main.bloodMoon)
						{
							shop.item[nextSlot].SetDefaults(mod.ItemType("UVaccine"));  //this is an example of how to add your item
							nextSlot++;
						}
						
					}	
				}
				if (type == NPCID.Cyborg)
					{
                    if (Main.hardMode) //if it's hardmode the NPC will sell this
                    {
						
						if (Main.bloodMoon)
						{
							shop.item[nextSlot].SetDefaults(mod.ItemType("RottenEye"));  //this is an example of how to add your item
							nextSlot++;
						}
						
					}	
				}
				if (type == NPCID.Clothier)
					{
						shop.item[nextSlot].SetDefaults(mod.ItemType("ACape"));  //this is an example of how to add your item
						nextSlot++;
						shop.item[nextSlot].SetDefaults(mod.ItemType("ObitoMask"));  //this is an example of how to add your item
						nextSlot++;
					}
			
		}         
	}
}