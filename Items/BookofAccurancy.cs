using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
	
    public class BookofAccurancy : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Book of Accurancy");
			Tooltip.SetDefault("+20% To all crit chances");
		}
		public override void SetDefaults()    
		{
                                 
			item.width = 22;  
			item.consumable = false;
			item.maxStack = 1;
			item.height = 24;                             
			item.value = 700000;                        
			item.rare = 6;    
			item.accessory = true;

		}
		
		
		public override void UpdateAccessory(Player player, bool hideVisual)
{
	player.meleeCrit += 20;
	player.rangedCrit += 20;
	player.magicCrit += 20;
	player.thrownCrit += 20;
}
	}
}