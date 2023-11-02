using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void GetLine()
        {
            var Entity_LINE_FEED = Convert.ToChar(10);

            var Start_POSITION = MeasureFileArray.Text.StringValue.LastIndexOf(Entity_LINE_FEED, MeasureFile.PhysicalOffset);

            var End_POSITION = MeasureFileArray.Text.StringValue.IndexOf(Entity_LINE_FEED, MeasureFile.PhysicalOffset);

            Boolean hasNotStartPosition, hasNotEndPosition;

            hasNotStartPosition = Start_POSITION.Equals(-1) is true;

            hasNotEndPosition = End_POSITION.Equals(-1) is true;

            if (hasNotStartPosition is true)
            {
                Start_POSITION = 0;
            }
            else
                "false".ToString();

            if (hasNotEndPosition is true)
            {
                var aoth = MeasureFileArray.Text.StringValue.Length;

                var roth = (aoth - 1);

                End_POSITION = roth;
            }
            else
                "false".ToString();

            var difference = (End_POSITION - Start_POSITION);

            var total = (difference + 1);

            var sub = MeasureFileArray.Text.StringValue.Substring(Start_POSITION, total);

            MeasureFile.Line = ScopeStringSafe.Simple(sub);

            MeasureFile.RelateOffset = (MeasureFile.PhysicalOffset - Start_POSITION);

            return;
        }
    }
}
