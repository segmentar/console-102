using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void AdvanceLinkedList(Tuple<String, String, String, String, String, String> item_TUPLE)
        {
            MeasureWait.LinkedList.AddLast(item_TUPLE);

            MeasureWait.LinkedListPointer = MeasureWait.LinkedList.Count - 1;

            return;
        }
    }
}
