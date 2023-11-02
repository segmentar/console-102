using Core;

namespace Core
{
    using System;

    public partial class Element
    {
        public Element(ElementStringSafe headerSubstring, ElementStringSafe bodySubstring, Boolean answer_DEBUG_is)
        {
            this.HeaderSubstring = headerSubstring;

            this.BodySubstring = bodySubstring;

            if (answer_DEBUG_is is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
