using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void FileSecondaryIteration()
        {
            if (MeasureFlag.StepLocalLineFlag is true)
            {
                StepLocalLineSync();

                MeasureQuery.LocalLineArrayList.Add(MeasureFile.Line.StringValue);

                AdvanceLine();
            }
            else
                "false".ToString();

            var boolean_match_VALID_is = true;

            boolean_match_VALID_is = boolean_match_VALID_is && MeasureFlag.StepLineFlag is true;

            boolean_match_VALID_is = boolean_match_VALID_is && MeasureFlag.StepOutsideFlag is true;

            if (boolean_match_VALID_is is true)
            {
                StepLineSync();

                StepOutsideSync();

                Element element;

                element = Element.MakeElementDefaultSurface(MeasureValue.StepLineSubstring.StringValue, MeasureValue.StepOutsideSubstring.StringValue);

                MeasureQuery.FormArrayList.Add(element);

                AdvanceForm();
            }
            else
                "false".ToString();

            return;
        }
    }
}
