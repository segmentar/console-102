﻿using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void ExpressionInstructionHandlerPartOperation(String[] array_STRING, Stack item_STACK, String item_STRING, String item_LOWER, String[] array_SPLIT)
        {
            switch (item_LOWER)
            {
                case ExpressionConstant.InstructionLOCK:
                    HLock(array_SPLIT);
                    break;

                case ExpressionConstant.InstructionOPERATION:
                    HOperation(array_SPLIT, item_STACK);
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
