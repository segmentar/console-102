using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void DirectionPause()
        {
            MeasureWait.IsPause = MeasureWait.IsPause.Equals(false);

            return;
        }
    }
}
