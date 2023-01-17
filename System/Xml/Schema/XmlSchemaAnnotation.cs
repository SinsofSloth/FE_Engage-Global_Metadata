// Namespace: System.Xml.Schema
public class XmlSchemaAnnotation : XmlSchemaObject // TypeDefIndex: 1963
{
	// Fields
	private string id; // 0x38
	private XmlSchemaObjectCollection items; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[XmlAttributeAttribute] // RVA: 0x483B0 Offset: 0x484B1 VA: 0x483B0
	public string Id { get; set; }
	[XmlElementAttribute] // RVA: 0x48410 Offset: 0x48511 VA: 0x48410
	[XmlElementAttribute] // RVA: 0x48410 Offset: 0x48511 VA: 0x48410
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] // RVA: 0x484E0 Offset: 0x485E1 VA: 0x484E0
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x195E0C0 Offset: 0x195E1C1 VA: 0x195E0C0
	public string get_Id() { }

	// RVA: 0x195E0D0 Offset: 0x195E1D1 VA: 0x195E0D0
	public void set_Id(string value) { }

	// RVA: 0x195E0E0 Offset: 0x195E1E1 VA: 0x195E0E0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x195E0F0 Offset: 0x195E1F1 VA: 0x195E0F0 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x195E100 Offset: 0x195E201 VA: 0x195E100 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x195E110 Offset: 0x195E211 VA: 0x195E110 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x195E120 Offset: 0x195E221 VA: 0x195E120
	public void .ctor() { }
}

