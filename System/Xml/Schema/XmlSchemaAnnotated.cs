// Namespace: System.Xml.Schema
public class XmlSchemaAnnotated : XmlSchemaObject // TypeDefIndex: 1962
{
	// Fields
	private string id; // 0x38
	private XmlSchemaAnnotation annotation; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[XmlAttributeAttribute] // RVA: 0x482B0 Offset: 0x483B1 VA: 0x482B0
	public string Id { get; set; }
	[XmlElementAttribute] // RVA: 0x48310 Offset: 0x48411 VA: 0x48310
	public XmlSchemaAnnotation Annotation { get; set; }
	[XmlAnyAttributeAttribute] // RVA: 0x48390 Offset: 0x48491 VA: 0x48390
	public XmlAttribute[] UnhandledAttributes { get; }
	[XmlIgnoreAttribute] // RVA: 0x483A0 Offset: 0x484A1 VA: 0x483A0
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x195E010 Offset: 0x195E111 VA: 0x195E010
	public string get_Id() { }

	// RVA: 0x195E020 Offset: 0x195E121 VA: 0x195E020
	public void set_Id(string value) { }

	// RVA: 0x195E030 Offset: 0x195E131 VA: 0x195E030
	public XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x195E040 Offset: 0x195E141 VA: 0x195E040
	public void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x195E050 Offset: 0x195E151 VA: 0x195E050
	public XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x195E060 Offset: 0x195E161 VA: 0x195E060 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x195E070 Offset: 0x195E171 VA: 0x195E070 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x195E080 Offset: 0x195E181 VA: 0x195E080 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x195E090 Offset: 0x195E191 VA: 0x195E090 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x195E0A0 Offset: 0x195E1A1 VA: 0x195E0A0
	public void .ctor() { }
}

