using Core;

namespace Core
{
    using System;

    public partial class ReflectModuleFirst
    {
        public ReflectModuleFunctionTen Function;

        public ReflectModuleFirst(ReflectModuleFunctionTen function)
        {
            this.Function = function;

            return;
        }

        ~ReflectModuleFirst()
        {
            return;
        }
    }
}
