// Namespace: System.Globalization
[ComVisibleAttribute] // RVA: 0x472EE0 Offset: 0x472FE1 VA: 0x472EE0
[FlagsAttribute] // RVA: 0x472EE0 Offset: 0x472FE1 VA: 0x472EE0
[Serializable]
public enum DateTimeStyles // TypeDefIndex: 694
{
	// Fields
	public int value__; // 0x0
	public const DateTimeStyles None = 0;
	public const DateTimeStyles AllowLeadingWhite = 1;
	public const DateTimeStyles AllowTrailingWhite = 2;
	public const DateTimeStyles AllowInnerWhite = 4;
	public const DateTimeStyles AllowWhiteSpaces = 7;
	public const DateTimeStyles NoCurrentDateDefault = 8;
	public const DateTimeStyles AdjustToUniversal = 16;
	public const DateTimeStyles AssumeLocal = 32;
	public const DateTimeStyles AssumeUniversal = 64;
	public const DateTimeStyles RoundtripKind = 128;
}

