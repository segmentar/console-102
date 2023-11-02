using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ReflectModuleFunctionHundred
    {
        public static IList<ReflectModuleFunctionHundred> FunctionDefaultSet(ReflectModuleFunctionNinety[] array_FUNCTION)
        {
            ICollection<ReflectModuleFunctionHundred> collectionResult = default;

            collectionResult = new Collection<ReflectModuleFunctionHundred>();

            foreach (ReflectModuleFunctionNinety item_FUNCTION in array_FUNCTION)
            {
                ReflectStringSafe initialStringValue;

                initialStringValue = item_FUNCTION.Function.Function.Function.ValueString;

                ReflectStringSafe subsequentStringValue;

                subsequentStringValue = item_FUNCTION.ValueString;

                ReflectStringSafe identityName;

                identityName = item_FUNCTION.Function.IdentityName;

                ReflectStringSafe virtualName;

                virtualName = item_FUNCTION.Function.VirtualName;

                Boolean stickyLeft, stickyRight;

                stickyLeft = item_FUNCTION.Function.StickyLeft;

                stickyRight = item_FUNCTION.Function.StickyRight;

                Int32 layer;

                layer = item_FUNCTION.Function.Function.Function.Layer;

                Int32 leftPosition, rightPosition;

                leftPosition = item_FUNCTION.Function.Function.Function.Left.Position;

                rightPosition = item_FUNCTION.Function.Function.Function.Right.Position;

                Char leftCharacter, rightCharacter;

                leftCharacter = item_FUNCTION.Function.Function.Function.Left.Character.CharacterValue;

                rightCharacter = item_FUNCTION.Function.Function.Function.Right.Character.CharacterValue;

                Char leftCharacterSafe, rightCharacterSafe;

                leftCharacterSafe = item_FUNCTION.Function.Function.Function.Left.Character.CharacterValueSafe;

                rightCharacterSafe = item_FUNCTION.Function.Function.Function.Right.Character.CharacterValueSafe;

                Char leftSymmetryCharacter, rightSymmetryCharacter;

                leftSymmetryCharacter = item_FUNCTION.Function.Function.Function.Left.SymmetryCharacter.CharacterValue;

                rightSymmetryCharacter = item_FUNCTION.Function.Function.Function.Right.SymmetryCharacter.CharacterValue;

                Char leftSymmetryCharacterSafe, rightSymmetryCharacterSafe;

                leftSymmetryCharacterSafe = item_FUNCTION.Function.Function.Function.Left.SymmetryCharacter.CharacterValueSafe;

                rightSymmetryCharacterSafe = item_FUNCTION.Function.Function.Function.Right.SymmetryCharacter.CharacterValueSafe;

                Boolean leftSymmetryHas, rightSymmetryHas;

                leftSymmetryHas = item_FUNCTION.Function.Function.Function.Left.HasSymmetry;

                rightSymmetryHas = item_FUNCTION.Function.Function.Function.Right.HasSymmetry;

                ReflectCharacterSafe reflectLeftCharacter, reflectRightCharacter;

                reflectLeftCharacter = new ReflectCharacterSafe();

                reflectLeftCharacter.CharacterValue = leftCharacter;

                reflectLeftCharacter.CharacterValueSafe = leftCharacterSafe;

                reflectRightCharacter = new ReflectCharacterSafe();

                reflectRightCharacter.CharacterValue = rightCharacter;

                reflectRightCharacter.CharacterValueSafe = rightCharacterSafe;

                ReflectCharacterSafe reflectLeftSymmetryCharacter, reflectRightSymmetryCharacter;

                reflectLeftSymmetryCharacter = new ReflectCharacterSafe();

                reflectLeftSymmetryCharacter.CharacterValue = leftSymmetryCharacter;

                reflectLeftSymmetryCharacter.CharacterValueSafe = leftSymmetryCharacterSafe;

                reflectRightSymmetryCharacter = new ReflectCharacterSafe();

                reflectRightSymmetryCharacter.CharacterValue = rightSymmetryCharacter;

                reflectLeftSymmetryCharacter.CharacterValueSafe = rightSymmetryCharacterSafe;

                var reflect_item_entry__FUNCTION = new ReflectModuleFunctionHundred()
{ 
    InitialStringValue = initialStringValue,
    SubsequentStringValue = subsequentStringValue,
    IdentityName = identityName,
    VirtualName = virtualName,
    StickyLeft = stickyLeft,
    StickyRight = stickyRight,
    Layer = layer,
    LeftPosition = leftPosition,
    LeftCharacter = reflectLeftCharacter,
    LeftSymmetryCharacter = reflectLeftSymmetryCharacter,
    LeftSymmetryHas = leftSymmetryHas,
    RightPosition = rightPosition,
    RightCharacter = reflectRightCharacter,
    RightSymmetryCharacter = reflectRightSymmetryCharacter,
    RightSymmetryHas = rightSymmetryHas
};

                collectionResult.Add(reflect_item_entry__FUNCTION);

                continue;
            }

            return new List<ReflectModuleFunctionHundred>(collectionResult);
        }
    }
}
