using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartBind(String[] array_STRING, Stack item_STACK, String item_STRING, String item_LOWER, String[] array_SPLIT)
        {
            switch (item_LOWER)
            {
                case ExpressionConstant.InstructionBIND:
                    HBind(array_SPLIT);
                    break;

                case ExpressionConstant.InstructionBINDINT32:
                    HBindInt32(array_SPLIT);
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
