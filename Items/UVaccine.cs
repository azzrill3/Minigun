using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class UVaccine : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Ultimate Vaccine");
			Tooltip.SetDefault("Immunity to all venom debuffs + immunity to Ichor and Feral Bite");
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
			item.rare = 5;
			item.useStyle = 1;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
{
	player.buffImmune[148] = true;
	player.buffImmune[70] = true;
	player.buffImmune[69] = true;
	player.buffImmune[20] = true;
}
		

  }

}