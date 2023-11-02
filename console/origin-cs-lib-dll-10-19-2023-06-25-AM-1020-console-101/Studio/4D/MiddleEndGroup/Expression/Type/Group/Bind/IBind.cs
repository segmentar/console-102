using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression IBind(Expression item_EXPRESSION, Object item_OBJECT)
        {
            Expression expressionResult = default;

            item_EXPRESSION.ObjectIdentity = item_OBJECT;
             
            return expressionResult;
        }
    }
}
