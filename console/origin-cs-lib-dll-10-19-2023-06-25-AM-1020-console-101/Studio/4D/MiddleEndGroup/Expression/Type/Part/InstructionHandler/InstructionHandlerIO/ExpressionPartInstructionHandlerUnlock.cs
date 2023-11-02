using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartUnlock(String[] array_STRING, Stack item_STACK, String item_STRING, String item_LOWER, String[] array_SPLIT)
        {
            switch (item_LOWER)
            {
                case ExpressionConstant.InstructionUNLOCK:
                    HUnlock(array_SPLIT);
                    break;

                case ExpressionConstant.InstructionVUNLOCK:
                    HVUnlock(array_SPLIT);
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
