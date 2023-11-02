using Core;

namespace Core
{
    using System;

    public partial class ExpressionSequence
    {

        [IntentionalShortMethod]
        public static void Debug(ExpressionStringSafe identityString, Object item_OBJECT, Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();

            ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Debug}-{nameof(Expression)}Debug", String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Expression) + ' ' + "::" + ' ' + nameof(ExpressionSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(identityString) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(identityString) + ':' + ' ' + $"<safe><<{identityString.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(item_OBJECT) + ':' + ' ' + item_OBJECT,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}'
            }));

            return;
        }
    }
}
