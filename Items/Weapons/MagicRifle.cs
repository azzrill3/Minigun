using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class MagicRifle : ModItem          
	{
		int a;
		int a2;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Rifle");
			Tooltip.SetDefault("Boom!"
			+ "\nConsumes all mana: The more mana consumed, the more damage you'll deal and more crit chance you'll get"
			+ "\nUses Magic Bullets as ammo");
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
				item.channel = true;
				item.shoot = 0;
				item.useAmmo = 0;
				item.mana = 0;
				item.useTime = 1;
				item.useAnimation = 1;
				item.UseSound = SoundID.Item1;
				item.reuseDelay = 0;
			
			}
			else
				{
			item.mana = a2;   
			item.damage = 50 * (int)(item.mana/10);   
			item.ranged = true; 
			item.crit = (1 * (int)(item.mana/10)) + 10;          
			item.width = 174;    		
			item.useAmmo = mod.ItemType("MBullet"); 
			item.height = 47;          
			item.useTime = 10;                                
			item.useAnimation = 10;                                                                               
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 1000000;                        
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = false; 
			item.reuseDelay = 600;
			item.scale = 1;
			item.shoot = mod.ProjectileType("MShot");                        
			item.shootSpeed = 67f; 
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/MagicRifle");
			if(player.statMana == item.mana)
			{
			Gore.NewGore(player.position, player.velocity, mod.GetGoreSlot("Gores/SShell"), 1f);
			}
		}
		return base.CanUseItem(player);
		}
		public override void SetDefaults()    
		{
                
			
			item.crit = (1 * (int)(item.mana/10)) + 10;    
			item.mana = a2;  
			item.damage = 80 * (int)(item.mana/10);   
			item.ranged = true;           
			item.width = 174;    		
			item.useAmmo = mod.ItemType("MBullet");
			item.height = 47;          
			item.useTime = 100;                                
			item.useAnimation = 100;                                                                               
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 1000000;                        
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = mod.ProjectileType("MShot");                      
			item.shootSpeed = 67f; 
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/MagicRifle");
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-18, 2);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			item.channel = true;
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("MagicShoot"), damage, knockBack, player.whoAmI);
			return true;
			
		}
		
		
public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddIngredient(ItemID.IllegalGunParts, 2);
			recipe.AddIngredient(ItemID.ManaCrystal, 10);
			recipe.AddIngredient(ItemID.MagicMirror, 1);
			recipe.AddIngredient(null, "OvercoaledSteel", 10);
			recipe.AddIngredient(null, "ShinyMetalBar", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
		}



	}

}