using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class AstralSickle : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Astral Sickle");
			Tooltip.SetDefault("Destructive star power!");
		}
		public override void SetDefaults()    
		{
         
			item.damage = 30;   
			item.crit = 30;
			item.melee = true;           
			item.width = 60;    		
			item.height = 56;          
			item.useTime = 20;                                
			item.useAnimation = 20; 
			item.noMelee = false;                      
			item.useStyle = 1; 			
			item.knockBack = 7;                    
			item.value = 700000;
			item.shootSpeed = 9f;
			item.rare = 9;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;                     
			item.UseSound = SoundID.Item71;
			item.shoot = mod.ProjectileType("ASick");
		}
		
		public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "ObscureSickle", 1);
		recipe.AddIngredient(null, "Starlight", 10);
		recipe.AddTile(TileID.Anvils);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}

	}
}