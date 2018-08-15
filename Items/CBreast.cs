using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
	[AutoloadEquip(EquipType.Body)]
	
    public class CBreast : ModItem          
	{
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Blood Breastplate");
			Tooltip.SetDefault("Has some great potential");
		}
		
		public override void SetDefaults()    
		{                    
			item.width = 38; 
			item.height = 20; 
			item.consumable = false;
			item.maxStack = 1;                                        
			item.value = 100000; 
			item.rare = 10;
			item.defense = 23;
			
		}
		
		public override bool DrawBody()
		{
			return true;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return head.type == mod.ItemType("CHelmet") && legs.type == mod.ItemType("CGreaves");
		}
		public override void UpdateArmorSet(Player player)
		{
			
			player.statDefense += 4;
		}
		
public override void AddRecipes()
		{
		ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CursedBloodBar", 18);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
  }

}