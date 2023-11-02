using Core;

namespace Core
{
    using System;

    public partial struct ReflectModule
    {
        public static ReflectModule ReflectModuleFive(ReflectModule module)
        {
            var array = ReflectModuleFunctionFifty.FunctionDefaultCompound(module.Reflect.InputString.StringValue, module.Fourth.Function.TupleArray);

            ReflectModuleFifth fifth;

            fifth = new ReflectModuleFifth(array);

            module.Fifth = fifth;

            return module;
        }
    }
}
