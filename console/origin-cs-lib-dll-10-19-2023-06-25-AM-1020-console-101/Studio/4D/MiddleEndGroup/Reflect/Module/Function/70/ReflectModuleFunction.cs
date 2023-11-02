using Core;

namespace Core
{
    using System;

    using System.Collections;

    [IntentionalShortClass]
    public partial class ReflectModuleFunctionSeventy
    {
        public ReflectModuleFunctionSixty Function;

        public ReflectModuleFunctionSixty FunctionParent;

        public ArrayList FunctionArray = new ArrayList();

        public ReflectModuleFunctionSeventy()
        {
            return;
        }

        ~ReflectModuleFunctionSeventy()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ReflectModuleFunctionSeventy) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Function) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(FunctionParent) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(FunctionArray) + ':' + ' ' + ". . ." + ' ' + $"<{FunctionArray.Count}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Function) + ':',
                String.Empty + Function,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(FunctionParent) + ':',
                String.Empty + FunctionParent,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(FunctionArray) + ':',
                String.Empty + String.Join('\n'.ToString(), FunctionArray.ToArray())
            });
        }
    }
}
