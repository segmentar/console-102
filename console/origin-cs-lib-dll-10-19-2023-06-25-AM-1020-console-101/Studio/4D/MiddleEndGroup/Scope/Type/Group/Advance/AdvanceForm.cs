using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void AdvanceForm()
        {
            MeasureFile.PhysicalOffset = (MeasureValue.FormEndPosition + ScopeImmutable.FormStringEnd.Length);

            MeasureFile.PhysicalOffset = MeasureFile.PhysicalOffset - 1;

            return;
        }
    }
}
