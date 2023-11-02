using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void FileArrayPrimaryIteration()
        {
            try
            {
                var reflect = (String[])(MeasureQuery.LocalLineArrayList.ToArray(typeof(String)) as Array);

                Host.ProcessScopeLocalLineArray(reflect);

                MeasureQuery.LocalLineArrayList.Clear();

            } catch (Exception exception)
            {
                ConsoleLJS.Log(false, "error in primary iteration, expression related");
            }

            return;
        }
    }
}
