using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartZeroTen(String[] array_STRING)
        {
            var stack = new Stack(array_STRING);

            stack = new Stack(stack);

            do
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = stack.Count.Equals(0) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var reflect = (String)(stack.Pop() as Object);

                ExpressionInstructionHandlerPartOneFirst(array_STRING, stack, reflect);

                continue;

            } while (true);

            return;
        }
    }
}
