using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Windows.Forms;
using System.Timers;

namespace Minigun.Items
{
    public class AttunedBottle : ModItem          
	{
public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Attuned Bottle");
			Tooltip.SetDefault("Use at night to collect Starlight");
		}
		public override void SetDefaults()    
		{
                                  
			item.width = 20; 
			item.height = 26; 
			item.consumable = true;
			item.useStyle = 3;
			item.useTime = 15;
			item.useAnimation = 15;
			item.maxStack = 64;			
			item.value = 10000;                        
			item.rare = 7;                                   
		}
		public override bool CanUseItem(Player player)
		{
			return !Main.dayTime;
		}
		public override bool UseItem(Player player)
		 {
			 Item.NewItem((int)player.position.X, (int)player.position.Y, player.width, player.height, mod.ItemType("Starlight"), 1);
			 return true;
		 }

public override void AddRecipes()
	
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.needWater = true;
		recipe.AddTile(TileID.Furnaces);
		recipe.AddIngredient(ItemID.Bottle, 2);
		recipe.AddIngredient(ItemID.FallenStar, 2);
		recipe.SetResult(this);
		recipe.AddRecipe();
	}
   }

}