// Namespace: System.Xml
public class XmlAttribute : XmlNode // TypeDefIndex: 1686
{
	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Properties
	internal XmlName XmlName { get; set; }
	public override XmlNode ParentNode { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string Value { get; set; }
	public override string InnerText { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public virtual bool Specified { get; }
	public virtual XmlElement OwnerElement { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0x1A958E0 Offset: 0x1A959E1 VA: 0x1A958E0
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0x1A95AD0 Offset: 0x1A95BD1 VA: 0x1A95AD0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x1A95C10 Offset: 0x1A95D11 VA: 0x1A95C10
	internal XmlName get_XmlName() { }

	// RVA: 0x1A95C20 Offset: 0x1A95D21 VA: 0x1A95C20
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x1A95C30 Offset: 0x1A95D31 VA: 0x1A95C30 Slot: 27
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1A95CF0 Offset: 0x1A95DF1 VA: 0x1A95CF0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1A95D00 Offset: 0x1A95E01 VA: 0x1A95D00 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1A95D10 Offset: 0x1A95E11 VA: 0x1A95D10 Slot: 31
	public override string get_LocalName() { }

	// RVA: 0x1A95D20 Offset: 0x1A95E21 VA: 0x1A95D20 Slot: 29
	public override string get_NamespaceURI() { }

	// RVA: 0x1A95D30 Offset: 0x1A95E31 VA: 0x1A95D30 Slot: 30
	public override string get_Prefix() { }

	// RVA: 0x1A95D40 Offset: 0x1A95E41 VA: 0x1A95D40 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1A95D50 Offset: 0x1A95E51 VA: 0x1A95D50 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1A95D60 Offset: 0x1A95E61 VA: 0x1A95D60 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1A95D70 Offset: 0x1A95E71 VA: 0x1A95D70 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1A95D80 Offset: 0x1A95E81 VA: 0x1A95D80 Slot: 34
	public override void set_InnerText(string value) { }

	// RVA: 0x1A95E70 Offset: 0x1A95F71 VA: 0x1A95E70
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0x1A95F30 Offset: 0x1A96031 VA: 0x1A95F30
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x1A961F0 Offset: 0x1A962F1 VA: 0x1A961F0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x1A96200 Offset: 0x1A96301 VA: 0x1A96200 Slot: 23
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x1A96500 Offset: 0x1A96601 VA: 0x1A96500 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1A96510 Offset: 0x1A96611 VA: 0x1A96510 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1A96520 Offset: 0x1A96621 VA: 0x1A96520 Slot: 24
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1A96540 Offset: 0x1A96641 VA: 0x1A96540 Slot: 45
	public virtual bool get_Specified() { }

	// RVA: 0x1A96550 Offset: 0x1A96651 VA: 0x1A96550 Slot: 21
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x1A96660 Offset: 0x1A96761 VA: 0x1A96660 Slot: 22
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x1A96770 Offset: 0x1A96871 VA: 0x1A96770 Slot: 46
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0x1A96800 Offset: 0x1A96901 VA: 0x1A96800 Slot: 35
	public override void set_InnerXml(string value) { }

	// RVA: 0x1A96890 Offset: 0x1A96991 VA: 0x1A96890 Slot: 36
	public override string get_BaseURI() { }

	// RVA: 0x1A96930 Offset: 0x1A96A31 VA: 0x1A96930 Slot: 38
	internal override void SetParent(XmlNode node) { }
}

