using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class BookofLife : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Book of Life");

		}
		public override void SetDefaults()    
		{

                                  
			item.width = 40;  
			item.mana = 20;
			item.consumable = false;
			item.maxStack = 1;
			item.height = 40;       
			item.useTime = 15;                                
			item.useAnimation = 15;                                                                               
			item.noMelee = true;   
			item.healLife = 20;
			item.useStyle = 4;                        
			item.value = 50000;                        
			item.rare = 7;                      
			item.UseSound = SoundID.Item29;                  
			item.autoReuse = false;                                    
		}
	}
}