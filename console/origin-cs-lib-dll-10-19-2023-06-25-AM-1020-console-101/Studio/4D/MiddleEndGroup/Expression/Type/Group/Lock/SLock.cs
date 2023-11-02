using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression SLock(String item_STRING)
        {
            Expression expressionResult = default;

            expressionResult = ILock(item_STRING, true);

            return expressionResult;
        }
    }
}
