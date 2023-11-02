using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial class ReflectModuleFunctionFourty
    {
        public static T[] ReflectDefaultContainerSurface<T>(Char[] array_OPEN, Char[] array_CLOSE)
        {
            T[] arrayResult = default;

            var list = ReflectDefaultContainer(array_OPEN, array_CLOSE);

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
