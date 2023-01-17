// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodeInfoAtom // TypeDefIndex: 1623
{
	// Fields
	private string localName; // 0x10
	private string namespaceUri; // 0x18
	private string prefix; // 0x20
	private XPathNode[] pageParent; // 0x28
	private XPathNode[] pageSibling; // 0x30
	private XPathDocument doc; // 0x38
	private int lineNumBase; // 0x40
	private int linePosBase; // 0x44
	private XPathNodePageInfo pageInfo; // 0x48

	// Properties
	public XPathNodePageInfo PageInfo { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public string Prefix { get; }
	public XPathNode[] SiblingPage { get; }
	public XPathNode[] ParentPage { get; }
	public XPathDocument Document { get; }
	public int LineNumberBase { get; }
	public int LinePositionBase { get; }

	// Methods

	// RVA: 0x19C0980 Offset: 0x19C0A81 VA: 0x19C0980
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x19C0990 Offset: 0x19C0A91 VA: 0x19C0990
	public string get_LocalName() { }

	// RVA: 0x19C09A0 Offset: 0x19C0AA1 VA: 0x19C09A0
	public string get_NamespaceUri() { }

	// RVA: 0x19C09B0 Offset: 0x19C0AB1 VA: 0x19C09B0
	public string get_Prefix() { }

	// RVA: 0x19C09C0 Offset: 0x19C0AC1 VA: 0x19C09C0
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0x19C09D0 Offset: 0x19C0AD1 VA: 0x19C09D0
	public XPathNode[] get_ParentPage() { }

	// RVA: 0x19C09E0 Offset: 0x19C0AE1 VA: 0x19C09E0
	public XPathDocument get_Document() { }

	// RVA: 0x19C09F0 Offset: 0x19C0AF1 VA: 0x19C09F0
	public int get_LineNumberBase() { }

	// RVA: 0x19C0A00 Offset: 0x19C0B01 VA: 0x19C0A00
	public int get_LinePositionBase() { }
}

