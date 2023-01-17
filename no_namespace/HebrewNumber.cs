// Namespace: 
private enum HebrewNumber.HebrewToken // TypeDefIndex: 701
{
	// Fields
	public int value__; // 0x0
	public const HebrewNumber.HebrewToken Invalid = -1;
	public const HebrewNumber.HebrewToken Digit400 = 0;
	public const HebrewNumber.HebrewToken Digit200_300 = 1;
	public const HebrewNumber.HebrewToken Digit100 = 2;
	public const HebrewNumber.HebrewToken Digit10 = 3;
	public const HebrewNumber.HebrewToken Digit1 = 4;
	public const HebrewNumber.HebrewToken Digit6_7 = 5;
	public const HebrewNumber.HebrewToken Digit7 = 6;
	public const HebrewNumber.HebrewToken Digit9 = 7;
	public const HebrewNumber.HebrewToken SingleQuote = 8;
	public const HebrewNumber.HebrewToken DoubleQuote = 9;
}

// Namespace: 
private class HebrewNumber.HebrewValue // TypeDefIndex: 702
{
	// Fields
	internal HebrewNumber.HebrewToken token; // 0x10
	internal int value; // 0x14

	// Methods

	// RVA: 0x35ED870 Offset: 0x35ED971 VA: 0x35ED870
	internal void .ctor(HebrewNumber.HebrewToken token, int value) { }
}

// Namespace: 
internal enum HebrewNumber.HS // TypeDefIndex: 703
{
	// Fields
	public int value__; // 0x0
	public const HebrewNumber.HS _err = -1;
	public const HebrewNumber.HS Start = 0;
	public const HebrewNumber.HS S400 = 1;
	public const HebrewNumber.HS S400_400 = 2;
	public const HebrewNumber.HS S400_X00 = 3;
	public const HebrewNumber.HS S400_X0 = 4;
	public const HebrewNumber.HS X00_DQ = 5;
	public const HebrewNumber.HS S400_X00_X0 = 6;
	public const HebrewNumber.HS X0_DQ = 7;
	public const HebrewNumber.HS X = 8;
	public const HebrewNumber.HS X0 = 9;
	public const HebrewNumber.HS X00 = 10;
	public const HebrewNumber.HS S400_DQ = 11;
	public const HebrewNumber.HS S400_400_DQ = 12;
	public const HebrewNumber.HS S400_400_100 = 13;
	public const HebrewNumber.HS S9 = 14;
	public const HebrewNumber.HS X00_S9 = 15;
	public const HebrewNumber.HS S9_DQ = 16;
	public const HebrewNumber.HS END = 100;
}

