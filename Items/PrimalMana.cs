using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
	
    public class PrimalMana : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Primal Mana");
			Tooltip.SetDefault("+ 200 Max Mana");
		}
		public override void SetDefaults()    
		{
                                 
			item.width = 22;  
			item.consumable = false;
			item.maxStack = 1;
			item.height = 24;                             
			item.value = 850000;                        
			item.rare = -1;    
			item.accessory = true;

		}
		
		
		public override void UpdateAccessory(Player player, bool hideVisual)
{
	player.statManaMax2 +=  200;
}
	}
}