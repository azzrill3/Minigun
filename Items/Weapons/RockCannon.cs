using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class RockCannon : ModItem          
	{
		int mode = 0;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rock Cannon");
			Tooltip.SetDefault("30% to not consume ammo"
			+"\nHas 3 modes: MachineGun, Magic Gun, Laser"
			+"\nRight Click to change modes");
		}
		public override void SetDefaults()    
		{
            if (mode == 0){
			item.damage = 50; 
			item.channel = false;
			item.crit = 23;
			item.mana = 0;
			item.ranged = true; 
			item.expert = false;
			item.width = 122;    		
			item.height = 27;          
			item.useTime = 6;                                
			item.useAnimation = 6; 
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   		
			item.value = 99999999;                        
			item.rare = 9;
			item.useAmmo = AmmoID.Bullet; 
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.shoot = 10;                     
			item.shootSpeed = 65f; 
			item.UseSound = SoundID.Item11;
				}	
				else if (mode == 1)
				{
				item.damage = 85;   
			item.crit = 23;
			item.expert = false;
			item.ranged = true;			
			item.mana = 3;
			item.channel = false;
			item.width = 122;    		
			item.height = 27;         
			item.useTime = 8;                                
			item.useAnimation = 8; 
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   			
			item.value = 99999999; 
			item.rare = 9;
			item.useAmmo = 0; 
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.shoot = mod.ProjectileType("RShoot");                     
			item.shootSpeed = 65f; 
			item.UseSound = SoundID.Item11;
				}
				else if (mode == 2)
				{
				item.damage = 20;   
			item.crit = 23;
			item.ranged = true;     
			item.mana = 7;
			item.width = 122;    		
			item.height = 27;          
			item.useTime = 20;                                
			item.useAnimation = 20; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   		
			item.value = 99999999; 		
			item.rare = 9;
			item.maxStack = 1;                 
			item.autoReuse = true; 
			item.useAmmo = 0;
			item.shoot = mod.ProjectileType("RLaser");                     
			item.shootSpeed = 65f; 
			item.UseSound = SoundID.Item11;
				}  

		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .30f;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
 
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 115f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 5);
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		
public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useAmmo = 0;
				item.shoot = 0;
				item.shootSpeed = 65f; 
				item.autoReuse = false;
				item.useAnimation = 10;
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
			item.damage = 50;   
			item.crit = 23;
			item.expert = false;
			item.mana = 0;
			item.ranged = true; 
			item.channel = false;			
			item.width = 122;    		
			item.height = 27;          
			item.useTime = 6;                                
			item.useAnimation = 6; 
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   		
			item.value = 99999999;                        
			item.rare = 9;
			item.useAmmo = AmmoID.Bullet; 
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.shoot = 10;                     
			item.shootSpeed = 65f; 
			item.UseSound = SoundID.Item11;
				}	
				else if (mode == 1)
				{
				item.damage = 85;   
			item.crit = 23;
			item.expert = false;
			item.mana = 3;
			item.ranged = true;			
			item.channel = false;
			item.width = 122;    		
			item.height = 27;          
			item.useTime = 8;                                
			item.useAnimation = 8; 
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   			
			item.value = 99999999; 
			item.rare = 9;
			item.useAmmo = 0; 
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.shoot = mod.ProjectileType("RShoot");                    
			item.shootSpeed = 65f; 
			item.UseSound = SoundID.Item11;
				}
				else if (mode == 2)
				{
				item.damage = 20;   
			item.crit = 23;
			item.ranged = true;     
			item.mana = 7;
			item.width = 122;    		
			item.height = 27;          
			item.useTime = 20;                                
			item.useAnimation = 20; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   		
			item.value = 99999999; 	
			item.rare = 9;
			item.maxStack = 1;  
			item.useAmmo = 0;			
			item.autoReuse = true;  
			item.shoot = mod.ProjectileType("RLaser");                     
			item.shootSpeed = 65f; 
			item.UseSound = SoundID.Item11;
				}  
			}
			return base.CanUseItem(player);
		}
		/*public override void AddRecipes()
		{
		ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RedDiode", 5);
			recipe.AddIngredient(null, "OvercoaledSteel", 20);
			recipe.AddIngredient(ItemID.Megashark, 1);
			recipe.AddIngredient(ItemID.SniperRifle, 1);
			recipe.AddIngredient(ItemID.VenusMagnum, 1);
			recipe.AddIngredient(ItemID.IllegalGunParts, 2);
			recipe.AddIngredient(ItemID.SoulofNight, 50);
			recipe.AddIngredient(null, "CursedBlood", 7);
			recipe.AddIngredient(null, "KLiquid", 25);
			recipe.AddIngredient(ItemID.SoulofFright, 15);
			recipe.AddIngredient(ItemID.SoulofSight, 35);
			recipe.AddIngredient(null, "IllegalWeaponInstructions", 1);
			recipe.AddIngredient(null, "LensAssemblage", 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/

	}

}