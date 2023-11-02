using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ResetRelateOffset()
        {
            MeasureFile.RelateOffset = 0;

            return;
        }
    }
}
