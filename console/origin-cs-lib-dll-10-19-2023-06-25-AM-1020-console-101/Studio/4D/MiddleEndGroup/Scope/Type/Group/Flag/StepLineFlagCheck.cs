using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void StepLineFlagCheck()
        {
            var Entity_PERIOD = Convert.ToChar(46);

            var Entity_COMMA = Convert.ToChar(44);

            var Position_PERIOD = MeasureFile.Line.StringValue.IndexOf(Entity_PERIOD);

            var Position_COMMA = MeasureFile.Line.StringValue.LastIndexOf(Entity_COMMA);

            var boolean_safe_INVALID_is = false;

            boolean_safe_INVALID_is = boolean_safe_INVALID_is || Position_PERIOD.Equals(-1) is true;

            boolean_safe_INVALID_is = boolean_safe_INVALID_is || Position_COMMA.Equals(-1) is true;

            if (boolean_safe_INVALID_is is true)
            {
                return;
            }
            else
                "false".ToString();

            var difference = (Position_COMMA - Position_PERIOD);

            var boolean_match__MORE_THAN = (difference > 0);

            MeasureFlag.StepLineFlag = boolean_match__MORE_THAN;

            var total = difference + 1;

            var sub = MeasureFile.Line.StringValue.Substring(Position_PERIOD, total);

            MeasureValue.StepLineSubstring = ScopeStringSafe.Simple(sub);

            return;
        }
    }
}
