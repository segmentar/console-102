using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ReflectModuleFunctionTwenty
    {
        public static ArrayList FunctionTupleArrayContainer(String item_STRING, Char[] array_CHARACTER)
        {
            ArrayList listResult = default;

            listResult = new ArrayList();

            var enumerator = array_CHARACTER.GetEnumerator();

            do
            {
                if (enumerator.MoveNext() is false)
                {
                    break;
                }
                else
                    "false".ToString();

                Char reflectCharacter;

                reflectCharacter = (Char)(enumerator.Current as Object);

                var entity__WHITE_SPACE = Convert.ToChar(32);

                var entity__NEW_LINE = String.Concat('\r', '\n');

                var separator = new String[] { entity__WHITE_SPACE.ToString(), entity__NEW_LINE };

                var split = item_STRING.Split(separator, StringSplitOptions.None);

                var list = new ArrayList();

                foreach (String stringItemEntry in split)
                {
                    var entity__BIND = new String(reflectCharacter, 2);

                    var position = stringItemEntry.IndexOf(entity__BIND);

                    var total = (position + entity__BIND.Length);

                    Boolean shouldContinueCheck;

                    shouldContinueCheck = position.Equals(-1) is true;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var difference = (stringItemEntry.Length - total);
                    
                    var sub = stringItemEntry.Substring(total, difference);

                    list.Add(sub);

                    continue;
                }

                var array = (String[])(list.ToArray(typeof(String)) as Array);

                Tuple<Char, String[]> tuple;

                tuple = new Tuple<Char, String[]>(reflectCharacter, array);

                listResult.Add(tuple);

                continue;

            } while (true);

            return listResult;
        }
    }
}
