﻿using Core;

namespace Core
{
    using System;

    using System.Linq;

    public partial class Scope
    {
        public static Int32 LineNumberCompound(String Text_ITEM)
        {
            Int32 integerResult = default;

            var predicate = new Func<Char, Boolean>(LineFeedCompoundPredicate);

            var count = Text_ITEM.Count<Char>(predicate);

            var total = (count + 1);

            var result = total;

            integerResult = result;

            return integerResult;
        }
    }
}
