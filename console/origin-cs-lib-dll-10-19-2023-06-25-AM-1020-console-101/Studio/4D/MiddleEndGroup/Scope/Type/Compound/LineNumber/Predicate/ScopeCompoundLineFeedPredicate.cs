using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static Boolean LineFeedCompoundPredicate(Char character)
        {
            Boolean booleanResult = default;

            var Entity_LINE_FEED = Convert.ToChar(10);

            Boolean isLineFeedContagentCheck;

            isLineFeedContagentCheck = character.Equals(Entity_LINE_FEED) is true;

            if (isLineFeedContagentCheck)
            {
                booleanResult = true;
            }
            else
            {
                booleanResult = false;
            }

            return booleanResult;
        }
    }
}
