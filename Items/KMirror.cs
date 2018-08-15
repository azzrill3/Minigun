using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class KMirror : ModItem          
	{
	private int k = 0;
	private float PosX = 0;
	private float PosY = 0;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bottomless Mirror");
			Tooltip.SetDefault("Rigt Click to set the point, than Left Click to teleport to the set point");
		}
		public override void SetDefaults()    
		{
                      
			item.width = 28; 
			item.height = 32; 
			item.accessory = true;
			item.consumable = false;
			item.maxStack = 1;                                        
			item.value = 100000; 
			item.useTime = 30;
			item.useAnimation = 10;
			item.rare = 8;
			item.useStyle = 1;
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				
				 PosX = player.position.X;
				 PosY = player.position.Y;
			}
			else
			{
			for (k = 0; k < 61; k++)
				{
			int dust = Dust.NewDust(
			player.position,					//position
			player.width,                                           //box width
			player.height,                                          //box height
			235,                                                          //type
			0,					//X velocity
			0,		                        //Y velocity
			0,                                                         //alpha
			new Color(),                                                //Color override
			3f                                                        //scale
    );
			}
				player.position.X = PosX;
				player.position.Y = PosY;
				player.noFallDmg = true;
				
				
			}
			return base.CanUseItem(player);
		}


		
public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.DemonAltar);
		recipe.AddIngredient(null, "KBar", 3);
		recipe.AddIngredient(null, "KLiquid", 5);
		recipe.AddIngredient(null, "OvercoaledSteel", 5);
		recipe.AddIngredient(ItemID.MagicMirror, 1);
		recipe.AddIngredient(ItemID.FallenStar, 10);
		recipe.SetResult(this);
		recipe.AddRecipe();
	
	}
  }

}