using Core;

namespace Core
{
    using System;

    [IntentionalShortClass]
    public partial class ReflectModuleFunctionNinety
    {
        public ReflectModuleFunctionEighty Function;

        public ReflectStringSafe ValueString;

        public ReflectModuleFunctionNinety(ReflectModuleFunctionEighty function, ReflectStringSafe valueString)
        {
            this.Function = function;

            this.ValueString = valueString;

            return;
        }

        ~ReflectModuleFunctionNinety()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ReflectModuleFunctionNinety) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Function) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ValueString) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ValueString) + ':' + ' ' + $"<safe><<{ValueString.StringValueSafe}>>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Function) + ':',
                String.Empty + Function
            });
        }
    }
}
