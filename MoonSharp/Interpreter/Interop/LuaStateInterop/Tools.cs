// Namespace: MoonSharp.Interpreter.Interop.LuaStateInterop
internal static class Tools // TypeDefIndex: 6150
{
	// Fields
	internal static Regex r; // 0x0

	// Methods

	// RVA: 0x3349E00 Offset: 0x3349F01 VA: 0x3349E00
	public static bool IsNumericType(object o) { }

	// RVA: 0x3349FB0 Offset: 0x334A0B1 VA: 0x3349FB0
	public static bool IsPositive(object Value, bool ZeroIsPositive) { }

	// RVA: 0x334A7F0 Offset: 0x334A8F1 VA: 0x334A7F0
	public static object ToUnsigned(object Value) { }

	// RVA: 0x334AE60 Offset: 0x334AF61 VA: 0x334AE60
	public static object ToInteger(object Value, bool Round) { }

	// RVA: 0x334B5B0 Offset: 0x334B6B1 VA: 0x334B5B0
	public static long UnboxToLong(object Value, bool Round) { }

	// RVA: 0x334BE70 Offset: 0x334BF71 VA: 0x334BE70
	public static string ReplaceMetaChars(string input) { }

	// RVA: 0x334BF50 Offset: 0x334C051 VA: 0x334BF50
	private static string ReplaceMetaCharsMatch(Match m) { }

	// RVA: 0x334C320 Offset: 0x334C421 VA: 0x334C320
	public static void fprintf(TextWriter Destination, string Format, object[] Parameters) { }

	// RVA: 0x334C3C0 Offset: 0x334C4C1 VA: 0x334C3C0
	public static string sprintf(string Format, object[] Parameters) { }

	// RVA: 0x334D6E0 Offset: 0x334D7E1 VA: 0x334D6E0
	private static string FormatOct(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, char Padding, object Value) { }

	// RVA: 0x334D9C0 Offset: 0x334DAC1 VA: 0x334D9C0
	private static string FormatHex(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, char Padding, object Value) { }

	// RVA: 0x334D2F0 Offset: 0x334D3F1 VA: 0x334D2F0
	private static string FormatNumber(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, bool PositiveSign, bool PositiveSpace, char Padding, object Value) { }

	// RVA: 0x334DCE0 Offset: 0x334DDE1 VA: 0x334DCE0
	private static void .cctor() { }
}

