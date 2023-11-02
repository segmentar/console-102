using Core;

namespace Core
{
    using System;

    public static partial class ScopeImmutable
    {
        public static readonly String FormStringStart;

        public static readonly String FormStringEnd;

        static ScopeImmutable()
        {
            var Entity_PERIOD = Convert.ToChar(46);

            FormStringStart = Entity_PERIOD.ToString();

            FormStringEnd = new String(Entity_PERIOD, 5);

            return;
        }
    }
}
