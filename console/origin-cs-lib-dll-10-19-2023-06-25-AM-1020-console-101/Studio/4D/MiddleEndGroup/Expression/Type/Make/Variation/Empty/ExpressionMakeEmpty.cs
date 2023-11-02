using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression MakeExpressionEmpty()
        {
            Expression expressionResult = default;

            ExpressionStringSafe expressionStringSafe;

            expressionStringSafe = new ExpressionStringSafe();

            Expression expression;

            expression = MakeExpressionDefaultSurface(expressionStringSafe, default(Object));

            expressionResult = expression;

            return expressionResult;
        }
    }
}
