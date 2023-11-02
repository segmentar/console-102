using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureFlag
    {
        [ScopeIntentionalShortMethod]
        [ScopeIntentionalLineEndingMethod]
        public override String ToString()
        {
            return String.Join("\r\n".ToString(), new String[] {

                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureFlag) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(EndOfFileArrayFlag) + ':' + ' ' + EndOfFileArrayFlag,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(EndOfFileFlag) + ':' + ' ' + EndOfFileFlag,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(StepLocalLineFlag) + ':' + ' ' + StepLocalLineFlag,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(StepGlobalLineFlag) + ':' + ' ' + StepGlobalLineFlag,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(StepLineFlag) + ':' + ' ' + StepLineFlag,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(StepOutsideFlag) + ':' + ' ' + StepOutsideFlag,
                String.Empty + '}'
            });
        }
    }
}
