using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial class ReflectModuleFunctionSeventy
    {
        public static T[] FunctionLayerContainerSurface<T>(ReflectModuleFunctionSixty[] array_FUNCTION)
        {
            T[] arrayResult = default;

            var list = FunctionLayerContainer(array_FUNCTION);

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            T[] array;

            array = reflect;

            arrayResult = array;

            return arrayResult;
        }
    }
}
