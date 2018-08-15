using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Minigun.Projectiles;

namespace Minigun.Items.Weapons      
{
    public class RiftBlade : ModItem          
	{
	
    
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rift Blade");
			Tooltip.SetDefault("Right Click to teleport to the cursor");
		}
		public override void SetDefaults()    
		{
			item.damage = 99;
			item.crit = 20;
			item.melee = true;           
			item.width = 44;    		
			item.height = 44;          
			item.useTime = 15;                                
			item.useAnimation = 15; 
			item.noMelee = false;                      
			item.useStyle = 1; 			
			item.knockBack = 4;                    
			item.value = 1000000;
			item.reuseDelay = 0;			
			item.rare = 9;
			item.maxStack = 1;                 
			item.autoReuse = true;  
			item.scale = 1;
			item.useTurn = true;
			item.UseSound = SoundID.Item1;
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useTime = 100; 
				item.damage = 9999;
				item.reuseDelay = 80;
				item.autoReuse = false;
				item.useStyle = 1;
				item.useAnimation = 100; 
				player.position.X = Main.mouseX + Main.screenPosition.X;
				player.position.Y = Main.mouseY + Main.screenPosition.Y;
				
			}
			else
			{
				item.damage = 99;
				item.useStyle = 1;
				item.reuseDelay = 0;
				item.autoReuse = true;
				item.useTime = 15;
				item.useAnimation = 15;
				item.shootSpeed = 16f;
			}
			return base.CanUseItem(player);
		}

		public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "EasymodeBar", 15);
		recipe.AddRecipeGroup(" Gold Bar", 10);
		recipe.AddIngredient(null, "KBar", 5);
		recipe.AddIngredient(ItemID.Diamond, 10);
		recipe.AddIngredient(null, "StableFabric", 5);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.AddTile(TileID.DemonAltar);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}

	}

}