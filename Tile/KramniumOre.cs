using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Minigun.Tile
{
    public class KramniumOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;  //true for block to emit light
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("KramniumCrystal");   //put your CustomBlock name
            AddMapEntry(new Color(200, 0, 0));
        }
      
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)   //light colors
        {
            r = 255f;
            g = 0.0f;
            b = 0.0f;
        }
    }
}