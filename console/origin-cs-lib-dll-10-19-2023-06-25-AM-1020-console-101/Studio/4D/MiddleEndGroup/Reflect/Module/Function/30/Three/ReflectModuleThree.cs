using Core;

namespace Core
{
    using System;

    public partial struct ReflectModule
    {
        public static ReflectModule ReflectModuleThree(ReflectModule module)
        {
            var array = ReflectModuleFunctionThirty.FunctionTupleArrayContainerSurface<Tuple<Char, String[], String[]>>(module.Reflect.EscapeCharacterArray.CharacterArray, module.First.Function.TupleArray, module.Second.Function.TupleArray);
            
            var function = new ReflectModuleFunctionThirty(array);

            ReflectModuleThird third;

            third = new ReflectModuleThird(function);

            module.Third = third;

            return module;
        }
    }
}
