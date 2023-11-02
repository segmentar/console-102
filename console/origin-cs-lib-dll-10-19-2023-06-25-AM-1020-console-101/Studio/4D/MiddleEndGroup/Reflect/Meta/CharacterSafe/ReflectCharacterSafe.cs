using Core;

namespace Core
{
    using System;

    public partial struct ReflectCharacterSafe : ICharacterSafe
    {
        public Char CharacterValue { get; set; }
        public Char CharacterValueSafe { get; set; }
    }
}
