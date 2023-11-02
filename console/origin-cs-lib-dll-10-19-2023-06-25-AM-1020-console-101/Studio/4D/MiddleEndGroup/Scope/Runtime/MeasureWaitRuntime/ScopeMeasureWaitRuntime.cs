using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scope
    {
        public static void MeasureWaitRuntime()
        {
            MeasureWait.IsPause = true;

            MeasureWait.WaitAfterStart = -1;

            MeasureWait.WaitEverybody = -1;

            MeasureWait.WaitBeforeEnd = -1;

            MeasureWait.LinkedList = new LinkedList<Tuple<String, String, String, String, String, String>>();

            MeasureWait.LinkedListPointer = -1;

            return;
        }
    }
}