using Terraria;
using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
    public class ASLEye : ModItem
    {
		
		public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Another Suspicious Looking Eye");
            Tooltip.SetDefault("Summons The Eye of Pain"
			+"\nYou thought it's The Eye of Cthulhu, but it's me - Dio!., oh. "
			+"\nNot Consumable");

        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = 100;
            item.rare = -1;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = false;
        }
        public override bool CanUseItem(Player player)
        {     
			if ((!NPC.AnyNPCs(mod.NPCType("PEye"))) && (!Main.dayTime)) 
			{
            return true;  
			}
			else {return false;}
        }
        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("PEye"));   //boss spawn
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);

            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SuspiciousLookingEye, 1);
			recipe.AddIngredient(null, "CursedBlood", 2);
			recipe.AddIngredient(ItemID.BeetleHusk, 5);
			recipe.AddIngredient(null, "LensAssemblage", 1);
			recipe.AddIngredient(ItemID.SoulofSight, 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
			
        }
    }
}
