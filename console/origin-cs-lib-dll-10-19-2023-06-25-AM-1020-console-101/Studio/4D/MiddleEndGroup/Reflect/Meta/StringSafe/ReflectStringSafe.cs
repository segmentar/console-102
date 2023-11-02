using Core;

namespace Core
{
    using System;

    public partial struct ReflectStringSafe : IStringSafe
    {
        public String StringValue { get; set; }
        public String StringValueSafe { get; set; }
    }
}
