using Core;

namespace Core
{
    using System;

    internal partial class Reflect
    {
        internal static Char ForgeSymmetryCharacter(Char item_CHARACTER)
        {
            Char characterResult = default;

            Char character;

            switch (item_CHARACTER)
            {
                case '(':
                    character = ')';
                    break;

                case '[':
                    character = ']';
                    break;

                case '{':
                    character = '}';
                    break;

                case '<':
                    character = '>';
                    break;

                case ')':
                    character = '(';
                    break;

                case ']':
                    character = '[';
                    break;

                case '}':
                    character = '{';
                    break;

                case '>':
                    character = '<';
                    break;

                default:
                    character = default(Char);
                    break;
            }

            characterResult = character;

            return characterResult;
        }
    }
}
