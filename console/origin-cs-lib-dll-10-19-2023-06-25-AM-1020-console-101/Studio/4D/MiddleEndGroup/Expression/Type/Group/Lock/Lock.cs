using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void Lock(String item_STRING)
        {
            LastLock = SLock(item_STRING);

            return;
        }
    }
}
