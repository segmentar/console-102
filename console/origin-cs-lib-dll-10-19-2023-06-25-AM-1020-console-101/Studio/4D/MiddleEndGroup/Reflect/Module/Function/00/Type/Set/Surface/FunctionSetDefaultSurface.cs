using Core;

namespace Core
{
    using System;

    public partial class ReflectModuleFunctionHundred
    {
        public static ReflectModuleFunctionHundred[] FunctionDefaultSetSurface(ReflectModuleFunctionNinety[] array_FUNCTION)
        {
            ReflectModuleFunctionHundred[] arrayResult = default;

            var list = FunctionDefaultSet(array_FUNCTION);

            var array = new ReflectModuleFunctionHundred[list.Count];

            list.CopyTo(array, ReflectPolicy.ReflectIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
