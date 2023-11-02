using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ReflectModuleFunctionEighty
    {
        public static IList<ReflectModuleFunctionEighty> FunctionDefaultSet(String item_STRING, ReflectModuleFunctionSeventy[] array_FUNCTION, Char[] array_CHARACTER)
        {
            ICollection<ReflectModuleFunctionEighty> collectionResult = default;

            collectionResult = new Collection<ReflectModuleFunctionEighty>();

            foreach (ReflectModuleFunctionSeventy item_FUNCTION in array_FUNCTION)
            {
                var entity_COLON = Convert.ToChar(58);

                var entity__DOUBLE_COLON = new String(entity_COLON, 2);

                var separator = new String[] { entity__DOUBLE_COLON };

                var split = item_FUNCTION.Function.ValueString.StringValue.Split(separator, StringSplitOptions.None);

                String identityName, virtualName;

                identityName = String.Empty;

                virtualName = String.Empty;

                Boolean stickyLeft, stickyRight;

                stickyLeft = false;

                stickyRight = false;

                Boolean hasIdentityNameCheck, hasVirtualNameCheck;

                hasIdentityNameCheck = (split.Length >= 1) is true;

                hasVirtualNameCheck = (split.Length >= 2) is true;

                if (hasIdentityNameCheck is true)
                {
                    var first = split[0];

                    identityName = first;
                }
                else
                    "false".ToString();

                if (hasVirtualNameCheck is true)
                {
                    var second = split[1];

                    virtualName = second;
                }
                else
                    "false".ToString();

                var roth = (item_FUNCTION.Function.Left.Position - 1);

                var zee = (item_FUNCTION.Function.Right.Position + 1);

                var aoth = item_STRING.Length;

                Boolean hasStartCheck, hasEndCheck;

                hasStartCheck = (roth < 0) is false;

                hasEndCheck = (zee >= aoth) is false;

                var entity_PERIOD = Convert.ToChar(46);

                if (hasStartCheck is true)
                {
                    stickyLeft = item_STRING[roth].Equals(entity_PERIOD) is true;
                }
                else
                    "false".ToString();

                if (hasEndCheck is true)
                {
                    stickyRight = item_STRING[zee].Equals(entity_PERIOD) is true;
                }
                else
                    "false".ToString();

                String identityNameString, identityNameStringSafe;

                identityNameString = identityName;

                identityNameStringSafe = ConsoleLJS.SafeString(identityNameString);

                String virtualNameString, virtualNameStringSafe;

                virtualNameString = virtualName;

                virtualNameStringSafe = ConsoleLJS.SafeString(virtualNameString);

                ReflectStringSafe reflectStringIdentityName;

                reflectStringIdentityName = new ReflectStringSafe();

                reflectStringIdentityName.StringValue = identityNameString;

                reflectStringIdentityName.StringValueSafe = identityNameStringSafe;

                ReflectStringSafe reflectStringVirtualName;

                reflectStringVirtualName = new ReflectStringSafe();

                reflectStringVirtualName.StringValue = virtualNameString;

                reflectStringVirtualName.StringValueSafe = virtualNameStringSafe;

                var item_entry_reflect_FUNCTION = new ReflectModuleFunctionEighty(item_FUNCTION, reflectStringIdentityName, reflectStringVirtualName, stickyLeft, stickyRight);

                collectionResult.Add(item_entry_reflect_FUNCTION);

                continue;
            }

            return new List<ReflectModuleFunctionEighty>(collectionResult);
        }
    }
}
