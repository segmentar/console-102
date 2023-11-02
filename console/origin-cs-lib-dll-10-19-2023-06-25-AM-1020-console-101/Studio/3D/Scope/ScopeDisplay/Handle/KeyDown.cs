using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ScopeDisplay
    {
        public static void HandleKeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.P)
            {
                Scope.DirectionPause();

                if (Scope.MeasureWait.IsPause is true)
                {
                    Scope.DirectionTemplate();
                }
                else
                    "false".ToString();

                if (Scope.MeasureWait.IsPause is false && (Scope.ScopeTemplate == default) is false)
                {
                    Scope.DirectionRestore(true);
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            if (e.KeyCode is Keys.F)
            {
                Scope.DirectionForward();
            }
            else
                "false".ToString();

            if (e.KeyCode is Keys.B)
            {
                Scope.DirectionBackward();
            }
            else
                "false".ToString();

            if (e.KeyCode is Keys.E)
            {
                Scope.DirectionEscape();
            }
            else
                "false".ToString();

            return;
        }
    }
}
