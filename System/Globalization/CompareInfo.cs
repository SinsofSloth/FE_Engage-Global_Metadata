// Namespace: System.Globalization
[ComVisibleAttribute] // RVA: 0x472E60 Offset: 0x472F61 VA: 0x472E60
[Serializable]
public class CompareInfo : IDeserializationCallback // TypeDefIndex: 684
{
	// Fields
	private const CompareOptions ValidIndexMaskOffFlags = -32;
	private const CompareOptions ValidCompareMaskOffFlags = -536870944;
	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = -32;
	[OptionalFieldAttribute] // RVA: 0x478540 Offset: 0x478641 VA: 0x478540
	private string m_name; // 0x10
	private string m_sortName; // 0x18
	[OptionalFieldAttribute] // RVA: 0x478580 Offset: 0x478681 VA: 0x478580
	private int win32LCID; // 0x20
	private int culture; // 0x24
	private const int LINGUISTIC_IGNORECASE = 16;
	private const int NORM_IGNORECASE = 1;
	private const int NORM_IGNOREKANATYPE = 65536;
	private const int LINGUISTIC_IGNOREDIACRITIC = 32;
	private const int NORM_IGNORENONSPACE = 2;
	private const int NORM_IGNORESYMBOLS = 4;
	private const int NORM_IGNOREWIDTH = 131072;
	private const int SORT_STRINGSORT = 4096;
	private const int COMPARE_OPTIONS_ORDINAL = 1073741824;
	internal const int NORM_LINGUISTIC_CASING = 134217728;
	private const int RESERVED_FIND_ASCII_STRING = 536870912;
	private const int SORT_VERSION_WHIDBEY = 4096;
	private const int SORT_VERSION_V4 = 393473;
	[OptionalFieldAttribute] // RVA: 0x4785C0 Offset: 0x4786C1 VA: 0x4785C0
	private SortVersion m_SortVersion; // 0x28
	private SimpleCollator collator; // 0x30
	private static Dictionary<string, SimpleCollator> collators; // 0x0
	private static bool managedCollation; // 0x8
	private static bool managedCollationChecked; // 0x9

	// Properties
	[ComVisibleAttribute] // RVA: 0x47DEE0 Offset: 0x47DFE1 VA: 0x47DEE0
	public virtual string Name { get; }
	private static bool UseManagedCollation { get; }

	// Methods

	// RVA: 0x33A82B0 Offset: 0x33A83B1 VA: 0x33A82B0
	internal void .ctor(CultureInfo culture) { }

	// RVA: 0x33A8300 Offset: 0x33A8401 VA: 0x33A8300
	public static CompareInfo GetCompareInfo(string name) { }

	[OnDeserializingAttribute] // RVA: 0x47C3F0 Offset: 0x47C4F1 VA: 0x47C3F0
	// RVA: 0x33A83C0 Offset: 0x33A84C1 VA: 0x33A83C0
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x33A83D0 Offset: 0x33A84D1 VA: 0x33A83D0
	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0x47C400 Offset: 0x47C501 VA: 0x47C400
	// RVA: 0x33A84A0 Offset: 0x33A85A1 VA: 0x33A84A0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x47C410 Offset: 0x47C511 VA: 0x47C410
	// RVA: 0x33A84B0 Offset: 0x33A85B1 VA: 0x33A84B0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x33A8550 Offset: 0x33A8651 VA: 0x33A8550 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x33A8560 Offset: 0x33A8661 VA: 0x33A8560 Slot: 5
	public virtual string get_Name() { }

	// RVA: 0x33A8600 Offset: 0x33A8701 VA: 0x33A8600 Slot: 6
	public virtual int Compare(string string1, string string2) { }

	// RVA: 0x33A8610 Offset: 0x33A8711 VA: 0x33A8610 Slot: 7
	public virtual int Compare(string string1, string string2, CompareOptions options) { }

	// RVA: 0x33A8890 Offset: 0x33A8991 VA: 0x33A8890 Slot: 8
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x33A8C00 Offset: 0x33A8D01 VA: 0x33A8C00
	private static int CompareOrdinal(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	// RVA: 0x33A8C60 Offset: 0x33A8D61 VA: 0x33A8C60 Slot: 9
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options) { }

	// RVA: 0x33A9280 Offset: 0x33A9381 VA: 0x33A9280 Slot: 10
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options) { }

	// RVA: 0x33A9480 Offset: 0x33A9581 VA: 0x33A9480 Slot: 11
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x33A9830 Offset: 0x33A9931 VA: 0x33A9830 Slot: 12
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x33A9B00 Offset: 0x33A9C01 VA: 0x33A9B00 Slot: 13
	public virtual SortKey GetSortKey(string source, CompareOptions options) { }

	// RVA: 0x33A9B10 Offset: 0x33A9C11 VA: 0x33A9B10
	private SortKey CreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x33A9D20 Offset: 0x33A9E21 VA: 0x33A9D20 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x33A9DF0 Offset: 0x33A9EF1 VA: 0x33A9DF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x33A9E20 Offset: 0x33A9F21 VA: 0x33A9E20
	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	// RVA: 0x33A9E30 Offset: 0x33A9F31 VA: 0x33A9E30
	internal int GetHashCodeOfString(string source, CompareOptions options, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x33A9F30 Offset: 0x33AA031 VA: 0x33A9F30 Slot: 3
	public override string ToString() { }

	// RVA: 0x33A8E60 Offset: 0x33A8F61 VA: 0x33A8E60
	private static bool get_UseManagedCollation() { }

	// RVA: 0x33A8FA0 Offset: 0x33A90A1 VA: 0x33A8FA0
	private SimpleCollator GetCollator() { }

	// RVA: 0x33A9C50 Offset: 0x33A9D51 VA: 0x33A9C50
	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	// RVA: 0x33A9730 Offset: 0x33A9831 VA: 0x33A9730
	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x33A87D0 Offset: 0x33A88D1 VA: 0x33A87D0
	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x33AA050 Offset: 0x33AA151 VA: 0x33AA050
	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x33A9FC0 Offset: 0x33AA0C1 VA: 0x33A9FC0
	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x33A9FA0 Offset: 0x33AA0A1 VA: 0x33A9FA0
	private void assign_sortkey(object key, string source, CompareOptions options) { }

	// RVA: 0x33AA040 Offset: 0x33AA141 VA: 0x33AA040
	private int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x33A9FB0 Offset: 0x33AA0B1 VA: 0x33A9FB0
	private int internal_index(string source, int sindex, int count, string value, CompareOptions options, bool first) { }

	// RVA: 0x33AA0C0 Offset: 0x33AA1C1 VA: 0x33AA0C0
	internal void .ctor() { }
}

