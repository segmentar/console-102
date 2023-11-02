using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class ScopeDisplayContext : ApplicationContext, IExposable<ScopeDisplayContext>
    {
        public static ScopeDisplayContext Instance;

        public ScopeDisplayContext(Form form) : base(form)
        {
            ExposeInstance();

            var RowWidth_Onefirst = (Screen.PrimaryScreen.Bounds.Width / 3);

            var RowHeight_Onefirst = 0;

            var RowWidth_Twosecond = (Screen.PrimaryScreen.Bounds.Width / 3);

            var RowHeight_Twosecond = (Screen.PrimaryScreen.WorkingArea.Height / 2);

            ScopeDisplay
                scopeDisplayOnefirst,
                scopeDisplayTwosecond,
                scopeDisplayThreethird,
                scopeDisplayFourfourth,
                scopeDisplayFivefifth,
                scopeDisplaySixsixth
                ;

            scopeDisplayOnefirst = new ScopeDisplay();

            scopeDisplayOnefirst.Location = new Point((RowWidth_Onefirst * 0), RowHeight_Onefirst);

            scopeDisplayOnefirst.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 2));

            scopeDisplayTwosecond = new ScopeDisplay();

            scopeDisplayTwosecond.Location = new Point((RowWidth_Onefirst * 1), RowHeight_Onefirst);

            scopeDisplayTwosecond.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 2));

            scopeDisplayThreethird = new ScopeDisplay();

            scopeDisplayThreethird.Location = new Point((RowWidth_Onefirst * 2), RowHeight_Onefirst);

            scopeDisplayThreethird.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 2));

            scopeDisplayFourfourth = new ScopeDisplay();

            scopeDisplayFourfourth.Location = new Point((RowWidth_Twosecond * 0), RowHeight_Twosecond);

            scopeDisplayFourfourth.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 2));

            scopeDisplayFivefifth = new ScopeDisplay();

            scopeDisplayFivefifth.Location = new Point((RowWidth_Twosecond * 1), RowHeight_Twosecond);

            scopeDisplayFivefifth.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 2));

            scopeDisplaySixsixth = new ScopeDisplay();

            scopeDisplaySixsixth.Location = new Point((RowWidth_Twosecond * 2), RowHeight_Twosecond);

            scopeDisplaySixsixth.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 2));

            ScopeDisplayArrayList.Add(scopeDisplayOnefirst);

            ScopeDisplayArrayList.Add(scopeDisplayTwosecond);

            ScopeDisplayArrayList.Add(scopeDisplayThreethird);

            ScopeDisplayArrayList.Add(scopeDisplayFourfourth);

            ScopeDisplayArrayList.Add(scopeDisplayFivefifth);

            ScopeDisplayArrayList.Add(scopeDisplaySixsixth);

            foreach (ScopeDisplay scopeDisplay in ScopeDisplayArrayList)
            {
                scopeDisplay.Show();

                continue;
            }

            return;
        }

        ~ScopeDisplayContext()
        {
            CleanInstance();

            return;
        }

        public ScopeDisplayContext ExposeInstance()
        {
            Instance = this;

            return this;
        }

        public ScopeDisplayContext CleanInstance()
        {
            Instance = null;

            return this;
        }
    }
}
