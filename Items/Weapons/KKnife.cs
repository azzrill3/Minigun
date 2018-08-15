using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class KKnife : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kramnium Knife");
			Tooltip.SetDefault("A Knife made from kramnium"
			 + "\nResonates with hardmode spirits...");
		}
		public override void SetDefaults()    
		{
             if (!Main.hardMode){
				item.damage = 30;
				}	
				else
				{
				item.damage = 99;
				}
			   
			item.crit = 80;
			item.magic = true;           
			item.width = 44;    		
			item.height = 42;          
			item.useTime = 15;                                
			item.useAnimation = 15; 
			item.noMelee = false;                      
			item.useStyle = 1; 			
			item.knockBack = 4;                    
			item.value = 1000000;                        
			item.rare = 10;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = mod.ProjectileType("KKnife");                     
			item.shootSpeed = 16f; 
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
				item.useStyle = 1;
				if (!Main.hardMode){
				item.damage = 30;
				}	
				else
				{
				item.damage = 99;
				}
				item.useTime = 18;
				item.useAnimation = 18;
				item.shoot = mod.ProjectileType("KWave");
				item.shootSpeed = 13f;
			}
			else
			{
				item.useStyle = 1;
				if (!Main.hardMode){
				item.damage = 30;
				}	
				else
				{
				item.damage = 99;
				}
				item.useTime = 15;
				item.useAnimation = 15;
				item.shoot = mod.ProjectileType("KKnife");
				item.shootSpeed = 16f;
			}
			return base.CanUseItem(player);
		}



	}

}