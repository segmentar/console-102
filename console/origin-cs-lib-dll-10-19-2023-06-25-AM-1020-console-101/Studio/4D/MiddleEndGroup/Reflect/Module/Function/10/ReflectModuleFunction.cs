using Core;

namespace Core
{
    using System;

    [IntentionalShortClass]
    public partial class ReflectModuleFunctionTen
    {
        public ReflectStringSafe StringResult;

        public Tuple<Char, String[]>[] TupleArray;

        public ReflectModuleFunctionTen(ReflectStringSafe stringResult, Tuple<Char, String[]>[] tupleArray)
        {
            this.StringResult = stringResult;

            this.TupleArray = tupleArray;

            return;
        }

        ~ReflectModuleFunctionTen()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[]
            {
                String.Empty + nameof(ReflectModuleFunctionTen) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(StringResult) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(StringResult) + ':' + ' ' + $"<safe><<{StringResult.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                String.Empty + ConsoleLJS.SafeTupleArrayString<Tuple<Char, String[]>>(TupleArray)
            });
        }
    }
}
