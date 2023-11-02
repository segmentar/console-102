using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ReflectModuleFunctionFourty
    {
        public static ArrayList ReflectDefaultContainer(Char[] array_OPEN, Char[] array_CLOSE)
        {
            ArrayList listResult = default;

            listResult = new ArrayList();

            foreach (Char character in array_OPEN)
            {
                Tuple<Char, Char, Boolean> tuple;

                var symmetry = Reflect.ForgeSymmetryCharacter(character);

                tuple = new Tuple<Char, Char, Boolean>(character, symmetry, false);

                listResult.Add(tuple);

                continue;
            }
            
            foreach (Char character in array_CLOSE)
            {
                Tuple<Char, Char, Boolean> tuple;

                var symmetry = Reflect.ForgeSymmetryCharacter(character);

                tuple = new Tuple<Char, Char, Boolean>(character, symmetry, true);

                listResult.Add(tuple);

                continue;
            }

            return listResult;
        }
    }
}
