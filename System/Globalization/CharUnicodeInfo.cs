// Namespace: System.Globalization
public static class CharUnicodeInfo // TypeDefIndex: 680
{
	// Fields
	private static ushort[] s_pCategoryLevel1Index; // 0x0
	private static byte[] s_pCategoriesValue; // 0x8
	private static ushort[] s_pNumericLevel1Index; // 0x10
	private static byte[] s_pNumericValues; // 0x18
	private static ushort[] s_pDigitValues; // 0x20

	// Methods

	// RVA: 0x33A1F80 Offset: 0x33A2081 VA: 0x33A1F80
	internal static int InternalConvertToUtf32(string s, int index) { }

	// RVA: 0x339E070 Offset: 0x339E171 VA: 0x339E070
	internal static bool IsWhiteSpace(char c) { }

	// RVA: 0x339DC30 Offset: 0x339DD31 VA: 0x339DC30
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	// RVA: 0x33A0E20 Offset: 0x33A0F21 VA: 0x33A0E20
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x33A1480 Offset: 0x33A1581 VA: 0x33A1480
	internal static UnicodeCategory InternalGetUnicodeCategory(int ch) { }

	// RVA: 0x33A20B0 Offset: 0x33A21B1 VA: 0x33A20B0
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	// RVA: 0x33A1700 Offset: 0x33A1801 VA: 0x33A1700
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	// RVA: 0x33A21D0 Offset: 0x33A22D1 VA: 0x33A21D0
	private static void .cctor() { }
}

