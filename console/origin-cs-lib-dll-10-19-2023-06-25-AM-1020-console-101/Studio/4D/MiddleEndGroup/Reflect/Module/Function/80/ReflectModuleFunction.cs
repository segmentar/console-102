using Core;

namespace Core
{
    using System;

    [IntentionalShortClass]
    public partial class ReflectModuleFunctionEighty
    {
        public ReflectModuleFunctionSeventy Function;

        public ReflectStringSafe IdentityName;

        public ReflectStringSafe VirtualName;

        public Boolean StickyLeft;

        public Boolean StickyRight;

        public ReflectModuleFunctionEighty(ReflectModuleFunctionSeventy function, ReflectStringSafe identityName, ReflectStringSafe virtualName, Boolean stickyLeft, Boolean stickyRight)
        {
            this.Function = function;

            this.IdentityName = identityName;

            this.VirtualName = virtualName;

            this.StickyLeft = stickyLeft;

            this.StickyRight = stickyRight;

            return;
        }

        ~ReflectModuleFunctionEighty()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ReflectModuleFunctionEighty) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Function) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(IdentityName) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(IdentityName) + ':' + ' ' + $"<safe><<{IdentityName.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(VirtualName) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(VirtualName) + ':' + ' ' + $"<safe><<{VirtualName.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(StickyLeft) + ':' + ' ' + StickyLeft,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(StickyRight) + ':' + ' ' + StickyRight,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Function) + ':',
                String.Empty + Function

            });
        }
    }
}
