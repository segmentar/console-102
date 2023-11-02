using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureQuery
    {
        [ScopeIntentionalShortMethod]
        [ScopeIntentionalLineEndingMethod]
        public override String ToString()
        {
            return String.Join("\r\n".ToString(), new String[] {

                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureQuery) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(LocalLineArrayList) + ':' + ' ' + ". . ." + ' ' + $"<{LocalLineArrayList.Count}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(GlobalLineArrayList) + ':' + ' ' + ". . ." + ' ' + $"<{GlobalLineArrayList.Count}>", 
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(LocalLineArrayList) + ':',
                String.Empty + String.Join("\n".ToString(), LocalLineArrayList.ToArray()),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(GlobalLineArrayList) + ':',
                String.Empty + String.Join('\n'.ToString(), GlobalLineArrayList.ToArray())
            });
        }
    }
}
