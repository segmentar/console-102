using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class Scope
    {
        public static void LoopFile()
        {
            do
            {
                EndOfFileCheck();

                if (MeasureFlag.EndOfFileFlag is true)
                {
                    EndOfFileSync();

                    break;
                }
                else
                    "false".ToString();

                GetVirtualOffset();

                GetLineNumber();

                GetCharacter();

                GetLine();

                FilePrimaryIteration();

                while (true)
                {
                    if (MeasureWait.IsPause is false)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    continue;
                }

                AdvanceLinkedListCollapse(MeasureWait.ToString(), MeasureFile.ToString(), MeasureFileArray.ToString(), MeasureFlag.ToString(), MeasureValue.ToString(), MeasureQuery.ToString());

                Thread.Sleep(MeasureWait.WaitEverybody);

                FileSecondaryIteration();

                AdvancePhysicalOffset();

                continue;

            } while (true);

            return;
        }
    }
}
