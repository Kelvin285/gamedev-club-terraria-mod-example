using gamedevclubmod.Projectiles;
using gamedevclubmod.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace gamedevclubmod.Items
{
    internal class GamedevClubTileItem : ModItem
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.CloneDefaults(ItemID.DirtBlock);
            Item.createTile = ModContent.TileType<GamedevClubTile>();
        }

        public override void AddRecipes()
        {
            base.AddRecipes();

            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

    }
}
