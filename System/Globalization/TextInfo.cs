// Namespace: System.Globalization
[ComVisibleAttribute] // RVA: 0x473000 Offset: 0x473101 VA: 0x473000
[Serializable]
public class TextInfo : ICloneable, IDeserializationCallback // TypeDefIndex: 710
{
	// Fields
	[OptionalFieldAttribute] // RVA: 0x478EC0 Offset: 0x478FC1 VA: 0x478EC0
	private string m_listSeparator; // 0x10
	[OptionalFieldAttribute] // RVA: 0x478F00 Offset: 0x479001 VA: 0x478F00
	private bool m_isReadOnly; // 0x18
	[OptionalFieldAttribute] // RVA: 0x478F40 Offset: 0x479041 VA: 0x478F40
	private string m_cultureName; // 0x20
	private CultureData m_cultureData; // 0x28
	private string m_textInfoName; // 0x30
	private Nullable<bool> m_IsAsciiCasingSameAsInvariant; // 0x38
	internal static TextInfo s_Invariant; // 0x0
	[OptionalFieldAttribute] // RVA: 0x478F80 Offset: 0x479081 VA: 0x478F80
	private string customCultureName; // 0x40
	[OptionalFieldAttribute] // RVA: 0x478FC0 Offset: 0x4790C1 VA: 0x478FC0
	internal int m_nDataItem; // 0x48
	[OptionalFieldAttribute] // RVA: 0x479000 Offset: 0x479101 VA: 0x479000
	internal bool m_useUserOverride; // 0x4C
	[OptionalFieldAttribute] // RVA: 0x479040 Offset: 0x479141 VA: 0x479040
	internal int m_win32LangID; // 0x50
	private const int wordSeparatorMask = 536672256;

	// Properties
	internal static TextInfo Invariant { get; }
	[ComVisibleAttribute] // RVA: 0x47DFE0 Offset: 0x47E0E1 VA: 0x47DFE0
	public string CultureName { get; }
	private bool IsAsciiCasingSameAsInvariant { get; }

	// Methods

	// RVA: 0x1B0FB10 Offset: 0x1B0FC11 VA: 0x1B0FB10
	internal static TextInfo get_Invariant() { }

	// RVA: 0x1B0FC00 Offset: 0x1B0FD01 VA: 0x1B0FC00
	internal void .ctor(CultureData cultureData) { }

	[OnDeserializingAttribute] // RVA: 0x47C480 Offset: 0x47C581 VA: 0x47C480
	// RVA: 0x1B0FC70 Offset: 0x1B0FD71 VA: 0x1B0FC70
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x1B0FCB0 Offset: 0x1B0FDB1 VA: 0x1B0FCB0
	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0x47C490 Offset: 0x47C591 VA: 0x47C490
	// RVA: 0x1B0FDE0 Offset: 0x1B0FEE1 VA: 0x1B0FDE0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x47C4A0 Offset: 0x47C5A1 VA: 0x47C4A0
	// RVA: 0x1B0FDF0 Offset: 0x1B0FEF1 VA: 0x1B0FDF0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1B0FE90 Offset: 0x1B0FF91 VA: 0x1B0FE90
	internal static int GetHashCodeOrdinalIgnoreCase(string s) { }

	// RVA: 0x1B0FEC0 Offset: 0x1B0FFC1 VA: 0x1B0FEC0
	internal static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x1B10000 Offset: 0x1B10101 VA: 0x1B10000
	internal static int CompareOrdinalIgnoreCase(string str1, string str2) { }

	// RVA: 0x1B101F0 Offset: 0x1B102F1 VA: 0x1B101F0
	internal static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB) { }

	// RVA: 0x1B10200 Offset: 0x1B10301 VA: 0x1B10200
	internal static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x1B102C0 Offset: 0x1B103C1 VA: 0x1B102C0
	internal static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x1B10380 Offset: 0x1B10481 VA: 0x1B10380
	public string get_CultureName() { }

	[ComVisibleAttribute] // RVA: 0x47C4B0 Offset: 0x47C5B1 VA: 0x47C4B0
	// RVA: 0x1B10390 Offset: 0x1B10491 VA: 0x1B10390 Slot: 6
	public virtual object Clone() { }

	// RVA: 0x1B10420 Offset: 0x1B10521 VA: 0x1B10420
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x1B10430 Offset: 0x1B10531 VA: 0x1B10430 Slot: 7
	public virtual char ToLower(char c) { }

	// RVA: 0x1B10B30 Offset: 0x1B10C31 VA: 0x1B10B30 Slot: 8
	public virtual string ToLower(string str) { }

	// RVA: 0x1B105C0 Offset: 0x1B106C1 VA: 0x1B105C0
	private static char ToLowerAsciiInvariant(char c) { }

	// RVA: 0x1B10C80 Offset: 0x1B10D81 VA: 0x1B10C80 Slot: 9
	public virtual char ToUpper(char c) { }

	// RVA: 0x1B112B0 Offset: 0x1B113B1 VA: 0x1B112B0 Slot: 10
	public virtual string ToUpper(string str) { }

	// RVA: 0x1B10CF0 Offset: 0x1B10DF1 VA: 0x1B10CF0
	private static char ToUpperAsciiInvariant(char c) { }

	// RVA: 0x1B104A0 Offset: 0x1B105A1 VA: 0x1B104A0
	private static bool IsAscii(char c) { }

	// RVA: 0x1B104B0 Offset: 0x1B105B1 VA: 0x1B104B0
	private bool get_IsAsciiCasingSameAsInvariant() { }

	// RVA: 0x1B11400 Offset: 0x1B11501 VA: 0x1B11400 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B114A0 Offset: 0x1B115A1 VA: 0x1B114A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B114B0 Offset: 0x1B115B1 VA: 0x1B114B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B11510 Offset: 0x1B11611 VA: 0x1B11510 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1B11520 Offset: 0x1B11621 VA: 0x1B11520
	internal int GetCaseInsensitiveHashCode(string str) { }

	// RVA: 0x1B0FEF0 Offset: 0x1B0FFF1 VA: 0x1B0FEF0
	internal int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x1B11530 Offset: 0x1B11631 VA: 0x1B11530
	private int GetInvariantCaseInsensitiveHashCode(string str) { }

	// RVA: 0x1B11310 Offset: 0x1B11411 VA: 0x1B11310
	private string ToUpperInternal(string str) { }

	// RVA: 0x1B10B90 Offset: 0x1B10C91 VA: 0x1B10B90
	private string ToLowerInternal(string str) { }

	// RVA: 0x1B10D10 Offset: 0x1B10E11 VA: 0x1B10D10
	private char ToUpperInternal(char c) { }

	// RVA: 0x1B105E0 Offset: 0x1B106E1 VA: 0x1B105E0
	private char ToLowerInternal(char c) { }

	// RVA: 0x1B10020 Offset: 0x1B10121 VA: 0x1B10020
	private static int InternalCompareStringOrdinalIgnoreCase(string strA, int indexA, string strB, int indexB, int lenA, int lenB) { }

	// RVA: 0x1B11660 Offset: 0x1B11761 VA: 0x1B11660
	internal void .ctor() { }
}

