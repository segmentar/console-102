using Core;

namespace Core
{
    using System;

    public partial class Element
    {
        public static Element MakeElementDefault(String HeaderSubstring__ITEM, String BodySubstring__ITEM, Boolean answer_DEBUG_is)
        {
            Element elementResult = default;

            var result = new ElementSequence(HeaderSubstring__ITEM, BodySubstring__ITEM, answer_DEBUG_is).Result;

            ElementPolicy.ElementArrayList.Add(result);

            elementResult = result;

            return elementResult;
        }
    }
}
