// Namespace: System.Xml
[Serializable]
public class XmlQualifiedName // TypeDefIndex: 1766
{
	// Fields
	private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private string name; // 0x10
	private string ns; // 0x18
	private int hash; // 0x20
	public static readonly XmlQualifiedName Empty; // 0x8

	// Properties
	public string Namespace { get; }
	public string Name { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x3300AE0 Offset: 0x3300BE1 VA: 0x3300AE0
	public void .ctor() { }

	// RVA: 0x3300C60 Offset: 0x3300D61 VA: 0x3300C60
	public void .ctor(string name) { }

	// RVA: 0x3300BB0 Offset: 0x3300CB1 VA: 0x3300BB0
	public void .ctor(string name, string ns) { }

	// RVA: 0x3300D30 Offset: 0x3300E31 VA: 0x3300D30
	public string get_Namespace() { }

	// RVA: 0x3300D40 Offset: 0x3300E41 VA: 0x3300D40
	public string get_Name() { }

	// RVA: 0x3300D50 Offset: 0x3300E51 VA: 0x3300D50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x32F31D0 Offset: 0x32F32D1 VA: 0x32F31D0
	public bool get_IsEmpty() { }

	// RVA: 0x3300FF0 Offset: 0x33010F1 VA: 0x3300FF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3301060 Offset: 0x3301161 VA: 0x3301060 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x3301270 Offset: 0x3301371 VA: 0x3301270
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x33011B0 Offset: 0x33012B1 VA: 0x33011B0
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x33012F0 Offset: 0x33013F1 VA: 0x33012F0
	public static string ToString(string name, string ns) { }

	// RVA: 0x3300E50 Offset: 0x3300F51 VA: 0x3300E50
	private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x3301370 Offset: 0x3301471 VA: 0x3301370
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0x3301380 Offset: 0x3301481 VA: 0x3301380
	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	// RVA: 0x3301390 Offset: 0x3301491 VA: 0x3301390
	internal void Init(string name, string ns) { }

	// RVA: 0x33013D0 Offset: 0x33014D1 VA: 0x33013D0
	internal void SetNamespace(string ns) { }

	// RVA: 0x33013E0 Offset: 0x33014E1 VA: 0x33013E0
	internal void Verify() { }

	// RVA: 0x3301490 Offset: 0x3301591 VA: 0x3301490
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0x3301500 Offset: 0x3301601 VA: 0x3301500
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	// RVA: 0x3301730 Offset: 0x3301831 VA: 0x3301730
	internal XmlQualifiedName Clone() { }

	// RVA: 0x33017C0 Offset: 0x33018C1 VA: 0x33017C0
	private static void .cctor() { }
}

