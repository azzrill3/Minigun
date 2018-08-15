using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
	[AutoloadEquip(EquipType.Legs)]
    public class CGreaves : ModItem          
	{
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Blood Greaves");
			Tooltip.SetDefault("Has some great potential");
		}
		
		public override void SetDefaults()    
		{                    
			item.width = 22; 
			item.height = 18; 
			item.consumable = false;
			item.maxStack = 1;                                        
			item.value = 100000; 
			item.rare = 10;
			item.defense = 14;
			
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("CBreast") && head.type == mod.ItemType("CHelmet");
		}
		public override void UpdateArmorSet(Player player)
		{
			
			player.statDefense += 4;
		}
		
	public override void AddRecipes()
		{
		ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CursedBloodBar", 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

  }

}