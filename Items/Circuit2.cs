using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class Circuit2 : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pistol Circuit");
		}
		public override void SetDefaults()    
		{

			                                  
			item.width = 17; 
			item.height = 26; 
			item.consumable = false;
			item.maxStack = 999;
			                                         
			item.value = 10000;                        
			item.rare = 10;                                   
		}

	
  }

}