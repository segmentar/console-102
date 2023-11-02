using Core;

namespace Core
{
    using System;

    public partial struct ReflectModule
    {
        public static ReflectModule ReflectModuleAction(ReflectStringFormat stringFormat, Char[] array_CHARACTER, Boolean answer_POLICY_has)
        {
            ReflectModule module;

            module = ReflectModuleDefault(stringFormat, array_CHARACTER);

            if (answer_POLICY_has is true)
            {
                try
                {
                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Reflect)}Info-{nameof(ReflectModule)}01", module.First.Function);

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Reflect)}Info-{nameof(ReflectModule)}02", module.Second.Function);

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Reflect)}Info-{nameof(ReflectModule)}03", module.Third.Function);

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Reflect)}Info-{nameof(ReflectModule)}04", module.Fourth.Function);

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Reflect)}Info-{nameof(ReflectModule)}05", String.Join('\n'.ToString(), (Object[])(module.Fifth.FunctionArray as Array)));

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Reflect)}Info-{nameof(ReflectModule)}06", String.Join('\n'.ToString(), (Object[])(module.Sixth.FunctionArray as Array)));

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Reflect)}Info-{nameof(ReflectModule)}07", String.Join('\n'.ToString(), (Object[])(module.Seventh.FunctionArray as Array)));

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Reflect)}Info-{nameof(ReflectModule)}08", String.Join('\n'.ToString(), (Object[])(module.Eighth.FunctionArray as Array)));

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Reflect)}Info-{nameof(ReflectModule)}09", String.Join('\n'.ToString(), (Object[])(module.Ninth.FunctionArray as Array)));

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Reflect)}Info-{nameof(ReflectModule)}10", String.Join('\n'.ToString(), (Object[])(module.Zeroth.FunctionArray as Array)));
                }
                catch (Exception exception)
                {
                    exception.ToString();
                }
            }
            else
                "false".ToString();

            return module;
        }
    }
}
