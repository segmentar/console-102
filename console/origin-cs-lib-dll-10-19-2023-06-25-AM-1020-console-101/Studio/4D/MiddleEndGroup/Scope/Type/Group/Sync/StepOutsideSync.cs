using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void StepOutsideSync()
        {
            MeasureFlag.StepOutsideFlag = false;

            return;
        }
    }
}
