using Core;

namespace Core
{
    using System;

    public partial class ReflectModuleFunctionSeventy
    {
        public static ReflectModuleFunctionSeventy[] FunctionDefaultSetSurface(String item_STRING, ReflectModuleFunctionSixty[] array_FUNCTION)
        {
            ReflectModuleFunctionSeventy[] arrayResult = default;

            var list = FunctionDefaultSet(item_STRING, array_FUNCTION);

            var array = new ReflectModuleFunctionSeventy[list.Count];

            list.CopyTo(array, ReflectPolicy.ReflectIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
    