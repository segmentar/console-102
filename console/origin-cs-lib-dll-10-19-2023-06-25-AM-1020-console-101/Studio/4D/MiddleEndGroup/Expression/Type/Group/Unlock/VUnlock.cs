using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void VUnlock(String item_STRING)
        {
            View();

            Unlock(item_STRING);

            return;
        }
    }
}
