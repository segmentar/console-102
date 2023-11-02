using Core;

namespace Core
{
    using System;
    internal partial class ReflectSequence
    {
        internal Reflect Result { get; set; } = default;
        
        internal ReflectSequence(ReflectStringFormat stringFormat, Char[] array_CHARACTER, Boolean answer_DEBUG_is)
        {
            Debug(stringFormat, array_CHARACTER, answer_DEBUG_is);

            String inputString, inputStringSafe;

            inputString = stringFormat.StringValueFormat;

            inputStringSafe = ConsoleLJS.SafeString(inputString);

            ReflectStringSafe reflectString;

            reflectString = new ReflectStringSafe();

            reflectString.StringValue = inputString;

            reflectString.StringValueSafe = inputStringSafe;

            Char[] characterArray, characterArraySafe;

            characterArray = array_CHARACTER;

            characterArraySafe = ConsoleLJS.SafeCharacterArray(characterArray);

            ReflectCharacterArraySafe reflectCharacterArray;

            reflectCharacterArray = new ReflectCharacterArraySafe();

            reflectCharacterArray.CharacterArray = characterArray;

            reflectCharacterArray.CharacterArraySafe = characterArraySafe;

            Reflect reflect;

            reflect = new Reflect(reflectString, reflectCharacterArray, answer_DEBUG_is);

            this.Result = reflect;

            return;
        }

        ~ReflectSequence()
        {
            return;
        }
    }
}
