using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class ScopeTextBox : TextBox
    {
        public ScopeTextBox()
        {
            this.WordWrap = ScopeTextBoxImmutable.WordWrap;

            this.ReadOnly = ScopeTextBoxImmutable.ReadOnly;

            this.Multiline = ScopeTextBoxImmutable.Multiline;

            this.ForeColor = ScopeTextBoxImmutable.ForeColor;

            this.BackColor = ScopeTextBoxImmutable.BackColor;

            this.Dock = ScopeTextBoxImmutable.Dock;

            this.Font = ScopeTextBoxImmutable.Font;

            return;
        }

        ~ScopeTextBox()
        {
            return;
        }
    }
}
