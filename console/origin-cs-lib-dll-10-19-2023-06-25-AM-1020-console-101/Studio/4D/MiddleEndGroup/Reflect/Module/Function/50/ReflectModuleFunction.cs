using Core;

namespace Core
{
    using System;

    [IntentionalShortClass]
    public partial class ReflectModuleFunctionFifty
    {
        public ReflectCharacterSafe Character;

        public ReflectCharacterSafe SymmetryCharacter;

        public Int32 Position;

        public Boolean HasSymmetry;

        public ReflectModuleFunctionFifty(ReflectCharacterSafe character, ReflectCharacterSafe symmetryCharacter, Int32 position, Boolean symmetry)
        {
            this.Character = character;

            this.SymmetryCharacter = symmetryCharacter;

            this.Position = position;

            if (symmetry is true)
            {
                this.HasSymmetry = true;
            }
            else
                "false".ToString();

            return;
        }

        ~ReflectModuleFunctionFifty()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(ReflectModuleFunctionFifty) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Character) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Character) + ':' + ' ' + $"<safe><<{Character.CharacterValueSafe}>>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(SymmetryCharacter) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(SymmetryCharacter) + ':' + ' ' + $"<safe><<{SymmetryCharacter.CharacterValueSafe}>>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Position) + ':' + ' ' + Position,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(HasSymmetry) + ':' + ' ' + HasSymmetry,
                String.Empty + '}'
            });
        }
    }
}
