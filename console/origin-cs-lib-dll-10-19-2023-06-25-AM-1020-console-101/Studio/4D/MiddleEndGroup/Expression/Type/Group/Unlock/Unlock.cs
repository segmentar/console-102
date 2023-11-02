using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void Unlock(String item_STRING)
        {
            LastLock = IUnlock(item_STRING);

            return;
        }
    }
}
