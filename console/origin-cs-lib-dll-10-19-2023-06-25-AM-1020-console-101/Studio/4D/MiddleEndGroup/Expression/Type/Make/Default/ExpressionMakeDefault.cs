using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression MakeExpressionDefault(ExpressionStringSafe identityString, Object item_OBJECT, Boolean debug)
        {
            Expression expressionResult = default;

            var result = new ExpressionSequence(identityString, item_OBJECT, debug).Result;

            ExpressionPolicy.ExpressionArrayList.Add(result);

            expressionResult = result;

            return expressionResult;
        }
    }
}
