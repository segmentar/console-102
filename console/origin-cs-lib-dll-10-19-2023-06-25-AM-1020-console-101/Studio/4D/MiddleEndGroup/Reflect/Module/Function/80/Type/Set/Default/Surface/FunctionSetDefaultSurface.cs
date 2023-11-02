using Core;

namespace Core
{
    using System;

    public partial class ReflectModuleFunctionEighty
    {
        public static ReflectModuleFunctionEighty[] FunctionDefaultSetSurface(String item_STRING, ReflectModuleFunctionSeventy[] array_FUNCTION, Char[] array_CHARACTER)
        {
            ReflectModuleFunctionEighty[] arrayResult = default;

            var list = FunctionDefaultSet(item_STRING, array_FUNCTION, array_CHARACTER);

            var array = new ReflectModuleFunctionEighty[list.Count];

            list.CopyTo(array, ReflectPolicy.ReflectIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
