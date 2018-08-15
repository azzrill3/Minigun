using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class RottenEye : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotten Eye");
			Tooltip.SetDefault("Now you scare them!"
			+"\nImmunity to Tongued, Blackout, Horrified, Stinky, Moon Bite and Obsrtucted");
		}
		
		public override void SetDefaults()    
		{                    
			item.width = 14; 
			item.height = 40; 
			item.consumable = false;
			item.accessory = true;
			item.maxStack = 1;                                        
			item.value = 100000; 
			item.useTime = 10;
			item.useAnimation = 10;
			item.rare = 3;
			item.useStyle = 1;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
{
	player.buffImmune[38] = true;
	player.buffImmune[37] = true;
	player.buffImmune[80] = true;
	player.buffImmune[120] = true;
	player.buffImmune[145] = true;
	player.buffImmune[163] = true;
}
		

  }

}