using Core;

namespace Core
{
    using System;

    internal partial class Reflect
    {
        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Reflect) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(InputString) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(InputString) + ':' + ' ' + $"<safe><<{InputString.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(EscapeCharacterArray) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(EscapeCharacterArray) + ':' + ' ' + ". . ." + $"<{EscapeCharacterArray.CharacterArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + $"<safe><<{nameof(EscapeCharacterArray)}>>" + ':',
                String.Empty + String.Join('\n'.ToString(), EscapeCharacterArray.CharacterArraySafe)
            });
        }
    }
}
