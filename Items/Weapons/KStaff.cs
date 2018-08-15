using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class KStaff : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kramnium Staff");
			Tooltip.SetDefault("Destroys everything on its way");
		}
		public override void SetDefaults()    
		{
               
			item.damage = 9999;   
			item.crit = 60;
			item.magic = true;           
			item.width = 44;    		
			item.height = 42;          
			item.useTime = 1;                                
			item.useAnimation = 6; 
			item.channel = true;
			item.noMelee = false;                      
			item.useStyle = 5; 
			Item.staff[item.type] = true;			
			item.knockBack = 4;                    
			item.value = 3000000;                        
			item.rare = 9;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = mod.ProjectileType("KBeam");                     
			item.shootSpeed = 67f; 
			item.UseSound = SoundID.Item13;
		}

public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DarkSteelBar", 23);
			recipe.AddIngredient(ItemID.SoulofNight, 12);
			recipe.AddIngredient(null, "KramniumCrystal", 15);
			recipe.AddIngredient(ItemID.LastPrism, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}



	}

}