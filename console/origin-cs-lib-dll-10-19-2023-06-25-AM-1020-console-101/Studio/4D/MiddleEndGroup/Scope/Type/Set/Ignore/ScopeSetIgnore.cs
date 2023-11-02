using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scope
    {
        public static IList<String> ScopeIgnoreSet(String[] File_ARRAY, params String[] Ignore_ARRAY)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            foreach (String item_FILE in File_ARRAY)
            {
                var path_NAME_extension = Path.GetExtension(item_FILE);

                var ignore = false;

                foreach (String Ignore_ITEM in Ignore_ARRAY)
                {
                    var Entity_PERIOD = Convert.ToChar(46);

                    var FormatExtension__ITEM = path_NAME_extension.TrimStart(Entity_PERIOD);

                    var FormatIgnore__ITEM = Ignore_ITEM.TrimStart(Entity_PERIOD);

                    Boolean isIgnoreCheck;

                    isIgnoreCheck = FormatExtension__ITEM.Equals(FormatIgnore__ITEM) is true;

                    if (isIgnoreCheck is true)
                    {
                        ignore = true;

                        break;
                    }
                    else
                        "false".ToString();

                    continue;
                }

                Boolean shouldContinueCheck;

                shouldContinueCheck = ignore is true;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                collectionResult.Add(item_FILE);

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
