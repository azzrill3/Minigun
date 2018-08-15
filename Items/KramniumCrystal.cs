using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class KramniumCrystal : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kramnium Crystals");
			Tooltip.SetDefault("Pulsing with destructive energy");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 25; 
			item.height = 18; 
			item.consumable = false;
			item.maxStack = 999;
			                                         
			item.value = 10000;                        
			item.rare = 10;                                   
		}

	
  }

}