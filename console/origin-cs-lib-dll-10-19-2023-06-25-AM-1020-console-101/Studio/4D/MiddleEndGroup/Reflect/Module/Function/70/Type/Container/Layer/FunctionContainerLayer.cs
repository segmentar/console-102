using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ReflectModuleFunctionSeventy
    {
        public static ArrayList FunctionLayerContainer(ReflectModuleFunctionSixty[] array_FUNCTION)
        {
            ArrayList listResult = default;

            listResult = new ArrayList();

            var largest = -1;

            foreach (ReflectModuleFunctionSixty item_FUNCTION in array_FUNCTION)
            {
                Boolean isLargerCheck, shouldContinueCheck;

                isLargerCheck = (item_FUNCTION.Layer > largest) is true;

                shouldContinueCheck = isLargerCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                largest = item_FUNCTION.Layer;

                continue;
            }

            largest = largest + 1;

            var indexer = 0;

            do
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = largest.Equals(indexer) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                ReflectModuleFunctionSixty[] functionArrayPrevious, functionArrayNext;

                functionArrayPrevious = new ReflectModuleFunctionSixty[0];

                functionArrayNext = new ReflectModuleFunctionSixty[0];

                ArrayList listPrevious, listNext;

                listPrevious = new ArrayList();

                listNext = new ArrayList();

                foreach (var item_FUNCTION in array_FUNCTION)
                {
                    Boolean isEqualCheck, shouldContinueCheck;

                    isEqualCheck = item_FUNCTION.Layer.Equals(indexer) is true;

                    shouldContinueCheck = isEqualCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    listPrevious.Add(item_FUNCTION);

                    continue;
                }

                foreach (var item_FUNCTION in array_FUNCTION)
                {
                    var zee = (indexer + 1);

                    Boolean isEqualCheck, shouldContinueCheck;

                    isEqualCheck = item_FUNCTION.Layer.Equals(zee) is true;

                    shouldContinueCheck = isEqualCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    listNext.Add(item_FUNCTION);

                    continue;
                }

                Array.Resize(ref functionArrayPrevious, listPrevious.Count);

                Array.Resize(ref functionArrayNext, listNext.Count);

                listPrevious.CopyTo(functionArrayPrevious, 0);

                listNext.CopyTo(functionArrayNext, 0);

                Tuple<ReflectModuleFunctionSixty[], ReflectModuleFunctionSixty[]> tuple;

                tuple = new Tuple<ReflectModuleFunctionSixty[], ReflectModuleFunctionSixty[]>(functionArrayPrevious, functionArrayNext);

                listResult.Add(tuple);

                indexer = indexer + 1;

                continue;

            } while (true);

            return listResult;
        }
    }
}
