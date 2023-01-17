// Namespace: System.Xml
public class XmlEntityReference : XmlLinkedNode // TypeDefIndex: 1699
{
	// Fields
	private string name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override string BaseURI { get; }
	internal string ChildBaseURI { get; }

	// Methods

	// RVA: 0x32EB320 Offset: 0x32EB421 VA: 0x32EB320
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x32EB420 Offset: 0x32EB521 VA: 0x32EB420 Slot: 6
	public override string get_Name() { }

	// RVA: 0x32EB430 Offset: 0x32EB531 VA: 0x32EB430 Slot: 31
	public override string get_LocalName() { }

	// RVA: 0x32EB440 Offset: 0x32EB541 VA: 0x32EB440 Slot: 7
	public override string get_Value() { }

	// RVA: 0x32EB450 Offset: 0x32EB551 VA: 0x32EB450 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x32EB4B0 Offset: 0x32EB5B1 VA: 0x32EB4B0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32EB4C0 Offset: 0x32EB5C1 VA: 0x32EB4C0 Slot: 27
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x32EB500 Offset: 0x32EB601 VA: 0x32EB500 Slot: 32
	public override bool get_IsReadOnly() { }

	// RVA: 0x32EB510 Offset: 0x32EB611 VA: 0x32EB510 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x32EB520 Offset: 0x32EB621 VA: 0x32EB520 Slot: 38
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x32EBC10 Offset: 0x32EBD11 VA: 0x32EBC10 Slot: 39
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x32EBC20 Offset: 0x32EBD21 VA: 0x32EBC20 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x32EBC30 Offset: 0x32EBD31 VA: 0x32EBC30 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x32EBC40 Offset: 0x32EBD41 VA: 0x32EBC40 Slot: 24
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x32EBC70 Offset: 0x32EBD71 VA: 0x32EBC70 Slot: 36
	public override string get_BaseURI() { }

	// RVA: 0x32EBCA0 Offset: 0x32EBDA1 VA: 0x32EBCA0
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x32EBD80 Offset: 0x32EBE81 VA: 0x32EBD80
	internal string get_ChildBaseURI() { }
}

