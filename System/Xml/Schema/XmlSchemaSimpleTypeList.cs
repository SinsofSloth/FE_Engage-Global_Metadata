// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent // TypeDefIndex: 2036
{
	// Fields
	private XmlQualifiedName itemTypeName; // 0x50
	private XmlSchemaSimpleType itemType; // 0x58
	private XmlSchemaSimpleType baseItemType; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x4B600 Offset: 0x4B701 VA: 0x4B600
	public XmlQualifiedName ItemTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x4B640 Offset: 0x4B741 VA: 0x4B640
	public XmlSchemaSimpleType ItemType { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4B6C0 Offset: 0x4B7C1 VA: 0x4B6C0
	public XmlSchemaSimpleType BaseItemType { get; set; }

	// Methods

	// RVA: 0x1971690 Offset: 0x1971791 VA: 0x1971690
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0x19716A0 Offset: 0x19717A1 VA: 0x19716A0
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x1971750 Offset: 0x1971851 VA: 0x1971750
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x1971760 Offset: 0x1971861 VA: 0x1971760
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x1971770 Offset: 0x1971871 VA: 0x1971770
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x1971780 Offset: 0x1971881 VA: 0x1971780
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x1971790 Offset: 0x1971891 VA: 0x1971790 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1971840 Offset: 0x1971941 VA: 0x1971840
	public void .ctor() { }
}

