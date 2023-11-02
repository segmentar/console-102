using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureValue
    {

        [ScopeIntentionalShortMethod]
        [ScopeIntentionalLineEndingMethod]
        public override String ToString()
        {
            return String.Join("\r\n".ToString(), new String[] { 
            
                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureValue) + ' ' + ':',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(StepLineSubstring) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(StepLineSubstring) + ':' + ' ' + $"<safe><<{StepLineSubstring.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(FormEndPosition) + ':' + ' ' + FormEndPosition,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(StepOutsideSubstring) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(StepOutsideSubstring) + ':' + ' ' + $"<safe><<{StepOutsideSubstring.StringValueSafe}>>",
                String.Empty + '}'
            });
        }
    }
}
