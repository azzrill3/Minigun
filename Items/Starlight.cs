using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Windows.Forms;
using System.Timers;

namespace Minigun.Items
{
    public class Starlight : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Botteled Starlight");
			Tooltip.SetDefault("Used to make astral things");
		}

		public override void SetDefaults()    
		{
                                
			item.width = 20; 
			item.height = 26; 
			item.consumable = false;
			item.maxStack = 64; 			
			item.value = 10000;                        
			item.rare = 9;                                   
		}

   }

}