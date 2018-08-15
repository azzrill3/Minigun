using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class BGSaw : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Gold Saw");
			Tooltip.SetDefault("Can be used both as a sword and as a saw"
			+ "\nRight Click to use like a saw"
			+ "\nMore references!");
		}
		public override void SetDefaults()    
		{
                
			item.damage = 130;   
			item.crit = 18;
			item.melee = true;
			item.axe = 0;			
			item.width = 100;    		
			item.height = 100;          
			item.useTime = 8;                                
			item.useAnimation = 8;                                                                               
			item.noMelee = false;                      
			item.useStyle = 1;          
			item.knockBack = 4;                    
			item.value = 100000; 
			item.channel = false;
			item.rare = 8;
			item.noUseGraphic = false;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.mana = 0;
			item.scale = 1;
			item.shoot = 0;                     
			item.shootSpeed = 67f; 
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
				item.shoot = mod.ProjectileType("Saw");
				item.damage = 130;
				item.axe = 200;
				item.useTime = 1;
				item.channel = true;
				item.noUseGraphic = true;
				item.mana = 0;
				item.noMelee = true;
				item.useStyle = 5;
				
				
			}
			else
			{              
			item.damage = 130;
			item.useTime = 8; 
			item.axe = 0;
			item.channel = false;
			item.useAnimation = 8; 
			item.shoot = 0; 
			item.noMelee = false;
			item.noUseGraphic = false;
			item.mana = 0;
			item.useStyle = 1;
			}
			return base.CanUseItem(player);
		}

	}

}