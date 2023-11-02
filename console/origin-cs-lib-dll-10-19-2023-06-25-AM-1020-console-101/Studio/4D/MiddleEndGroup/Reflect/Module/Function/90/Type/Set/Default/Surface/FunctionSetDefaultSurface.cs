using Core;

namespace Core
{
    using System;

    public partial class ReflectModuleFunctionNinety
    {
        public static ReflectModuleFunctionNinety[] FunctionDefaultSetSurface(ReflectModuleFunctionEighty[] array__FUNCTION, Tuple<Char, String[], String[]>[] array_TUPLE)
        {
            ReflectModuleFunctionNinety[] arrayResult = default;

            var list = FunctionDefaultSet(array__FUNCTION, array_TUPLE);

            var array = new ReflectModuleFunctionNinety[list.Count];

            list.CopyTo(array, ReflectPolicy.ReflectIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
