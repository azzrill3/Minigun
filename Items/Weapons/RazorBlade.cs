using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items.Weapons      
{
    public class RazorBlade : ModItem          
	{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Razor Blade");
			Tooltip.SetDefault("Cuts even space"
			+"\nRight Click to teleport to the cursor");
		}
		public override void SetDefaults()    
		{
               
			item.damage = 313;   
			item.crit = 30;
			item.melee = true;           
			item.width = 42;    		
			item.height = 48;          
			item.useTime = 5;                                
			item.useAnimation = 8; 
			item.noMelee = false;                      
			item.useStyle = 1; 			
			item.knockBack = 1;                    
			item.value = 7000000;                        
			item.rare = -1;
			item.maxStack = 1;                 
			item.autoReuse = true; 
			item.useTurn = true;
			item.scale = 1;                     
			item.UseSound = SoundID.Item71;
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useTime = 20; 
				item.damage = 9999;
				item.useStyle = 1;
				player.position.X = Main.mouseX + Main.screenPosition.X;
				player.position.Y = Main.mouseY + Main.screenPosition.Y;
				
			}
			else
			{
				item.damage = 313;
				item.useStyle = 1;
				item.useTime = 5;
				item.useAnimation = 8;
			}
			return base.CanUseItem(player);
		}
		
		public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null, "DarkSteelBar", 12);
		recipe.AddIngredient(null, "KBar", 5);
		recipe.AddIngredient(null, "RiftBlade", 1);
		recipe.AddIngredient(null, "CBlade", 1);
		recipe.AddIngredient(null, "StableFabric", 5);
		recipe.AddIngredient(null, "RealityFabric", 5);
		recipe.AddTile(TileID.MythrilAnvil);
		recipe.AddTile(TileID.Autohammer);
		recipe.SetResult(this);
		recipe.AddRecipe();

	}

	}
}