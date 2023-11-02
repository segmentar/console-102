using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression(ExpressionStringSafe stringIdentity, Object objectIdentity, Boolean debug)
        {
            this.StringIdentity = stringIdentity;

            this.ObjectIdentity = objectIdentity;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
