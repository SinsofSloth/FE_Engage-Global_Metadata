// Namespace: System
internal struct ParsingInfo // TypeDefIndex: 239
{
	// Fields
	internal Calendar calendar; // 0x0
	internal int dayOfWeek; // 0x8
	internal DateTimeParse.TM timeMark; // 0xC
	internal bool fUseHour12; // 0x10
	internal bool fUseTwoDigitYear; // 0x11
	internal bool fAllowInnerWhite; // 0x12
	internal bool fAllowTrailingWhite; // 0x13
	internal bool fCustomNumberParser; // 0x14
	internal DateTimeParse.MatchNumberDelegate parseNumberDelegate; // 0x18

	// Methods

	// RVA: 0x381C170 Offset: 0x381C271 VA: 0x381C170
	internal void Init() { }
}

