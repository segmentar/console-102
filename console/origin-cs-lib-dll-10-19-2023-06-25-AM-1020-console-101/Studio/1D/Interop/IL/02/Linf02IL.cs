using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Linf02IL()
        {
            if (ArchitectureConsoleLJOneFirst.HasLength is false)
            {
                return;
            }
            else
                "false".ToString();

            var roth = (ArchitectureConsoleLJOneFirst.ArgumentArray.Length - 1);

            var eoth = ArchitectureConsoleLJOneFirst.ArgumentArray[roth];

            var lower = eoth.ToLower();

            Boolean isLingerCheck, shouldReturn;

            isLingerCheck = lower.Equals("linger") is true;

            shouldReturn = isLingerCheck is false;

            if (shouldReturn is true)
            {
                return;
            }
            else
                "false".ToString();

            ArchitectureConsoleLJOneFirst.HasLinger = true;

            return;
        }
    }
}
