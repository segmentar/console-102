using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Scope
    {
        public static void DirectionBackward()
        {
            Boolean shouldReturnCheck;

            shouldReturnCheck = MeasureWait.LinkedListPointer.Equals(0) is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MeasureWait.LinkedListPointer = MeasureWait.LinkedListPointer - 1;

            var node = new ArrayList(MeasureWait.LinkedList)[MeasureWait.LinkedListPointer];

            var reflect = (Tuple<String, String, String, String, String, String>)(node as Object);

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[0] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = reflect.Item1.ToString();

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[1] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = reflect.Item2.ToString();

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[2] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = reflect.Item3.ToString();

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[3] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = reflect.Item4.ToString();

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[4] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = reflect.Item5.ToString();

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[5] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = reflect.Item6.ToString();

            return;
        }
    }
}
