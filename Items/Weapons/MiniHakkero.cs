using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class MiniHakkero : ModItem          
	{
		int mode = 0;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mini Hakkero");
			Tooltip.SetDefault("Right Click to change modes");
		}
		public override void SetDefaults()    
		{
            if (mode == 0){
			item.damage = 400;   
			item.crit = 23;
			item.magic = true;     
			item.mana = 5;
			item.width = 80;    		
			item.height = 177;          
			item.useTime = 20;                                
			item.useAnimation = 20; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   		
			item.value = 99999999;                        
			item.rare = 8;
			item.expert = true;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 0.2f;
			item.shoot = mod.ProjectileType("CoDLT");                     
			item.shootSpeed = 67f; 
			item.UseSound = SoundID.Item13;
				}	
				else if (mode == 1)
				{
				item.damage = 800;   
			item.crit = 23;
			item.magic = true;     
			item.mana = 12;
			item.width = 80;    		
			item.height = 177;          
			item.useTime = 20;                                
			item.useAnimation = 20; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   			
			item.value = 99999999; 
			item.expert = true;
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 0.2f;
			item.shoot = mod.ProjectileType("CoDLTD");                     
			item.shootSpeed = 67f; 
			item.UseSound = SoundID.Item13;
				}
				else if (mode == 2)
				{
				item.damage = 1600;   
			item.crit = 23;
			item.magic = true;     
			item.mana = 30;
			item.width = 80;    		
			item.height = 177;          
			item.useTime = 20;                                
			item.useAnimation = 20; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   		
			item.value = 99999999; 
			item.expert = true;			
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 0.2f;
			item.shoot = mod.ProjectileType("CoDLTF");                     
			item.shootSpeed = 67f; 
			item.UseSound = SoundID.Item13;
				}  

		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		
public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.autoReuse = false;
				item.reuseDelay = 30;
				item.useAnimation = 30;
				item.useTime = 12;
				mode++;
				if (mode > 2)
				{
					mode = 0;
				}
			
			}
			else
			{
				              
			if (mode == 0){
			item.damage = 400;   
			item.crit = 23;
			item.magic = true;     
			item.mana = 5;
			item.width = 80;    		
			item.height = 177;          
			item.useTime = 20;                                
			item.useAnimation = 20; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   		
			item.value = 99999999;                        
			item.rare = 8;
			item.expert = true;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 0.2f;
			item.shoot = mod.ProjectileType("CoDLT");                     
			item.shootSpeed = 67f; 
			item.UseSound = SoundID.Item13;
				}	
				else if (mode == 1)
				{
				item.damage = 800;   
			item.crit = 23;
			item.magic = true;     
			item.mana = 12;
			item.width = 80;    		
			item.height = 177;          
			item.useTime = 20;                                
			item.useAnimation = 20; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   			
			item.value = 99999999; 
			item.expert = true;
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 0.2f;
			item.shoot = mod.ProjectileType("CoDLTD");                     
			item.shootSpeed = 67f; 
			item.UseSound = SoundID.Item13;
				}
				else if (mode == 2)
				{
				item.damage = 1600;   
			item.crit = 23;
			item.magic = true;     
			item.mana = 30;
			item.width = 80;    		
			item.height = 177;          
			item.useTime = 20;                                
			item.useAnimation = 20; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   		
			item.value = 99999999; 
			item.expert = true;			
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 0.2f;
			item.shoot = mod.ProjectileType("CoDLTF");                     
			item.shootSpeed = 67f; 
			item.UseSound = SoundID.Item13;
				}  
			}
			return base.CanUseItem(player);
		}

	}

}