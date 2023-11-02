using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ScopeDisplay
    {
        [STAThread]
        public static void MainThread()
        {
            try
            {
                Application.EnableVisualStyles();

                Application.SetCompatibleTextRenderingDefault(false);

                ApplicationContext applicationContext;

                applicationContext = new ScopeDisplayContext(default);

                Application.Run(applicationContext);

            } catch (Exception exception)
            {
                ConsoleLJS.Log(false, exception);
            }

            return;
        }
    }
}
