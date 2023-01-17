// Namespace: System.Xml
internal struct XmlCharType // TypeDefIndex: 1737
{
	// Fields
	private static object s_Lock; // 0x0
	private static byte[] s_CharProperties; // 0x8
	internal byte[] charProperties; // 0x0

	// Properties
	private static object StaticLock { get; }
	public static XmlCharType Instance { get; }

	// Methods

	// RVA: 0x1A9FFF0 Offset: 0x1AA00F1 VA: 0x1A9FFF0
	private static object get_StaticLock() { }

	// RVA: 0x1AA00B0 Offset: 0x1AA01B1 VA: 0x1AA00B0
	private static void InitInstance() { }

	// RVA: 0x1AA0360 Offset: 0x1AA0461 VA: 0x1AA0360
	private static void SetProperties(string ranges, byte value) { }

	// RVA: 0x1AA0470 Offset: 0x1AA0571 VA: 0x1AA0470
	private void .ctor(byte[] charProperties) { }

	// RVA: 0x1AA0480 Offset: 0x1AA0581 VA: 0x1AA0480
	public static XmlCharType get_Instance() { }

	// RVA: 0x1AA0510 Offset: 0x1AA0611 VA: 0x1AA0510
	public bool IsWhiteSpace(char ch) { }

	// RVA: 0x1AA0550 Offset: 0x1AA0651 VA: 0x1AA0550
	public bool IsNCNameSingleChar(char ch) { }

	// RVA: 0x1AA0590 Offset: 0x1AA0691 VA: 0x1AA0590
	public bool IsStartNCNameSingleChar(char ch) { }

	// RVA: 0x1AA05D0 Offset: 0x1AA06D1 VA: 0x1AA05D0
	public bool IsNameSingleChar(char ch) { }

	// RVA: 0x1AA0620 Offset: 0x1AA0721 VA: 0x1AA0620
	public bool IsCharData(char ch) { }

	// RVA: 0x1AA0660 Offset: 0x1AA0761 VA: 0x1AA0660
	public bool IsPubidChar(char ch) { }

	// RVA: 0x1AA06E0 Offset: 0x1AA07E1 VA: 0x1AA06E0
	public static bool IsDigit(char ch) { }

	// RVA: 0x1AA0720 Offset: 0x1AA0821 VA: 0x1AA0720
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0x1AA0730 Offset: 0x1AA0831 VA: 0x1AA0730
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0x1AA0740 Offset: 0x1AA0841 VA: 0x1AA0740
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0x1AA0750 Offset: 0x1AA0851 VA: 0x1AA0750
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0x1AA0770 Offset: 0x1AA0871 VA: 0x1AA0770
	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

	// RVA: 0x1AA07B0 Offset: 0x1AA08B1 VA: 0x1AA07B0
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x1AA0860 Offset: 0x1AA0961 VA: 0x1AA0860
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x1AA0900 Offset: 0x1AA0A01 VA: 0x1AA0900
	internal int IsOnlyCharData(string str) { }

	// RVA: 0x1AA0A00 Offset: 0x1AA0B01 VA: 0x1AA0A00
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x1AA0A80 Offset: 0x1AA0B81 VA: 0x1AA0A80
	internal int IsPublicId(string str) { }

	// RVA: 0x1AA0700 Offset: 0x1AA0801 VA: 0x1AA0700
	private static bool InRange(int value, int start, int end) { }
}

