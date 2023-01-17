// Namespace: System.Xml.Schema
public class XmlSchemaDocumentation : XmlSchemaObject // TypeDefIndex: 1985
{
	// Fields
	private string source; // 0x38
	private string language; // 0x40
	private XmlNode[] markup; // 0x48
	private static XmlSchemaSimpleType languageType; // 0x0

	// Properties
	[XmlAttributeAttribute] // RVA: 0x49A20 Offset: 0x49B21 VA: 0x49A20
	public string Source { set; }
	[XmlAttributeAttribute] // RVA: 0x49A80 Offset: 0x49B81 VA: 0x49A80
	public string Language { set; }
	[XmlTextAttribute] // RVA: 0x49AC0 Offset: 0x49BC1 VA: 0x49AC0
	[XmlAnyElementAttribute] // RVA: 0x49AC0 Offset: 0x49BC1 VA: 0x49AC0
	public XmlNode[] Markup { set; }

	// Methods

	// RVA: 0x1964CF0 Offset: 0x1964DF1 VA: 0x1964CF0
	public void set_Source(string value) { }

	// RVA: 0x1964D00 Offset: 0x1964E01 VA: 0x1964D00
	public void set_Language(string value) { }

	// RVA: 0x1964DD0 Offset: 0x1964ED1 VA: 0x1964DD0
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x1964DE0 Offset: 0x1964EE1 VA: 0x1964DE0
	public void .ctor() { }

	// RVA: 0x1964DF0 Offset: 0x1964EF1 VA: 0x1964DF0
	private static void .cctor() { }
}

