using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public partial class ScopeIntentionalLineEndingClass : Attribute
    {
        public ScopeIntentionalLineEndingClass()
        {
            return;
        }

        ~ScopeIntentionalLineEndingClass()
        {
            return;
        }
    }
}
