using Core;

namespace Core
{
    using System;

    [IntentionalShortClass]
    public partial class ReflectModuleFunctionFourty
    {
        public Tuple<Char, Char, Boolean>[] TupleArray;

        public ReflectModuleFunctionFourty(Tuple<Char, Char, Boolean>[] tupleArray)
        {
            this.TupleArray = tupleArray;

            return;
        }

        ~ReflectModuleFunctionFourty()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(ReflectModuleFunctionFourty) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                String.Empty + ConsoleLJS.SafeTupleArrayString<Tuple<Char, Char, Boolean>>(TupleArray)
            });
        }
    }
}
