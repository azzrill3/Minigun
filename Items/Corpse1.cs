using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class Corpse1 : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pistol Corpse");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 100; 
			item.height = 100; 
			item.consumable = false;
			item.maxStack = 999;
			                                         
			item.value = 10000;                        
			item.rare = 10;                                   
		}

	
  }

}