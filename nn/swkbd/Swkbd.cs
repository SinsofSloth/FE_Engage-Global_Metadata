// Namespace: nn.swkbd
public static class Swkbd // TypeDefIndex: 14504
{
	// Fields
	public const int TextMaxLength = 500;
	public const int SeparateModeTextMaxLength = 24;
	public const int HeaderTextMaxLength = 64;
	public const int SubTextMaxLength = 128;
	public const int GuideTextMaxLength = 256;
	public const int OkTextMaxLength = 8;
	public const int UnfixedStringLengthMax = 24;
	public const int UserWordMax = 5000;
	public const int DialogTextMaxLength = 500;
	public const int SepareteTextPosMax = 8;
	public const int CustomizedDicionarySetMax = 24;

	// Properties
	public static ErrorRange ResultCanceled { get; }

	// Methods

	// RVA: 0x292A230 Offset: 0x292A331 VA: 0x292A230
	public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) { }

	// RVA: 0x292A480 Offset: 0x292A581 VA: 0x292A480
	public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads) { }

	// RVA: 0x292A650 Offset: 0x292A751 VA: 0x292A650
	public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x292A720 Offset: 0x292A821 VA: 0x292A720
	public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x292A3D0 Offset: 0x292A4D1 VA: 0x292A3D0
	private static extern Result ShowKeyboard([In] [Out] StringBuilder pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x292A5B0 Offset: 0x292A6B1 VA: 0x292A5B0
	private static extern Result ShowKeyboard([In] [Out] byte[] pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg) { }

	// RVA: 0x292A7C0 Offset: 0x292A8C1 VA: 0x292A7C0
	public static extern void InitializeKeyboardConfig(ref KeyboardConfig pOutKeyboardConfig) { }

	// RVA: 0x292A860 Offset: 0x292A961 VA: 0x292A860
	public static extern void MakePreset(ref KeyboardConfig pOutKeyboardConfig, Preset preset) { }

	// RVA: 0x292A910 Offset: 0x292AA11 VA: 0x292A910
	public static extern long GetRequiredStringBufferSize() { }

	// RVA: 0x292A920 Offset: 0x292AA21 VA: 0x292A920
	public static extern void SetLeftOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code) { }

	// RVA: 0x292A9D0 Offset: 0x292AAD1 VA: 0x292A9D0
	public static extern void SetLeftOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code) { }

	// RVA: 0x292AA90 Offset: 0x292AB91 VA: 0x292AA90
	public static extern void SetRightOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code) { }

	// RVA: 0x292AB40 Offset: 0x292AC41 VA: 0x292AB40
	public static extern void SetRightOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code) { }

	// RVA: 0x292AC00 Offset: 0x292AD01 VA: 0x292AC00
	public static extern void SetOkText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x292ACC0 Offset: 0x292ADC1 VA: 0x292ACC0
	public static extern void SetOkTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x292AD80 Offset: 0x292AE81 VA: 0x292AD80
	public static extern void SetHeaderText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x292AE40 Offset: 0x292AF41 VA: 0x292AE40
	public static extern void SetHeaderTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x292AF00 Offset: 0x292B001 VA: 0x292AF00
	public static extern void SetSubText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x292AFC0 Offset: 0x292B0C1 VA: 0x292AFC0
	public static extern void SetSubTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x292B080 Offset: 0x292B181 VA: 0x292B080
	public static extern void SetGuideText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr) { }

	// RVA: 0x292B140 Offset: 0x292B241 VA: 0x292B140
	public static extern void SetGuideTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr) { }

	// RVA: 0x292B200 Offset: 0x292B301 VA: 0x292B200
	public static extern void SetInitialText(ref ShowKeyboardArg pOutShowKeyboardArg, [In] string pStr) { }

	// RVA: 0x292B2C0 Offset: 0x292B3C1 VA: 0x292B2C0
	public static extern void SetInitialTextUtf8(ref ShowKeyboardArg pOutShowKeyboardArg, [In] byte[] pStr) { }

	// RVA: 0x292B380 Offset: 0x292B481 VA: 0x292B380
	public static extern void SetUserWordList(ref ShowKeyboardArg pOutShowKeyboardArg, [In] UserWord[] pUserWord, int userWordNum) { }

	// RVA: 0x292B4E0 Offset: 0x292B5E1 VA: 0x292B4E0
	public static extern void SetTextCheckCallback(ref ShowKeyboardArg pOutShowKeyboardArg, [In] TextCheckCallback pCallback) { }

	// RVA: 0x292B5A0 Offset: 0x292B6A1 VA: 0x292B5A0
	public static extern void SetCustomizedDictionaries(ref ShowKeyboardArg pOutShowKeyboardArg, CustomizedDictionarySet dicSet) { }

	// RVA: 0x292B670 Offset: 0x292B771 VA: 0x292B670
	public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory, bool useTextCheck) { }

	// RVA: 0x292B730 Offset: 0x292B831 VA: 0x292B730
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory) { }

	// RVA: 0x292B7F0 Offset: 0x292B8F1 VA: 0x292B7F0
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg) { }

	// RVA: 0x292B8A0 Offset: 0x292B9A1 VA: 0x292B8A0
	public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum, bool useTextCheck) { }

	// RVA: 0x292B960 Offset: 0x292BA61 VA: 0x292B960
	public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum) { }

	// RVA: 0x292BA20 Offset: 0x292BB21 VA: 0x292BA20
	public static extern void Destroy(ref ShowKeyboardArg pOutShowKeyboardArg) { }

	// RVA: 0x292A3B0 Offset: 0x292A4B1 VA: 0x292A3B0
	private static int GetByteSize(StringBuilder sb) { }

	// RVA: 0x292BAD0 Offset: 0x292BBD1 VA: 0x292BAD0
	public static ErrorRange get_ResultCanceled() { }
}

