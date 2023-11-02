using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression ULock(String item_STRING)
        {
            Expression expressionResult = default;

            expressionResult = ILock(item_STRING, false);

            return expressionResult;
        }
    }
}
