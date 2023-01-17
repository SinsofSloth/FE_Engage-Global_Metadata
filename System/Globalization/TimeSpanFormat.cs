// Namespace: System.Globalization
internal static class TimeSpanFormat // TypeDefIndex: 713
{
	// Fields
	internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals; // 0x0
	internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals; // 0x28

	// Methods

	// RVA: 0x1B18660 Offset: 0x1B18761 VA: 0x1B18660
	private static string IntToString(int n, int digits) { }

	// RVA: 0x1B18010 Offset: 0x1B18111 VA: 0x1B18010
	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	// RVA: 0x1B18680 Offset: 0x1B18781 VA: 0x1B18680
	private static string FormatStandard(TimeSpan value, bool isInvariant, string format, TimeSpanFormat.Pattern pattern) { }

	// RVA: 0x1B18C70 Offset: 0x1B18D71 VA: 0x1B18C70
	internal static string FormatCustomized(TimeSpan value, string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1B194B0 Offset: 0x1B195B1 VA: 0x1B194B0
	private static void .cctor() { }
}

