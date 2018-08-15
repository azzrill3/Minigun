using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class StopWatch : ModItem          
	{
	private double a = 0;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stop Watch");
			Tooltip.SetDefault("Rigt click to set the time, than equip to stop on the set time"
			+ "\nAlso can use Left click to turn to the set time");
		}
		public override void SetDefaults()    
		{
            item.damage = (int)a;                    
			item.width = 28; 
			item.height = 32; 
			item.accessory = true;
			item.consumable = false;
			item.maxStack = 1;                                        
			item.value = 100000; 
			item.useTime = 10;
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
				
				 a = Main.time;
			}
			else
			{
				Main.time = a;
			}
			return base.CanUseItem(player);
		}


		public override void UpdateAccessory(Player player, bool hideVisual)
{
	Main.time = a;
}
public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddTile(TileID.DemonAltar);
		recipe.AddIngredient(null, "TimeManip", 1);
		recipe.AddIngredient(null, "CursedBlood", 3);
		recipe.AddIngredient(null, "OvercoaledSteel", 5);
		recipe.AddIngredient(ItemID.Stopwatch, 1);
		recipe.AddIngredient(ItemID.SoulofSight, 10);
		recipe.SetResult(this);
		recipe.AddRecipe();
	
	}
  }

}