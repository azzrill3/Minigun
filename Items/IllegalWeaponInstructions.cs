using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class IllegalWeaponInstructions : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Illegal Weapon Instructions");
			Tooltip.SetDefault("Read if you dare!"
			+"\nThe fact that this item is in a mod is illegal");
		}
		public override void SetDefaults()    
		{                                 
			item.width = 30; 
			item.height = 30; 
			item.consumable = false;
			item.maxStack = 1;                                         
			item.value = 500000;                        
			item.rare = 1;                                   
		}
  }

}