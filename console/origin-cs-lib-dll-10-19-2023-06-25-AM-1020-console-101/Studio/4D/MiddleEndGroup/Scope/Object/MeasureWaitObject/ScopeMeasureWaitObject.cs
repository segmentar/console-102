using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureWait
    {
        [ScopeIntentionalShortMethod]
        [ScopeIntentionalLineEndingMethod]
        public override String ToString()
        {
            return String.Join("\r\n".ToString(), new String[] {

                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureWait) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsPause) + ':' + ' ' + IsPause,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(WaitAfterStart) + ':' + ' ' + WaitAfterStart,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(WaitEverybody) + ':' + ' ' + WaitEverybody,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(WaitBeforeEnd) + ':' + ' ' + WaitBeforeEnd,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(LinkedList) + ':' + ' ' + "<hidden>" + ' ' + $"<{LinkedList.Count}>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(LinkedListPointer) + ':' + ' ' + LinkedListPointer,
                String.Empty + '}'
            });
        }
    }
}
