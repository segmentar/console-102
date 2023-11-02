using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureFileArray
    {
        [ScopeIntentionalShortMethod]
        [ScopeIntentionalLineEndingMethod]
        public override String ToString()
        {
            return String.Join("\r\n".ToString(), new String[] {

                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureFileArray) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(FileArray) + ':' + ' ' + ". . ." + ' ' + $"<{FileArray.Length}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(FilePointer) + ':' + ' ' + FilePointer,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Filename) + ':' + ' ' + Filename,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Text) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Text) + ':' + ' ' + Text.StringValueSafe,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FileArray) + ':',
                String.Empty + String.Join("\n".ToString(), FileArray)
            });
        }
    }
}
