using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
	[AutoloadEquip(EquipType.Head)]
    public class CHelmet : ModItem          
	{
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Blood Helmet");
			Tooltip.SetDefault("Has some great potential");
		}
		
		public override void SetDefaults()    
		{                    
			item.width = 30; 
			item.height = 22; 
			item.consumable = false;
			item.maxStack = 1;                                        
			item.value = 100000; 
			item.rare = 10;
			item.defense = 17;
			
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("CBreast") && legs.type == mod.ItemType("CGreaves");
		}
		public override void UpdateArmorSet(Player player)
		{
			
			player.statDefense += 4;
		}
		
		public override bool DrawHead()
		{
			return true;
		}
		public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		{
			drawHair = false;
		}
		public override void AddRecipes()
		{
		ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CursedBloodBar", 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

  }

}