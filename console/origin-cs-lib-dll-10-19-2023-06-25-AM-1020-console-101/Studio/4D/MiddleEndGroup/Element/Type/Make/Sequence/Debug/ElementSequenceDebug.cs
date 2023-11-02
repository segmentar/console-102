using Core;

namespace Core
{
    using System;

    public partial class ElementSequence
    {
        [IntentionalShortMethod]
        public static void Debug(String HeaderSubstring__ITEM, String BodySubstring__ITEM, Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            var join = String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Element) + ' ' + "::" + ' ' + nameof(ElementSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(HeaderSubstring__ITEM) + ':' + ' ' + HeaderSubstring__ITEM,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(BodySubstring__ITEM) + ':' + ' ' + BodySubstring__ITEM,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}'
            });

            ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Debug}-{nameof(Element)}Debug", join);

            return;
        }
    }
}
