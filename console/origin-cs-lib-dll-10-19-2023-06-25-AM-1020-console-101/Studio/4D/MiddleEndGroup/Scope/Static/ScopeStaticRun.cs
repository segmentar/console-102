using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class Scope
    {
        public static void Run()
        {
            var thread = ScopeMainThread();

            thread.Start();

            Thread.Sleep(MeasureWait.WaitBeforeEnd);

            return;
        }
    }
}
