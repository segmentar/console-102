using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression MakeExpressionRoot()
        {
            Expression expressionResult = default;

            String stringValue, stringValueSafe;

            stringValue = "root";

            stringValueSafe = ConsoleLJS.SafeString(stringValue);

            ExpressionStringSafe expressionStringSafe;

            expressionStringSafe = new ExpressionStringSafe();

            expressionStringSafe.StringValue = stringValue;

            expressionStringSafe.StringValueSafe = stringValueSafe;

            Expression expression;

            expression = MakeExpressionDefaultSurface(expressionStringSafe, default(Object));

            expressionResult = expression;

            return expressionResult;
        }
    }
}
