using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
	
    public class PureMana : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pure Mana");
			Tooltip.SetDefault("+400 Max Mana");
		}
		public override void SetDefaults()    
		{
                                 
			item.width = 22;  
			item.consumable = false;
			item.maxStack = 1;
			item.height = 24;                             
			item.value = 150000;                        
			item.rare = 10;    
			item.accessory = true;
		}
		
		
		public override void UpdateAccessory(Player player, bool hideVisual)
{
	player.statManaMax = 600;
}
	}
}