using Core;

namespace Core
{
    using System;

    [IntentionalShortClass]
    public partial class ReflectModuleFunctionSixty
    {
        public ReflectModuleFunctionFifty Left;

        public ReflectModuleFunctionFifty Right;

        public ReflectStringSafe ValueString;

        public Int32 Layer;

        public ReflectModuleFunctionSixty(ReflectModuleFunctionFifty left, ReflectModuleFunctionFifty right, ReflectStringSafe valueString, Int32 layer)
        {
            this.Left = left;

            this.Right = right;

            this.ValueString = valueString;

            this.Layer = layer;

            return;
        }

        ~ReflectModuleFunctionSixty()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ReflectModuleFunctionSixty) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Left) + ':' + ' ' + ". . ." + ' ' + $"<{(Left == default)}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Right) + ':' + ' ' + ". . ." + ' ' + $"<{(Right == default)}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ValueString) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ValueString) + ':' + ' ' + $"<safe><<{ValueString.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Left) + ':',
                String.Empty + Left,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Right) + ':',
                String.Empty + Right
            });
        }
    }
}
