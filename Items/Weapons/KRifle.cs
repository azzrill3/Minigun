using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class KRifle : ModItem          
	{
		int mode = 0;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("MachineRifle");
			Tooltip.SetDefault("Converts Musket Balls to Kramnium Bullets"
			+"\n40% to not consume ammo"
			+"\nHas 3 modes: MachineGun, Rifle, Laser"
			+"\nRight Click to change modes");
		}
		public override void SetDefaults()    
		{
            if (mode == 0){
			item.damage = 60; 
			item.channel = false;
			item.crit = 23;
			item.mana = 0;
			item.ranged = true; 
			item.expert = false;
			item.width = 92;    		
			item.height = 24;          
			item.useTime = 5;                                
			item.useAnimation = 5; 
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   		
			item.value = 99999999;                        
			item.rare = 8;
			item.useAmmo = AmmoID.Bullet; 
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.shoot = 10;                     
			item.shootSpeed = 60f; 
			item.UseSound = SoundID.Item11;
				}	
				else if (mode == 1)
				{
				item.damage = 800;   
			item.crit = 23;
			item.expert = false;
			item.ranged = true;			
			item.mana = 0;
			item.channel = false;
			item.width = 92;    		
			item.height = 24;          
			item.useTime = 30;                                
			item.useAnimation = 30; 
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   			
			item.value = 99999999; 
			item.rare = 9;
			item.useAmmo = AmmoID.Bullet; 
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.shoot = 10;                     
			item.shootSpeed = 60f; 
			item.UseSound = SoundID.Item11;
				}
				else if (mode == 2)
				{
				item.damage = 30;   
			item.crit = 23;
			item.ranged = true;     
			item.mana = 30;
			item.width = 92;    		
			item.height = 24;          
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
			item.useAmmo = 0;
			item.shoot = mod.ProjectileType("KLaser");                     
			item.shootSpeed = 60f; 
			item.UseSound = SoundID.Item11;
				}  

		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .40f;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet)
			{
				type = mod.ProjectileType("KShoot");
			}
 
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 60f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-20, 2);
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
				item.shootSpeed = 60f; 
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
			item.damage = 60;   
			item.crit = 23;
			item.expert = false;
			item.mana = 0;
			item.ranged = true; 
			item.channel = false;			
			item.width = 92;    		
			item.height = 24;          
			item.useTime = 5;                                
			item.useAnimation = 5; 
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   		
			item.value = 99999999;                        
			item.rare = 8;
			item.useAmmo = AmmoID.Bullet; 
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.shoot = 10;                     
			item.shootSpeed = 60f; 
			item.UseSound = SoundID.Item11;
				}	
				else if (mode == 1)
				{
				item.damage = 800;   
			item.crit = 23;
			item.expert = false;
			item.mana = 0;
			item.ranged = true;			
			item.channel = false;
			item.width = 92;    		
			item.height = 24;          
			item.useTime = 60;                                
			item.useAnimation = 60; 
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;   			
			item.value = 99999999; 
			item.rare = 9;
			item.useAmmo = AmmoID.Bullet; 
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.shoot = 10;                     
			item.shootSpeed = 60f; 
			item.UseSound = SoundID.Item11;
				}
				else if (mode == 2)
				{
				item.damage = 30;   
			item.crit = 23;
			item.ranged = true;     
			item.mana = 30;
			item.width = 92;    		
			item.height = 24;          
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
			item.useAmmo = 0;			
			item.autoReuse = true;  
			item.shoot = mod.ProjectileType("KLaser");                     
			item.shootSpeed = 60f; 
			item.UseSound = SoundID.Item11;
				}  
			}
			return base.CanUseItem(player);
		}
		public override void AddRecipes()
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
		}

	}

}