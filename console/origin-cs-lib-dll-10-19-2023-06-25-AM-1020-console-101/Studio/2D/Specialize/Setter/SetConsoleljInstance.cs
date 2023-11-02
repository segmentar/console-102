using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static void SetConsoleLJInstance(ConsoleLJ instance, Boolean hasInstance)
        {
            ArchitectureConsoleLJTwoSecond.ConsoleLJInstance = instance;

            ArchitectureConsoleLJTwoSecond.HasConsoleLJInstance = hasInstance;

            return;
        }
    }
}
