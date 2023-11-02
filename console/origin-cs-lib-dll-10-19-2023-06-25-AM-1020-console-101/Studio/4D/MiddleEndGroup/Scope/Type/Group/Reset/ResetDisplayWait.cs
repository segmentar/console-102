using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ResetDisplayWait(Int32 CollectiveWait__ITEM, Int32 IndividualWait__ITEM, Int32 InitializeWait__ITEM)
        {
            MeasureWait.WaitAfterStart = CollectiveWait__ITEM;

            MeasureWait.WaitEverybody = IndividualWait__ITEM;

            MeasureWait.WaitBeforeEnd = InitializeWait__ITEM;

            return;
        }
    }
}
