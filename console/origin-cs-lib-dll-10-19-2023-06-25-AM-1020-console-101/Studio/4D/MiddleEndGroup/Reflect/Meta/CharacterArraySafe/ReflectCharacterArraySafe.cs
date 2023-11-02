using Core;

namespace Core
{
    using System;

    public partial struct ReflectCharacterArraySafe : ICharacterArraySafe
    {
        public Char[] CharacterArray { get; set; }
        public Char[] CharacterArraySafe { get; set; }
    }
}
