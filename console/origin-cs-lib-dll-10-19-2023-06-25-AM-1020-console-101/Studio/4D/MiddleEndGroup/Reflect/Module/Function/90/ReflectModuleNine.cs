using Core;

namespace Core
{
    using System;

    public partial struct ReflectModule
    {
        public static ReflectModule ReflectModuleNine(ReflectModule module)
        {
            var array = ReflectModuleFunctionNinety.FunctionDefaultSetSurface(module.Eighth.FunctionArray, module.Third.Function.TupleArray);

            ReflectModuleNinth ninth;

            ninth = new ReflectModuleNinth(array);

            module.Ninth = ninth;

            return module;
        }
    }
}
