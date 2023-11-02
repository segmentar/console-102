using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartRelease(String[] array_STRING, Stack item_STACK, String item_STRING, String item_LOWER, String[] array_SPLIT)
        {
            switch (item_LOWER)
            {
                case ExpressionConstant.InstructionRELEASE:
                    HRelease();
                    break;

                case ExpressionConstant.InstructionVRELEASE:
                    HVRelease();
                    break;

                case ExpressionConstant.InstructionBRELEASE:
                    HBRelease();
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
