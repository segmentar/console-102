using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static String GetInputDirectory()
        {
            String stringResult = default;

            var boolean_safe_RETURN_should = false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || ArchitectureConsoleLJOneFirst.HasInputDirectory is false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should || ArchitectureConsoleLJOneFirst.HasValidInputDirectory is false;

            Boolean shouldReturnCheck;

            shouldReturnCheck = boolean_safe_RETURN_should is true;

            if (shouldReturnCheck is true)
            {
                return stringResult;
            }
            else
                "false".ToString();

            String inputDirectory;

            inputDirectory = ArchitectureConsoleLJOneFirst.InputDirectory;

            stringResult = inputDirectory;

            return stringResult;
        }
    }
}
