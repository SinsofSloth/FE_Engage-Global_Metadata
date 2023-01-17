// Namespace: System.Xml.Schema
internal class Asttree // TypeDefIndex: 1794
{
	// Fields
	private ArrayList fAxisArray; // 0x10
	private string xpathexpr; // 0x18
	private bool isField; // 0x20
	private XmlNamespaceManager nsmgr; // 0x28

	// Properties
	internal ArrayList SubtreeArray { get; }

	// Methods

	// RVA: 0x1A22050 Offset: 0x1A22151 VA: 0x1A22050
	internal ArrayList get_SubtreeArray() { }

	// RVA: 0x1A22060 Offset: 0x1A22161 VA: 0x1A22060
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x1A22910 Offset: 0x1A22A11 VA: 0x1A22910
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0x1A22940 Offset: 0x1A22A41 VA: 0x1A22940
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0x1A22970 Offset: 0x1A22A71 VA: 0x1A22970
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0x1A229A0 Offset: 0x1A22AA1 VA: 0x1A229A0
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0x1A220D0 Offset: 0x1A221D1 VA: 0x1A220D0
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x1A229D0 Offset: 0x1A22AD1 VA: 0x1A229D0
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }
}

