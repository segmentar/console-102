using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static ScopeMeasureWait MeasureWait = new ScopeMeasureWait();

        public static ScopeMeasureFile MeasureFile = new ScopeMeasureFile();

        public static ScopeMeasureFileArray MeasureFileArray = new ScopeMeasureFileArray();

        public static ScopeMeasureFlag MeasureFlag = new ScopeMeasureFlag();

        public static ScopeMeasureValue MeasureValue = new ScopeMeasureValue();

        public static ScopeMeasureQuery MeasureQuery = new ScopeMeasureQuery();
    }
}