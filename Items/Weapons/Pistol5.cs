using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class Pistol5 : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Pistol");
			Tooltip.SetDefault("Collect like you want!"
			);
		}
		public override void SetDefaults()    
		{
                
			item.damage = 55;   
			item.crit = 60;
			item.ranged = true;           
			item.width = 100;    		
			item.mana = 8; 
			item.height = 100;          
			item.useTime = 6;                                
			item.useAnimation = 3;                                                                               
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 1000000;                        
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 0.3f;
			item.shoot = mod.ProjectileType("Shoot1");                     
			item.shootSpeed = 40f; 
			item.UseSound = SoundID.Item11;
		}

		
public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wire, 5); 
			recipe.AddIngredient(null, "Circuit2", 1);
			recipe.AddIngredient(null, "Corpse2", 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}



	}

}