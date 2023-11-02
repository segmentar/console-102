using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression UPeek(String item_STRING)
        {
            Expression expressionResult = default;

            foreach (Expression expression in ExpressionAllSetSurface(this))
            {
                var entity__UNDER_SCORE = Convert.ToChar(95);

                var split = expression.StringIdentity.StringValue.Split(new String[] { entity__UNDER_SCORE.ToString() }, StringSplitOptions.RemoveEmptyEntries);

                var entity__WHITE_SPACE = Convert.ToChar(32);

                var join = String.Join(entity__WHITE_SPACE.ToString(), split);

                var result = join;

                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = item_STRING.Equals(result) is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                expressionResult = expression;

                continue;
            }

            return expressionResult;
        }
    }
}
