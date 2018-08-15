using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class SunAlloy : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sun Alloy");
			Tooltip.SetDefault("Glows in a dark");
		}
		public override void SetDefaults()    
		{                                 
			item.width = 30; 
			item.height = 24; 
			item.consumable = false;
			item.maxStack = 999;                                         
			item.value = 10000;                        
			item.rare = 8;                                   
		}
	
  }

}