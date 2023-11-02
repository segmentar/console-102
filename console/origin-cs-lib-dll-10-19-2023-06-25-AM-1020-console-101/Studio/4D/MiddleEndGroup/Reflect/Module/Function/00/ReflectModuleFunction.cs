using Core;

namespace Core
{
    using System;

    [IntentionalShortClass]
    public partial class ReflectModuleFunctionHundred
    {
        public ReflectStringSafe InitialStringValue = default(ReflectStringSafe);

        public ReflectStringSafe SubsequentStringValue { get; set; } = default(ReflectStringSafe);

        public ReflectStringSafe IdentityName { get; set; } = default(ReflectStringSafe);

        public ReflectStringSafe VirtualName { get; set; } = default(ReflectStringSafe);

        public Boolean StickyLeft { get; set; } = default(Boolean);

        public Boolean StickyRight { get; set; } = default(Boolean);

        public Int32 Layer { get; set; } = default(Int32);

        public Int32 LeftPosition { get; set; } = default(Int32);

        public ReflectCharacterSafe LeftCharacter { get; set; } = default(ReflectCharacterSafe);

        public ReflectCharacterSafe LeftSymmetryCharacter { get; set; } = default(ReflectCharacterSafe);

        public Boolean LeftSymmetryHas { get; set; } = default(Boolean);

        public Int32 RightPosition { get; set; } = default(Int32);

        public ReflectCharacterSafe RightCharacter { get; set; } = default(ReflectCharacterSafe);

        public ReflectCharacterSafe RightSymmetryCharacter { get; set; } = default(ReflectCharacterSafe);

        public Boolean RightSymmetryHas { get; set; } = default(Boolean);

        public ReflectModuleFunctionHundred()
        {
            return;
        }

        ~ReflectModuleFunctionHundred()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ReflectModuleFunctionHundred) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(InitialStringValue) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(InitialStringValue) + ':' + ' ' + $"<safe><<{InitialStringValue.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(SubsequentStringValue) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(SubsequentStringValue) + ':' + ' ' + $"<safe><<{SubsequentStringValue.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(IdentityName) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(IdentityName) + ':' + ' ' + $"<safe><<{IdentityName.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(VirtualName) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(VirtualName) + ':' + ' ' + $"<safe><<{VirtualName.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(StickyLeft) + ':' + ' ' + StickyLeft,
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(StickyRight) + ':' + ' ' + StickyRight,
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '\t' + '~' + "12" + ' ' + nameof(LeftPosition) + ':' + ' ' + LeftPosition,
                String.Empty + '\t' + '~' + "13" + ' ' + nameof(LeftCharacter) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "14" + ' ' + nameof(LeftCharacter) + ':' + ' ' + $"<safe><<{LeftCharacter.CharacterValueSafe}>>",
                String.Empty + '\t' + '~' + "15" + ' ' + nameof(LeftSymmetryCharacter) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "16" + ' ' + nameof(LeftSymmetryCharacter) + ':' + ' ' + $"<safe><<{LeftSymmetryCharacter.CharacterValueSafe}>>",
                String.Empty + '\t' + '~' + "17" + ' ' + nameof(RightPosition) + ':' + ' ' + RightPosition,
                String.Empty + '\t' + '~' + "18" + ' ' + nameof(RightCharacter) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "19" + ' ' + nameof(RightCharacter) + ':' + ' ' + $"<safe><<{RightCharacter.CharacterValueSafe}>>",
                String.Empty + '\t' + '~' + "20" + ' ' + nameof(RightSymmetryCharacter) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "21" + ' ' + nameof(RightSymmetryCharacter) + ':' + ' ' + $"<safe><<{RightSymmetryCharacter.CharacterValueSafe}>>",
                String.Empty + '}'
            });
        }
    }
}
