using Core;

namespace Core
{
    using System;

    public partial class ReflectModuleFunctionFifty
    {
        public static ReflectModuleFunctionFifty[] FunctionDefaultCompound(String item_STRING, Tuple<Char, Char, Boolean>[] array_TUPLE)
        {
            ReflectModuleFunctionFifty[] arrayResult = default;

            var array = FunctionDefaultSetSurface(item_STRING, array_TUPLE);

            FunctionProofVoid(item_STRING, array);

            arrayResult = array;

            return arrayResult;
        }
    }
}
