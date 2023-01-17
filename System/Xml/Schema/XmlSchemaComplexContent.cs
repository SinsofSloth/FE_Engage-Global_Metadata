// Namespace: System.Xml.Schema
public class XmlSchemaComplexContent : XmlSchemaContentModel // TypeDefIndex: 1975
{
	// Fields
	private XmlSchemaContent content; // 0x50
	private bool isMixed; // 0x58
	private bool hasMixedAttribute; // 0x59

	// Properties
	[XmlAttributeAttribute] // RVA: 0x48E60 Offset: 0x48F61 VA: 0x48E60
	public bool IsMixed { get; set; }
	[XmlElementAttribute] // RVA: 0x48EA0 Offset: 0x48FA1 VA: 0x48EA0
	[XmlElementAttribute] // RVA: 0x48EA0 Offset: 0x48FA1 VA: 0x48EA0
	public override XmlSchemaContent Content { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x48F70 Offset: 0x49071 VA: 0x48F70
	internal bool HasMixedAttribute { get; }

	// Methods

	// RVA: 0x1960B50 Offset: 0x1960C51 VA: 0x1960B50
	public bool get_IsMixed() { }

	// RVA: 0x1960B60 Offset: 0x1960C61 VA: 0x1960B60
	public void set_IsMixed(bool value) { }

	// RVA: 0x1960B80 Offset: 0x1960C81 VA: 0x1960B80 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x1960B90 Offset: 0x1960C91 VA: 0x1960B90 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x1960BA0 Offset: 0x1960CA1 VA: 0x1960BA0
	internal bool get_HasMixedAttribute() { }

	// RVA: 0x1960BB0 Offset: 0x1960CB1 VA: 0x1960BB0
	public void .ctor() { }
}

