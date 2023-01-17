// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent // TypeDefIndex: 2038
{
	// Fields
	private XmlSchemaObjectCollection baseTypes; // 0x50
	private XmlQualifiedName[] memberTypes; // 0x58
	private XmlSchemaSimpleType[] baseMemberTypes; // 0x60

	// Properties
	[XmlElementAttribute] // RVA: 0x4BB40 Offset: 0x4BC41 VA: 0x4BB40
	public XmlSchemaObjectCollection BaseTypes { get; }
	[XmlAttributeAttribute] // RVA: 0x4BBC0 Offset: 0x4BCC1 VA: 0x4BBC0
	public XmlQualifiedName[] MemberTypes { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4BC00 Offset: 0x4BD01 VA: 0x4BC00
	public XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x1971B30 Offset: 0x1971C31 VA: 0x1971B30
	public XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x1971B40 Offset: 0x1971C41 VA: 0x1971B40
	public XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0x1971B50 Offset: 0x1971C51 VA: 0x1971B50
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x1971B60 Offset: 0x1971C61 VA: 0x1971B60
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x1971B70 Offset: 0x1971C71 VA: 0x1971B70
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0x1971B80 Offset: 0x1971C81 VA: 0x1971B80 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1971D20 Offset: 0x1971E21 VA: 0x1971D20
	public void .ctor() { }
}

