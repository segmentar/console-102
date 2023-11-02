using Core;

namespace Core
{
    using System;

    public partial class ScopeTemplate
    {
        public ScopeMeasureWait MeasureWait;

        public ScopeMeasureFileArray MeasureFileArray;

        public ScopeMeasureFile MeasureFile;

        public ScopeMeasureFlag MeasureFlag;

        public ScopeMeasureValue MeasureValue;

        public ScopeMeasureQuery MeasureQuery;

        public ScopeTemplate
(
ScopeMeasureWait measureWait,
ScopeMeasureFileArray measureFileArray,
ScopeMeasureFile measureFile,
ScopeMeasureFlag measureFlag,
ScopeMeasureValue measureValue,
ScopeMeasureQuery measureQuery
)
        {
            this.MeasureWait = measureWait;

            this.MeasureFileArray = measureFileArray;

            this.MeasureFile = measureFile;

            this.MeasureFlag = measureFlag;

            this.MeasureValue = measureValue;

            this.MeasureQuery = measureQuery;

            return;
        }

        ~ScopeTemplate()
        {
            return;
        }
    }
}
