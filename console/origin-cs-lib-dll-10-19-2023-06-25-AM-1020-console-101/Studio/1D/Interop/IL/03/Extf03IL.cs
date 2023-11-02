using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Extf03IL()
        {
            if (ArchitectureConsoleLJOneFirst.HasLength is false)
            {
                return;
            }
            else
                "false".ToString();

            if (ArchitectureConsoleLJOneFirst.HasLinger)
            {
                ArchitectureConsoleLJOneFirst.IsExternalCall = false;
            }
            else
            {
                ArchitectureConsoleLJOneFirst.IsExternalCall = true;
            }

            return;
        }
    }
}
