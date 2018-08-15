using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class AzzrillsLongMinigun : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Azzrill's Long Minigun");
			Tooltip.SetDefault("Legendary weapon from 1.1.2"
			+ "\nThat was the first item that Azzrill made...");
		}
		public override void SetDefaults()    
		{
                
			item.damage = 35;   
			item.crit = 60;
			item.ranged = true;           
			item.width = 174;    		
			item.useAmmo = AmmoID.Bullet; 
			item.height = 47;          
			item.useTime = 1;                                
			item.useAnimation = 6;                                                                               
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 1000000;                        
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = 10;                     
			item.shootSpeed = 67f; 
			item.UseSound = SoundID.Item11;
		}

		
public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(ItemID.Minishark, 3);
			recipe.AddIngredient(ItemID.Megashark, 2);
			recipe.AddIngredient(ItemID.SoulofLight, 100);
			recipe.AddIngredient(ItemID.SoulofNight, 100);
			recipe.AddIngredient(ItemID.SoulofSight, 100);
			recipe.AddIngredient(ItemID.SoulofMight, 100);
			recipe.AddIngredient(ItemID.SoulofFright, 100);
			recipe.AddIngredient(ItemID.CursedBullet, 2000);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
		}



	}

}