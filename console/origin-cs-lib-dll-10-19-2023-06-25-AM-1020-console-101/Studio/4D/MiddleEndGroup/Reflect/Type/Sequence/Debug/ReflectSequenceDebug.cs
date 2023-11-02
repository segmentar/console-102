using Core;

namespace Core
{
    using System;

    internal partial class ReflectSequence
    {
        [IntentionalShortMethod]
        internal static void Debug(ReflectStringFormat stringFormat, Char[] array_CHARACTER, Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Debug}-{nameof(Reflect)}Debug", String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Reflect) + ' ' + "::" + ' ' + nameof(ReflectSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(stringFormat) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(array_CHARACTER) + ':' + ' ' + ". . ." + $"<{array_CHARACTER.Length}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(stringFormat) + ':',
                String.Empty + stringFormat,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + $"<safe><<{nameof(array_CHARACTER)}>>" + ':',
                String.Empty + String.Join('\n'.ToString(), ConsoleLJS.SafeCharacterArray(array_CHARACTER))
            }));

            return;
        }
    }
}
