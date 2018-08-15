using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons
{
    public class AncientWind : ModItem          
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Wind");
			Tooltip.SetDefault("Ancient's best friend");
		}
		public override void SetDefaults()    
		{
              
			item.damage = 126;
			item.magic = true;
			item.width = 30;    		               
			item.height = 28;          
			item.useTime = 5;                                
			item.useAnimation = 3;                                                                               
			item.noMelee = true;                      
			item.useStyle = 5;      
			item.knockBack = 2;                    
			item.value = 10000;                        
			item.rare = 7;                      
			item.UseSound = SoundID.Item39;                  
			item.autoReuse = true;                
			item.shoot = mod.ProjectileType("AncientWind");                     
			item.shootSpeed = 9f;                             
		}

public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.SandBlock, 500);
		recipe.AddIngredient(ItemID.SpellTome, 1);
		recipe.AddIngredient(ItemID.Ectoplasm, 12);
		recipe.AddIngredient(ItemID.SoulofLight, 25);
		recipe.AddTile(TileID.LihzahrdFurnace);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}
	
  }

}