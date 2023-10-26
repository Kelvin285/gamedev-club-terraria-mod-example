using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace gamedevclubmod.Tiles
{
    internal class GamedevClubTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            AddMapEntry(new Color(0, 255, 0));
        }
    }

    
}
