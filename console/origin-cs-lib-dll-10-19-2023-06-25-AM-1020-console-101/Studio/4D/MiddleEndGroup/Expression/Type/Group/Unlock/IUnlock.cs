using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression IUnlock(String item_STRING)
        {
            Expression expressionResult = default;

            Expression expression;

            expression = SLock(item_STRING);

            IView(expression);

            expressionResult = expression;

            return expressionResult;
        }
    }
}
