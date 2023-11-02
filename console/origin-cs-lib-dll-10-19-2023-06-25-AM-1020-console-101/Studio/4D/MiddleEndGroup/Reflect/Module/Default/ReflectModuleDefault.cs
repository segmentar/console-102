using Core;

namespace Core
{
    using System;

    public partial struct ReflectModule
    {
        public static ReflectModule ReflectModuleDefault(ReflectStringFormat stringFormat, Char[] array_CHARACTER)
        {
            ReflectModule module;

            module = new ReflectModule();

            module.Reflect = Reflect.MakeReflectDefaultSurface(stringFormat, array_CHARACTER);

            module = ReflectModuleOne(module);

            module = ReflectModuleTwo(module);

            module = ReflectModuleThree(module);

            module = ReflectModuleFour(module);
            
            module = ReflectModuleFive(module);
            
            module = ReflectModuleSix(module);

            module = ReflectModuleSeven(module);

            module = ReflectModuleEight(module);

            module = ReflectModuleNine(module);

            module = ReflectModuleZero(module);

            return module;
        }
    }
}
