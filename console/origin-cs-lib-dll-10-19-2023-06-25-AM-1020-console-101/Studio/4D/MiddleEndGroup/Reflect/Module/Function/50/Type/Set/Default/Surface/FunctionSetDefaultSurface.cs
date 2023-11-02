using Core;

namespace Core
{
    using System;

    public partial class ReflectModuleFunctionFifty
    {
        public static ReflectModuleFunctionFifty[] FunctionDefaultSetSurface(String item_STRING, Tuple<Char, Char, Boolean>[] array_TUPLE)
        {
            ReflectModuleFunctionFifty[] arrayResult = default;

            var list = FunctionDefaultSet(item_STRING, array_TUPLE);

            var array = new ReflectModuleFunctionFifty[list.Count];

            list.CopyTo(array, ReflectPolicy.ReflectIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
