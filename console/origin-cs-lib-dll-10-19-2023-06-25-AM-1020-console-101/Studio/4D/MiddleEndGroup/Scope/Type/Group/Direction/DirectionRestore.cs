using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void DirectionRestore(Boolean answer_UNPAUSE_should)
        {
            MeasureWait = ScopeTemplate.MeasureWait;

            MeasureFileArray = ScopeTemplate.MeasureFileArray;

            MeasureFile = ScopeTemplate.MeasureFile;

            MeasureFlag = ScopeTemplate.MeasureFlag;

            MeasureValue = ScopeTemplate.MeasureValue;

            MeasureQuery = ScopeTemplate.MeasureQuery;

            if (answer_UNPAUSE_should is true)
            {
                MeasureWait.IsPause = false;
            }
            else
                "false".ToString();

            return;
        }
    }
}
