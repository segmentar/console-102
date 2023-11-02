using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureFile
    {
        [ScopeIntentionalShortMethod]
        [ScopeIntentionalLineEndingMethod]
        public override String ToString()
        {
            return String.Join("\r\n".ToString(), new String[] {

                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureFile) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(PhysicalOffset) + ':' + ' ' + PhysicalOffset,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(VirtualOffset) + ':' + ' ' + VirtualOffset,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(LineNumber) + ':' + ' ' + LineNumber,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Character) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Character) + ':' + ' ' + $"<safe><<{Character.CharacterValueSafe}>>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(Line) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(Line) + ':' + ' ' + $"<safe><{Line.StringValueSafe}>",
                String.Empty + '}'
            });
        }
    }
}
