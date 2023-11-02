using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expression
    {
        public LinkedList<Expression> IMod()
        {
            LinkedList<Expression> listResult = default;

            var array = (Expression[])(ViewList.ToArray(typeof(Expression)) as Array);

            var list = new LinkedList<Expression>(array);

            listResult = list;

            return listResult;
        }
    }
}
