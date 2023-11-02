using Core;

namespace Core
{
    using System;

    public partial class ReflectModuleFunctionFifty
    {
        public static void FunctionProofVoid(String item_STRING, ReflectModuleFunctionFifty[] array_FUNCTION)
        {
            foreach (ReflectModuleFunctionFifty item_FUNCTION in array_FUNCTION)
            {
                Boolean shouldThrowCheck;

                shouldThrowCheck = item_STRING[item_FUNCTION.Position].Equals(item_FUNCTION.Character.CharacterValue) is false;

                if (shouldThrowCheck is true)
                {
                    ConsoleLJS.Log(false, "fatal error");
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}