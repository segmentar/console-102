using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void IView(Expression item_EXPRESSION)
        {
            ViewList.Add(item_EXPRESSION);

            return;
        }
    }
}
