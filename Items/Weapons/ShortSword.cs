using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class ShortSword : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Short-Sword");
			Tooltip.SetDefault("Half Short and half Sword - Completely awesome...");
		}
		public override void SetDefaults()    
		{
               
			item.damage = 20;   
			item.crit = 15;
			item.melee = true;  
			item.material = true;
			item.width = 28;    		
			item.height = 48;          
			item.useTime = 17;                                
			item.useAnimation = 17; 
			item.noMelee = false;                      
			item.useStyle = 1; 			
			item.knockBack = 6;                    
			item.value = 50000;                        
			item.rare = 3;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;                     
			item.UseSound = SoundID.Item1;
	
		}
		
		 
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
		
			if (player.altFunctionUse == 2)
			{
				item.useStyle = 3;
				item.useTime = 15;
				item.useAnimation = 15;
				item.damage = 20;
				item.autoReuse = true;
			}
			else
			{
				item.useStyle = 1;
				item.useTime = 17;
				item.useAnimation = 17;
				item.damage = 20;
				item.autoReuse = true;
			}
			return base.CanUseItem(player);
		}

	}
}