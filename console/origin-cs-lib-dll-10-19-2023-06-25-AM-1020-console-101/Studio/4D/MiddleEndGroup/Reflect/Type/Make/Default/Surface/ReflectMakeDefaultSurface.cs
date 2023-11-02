using Core;

namespace Core
{
    using System;

    internal partial class Reflect
    {
        internal static Reflect MakeReflectDefaultSurface(ReflectStringFormat stringFormat, Char[] array_CHARACTER)
        {
            Reflect reflectResult = default;

            reflectResult = MakeReflectDefault(stringFormat, array_CHARACTER, ReflectPolicy.ReflectDebugPolicy);

            return reflectResult;
        }
    }
}
