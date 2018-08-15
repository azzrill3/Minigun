using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
	
    public class OldScissors : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Old Scissors");
			Tooltip.SetDefault("It feels cursed...");
		}
		public override void SetDefaults()    
		{
              
			item.damage = 45;
			item.melee = true;
			item.crit = 13;           
			item.width = 67;    		
			item.height = 36;          
			item.useTime = 7;                                
			item.useAnimation = 25; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 10000000;                        
			item.rare = -1;
			item.noUseGraphic = true;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = mod.ProjectileType("OldSlash");                     
			item.shootSpeed = 40f; 
			item.UseSound = SoundID.Item1;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 0.5f;
			
			return true;
		}




	}

}