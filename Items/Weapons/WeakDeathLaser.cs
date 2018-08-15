using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class WeakDeathLaser : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Weak Death Laser");

		}
		public override void SetDefaults()    
		{
               
			item.damage = 18;   
			item.crit = 60;
			item.ranged = true;           
			item.width = 174;    		
			item.height = 47;          
			item.useTime = 10;                                
			item.useAnimation = 6; 
			item.channel = true;
			item.noMelee = true;                      
			item.useStyle = 5;          
			item.knockBack = 4;                    
			item.value = 100000;                        
			item.rare = 8;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.shoot = mod.ProjectileType("WeDeLa");                     
			item.shootSpeed = 67f; 
			item.UseSound = SoundID.Item13;
		}

public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RedDiode", 15);
			recipe.AddIngredient(ItemID.IronBar, 12);
			recipe.AddIngredient(ItemID.Wire, 20);
			recipe.AddIngredient(ItemID.Lens, 3);
			recipe.AddIngredient(ItemID.IllegalGunParts, 1);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
		}



	}

}