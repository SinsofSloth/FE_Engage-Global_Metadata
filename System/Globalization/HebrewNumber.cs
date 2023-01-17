// Namespace: System.Globalization
internal class HebrewNumber // TypeDefIndex: 704
{
	// Fields
	private static HebrewNumber.HebrewValue[] HebrewValues; // 0x0
	private static char maxHebrewNumberCh; // 0x8
	private static readonly HebrewNumber.HS[][] NumberPasingState; // 0x10

	// Methods

	// RVA: 0x38C2E60 Offset: 0x38C2F61 VA: 0x38C2E60
	internal static string ToString(int Number) { }

	// RVA: 0x38C30C0 Offset: 0x38C31C1 VA: 0x38C30C0
	internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context) { }

	// RVA: 0x38C32A0 Offset: 0x38C33A1 VA: 0x38C32A0
	internal static bool IsDigit(char ch) { }

	// RVA: 0x38C33B0 Offset: 0x38C34B1 VA: 0x38C33B0
	private static void .cctor() { }
}

