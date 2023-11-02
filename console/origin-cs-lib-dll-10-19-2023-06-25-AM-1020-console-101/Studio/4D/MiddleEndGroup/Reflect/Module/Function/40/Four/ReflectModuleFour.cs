using Core;

namespace Core
{
    using System;

    public partial struct ReflectModule
    {
        public static ReflectModule ReflectModuleFour(ReflectModule module)
        {
            var entity__PARENTHESIS_LEFT = Convert.ToChar(40);

            var entity__PARENTHESIS_RIGHT = Convert.ToChar(41);

            var entity__SQUARE_BRACKET_LEFT = Convert.ToChar(91);

            var entity__SQUARE_BRACKET_RIGHT = Convert.ToChar(93);

            var entity__CURCLY_BRACKET_LEFT = Convert.ToChar(123);

            var entity__CURLY_BRACKET_RIGHT = Convert.ToChar(125);

            var entity__ARROW_BRACKET_LEFT = Convert.ToChar(60);

            var entity__ARROW_BRACKET_RIGHT = Convert.ToChar(62);

            Char[] openCharacterArray, closeCharacterArray;

            openCharacterArray = new Char[] {
                entity__PARENTHESIS_LEFT, 
                entity__SQUARE_BRACKET_LEFT,
                entity__CURCLY_BRACKET_LEFT,
                entity__ARROW_BRACKET_LEFT
            };

            closeCharacterArray = new Char[] {
                entity__PARENTHESIS_RIGHT, 
                entity__SQUARE_BRACKET_RIGHT,
                entity__CURLY_BRACKET_RIGHT,
                entity__ARROW_BRACKET_RIGHT
            };

            var tuple = ReflectModuleFunctionFourty.ReflectDefaultContainerSurface<Tuple<Char, Char, Boolean>>(openCharacterArray, closeCharacterArray);

            var function = new ReflectModuleFunctionFourty(tuple);

            ReflectModuleFourth fourth;

            fourth = new ReflectModuleFourth(function);

            module.Fourth = fourth;

            return module;
        }
    }
}
