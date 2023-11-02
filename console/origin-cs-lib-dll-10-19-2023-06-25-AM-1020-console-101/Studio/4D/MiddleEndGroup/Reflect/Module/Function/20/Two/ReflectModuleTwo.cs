using Core;

namespace Core
{
    using System;

    public partial struct ReflectModule
    {
        public static ReflectModule ReflectModuleTwo(ReflectModule module)
        {
            var array = ReflectModuleFunctionTwenty.FunctionTupleArrayContainerSurface<Tuple<Char, String[]>>(module.Reflect.InputString.StringValue, module.Reflect.EscapeCharacterArray.CharacterArray);

            var function = new ReflectModuleFunctionTwenty(array);

            ReflectModuleSecond second;

            second = new ReflectModuleSecond(function);

            module.Second = second;

            return module;
        }
    }
}
