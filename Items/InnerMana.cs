using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
	
    public class InnerMana : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Inner Mana");
			Tooltip.SetDefault("+100 Max Mana");
		}
		public override void SetDefaults()    
		{

                                
			item.width = 22;  
			item.consumable = false;
			item.maxStack = 1;
			item.height = 24;                             
			item.value = 150000;                        
			item.rare = 9;    
			item.accessory = true;

		}
		
		
		public override void UpdateAccessory(Player player, bool hideVisual)
{
	player.statManaMax = 300;
}
	}
}