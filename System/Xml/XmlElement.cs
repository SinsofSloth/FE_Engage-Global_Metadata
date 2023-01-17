// Namespace: System.Xml
public class XmlElement : XmlLinkedNode // TypeDefIndex: 1697
{
	// Fields
	private XmlName name; // 0x20
	private XmlAttributeCollection attributes; // 0x28
	private XmlLinkedNode lastChild; // 0x30

	// Properties
	internal XmlName XmlName { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	internal override bool IsContainer { get; }
	public bool IsEmpty { get; set; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlAttributeCollection Attributes { get; }
	public virtual bool HasAttributes { get; }
	public override string InnerXml { set; }
	public override string InnerText { get; set; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x32E98B0 Offset: 0x32E99B1 VA: 0x32E98B0
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x32E9A10 Offset: 0x32E9B11 VA: 0x32E9A10
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x32E9A50 Offset: 0x32E9B51 VA: 0x32E9A50
	internal XmlName get_XmlName() { }

	// RVA: 0x32E9A60 Offset: 0x32E9B61 VA: 0x32E9A60
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x32E9A70 Offset: 0x32E9B71 VA: 0x32E9A70 Slot: 27
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x32EA070 Offset: 0x32EA171 VA: 0x32EA070 Slot: 6
	public override string get_Name() { }

	// RVA: 0x32EA220 Offset: 0x32EA321 VA: 0x32EA220 Slot: 31
	public override string get_LocalName() { }

	// RVA: 0x32EA230 Offset: 0x32EA331 VA: 0x32EA230 Slot: 29
	public override string get_NamespaceURI() { }

	// RVA: 0x32EA240 Offset: 0x32EA341 VA: 0x32EA240 Slot: 30
	public override string get_Prefix() { }

	// RVA: 0x32EA250 Offset: 0x32EA351 VA: 0x32EA250 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32EA260 Offset: 0x32EA361 VA: 0x32EA260 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x32EA270 Offset: 0x32EA371 VA: 0x32EA270 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x32EA280 Offset: 0x32EA381 VA: 0x32EA280 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x32EA290 Offset: 0x32EA391 VA: 0x32EA290 Slot: 23
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x32E9F90 Offset: 0x32EA091 VA: 0x32E9F90
	public bool get_IsEmpty() { }

	// RVA: 0x32E9FA0 Offset: 0x32EA0A1 VA: 0x32E9FA0
	public void set_IsEmpty(bool value) { }

	// RVA: 0x32EA4F0 Offset: 0x32EA5F1 VA: 0x32EA4F0 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x32EA500 Offset: 0x32EA601 VA: 0x32EA500 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x32EA510 Offset: 0x32EA611 VA: 0x32EA510 Slot: 24
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x32EA540 Offset: 0x32EA641 VA: 0x32EA540 Slot: 14
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x32EA690 Offset: 0x32EA791 VA: 0x32EA690 Slot: 45
	public virtual bool get_HasAttributes() { }

	// RVA: 0x32EA6C0 Offset: 0x32EA7C1 VA: 0x32EA6C0 Slot: 46
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x32EA7D0 Offset: 0x32EA8D1 VA: 0x32EA7D0 Slot: 47
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x32EA820 Offset: 0x32EA921 VA: 0x32EA820 Slot: 37
	public override void RemoveAll() { }

	// RVA: 0x32EA470 Offset: 0x32EA571 VA: 0x32EA470
	internal void RemoveAllChildren() { }

	// RVA: 0x32EA930 Offset: 0x32EAA31 VA: 0x32EA930 Slot: 35
	public override void set_InnerXml(string value) { }

	// RVA: 0x32EAAD0 Offset: 0x32EABD1 VA: 0x32EAAD0 Slot: 33
	public override string get_InnerText() { }

	// RVA: 0x32EABF0 Offset: 0x32EACF1 VA: 0x32EABF0 Slot: 34
	public override void set_InnerText(string value) { }

	// RVA: 0x32EAD00 Offset: 0x32EAE01 VA: 0x32EAD00 Slot: 13
	public override XmlNode get_NextSibling() { }

	// RVA: 0x32EAD50 Offset: 0x32EAE51 VA: 0x32EAD50 Slot: 38
	internal override void SetParent(XmlNode node) { }
}

