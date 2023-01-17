// Namespace: System.Globalization
internal class DateTimeFormatInfoScanner // TypeDefIndex: 693
{
	// Fields
	internal List<string> m_dateWords; // 0x10
	private static Dictionary<string, string> s_knownWords; // 0x0
	private DateTimeFormatInfoScanner.FoundDatePattern m_ymdFlags; // 0x18

	// Properties
	private static Dictionary<string, string> KnownWords { get; }

	// Methods

	// RVA: 0x35BF590 Offset: 0x35BF691 VA: 0x35BF590
	private static Dictionary<string, string> get_KnownWords() { }

	// RVA: 0x35BF980 Offset: 0x35BFA81 VA: 0x35BF980
	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

	// RVA: 0x35BFAA0 Offset: 0x35BFBA1 VA: 0x35BFAA0
	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	// RVA: 0x35BFE00 Offset: 0x35BFF01 VA: 0x35BFE00
	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	// RVA: 0x35BFFE0 Offset: 0x35C00E1 VA: 0x35BFFE0
	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	// RVA: 0x35BFCE0 Offset: 0x35BFDE1 VA: 0x35BFCE0
	internal void AddIgnorableSymbols(string text) { }

	// RVA: 0x35C0060 Offset: 0x35C0161 VA: 0x35C0060
	internal void ScanDateWord(string pattern) { }

	// RVA: 0x35BE7B0 Offset: 0x35BE8B1 VA: 0x35BE7B0
	internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	// RVA: 0x35BC0D0 Offset: 0x35BC1D1 VA: 0x35BC0D0
	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x35BC120 Offset: 0x35BC221 VA: 0x35BC120
	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x35BC1E0 Offset: 0x35BC2E1 VA: 0x35BC1E0
	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames) { }

	// RVA: 0x35BC230 Offset: 0x35BC331 VA: 0x35BC230
	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	// RVA: 0x35C0330 Offset: 0x35C0431 VA: 0x35C0330
	private static bool EqualStringArrays(string[] array1, string[] array2) { }

	// RVA: 0x35C0650 Offset: 0x35C0751 VA: 0x35C0650
	private static bool ArrayElementsHaveSpace(string[] array) { }

	// RVA: 0x35C03F0 Offset: 0x35C04F1 VA: 0x35C03F0
	private static bool ArrayElementsBeginWithDigit(string[] array) { }

	// RVA: 0x35BE720 Offset: 0x35BE821 VA: 0x35BE720
	public void .ctor() { }
}

