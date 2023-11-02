using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void VLock(String item_STRING)
        {
            View();

            Lock(item_STRING);

            return;
        }
    }
}
