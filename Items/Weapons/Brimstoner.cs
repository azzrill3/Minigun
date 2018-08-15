using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class Brimstoner : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brimstoner");
			Tooltip.SetDefault("Uses Kramnium Cells as ammo"
			+ "\nRight Click for Insane mode"
			+ "\n80% chance to not consume Kramnium Cells");
		}
		public override void SetDefaults()    
		{
                
			item.damage = 200;   
			item.crit = 18;
			item.ranged = true;           
			item.width = 64;    		
			item.useAmmo = mod.ItemType("KLiquid"); 
			item.height = 47;          
			item.useTime = 5;                                
			item.useAnimation = 6;                                                                               
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 100000;                        
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.mana = 0;
			item.scale = 1;
			item.shoot = mod.ProjectileType("BrimK");                     
			item.shootSpeed = 67f; 
			item.UseSound = SoundID.Item13;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 60f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}

public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RedDiode", 25);
			recipe.AddIngredient(null, "OvercoaledSteel",3);
			recipe.AddIngredient(ItemID.Minishark, 1);
			recipe.AddIngredient(ItemID.IllegalGunParts, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 30);
			recipe.AddIngredient(ItemID.Flamethrower, 1);
			recipe.AddIngredient(ItemID.SoulofMight, 20);
			recipe.AddIngredient(ItemID.SoulofSight, 10);
			recipe.AddIngredient(null, "KLiquid", 100);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .80f;
		}
public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.shoot = mod.ProjectileType("Brim");
				item.damage = 100;
				item.useTime = 1;
				item.useAmmo = mod.ItemType("KLiquid");
				item.mana = 8;
				
				
			}
			else
			{              
			item.damage = 200;
			item.useTime = 2;      
			item.useAmmo = mod.ItemType("KLiquid");    
			item.useAnimation = 6; 
			item.shoot = mod.ProjectileType("BrimK");   
			item.mana = 0;
			}
			return base.CanUseItem(player);
		}

	}

}