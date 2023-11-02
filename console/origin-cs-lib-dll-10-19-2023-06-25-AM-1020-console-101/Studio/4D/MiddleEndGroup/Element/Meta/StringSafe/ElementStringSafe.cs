using Core;

namespace Core
{
    using System;

    public partial struct ElementStringSafe
    {
        public String StringValue { get; set; }
        public String StringValueSafe { get; set; }

        public static ElementStringSafe Simple(String item_STRING)
        {
            ElementStringSafe safeResult = default;

            String stringValue, stringValueSafe;

            stringValue = item_STRING;

            stringValueSafe = ConsoleLJS.SafeString(stringValue);

            ElementStringSafe safe;

            safe = new ElementStringSafe();

            safe.StringValue = stringValue;

            safe.StringValueSafe = stringValueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
