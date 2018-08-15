using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class SinSoul4 : ModItem          
	{
		public override void SetStaticDefaults()
		{
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
			ItemID.Sets.AnimatesAsSoul[item.type] = true;
			ItemID.Sets.ItemIconPulse[item.type] = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
			DisplayName.SetDefault("Soul of Sin");
			Tooltip.SetDefault("Superbia"
			+ "\nOne of many");
		}
		public override void SetDefaults()    
		{
                        
			Item refItem = new Item();
			refItem.SetDefaults(ItemID.SoulofSight);
			item.consumable = false;
			item.maxStack = 99;                                         
			item.value = 10000;                        
			item.rare = 3;                                   
		}

  }

}