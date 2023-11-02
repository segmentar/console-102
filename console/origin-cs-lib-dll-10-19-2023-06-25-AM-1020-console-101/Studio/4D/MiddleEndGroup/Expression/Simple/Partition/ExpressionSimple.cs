using Core;

namespace Core
{
    using System;

    public partial class ExpressionSimple
    {
        public Expression Result { get; set; } = default;

        public ExpressionSimple()
        {
            return;
        }

        ~ExpressionSimple()
        {
            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class ExpressionSimple
    {
        public ExpressionSimple(ExpressionStringSafe stringIdentity, Object objectIdentity, params String[] stringArray)
        {
            Expression expression;

            expression = Expression.MakeExpressionDefaultSurface(stringIdentity, objectIdentity);

            foreach (String stringItem in stringArray)
            {
                Expression expressionEmpty;

                expressionEmpty = Expression.MakeExpressionEmpty();

                var StringIdentity__EXPRESSION_STRING_SAFE = ExpressionStringSafe.Simple(stringItem);

                expressionEmpty.StringIdentity = StringIdentity__EXPRESSION_STRING_SAFE;

                expression.ExpressionArrayList.Add(expressionEmpty);

                continue;
            }

            this.Result = expression;

            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class ExpressionSimple
    {
        public ExpressionSimple(ExpressionStringSafe stringIdentity, Object objectIdentity, params Object[] objectArray)
        {
            Expression expression;

            expression = Expression.MakeExpressionDefaultSurface(stringIdentity, objectIdentity);

            foreach (Object objectItem in objectArray)
            {
                Expression expressionEmpty;

                expressionEmpty = Expression.MakeExpressionEmpty();

                expressionEmpty.ObjectIdentity = objectItem;

                expression.ExpressionArrayList.Add(expressionEmpty);

                continue;
            }

            this.Result = expression;

            return;
        }
    }
}