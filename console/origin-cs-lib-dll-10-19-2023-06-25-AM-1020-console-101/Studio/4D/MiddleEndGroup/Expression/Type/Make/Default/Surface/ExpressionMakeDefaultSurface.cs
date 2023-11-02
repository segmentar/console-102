using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression MakeExpressionDefaultSurface(ExpressionStringSafe stringIdentity, Object item_OBJECT)
        {
            Expression expressionResult = default;

            expressionResult = MakeExpressionDefault(stringIdentity, item_OBJECT, ExpressionPolicy.ExpressionDebugPolicy);

            return expressionResult;
        }
    }
}
