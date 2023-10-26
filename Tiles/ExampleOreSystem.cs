using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace gamedevclubmod.Tiles
{
    public class ExampleOreSystem : ModSystem
    {
        public static string ExampleOrePassMessage { get; private set; }

        public override void SetStaticDefaults()
        {
            ExampleOrePassMessage = Mod.GetLocalizationKey($"WorldGen.{nameof(ExampleOrePassMessage)}");
        }

        // World generation is explained more in https://github.com/tModLoader/tModLoader/wiki/World-Generation
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
        {
            // Because world generation is like layering several images on top of each other, we need to do some steps between the original world generation steps.

            // Most vanilla ores are generated in a step called "Shinies", so for maximum compatibility, we will also do this.
            // First, we find out which step "Shinies" is.
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));

            if (ShiniesIndex != -1)
            {
                // Next, we insert our pass directly after the original "Shinies" pass.
                // ExampleOrePass is a class seen bellow
                tasks.Insert(ShiniesIndex + 1, new ExampleOrePass("Example Mod Ores", 237.4298f));
            }
        }
    }
}
