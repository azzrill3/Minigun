using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minigun.Items
{
	[AutoloadEquip(EquipType.Head)]
    public class ObitoMask : ModItem          
	{
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Obito Mask");
			
		}
		
		public override void SetDefaults()    
		{                    
			item.width = 46; 
			item.height = 32; 
			item.consumable = false;
			item.maxStack = 1;                                        
			item.value = 100000; 
			item.rare = 4;
			
		}
		
		public override bool DrawHead()
		{
			return true;
		}
		public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		{
			drawHair = true;
		}

  }

}