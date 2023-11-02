using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression MakeExpressionDefaultSurfaceSimple(String item_STRING, Object item_OBJECT)
        {
            Expression expressionResult = default;

            String stringValue, stringValueSafe;

            stringValue = item_STRING;

            stringValueSafe = ConsoleLJS.SafeString(stringValue);

            var ExpressionStringSafe___STRING_IDENTITY = new ExpressionStringSafe();

            ExpressionStringSafe___STRING_IDENTITY.StringValue = stringValue;

            ExpressionStringSafe___STRING_IDENTITY.StringValueSafe = stringValueSafe;

            expressionResult = MakeExpressionDefault(ExpressionStringSafe___STRING_IDENTITY, item_OBJECT, ExpressionPolicy.ExpressionDebugPolicy);

            return expressionResult;
        }
    }
}
