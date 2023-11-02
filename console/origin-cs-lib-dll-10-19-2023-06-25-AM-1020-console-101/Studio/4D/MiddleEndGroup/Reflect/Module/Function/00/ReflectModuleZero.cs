using Core;

namespace Core
{
    using System;

    public partial struct ReflectModule
    {
        public static ReflectModule ReflectModuleZero(ReflectModule module)
        {
            var array = ReflectModuleFunctionHundred.FunctionDefaultSetSurface(module.Ninth.FunctionArray);

            ReflectModuleZeroth zeroth;

            zeroth = new ReflectModuleZeroth(array);

            module.Zeroth = zeroth;

            return module;
        }
    }
}
