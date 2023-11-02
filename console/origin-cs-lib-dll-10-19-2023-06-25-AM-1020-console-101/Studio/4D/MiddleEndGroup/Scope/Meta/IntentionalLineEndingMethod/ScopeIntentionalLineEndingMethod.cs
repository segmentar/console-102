using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public partial class ScopeIntentionalLineEndingMethod : Attribute
    {
        public ScopeIntentionalLineEndingMethod()
        {
            return;
        }

        ~ScopeIntentionalLineEndingMethod()
        {
            return;
        }
    }
}
