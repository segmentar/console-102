using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ProcessFileArrayInner(String[] File_ARRAY)
        {
            try
            {

                MeasureRuntime();

                SetFileArray(File_ARRAY);

                ResetDisplayWait(1000, 100, 1000);

                Run();

                ResetFilePointer();

                LoopFileArray();

                Close();

            }
            catch (Exception exception)
            {
                ConsoleLJS.Log(false, exception);
            }

            return;
        }
    }
}
