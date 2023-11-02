using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ReflectModuleFunctionTen
    {

        [SymmetryUsageMethod]
        public static ReflectModuleFunctionTen FunctionDefaultFor(String item_STRING, Char[] array_CHARACTER)
        {
            ReflectModuleFunctionTen functionResult = default;

            Char[] characterArray;

            characterArray = item_STRING.ToCharArray();

            ArrayList characterArrayList, tupleArrayList;

            characterArrayList = new ArrayList(characterArray);

            tupleArrayList = new ArrayList();

            char[] data = characterArray;

            int i, j;

            char ci, cj, ck, cl;

            string sz;

            i = 0;

            var enity_WHITE_SPACE = Convert.ToChar(32);

            for (; ; )
            {
                j = 0;

                Boolean shouldBreakCheck;

                shouldBreakCheck = array_CHARACTER.Length.Equals(i) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                ci = array_CHARACTER[i];

                var boolean_match_BLACK_HOLE_is = false;

                var boolean_match_WHITE_HOLE_is = false;

                var boolean_match_COMPARE_HOLE_is = false;

                var array__BLACK_HOLE = new Char[data.Length];

                var array__WHITE_HOLE = new Char[data.Length];

                var array__COMPARE_HOLE = new Char[data.Length];

                while (data.Length.Equals(j) is false)
                {
                    cj = data[j];

                    if (boolean_match_BLACK_HOLE_is)
                    {
                        array__BLACK_HOLE[j] = cj;
                    }
                    else
                    {
                        array__BLACK_HOLE[j] = enity_WHITE_SPACE;
                    }

                    Boolean isHoleCheck;

                    isHoleCheck = ci.Equals(cj) is true;

                    if (isHoleCheck is true)
                    {
                        boolean_match_BLACK_HOLE_is = boolean_match_BLACK_HOLE_is.Equals(false);

                        boolean_match_WHITE_HOLE_is = boolean_match_WHITE_HOLE_is.Equals(false);
                    }
                    else
                        "false".ToString();

                    if (boolean_match_WHITE_HOLE_is)
                    {
                        array__WHITE_HOLE[j] = cj;
                    }
                    else
                    {
                        array__WHITE_HOLE[j] = enity_WHITE_SPACE;
                    }

                    ck = array__BLACK_HOLE[j];

                    cl = array__WHITE_HOLE[j];

                    var total = (ck + cl);

                    var divide = (total / 2);

                    var convert = Convert.ToChar(divide);

                    boolean_match_COMPARE_HOLE_is = ck.Equals(cl) is true;

                    if (boolean_match_COMPARE_HOLE_is)
                    {
                        array__COMPARE_HOLE[j] = convert;
                    }
                    else
                    {
                        array__COMPARE_HOLE[j] = ci;
                    }

                    var boolean_match_WHITE_SPACE_is = true;

                    boolean_match_WHITE_SPACE_is = boolean_match_WHITE_SPACE_is && ck.Equals(cl) is true;

                    boolean_match_WHITE_SPACE_is = boolean_match_WHITE_SPACE_is && divide.Equals(enity_WHITE_SPACE) is true;

                    Boolean isWhiteSpaceCheck;

                    isWhiteSpaceCheck = boolean_match_WHITE_SPACE_is is true;

                    if (isWhiteSpaceCheck is false)
                    {
                        characterArrayList[j] = enity_WHITE_SPACE;
                    }
                    else
                        "false".ToString();

                    j = j + 1;

                    continue;
                }

                var item__BLACK_HOLE = new String(array__BLACK_HOLE);

                var item__WHITE_HOLE = new String(array__WHITE_HOLE);

                var item__COMPARE = new String(array__COMPARE_HOLE);

                var entity_BIND = new String(ci, 2);

                var separator = new String[] { enity_WHITE_SPACE.ToString(), entity_BIND };

                var split = item__COMPARE.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                Boolean hasLengthCheck;

                hasLengthCheck = split.Length.Equals(0) is false;

                if (hasLengthCheck is true)
                {
                    var indexer = 0;

                    while (split.Length.Equals(indexer) is false)
                    {
                        sz = split[indexer];

                        var format = sz.Trim(ci);

                        split[indexer] = format;

                        indexer = indexer + 1;

                        continue;
                    }
                }
                else
                    "false".ToString();

                Char character;

                character = ci;

                String[] holeArray;

                holeArray = split;

                Tuple<Char, String[]> tuple;

                tuple = new Tuple<Char, String[]>(character, holeArray);
 
                tupleArrayList.Add(tuple);

                i = i + 1;

                continue;
            }

            var array_reflect__CHARACTER_ARRAY_LIST = new Char[characterArrayList.Count];

            var array_reflect__TUPLE_ARRAY_LIST = new Tuple<Char, String[]>[tupleArrayList.Count];

            characterArrayList.CopyTo(array_reflect__CHARACTER_ARRAY_LIST, 0);

            tupleArrayList.CopyTo(array_reflect__TUPLE_ARRAY_LIST, 0);

            String stringResult, stringResultSafe;

            stringResult = new String(array_reflect__CHARACTER_ARRAY_LIST);

            stringResultSafe = ConsoleLJS.SafeString(stringResult);

            ReflectStringSafe reflectString;

            reflectString = new ReflectStringSafe();

            reflectString.StringValue = stringResult;

            reflectString.StringValueSafe = stringResultSafe;

            Tuple<Char, String[]>[] tupleArray;

            tupleArray = array_reflect__TUPLE_ARRAY_LIST;

            var item_entry__FUNCTION = new ReflectModuleFunctionTen(reflectString, tupleArray);

            functionResult = item_entry__FUNCTION;

            return functionResult;
        }
    }
}
