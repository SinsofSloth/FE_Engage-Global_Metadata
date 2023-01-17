// Namespace: System.Xml.Schema
public class XmlSchemaAppInfo : XmlSchemaObject // TypeDefIndex: 1966
{
	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Properties
	[XmlAttributeAttribute] // RVA: 0x48700 Offset: 0x48801 VA: 0x48700
	public string Source { set; }
	[XmlTextAttribute] // RVA: 0x48760 Offset: 0x48861 VA: 0x48760
	[XmlAnyElementAttribute] // RVA: 0x48760 Offset: 0x48861 VA: 0x48760
	public XmlNode[] Markup { set; }

	// Methods

	// RVA: 0x195ECF0 Offset: 0x195EDF1 VA: 0x195ECF0
	public void set_Source(string value) { }

	// RVA: 0x195ED00 Offset: 0x195EE01 VA: 0x195ED00
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x195ED10 Offset: 0x195EE11 VA: 0x195ED10
	public void .ctor() { }
}

