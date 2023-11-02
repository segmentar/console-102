using Core;

namespace Core
{
    using System;

    [IntentionalShortClass]
    public partial class ReflectModuleFunctionTwenty
    {
        public Tuple<Char, String[]>[] TupleArray;

        public ReflectModuleFunctionTwenty(Tuple<Char, String[]>[] tupleArray)
        {
            this.TupleArray = tupleArray;

            return;
        }

        ~ReflectModuleFunctionTwenty()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 

                String.Empty + nameof(ReflectModuleFunctionTwenty) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                String.Empty + ConsoleLJS.SafeTupleArrayString<Tuple<Char, String[]>>(TupleArray)
            });
        }
    }
}
