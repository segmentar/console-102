using Core;

namespace Core
{
    using System;

    public partial struct ScopeCharacterSafe
    {
        public Char CharacterValue { get; set; }

        public Char CharacterValueSafe 
        {
            get { return RepresentCharacter(CharacterValueSafeAddress); }

            set { CharacterValueSafeAddress = value; }
        }

        private Char CharacterValueSafeAddress;

        public static ScopeCharacterSafe Simple(Char item_CHARACTER)
        {
            ScopeCharacterSafe safeResult = default;

            Char characterValue, characterValueSafe;

            characterValue = item_CHARACTER;

            characterValueSafe = ConsoleLJS.SafeCharacter(characterValue);

            ScopeCharacterSafe safe;

            safe = new ScopeCharacterSafe();

            safe.CharacterValue = characterValue;

            safe.CharacterValueSafe = characterValueSafe;

            safeResult = safe;

            return safeResult;
        }
        
        public static Char RepresentCharacter(Char item_CHARACTER)
        {
            Char characterResult = default;

            var Entity_EMPTY = Convert.ToChar(0);

            Boolean isEmptyContagentCheck;

            isEmptyContagentCheck = item_CHARACTER.Equals(Entity_EMPTY) is true;

            Char character;

            if (isEmptyContagentCheck)
            {
                var Entity_WHITE_SPACE = Convert.ToChar(32);

                character = Entity_WHITE_SPACE;
            }
            else
            {
                character = item_CHARACTER;
            }

            characterResult = character;
            
            return characterResult;
        }
    }
}
