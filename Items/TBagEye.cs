using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class TBagEye : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}
		public override void SetDefaults()    
		{                                 
			item.width = 32; 
			item.height = 32; 
			item.consumable = false;
			item.maxStack = 999; 
			item.expert = true;
			item.value = 0;                        
			item.rare = 8; 
			bossBagNPC = mod.NPCType("PEye");
		}
	public override bool CanRightClick()
		{
			return true;
		}
		public override void OpenBossBag(Player player)
		{
			player.TryGettingDevArmor();
			player.TryGettingDevArmor();
			
			switch (Main.rand.Next(0,6))
			{
				case 0:
            player.QuickSpawnItem(mod.ItemType("SinSoul"), Main.rand.Next(25,35));
			break;
			case 1:
            player.QuickSpawnItem(mod.ItemType("SinSoul1"), Main.rand.Next(25,35));
			break;
			case 2:
            player.QuickSpawnItem(mod.ItemType("SinSoul2"), Main.rand.Next(25,35));
			break;
			case 3:
            player.QuickSpawnItem(mod.ItemType("SinSoul3"), Main.rand.Next(25,35));
			break;
			case 4:
            player.QuickSpawnItem(mod.ItemType("SinSoul4"), Main.rand.Next(25,35));
			break;
			case 5:
            player.QuickSpawnItem(mod.ItemType("SinSoul5"), Main.rand.Next(25,35));
			break;
			case 6:
            player.QuickSpawnItem(mod.ItemType("SinSoul6"), Main.rand.Next(25,35));
			break;
			}
			int Chance = Main.rand.Next(0,99);
			if (Chance <= 14)
			{
				switch (Main.rand.Next(0,1))
				{
					case 0:
					player.QuickSpawnItem(mod.ItemType("RockCannon"), 1);
					break;
					case 1:
					player.QuickSpawnItem(mod.ItemType("BGSaw"), 1);
					break;
				}
			}
			
		}
  }

}