using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct ScopeMeasureWait
    {
        public Boolean IsPause;

        public Int32 WaitAfterStart;

        public Int32 WaitEverybody;

        public Int32 WaitBeforeEnd;

        public LinkedList<Tuple<String, String, String, String, String, String>> LinkedList;

        public Int32 LinkedListPointer;
    }
}