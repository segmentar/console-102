using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void StepOutsideFlagCheck()
        {
            var position = MeasureFileArray.Text.StringValue.IndexOf(ScopeImmutable.FormStringEnd, MeasureFile.PhysicalOffset);

            Boolean isInvalidCheck;

            isInvalidCheck = position.Equals(-1) is true;

            if (isInvalidCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MeasureFlag.StepOutsideFlag = true;

            MeasureValue.FormEndPosition = position;

            var OutsideStart__ITEM = 0;

            OutsideStart__ITEM = OutsideStart__ITEM + (MeasureFile.PhysicalOffset - MeasureFile.RelateOffset);

            OutsideStart__ITEM = OutsideStart__ITEM + MeasureFile.Line.StringValue.Length;

            var OutsideEnd__ITEM = MeasureValue.FormEndPosition - 1;

            var difference = ((OutsideEnd__ITEM - OutsideStart__ITEM) + 1);

            var sub = MeasureFileArray.Text.StringValue.Substring(OutsideStart__ITEM, difference);

            MeasureValue.StepOutsideSubstring = ScopeStringSafe.Simple(sub);

            return;
        }
    }
}
