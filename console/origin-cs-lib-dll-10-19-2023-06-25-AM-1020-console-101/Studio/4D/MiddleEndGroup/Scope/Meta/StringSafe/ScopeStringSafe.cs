using Core;

namespace Core
{
    using System;

    public partial struct ScopeStringSafe
    {
        public String StringValue { get; set; }
        public String StringValueSafe { get; set; }

        public static ScopeStringSafe Simple(String item_STRING)
        {
            ScopeStringSafe safeResult = default;

            String stringValue, stringValueSafe;

            stringValue = item_STRING;

            stringValueSafe = ConsoleLJS.SafeString(stringValue);

            ScopeStringSafe safe;

            safe = new ScopeStringSafe();

            safe.StringValue = stringValue;

            safe.StringValueSafe = stringValueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
