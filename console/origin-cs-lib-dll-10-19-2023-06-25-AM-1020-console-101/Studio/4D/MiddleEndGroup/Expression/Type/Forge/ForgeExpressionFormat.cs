using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static String ForgeExpressionFormat(String item_STRING, Boolean answer_VALIDATION_is)
        {
            String stringResult = default;

            var entity__WHITE_SPACE = Convert.ToChar(32);

            var entity__UNDER_SCORE = Convert.ToChar(95);

            var separator = new Char[] { entity__WHITE_SPACE, entity__UNDER_SCORE };

            var format = item_STRING.Trim(separator);

            var split = format.Split(separator, StringSplitOptions.None);

            if (answer_VALIDATION_is)
            {
                var entity_DASH = Convert.ToChar(45);

                var join = String.Join(entity_DASH.ToString(), split);

                stringResult = join;
            }
            else
            {
                var join = String.Join(entity__WHITE_SPACE.ToString(), split);

                stringResult = join;
            }

            return stringResult;
        }
    }
}
