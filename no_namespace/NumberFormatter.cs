// Namespace: 
private class NumberFormatter.CustomInfo // TypeDefIndex: 383
{
	// Fields
	public bool UseGroup; // 0x10
	public int DecimalDigits; // 0x14
	public int DecimalPointPos; // 0x18
	public int DecimalTailSharpDigits; // 0x1C
	public int IntegerDigits; // 0x20
	public int IntegerHeadSharpDigits; // 0x24
	public int IntegerHeadPos; // 0x28
	public bool UseExponent; // 0x2C
	public int ExponentDigits; // 0x30
	public int ExponentTailSharpDigits; // 0x34
	public bool ExponentNegativeSignOnly; // 0x38
	public int DividePlaces; // 0x3C
	public int Percents; // 0x40
	public int Permilles; // 0x44

	// Methods

	// RVA: 0x35EEF50 Offset: 0x35EF051 VA: 0x35EEF50
	public static void GetActiveSection(string format, ref bool positive, bool zero, ref int offset, ref int length) { }

	// RVA: 0x35EF210 Offset: 0x35EF311 VA: 0x35EF210
	public static NumberFormatter.CustomInfo Parse(string format, int offset, int length, NumberFormatInfo nfi) { }

	// RVA: 0x35EF6D0 Offset: 0x35EF7D1 VA: 0x35EF6D0
	public string Format(string format, int offset, int length, NumberFormatInfo nfi, bool positive, StringBuilder sb_int, StringBuilder sb_dec, StringBuilder sb_exp) { }

	// RVA: 0x35EF6B0 Offset: 0x35EF7B1 VA: 0x35EF6B0
	public void .ctor() { }
}

