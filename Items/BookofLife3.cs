using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class BookofLife3 : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Book of Life Tier 3");
			
		}
		public override void SetDefaults()    
		{

			                 
			item.width = 40;  
			item.mana = 30;
			item.consumable = false;
			item.maxStack = 1;
			item.height = 40;       
			item.useTime = 15;                                
			item.useAnimation = 15;                                                                               
			item.noMelee = true;   
			item.healLife = 40;
			item.useStyle = 4;                        
			item.value = 250000;                        
			item.rare = 7;                      
			item.UseSound = SoundID.Item29;                  
			item.autoReuse = false;                                    
		}
	}
}