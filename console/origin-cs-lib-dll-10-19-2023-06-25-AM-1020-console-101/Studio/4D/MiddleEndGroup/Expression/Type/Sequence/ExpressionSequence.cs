using Core;

namespace Core
{
    using System;

    public partial class ExpressionSequence
    {
        public Expression Result { get; set; } = default;

        public ExpressionSequence(ExpressionStringSafe identityString, Object item_OBJECT, Boolean debug)
        {
            Debug(identityString, item_OBJECT, debug);

            Expression expression;

            expression = new Expression(identityString, item_OBJECT, debug);

            this.Result = expression;

            return;
        }

        ~ExpressionSequence()
        {
            return;
        }
    }
}
