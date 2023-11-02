using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ReflectModuleFunctionFifty
    {
        public static IList<ReflectModuleFunctionFifty> FunctionDefaultSet(String item_STRING, Tuple<Char, Char, Boolean>[] array_TUPLE)
        {
            ICollection<ReflectModuleFunctionFifty> collectionResult = default;

            collectionResult = new Collection<ReflectModuleFunctionFifty>();

            foreach (var item_TUPLE in array_TUPLE)
            {
                Char character, symmetryCharacter;

                character = item_TUPLE.Item1;

                symmetryCharacter = item_TUPLE.Item2;

                Boolean oppositeBoolean;

                oppositeBoolean = item_TUPLE.Item3;

                var zeroth = -1;

                foreach (var item_CHARACTER in item_STRING)
                {
                    zeroth = zeroth + 1;

                    Boolean shouldContinueCheck;

                    shouldContinueCheck = character.Equals(item_CHARACTER) is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var total = (character + item_CHARACTER);

                    var divide = (total / 2);

                    var convert = Convert.ToChar(divide);

                    var item_entry_CHARACTER = convert;

                    var item_entry__CHARACTER_SAFE = ConsoleLJS.SafeCharacter(item_entry_CHARACTER);

                    var item_entry__CHARACTER_SYMMETRY = symmetryCharacter;

                    var item_entry__CHARACTER_SYMMETRY_SAFE = ConsoleLJS.SafeCharacter(item_entry__CHARACTER_SYMMETRY);

                    ReflectCharacterSafe reflectCharacter;

                    reflectCharacter = new ReflectCharacterSafe();

                    reflectCharacter.CharacterValue = item_entry_CHARACTER;

                    reflectCharacter.CharacterValueSafe = item_entry__CHARACTER_SAFE;

                    ReflectCharacterSafe reflectSymmetryCharacter;

                    reflectSymmetryCharacter = new ReflectCharacterSafe();

                    reflectSymmetryCharacter.CharacterValue = item_entry__CHARACTER_SYMMETRY;

                    reflectSymmetryCharacter.CharacterValueSafe = item_entry__CHARACTER_SYMMETRY_SAFE;

                    ReflectModuleFunctionFifty hierarchyOneFirst;

                    hierarchyOneFirst = new ReflectModuleFunctionFifty(reflectCharacter, reflectSymmetryCharacter, zeroth, oppositeBoolean);

                    collectionResult.Add(hierarchyOneFirst);

                    continue;
                }

                continue;
            }

            return new List<ReflectModuleFunctionFifty>(collectionResult);
        }
    }
}
