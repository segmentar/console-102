using Core;

namespace Core
{
    using System;

    public partial class ReflectModuleFunctionSixty
    {
        public static ReflectModuleFunctionSixty[] FunctionDefaultSetSurface(String item_STRING, ReflectModuleFunctionFifty[] array_FUNCTION)
        {
            ReflectModuleFunctionSixty[] arrayResult = default;

            var list = FunctionDefaultSet(item_STRING, array_FUNCTION);

            var array = new ReflectModuleFunctionSixty[list.Count];

            list.CopyTo(array, ReflectPolicy.ReflectIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
    