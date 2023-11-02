using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression IOperation(String item_STRING)
        {
            Expression expressionResult = default;

            var list = IMod();

            Expression expression;

            expression = list.Last.Value;

            expressionResult = expression;

            return expressionResult;
        }
    }
}
