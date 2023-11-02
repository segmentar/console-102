using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        [SymmetryUsageMethod]
        public Expression ILock(String item_STRING, Boolean answer_SAFE_is)
        {
            Expression expressionResult = default;

            var list = IMod();

            Expression currentExpression;

            currentExpression = list.Last.Value;
            
            Expression expression;

            expression = MakeExpressionDefaultSurfaceSimple(item_STRING, default(Object));

            if (answer_SAFE_is is true)
            {
                var boolean_match_CONTAIN_is = false;

                var childExpression = default(Expression);

                foreach (Expression expressionChild in currentExpression.ExpressionArrayList)
                {
                    childExpression = expressionChild;

                    Boolean isEqualCheck, shouldContinueCheck;

                    isEqualCheck = expressionChild.StringIdentity.StringValue.Equals(item_STRING) is true;

                    shouldContinueCheck = isEqualCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    boolean_match_CONTAIN_is = true;

                    break;
                }

                Boolean isContainCheck;

                isContainCheck = boolean_match_CONTAIN_is is true;

                if (isContainCheck)
                {
                    IView(childExpression);

                    expressionResult = childExpression;
                }
                else
                {
                    currentExpression.ExpressionArrayList.Add(expression);

                    expressionResult = expression;
                }
            }
            else
            {
                currentExpression.ExpressionArrayList.Add(expression);

                expressionResult = expression;
            }

            return expressionResult;
        }
    }
}
