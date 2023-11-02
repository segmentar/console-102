using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void FilePrimaryIteration()
        {
            StepLocalLineCheck();

            StepLineFlagCheck();

            StepOutsideFlagCheck();

            return;
        }
    }
}
