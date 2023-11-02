using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ProcessFileArray(String[] File_ARRAY)
        {
            var array = ScopeIgnoreSetSurface(File_ARRAY, "package");

            ProcessFileArrayInner(array);

            return;
        }
    }
}
