using Core;

namespace Core
{
    using System;

    using System.Threading;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Scope
    {
        public static void Close()
        {
            Thread.Sleep(MeasureWait.WaitAfterStart);

            Application.Restart();

            return;
        }
    }
}
