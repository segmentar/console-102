using Core;

namespace Core
{
    using System;

    [IntentionalShortClass]
    public partial class ReflectModuleFunctionThirty
    {
        public Tuple<Char, String[], String[]>[] TupleArray;

        public ReflectModuleFunctionThirty(Tuple<Char, String[], String[]>[] tupleArray)
        {
            this.TupleArray = tupleArray;

            return;
        }

        ~ReflectModuleFunctionThirty()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ReflectModuleFunctionThirty) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                String.Empty + ConsoleLJS.SafeTupleArrayString<Tuple<Char, String[], String[]>>(TupleArray)
            });
        }
    }
}
