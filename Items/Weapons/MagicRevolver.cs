using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class MagicRevolver : ModItem          
	{
		int a;
		int a2;
		int b;
		private int i;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Revolver");
			Tooltip.SetDefault("Zap. Zap. Zap. Zap. Zap. Zap. Click-Clack"
			+ "\nConsumes 1/6 of your mana: The more mana consumed, the more damage you'll deal and more crit chance you'll get"
			+ "\nReplenishes half of your mana on reload"
			+ "\nUses Revolver Bullets as ammo");
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			a = player.statManaMax;
			a2 = player.statManaMax2;
			
			if (player.altFunctionUse == 2)
			{
				item.channel = false;
				item.shoot = 0;
				item.useAmmo = 0;
				item.healMana = 0;
				item.mana = 0;
				item.useTime = 1;
				item.useAnimation = 1;
				item.UseSound = SoundID.Item1;
				item.reuseDelay = 0;
			
			}
			else
				{
			item.mana = (int)(a2/6);   
			item.damage = 15 * (int)(item.mana/10);   
			item.ranged = true; 
			item.crit = 5 * (int)(item.mana/10);          
			item.width = 174;    		
			item.useAmmo = mod.ItemType("RevBullet"); 
			item.height = 47;   
			item.consumable = false;
			item.useTime = 10;                                
			item.useAnimation = 10;                                                                               
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 1000000;                        
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = false; 
			item.scale = 1;
			item.healMana = 0;
			item.shoot = mod.ProjectileType("RevShot");                        
			item.shootSpeed = 67f; 
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/RevShot");
			if(b <= 5)
			{
			if(player.statMana >= item.mana)
			{
				b++;
			}
			}
			else
			{
				b++;
			}
			
			if(b > 6)
			{
				item.useAnimation = 70;
				item.useTime = 70;
				item.healMana = player.statManaMax2/2;
				b = 0;
				item.mana = 0;
				item.shoot = 0;
				item.useAmmo = 0;
				item.useStyle = 5;
				for(i = 0; i < 7; i++)
				{
				Gore.NewGore(player.position, player.velocity, mod.GetGoreSlot("Gores/RShell"), 1f);
				}
				item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/RevReload");
			}
		}
		return base.CanUseItem(player);
		}
		public override void SetDefaults()    
		{
                
			
			item.crit = 60;
			item.mana = (a + a2) - 200;   
			item.damage = 15 * (int)(item.mana/10);   
			item.ranged = true;           
			item.width = 174;    		
			item.useAmmo = mod.ItemType("RevBullet");
			item.height = 47;          
			item.useTime = 100;                                
			item.useAnimation = 100;                                                                               
			item.noMelee = true;                      
			item.useStyle = 5; 
			item.consumable = false;
			item.knockBack = 4;                    
			item.value = 1000000;                        
			item.rare = 8;
			item.healMana = 0;
			item.maxStack = 1;                 
			item.autoReuse = false;  
			item.scale = 1;
			item.shoot = mod.ProjectileType("RevShot");                      
			item.shootSpeed = 67f; 
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/RevShot");
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-7, 2);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			item.channel = false;
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("RevShoot"), damage, knockBack, player.whoAmI);
			return true;
			
		}
		



	}

}