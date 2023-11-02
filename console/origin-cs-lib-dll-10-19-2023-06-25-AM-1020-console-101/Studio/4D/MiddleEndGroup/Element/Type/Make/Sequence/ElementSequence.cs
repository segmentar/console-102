using Core;

namespace Core
{
    using System;

    public partial class ElementSequence
    {
        public Element Result { get; set; } = default;

        public ElementSequence(String HeaderSubstring__ITEM, String BodySubstring__ITEM, Boolean answer_DEBUG_is)
        {
            Debug(HeaderSubstring__ITEM, BodySubstring__ITEM, answer_DEBUG_is);

            var HeaderSubstringSafe___ITEM = ElementStringSafe.Simple(HeaderSubstring__ITEM);

            var BodySubstringSafe___ITEM = ElementStringSafe.Simple(BodySubstring__ITEM);

            Element element;

            element = new Element(HeaderSubstringSafe___ITEM, BodySubstringSafe___ITEM, answer_DEBUG_is);

            this.Result = element;

            return;
        }

        ~ElementSequence()
        {
            return;
        }
    }
}
