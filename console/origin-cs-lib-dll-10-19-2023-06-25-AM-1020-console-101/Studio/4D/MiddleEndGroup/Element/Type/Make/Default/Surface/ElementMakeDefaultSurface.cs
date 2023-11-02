using Core;

namespace Core
{
    using System;

    public partial class Element
    {
        public static Element MakeElementDefaultSurface(String HeaderSubstring__ITEM, String BodySubstring__ITEM)
        {
            Element elementResult = default;

            elementResult = MakeElementDefault(HeaderSubstring__ITEM, BodySubstring__ITEM, ElementPolicy.ElementDebugPolicy);

            return elementResult;
        }
    }
}
