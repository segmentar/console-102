using Core;

namespace Core
{
    using System;

    public partial class Element
    {
        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Element) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(HeaderSubstring) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(HeaderSubstring) + ':' + ' ' + $"<safe><<{HeaderSubstring.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(BodySubstring) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(BodySubstring) + ':' + ' ' + $"<safe><<{BodySubstring.StringValueSafe}>>",
                String.Empty + '}'
            });
        }
    }
}
