using Core;

namespace Core
{
    using System;

    internal partial class Reflect
    {
        internal Reflect(ReflectStringSafe inputString, ReflectCharacterArraySafe escapeCharacterArray, Boolean answer_DEBUG_is)
        {
            this.InputString = inputString;

            this.EscapeCharacterArray = escapeCharacterArray;

            if (answer_DEBUG_is is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
