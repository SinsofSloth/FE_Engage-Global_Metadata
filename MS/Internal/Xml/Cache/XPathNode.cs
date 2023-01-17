// Namespace: MS.Internal.Xml.Cache
internal struct XPathNode // TypeDefIndex: 1619
{
	// Fields
	private XPathNodeInfoAtom info; // 0x0
	private ushort idxSibling; // 0x8
	private ushort idxParent; // 0xA
	private ushort idxSimilar; // 0xC
	private ushort posOffset; // 0xE
	private uint props; // 0x10
	private string value; // 0x18

	// Properties
	public XPathNodeType NodeType { get; }
	public string Prefix { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public XPathDocument Document { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public int CollapsedLinePosition { get; }
	public XPathNodePageInfo PageInfo { get; }
	public bool IsXmlNamespaceNode { get; }
	public bool HasSibling { get; }
	public bool HasCollapsedText { get; }
	public bool IsText { get; }
	public bool HasNamespaceDecls { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x19BCD70 Offset: 0x19BCE71 VA: 0x19BCD70
	public XPathNodeType get_NodeType() { }

	// RVA: 0x19BCE60 Offset: 0x19BCF61 VA: 0x19BCE60
	public string get_Prefix() { }

	// RVA: 0x19BCDC0 Offset: 0x19BCEC1 VA: 0x19BCDC0
	public string get_LocalName() { }

	// RVA: 0x19BCE10 Offset: 0x19BCF11 VA: 0x19BCE10
	public string get_NamespaceUri() { }

	// RVA: 0x19BCEB0 Offset: 0x19BCFB1 VA: 0x19BCEB0
	public XPathDocument get_Document() { }

	// RVA: 0x19BD7B0 Offset: 0x19BD8B1 VA: 0x19BD7B0
	public int get_LineNumber() { }

	// RVA: 0x19BD8A0 Offset: 0x19BD9A1 VA: 0x19BD8A0
	public int get_LinePosition() { }

	// RVA: 0x19BD880 Offset: 0x19BD981 VA: 0x19BD880
	public int get_CollapsedLinePosition() { }

	// RVA: 0x19C0870 Offset: 0x19C0971 VA: 0x19C0870
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x19BD490 Offset: 0x19BD591 VA: 0x19BD490
	public int GetParent(out XPathNode[] pageNode) { }

	// RVA: 0x19BD260 Offset: 0x19BD361 VA: 0x19BD260
	public int GetSibling(out XPathNode[] pageNode) { }

	// RVA: 0x19BD1E0 Offset: 0x19BD2E1 VA: 0x19BD1E0
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x19C0880 Offset: 0x19C0981 VA: 0x19C0880
	public bool get_HasSibling() { }

	// RVA: 0x19C0890 Offset: 0x19C0991 VA: 0x19C0890
	public bool get_HasCollapsedText() { }

	// RVA: 0x19C08A0 Offset: 0x19C09A1 VA: 0x19C08A0
	public bool get_IsText() { }

	// RVA: 0x19C0920 Offset: 0x19C0A21 VA: 0x19C0920
	public bool get_HasNamespaceDecls() { }

	// RVA: 0x19C0930 Offset: 0x19C0A31 VA: 0x19C0930
	public string get_Value() { }
}

