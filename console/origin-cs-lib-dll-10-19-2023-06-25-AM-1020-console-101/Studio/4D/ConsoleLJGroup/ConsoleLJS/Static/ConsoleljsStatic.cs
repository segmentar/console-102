using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial class ConsoleLJS
    {
        public static void Procedure()
        {
            ConsoleLJPolicy.ConsoleLJDebugPolicy = true;

            ConsoleLJPolicy.ConsoleLJInfoPolicy = true;

            ReflectPolicy.ReflectDebugPolicy = true;

            ReflectPolicy.ReflectInfoPolicy = true;

            ExpressionPolicy.ExpressionDebugPolicy = true;

            ExpressionPolicy.ExpressionInfoPolicy = true;

            ContributePolicy.ContributeDebugPolicy = true;

            ContributePolicy.ContributeInfoPolicy = true;

            ElementPolicy.ElementDebugPolicy = true;

            ElementPolicy.ElementInfoPolicy = true;

            return;
        }

        public static void Manual()
        {
            return;
        }

        public static void Raise()
        {
            if (ConsoleLJPolicy.ConsoleLJInfoPolicy is true)
            {
                Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(ConsoleLJ)}Info", ConsoleLJPolicy.ConsoleLJArrayList.ToArray());
            }
            else
                "false".ToString();

            if (ReflectPolicy.ReflectInfoPolicy is true)
            {
                Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Reflect)}Info", ReflectPolicy.ReflectArrayList.ToArray());
            }
            else
                "false".ToString();

            if (ExpressionPolicy.ExpressionInfoPolicy is true)
            {
                Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info", ExpressionPolicy.ExpressionArrayList.ToArray());
            }
            else
                "false".ToString();

            if (ContributePolicy.ContributeInfoPolicy is true)
            {
                Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Contribute)}Info", ContributePolicy.ContributeArrayList.ToArray());
            }
            else
                "false".ToString();
            
            if (ElementPolicy.ElementInfoPolicy is true)
            {
                Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Element)}Info", ElementPolicy.ElementArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }

        public static void Bundle(Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is true)
            {
                ArchitectureConsoleLJZeroTen.PropagateDebug = true;
            }
            else
                "false".ToString();

            if (ArchitectureConsoleLJZeroTen.PropagateDebug is true)
            {
                Procedure();
            }
            else
                "false".ToString();

            Manual();

            if (ArchitectureConsoleLJZeroTen.PropagateDebug is true)
            {
                AppDomain.CurrentDomain.ProcessExit += new EventHandler((Object sender, EventArgs e) => {

                    Raise();
                });
            }
            else
                "false".ToString();

            return;
        }

        static ConsoleLJS()
        {
            return;
        }
    }
}
