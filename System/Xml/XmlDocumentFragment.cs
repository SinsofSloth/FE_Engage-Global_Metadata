// Namespace: System.Xml
public class XmlDocumentFragment : XmlNode // TypeDefIndex: 1695
{
	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string InnerXml { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }

	// Methods

	// RVA: 0x32E8330 Offset: 0x32E8431 VA: 0x32E8330
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x32E83D0 Offset: 0x32E84D1 VA: 0x32E83D0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x32E8400 Offset: 0x32E8501 VA: 0x32E8400 Slot: 31
	public override string get_LocalName() { }

	// RVA: 0x32E8430 Offset: 0x32E8531 VA: 0x32E8430 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32E8440 Offset: 0x32E8541 VA: 0x32E8440 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x32E8450 Offset: 0x32E8551 VA: 0x32E8450 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x32E84D0 Offset: 0x32E85D1 VA: 0x32E84D0 Slot: 35
	public override void set_InnerXml(string value) { }

	// RVA: 0x32E8750 Offset: 0x32E8851 VA: 0x32E8750 Slot: 27
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x32E87D0 Offset: 0x32E88D1 VA: 0x32E87D0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x32E87E0 Offset: 0x32E88E1 VA: 0x32E87E0 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x32E87F0 Offset: 0x32E88F1 VA: 0x32E87F0 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x32E8800 Offset: 0x32E8901 VA: 0x32E8800 Slot: 24
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x32E8880 Offset: 0x32E8981 VA: 0x32E8880 Slot: 25
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }
}

