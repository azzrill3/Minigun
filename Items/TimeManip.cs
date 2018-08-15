using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class TimeManip : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Time Manipulator");
			Tooltip.SetDefault("'Made from Kramnium, Dark Steel and Sun Alloy' as inscription says");
		}
		public override void SetDefaults()    
		{
                                  
			item.width = 30; 
			item.height = 30; 
			item.consumable = false;
			item.maxStack = 1;                                         
			item.value = 100000; 
			item.useTime = 10;
			item.useAnimation = 10;
			item.rare = 8;
			item.useStyle = 1;
		}

public override bool UseItem(Player player)
		{
			
			
				if (Main.dayTime)
				{
					Main.time = 54000;
				}
				else
				{
					Main.time = 32400;
				}
				
			
			return true;
		}
	
  }

}