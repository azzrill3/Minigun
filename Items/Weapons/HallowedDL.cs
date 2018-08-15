using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class HallowedDL : ModItem          
	{
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Death Laser");

		}
		public override void SetDefaults()    
		{

	               
			item.damage = 35;   
			item.crit = 60;
			item.ranged = true;           
			item.width = 174;    		
			item.height = 47;          
			item.useTime = 8;                                
			item.useAnimation = 6; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 30000;                        
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = mod.ProjectileType("EHDL");                     
			item.shootSpeed = 67f; 
			item.UseSound = SoundID.Item13;
		}

public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CorruptDL", 1);
			recipe.AddIngredient(ItemID.SoulofLight, 12);
			recipe.AddIngredient(ItemID.PixieDust, 20);
			recipe.AddIngredient(ItemID.UnicornHorn, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
		}



	}

}