// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 1618
{
	// Fields
	private XPathNode[] pageCurrent; // 0x10
	private XPathNode[] pageParent; // 0x18
	private int idxCurrent; // 0x20
	private int idxParent; // 0x24

	// Properties
	public override string Value { get; }
	public override XPathNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override XmlNameTable NameTable { get; }
	public override object UnderlyingObject { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x19BC6E0 Offset: 0x19BC7E1 VA: 0x19BC6E0
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x19BC7B0 Offset: 0x19BC8B1 VA: 0x19BC7B0 Slot: 5
	public override string get_Value() { }

	// RVA: 0x19BCC40 Offset: 0x19BCD41 VA: 0x19BCC40 Slot: 23
	public override XPathNavigator Clone() { }

	// RVA: 0x19BCD30 Offset: 0x19BCE31 VA: 0x19BCD30 Slot: 24
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x19BCD80 Offset: 0x19BCE81 VA: 0x19BCD80 Slot: 25
	public override string get_LocalName() { }

	// RVA: 0x19BCDD0 Offset: 0x19BCED1 VA: 0x19BCDD0 Slot: 26
	public override string get_NamespaceURI() { }

	// RVA: 0x19BCE20 Offset: 0x19BCF21 VA: 0x19BCE20 Slot: 27
	public override string get_Prefix() { }

	// RVA: 0x19BCE70 Offset: 0x19BCF71 VA: 0x19BCE70 Slot: 19
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x19BCEC0 Offset: 0x19BCFC1 VA: 0x19BCEC0 Slot: 30
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x19BD2A0 Offset: 0x19BD3A1 VA: 0x19BD2A0 Slot: 31
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x19BD4D0 Offset: 0x19BD5D1 VA: 0x19BD4D0 Slot: 32
	public override bool MoveToParent() { }

	// RVA: 0x19BD650 Offset: 0x19BD751 VA: 0x19BD650 Slot: 33
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x19BD710 Offset: 0x19BD811 VA: 0x19BD710 Slot: 28
	public override object get_UnderlyingObject() { }

	// RVA: 0x19BD720 Offset: 0x19BD821 VA: 0x19BD720 Slot: 35
	public int get_LineNumber() { }

	// RVA: 0x19BD7D0 Offset: 0x19BD8D1 VA: 0x19BD7D0 Slot: 36
	public int get_LinePosition() { }

	// RVA: 0x19BD8C0 Offset: 0x19BD9C1 VA: 0x19BD8C0
	public int GetPositionHashCode() { }
}

