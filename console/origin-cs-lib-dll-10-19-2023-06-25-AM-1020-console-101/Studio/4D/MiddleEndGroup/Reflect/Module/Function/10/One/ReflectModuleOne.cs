using Core;

namespace Core
{
    using System;

    public partial struct ReflectModule
    {
        public static ReflectModule ReflectModuleOne(ReflectModule module)
        {
            var function = ReflectModuleFunctionTen.FunctionDefaultFor(module.Reflect.InputString.StringValue, module.Reflect.EscapeCharacterArray.CharacterArray);

            ReflectModuleFirst first;

            first = new ReflectModuleFirst(function);

            module.First = first;

            return module;
        }
    }
}
