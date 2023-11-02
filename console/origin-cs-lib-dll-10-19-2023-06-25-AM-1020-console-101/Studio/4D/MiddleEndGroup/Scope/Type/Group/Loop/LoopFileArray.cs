using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void LoopFileArray()
        {
            do
            {
                EndOfFileArrayCheck();

                if (MeasureFlag.EndOfFileArrayFlag is true)
                {
                    EndOfFileArraySync();

                    break;
                }
                else
                    "false".ToString();

                GetFilename();

                GetText();

                ResetPhysicalOffset();

                ResetVirtualOffset();

                ResetRelateOffset();

                ResetLineNumber();

                LoopFile();

                FileArrayPrimaryIteration();

                AdvanceFilePointer();

                continue;

            } while (true);

            return;
        }
    }
}
