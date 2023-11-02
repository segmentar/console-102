using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ReflectModuleFunctionSixty
    {
        public static IList<ReflectModuleFunctionSixty> FunctionDefaultSet(String item_STRING, ReflectModuleFunctionFifty[] array_FUNCTION)
        {
            ICollection<ReflectModuleFunctionSixty> collectionResult = default;

            collectionResult = new Collection<ReflectModuleFunctionSixty>();

            var list = new ArrayList(array_FUNCTION);

            do
            {
                ReflectModuleFunctionFifty left, right;

                left = default;

                right = default;

                var zeroth = -1;

                foreach (ReflectModuleFunctionFifty item_FUNCTION in new ArrayList(list))
                {
                    var boolean_safe_LARGER_is = true;

                    boolean_safe_LARGER_is = boolean_safe_LARGER_is && (item_FUNCTION.Position > zeroth) is true;

                    boolean_safe_LARGER_is = boolean_safe_LARGER_is && item_FUNCTION.HasSymmetry.Equals(false) is true;

                    Boolean isLargerCheck, shouldContinueCheck;

                    isLargerCheck = boolean_safe_LARGER_is is true;

                    shouldContinueCheck = isLargerCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    if (isLargerCheck is true)
                    {
                        zeroth = item_FUNCTION.Position;
                    }
                    else
                        "false".ToString();

                    left = item_FUNCTION;

                    continue;
                }

                var aoth = item_STRING.Length;

                foreach (ReflectModuleFunctionFifty item_FUNCTION in new ArrayList(list))
                {
                    var boolean_safe_SMALLER_is = true;

                    boolean_safe_SMALLER_is = boolean_safe_SMALLER_is && item_FUNCTION.Character.Equals(left.SymmetryCharacter) is true;

                    boolean_safe_SMALLER_is = boolean_safe_SMALLER_is && item_FUNCTION.HasSymmetry.Equals(true) is true;

                    boolean_safe_SMALLER_is = boolean_safe_SMALLER_is && (item_FUNCTION.Position > zeroth) is true;

                    boolean_safe_SMALLER_is = boolean_safe_SMALLER_is && (item_FUNCTION.Position < aoth) is true;

                    Boolean isSmallerCheck, shouldContinueCheck;

                    isSmallerCheck = boolean_safe_SMALLER_is is true;

                    shouldContinueCheck = isSmallerCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    if (isSmallerCheck is true)
                    {
                        aoth = item_FUNCTION.Position;
                    }
                    else
                        "false".ToString();

                    right = item_FUNCTION;

                    continue;
                }

                var boolean_contagious_BREAK_should = false;

                boolean_contagious_BREAK_should = boolean_contagious_BREAK_should || (left == default) is true;

                boolean_contagious_BREAK_should = boolean_contagious_BREAK_should || (right == default) is true;

                Boolean shouldBreakCheck;

                shouldBreakCheck = boolean_contagious_BREAK_should is true;

                if (shouldBreakCheck)
                {
                    break;
                }
                else
                {
                    var layer = 1;

                    foreach (ReflectModuleFunctionFifty entry_FUNCTION in list)
                    {
                        var boolean_safe_EQUAL_is = true;

                        boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && ReferenceEquals(entry_FUNCTION, right) is false;

                        boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && (entry_FUNCTION.Position > right.Position) is true;

                        boolean_safe_EQUAL_is = boolean_safe_EQUAL_is && entry_FUNCTION.Character.Equals(right.Character) is true;

                        Boolean shouldContinueCheck;

                        shouldContinueCheck = boolean_safe_EQUAL_is is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        layer = layer + 1;

                        continue;
                    }

                    list.Remove(left);

                    list.Remove(right);

                    var start = left.Position;

                    var difference = (right.Position - start);

                    var align_LEFT = (start + 1);

                    var align_RIGHT = (difference - 1);

                    var sub = item_STRING.Substring(align_LEFT, align_RIGHT);

                    var item_entry__VALUE_STRING = sub;

                    var item_entry__VALUE_STRING_SAFE = ConsoleLJS.SafeString(item_entry__VALUE_STRING);

                    ReflectStringSafe reflectString;

                    reflectString = new ReflectStringSafe();

                    reflectString.StringValue = item_entry__VALUE_STRING;

                    reflectString.StringValueSafe = item_entry__VALUE_STRING_SAFE;

                    var item_FUNCTION = new ReflectModuleFunctionSixty(left, right, reflectString, layer);

                    collectionResult.Add(item_FUNCTION);
                }

                continue;

            } while (true);

            return new List<ReflectModuleFunctionSixty>(collectionResult);
        }
    }
}
