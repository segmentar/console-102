using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void StepLocalLineCheck()
        {
            var Entity_PERIOD = Convert.ToChar(46);

            var FormatInitial__ITEM = MeasureFile.Line.StringValue.TrimEnd();

            var FormatSubsequent__ITEM = FormatInitial__ITEM.TrimEnd(Entity_PERIOD);

            var Aoth_LINE = FormatInitial__ITEM.Length;

            var Aoth_FORMAT = FormatSubsequent__ITEM.Length;

            var Aoth_DIFFERENCE = (Aoth_LINE - Aoth_FORMAT);

            Boolean isLocalLineCheck, shouldReturnCheck;

            isLocalLineCheck = Aoth_DIFFERENCE.Equals(1) is true;

            shouldReturnCheck = isLocalLineCheck is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MeasureFlag.StepLocalLineFlag = true;

            return;
        }
    }
}
