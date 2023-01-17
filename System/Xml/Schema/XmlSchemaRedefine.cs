// Namespace: System.Xml.Schema
public class XmlSchemaRedefine : XmlSchemaExternal // TypeDefIndex: 2028
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x68
	private XmlSchemaObjectTable attributeGroups; // 0x70
	private XmlSchemaObjectTable types; // 0x78
	private XmlSchemaObjectTable groups; // 0x80

	// Properties
	[XmlElementAttribute] // RVA: 0x4A9B0 Offset: 0x4AAB1 VA: 0x4A9B0
	[XmlElementAttribute] // RVA: 0x4A9B0 Offset: 0x4AAB1 VA: 0x4A9B0
	[XmlElementAttribute] // RVA: 0x4A9B0 Offset: 0x4AAB1 VA: 0x4A9B0
	[XmlElementAttribute] // RVA: 0x4A9B0 Offset: 0x4AAB1 VA: 0x4A9B0
	[XmlElementAttribute] // RVA: 0x4A9B0 Offset: 0x4AAB1 VA: 0x4A9B0
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] // RVA: 0x4AB60 Offset: 0x4AC61 VA: 0x4AB60
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnoreAttribute] // RVA: 0x4AB70 Offset: 0x4AC71 VA: 0x4AB70
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnoreAttribute] // RVA: 0x4AB80 Offset: 0x4AC81 VA: 0x4AB80
	public XmlSchemaObjectTable Groups { get; }

	// Methods

	// RVA: 0x1968DD0 Offset: 0x1968ED1 VA: 0x1968DD0
	public void .ctor() { }

	// RVA: 0x1968ED0 Offset: 0x1968FD1 VA: 0x1968ED0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1968EE0 Offset: 0x1968FE1 VA: 0x1968EE0
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x1968EF0 Offset: 0x1968FF1 VA: 0x1968EF0
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x1968F00 Offset: 0x1969001 VA: 0x1968F00
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x1968F10 Offset: 0x1969011 VA: 0x1968F10 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}

