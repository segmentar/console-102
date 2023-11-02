using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial class ReflectModuleFunctionTwenty
    {
        public static T[] FunctionTupleArrayContainerSurface<T>(String item_STRING, Char[] array_CHARACTER)
        {
            T[] arrayResult = default;

            var list = FunctionTupleArrayContainer(item_STRING, array_CHARACTER);

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
