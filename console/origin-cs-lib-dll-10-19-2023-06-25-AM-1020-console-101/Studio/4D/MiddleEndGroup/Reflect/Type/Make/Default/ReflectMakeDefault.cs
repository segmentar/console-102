using Core;

namespace Core
{
    using System;

    internal partial class Reflect
    {
        internal static Reflect MakeReflectDefault(ReflectStringFormat stringFormat, Char[] array_CHARACTER, Boolean answer_DEBUG_is)
        {
            Reflect reflectResult = default;

            var result = new ReflectSequence(stringFormat, array_CHARACTER, answer_DEBUG_is).Result;

            ReflectPolicy.ReflectArrayList.Add(result);

            reflectResult = result;

            return reflectResult;
        }
    }
}
