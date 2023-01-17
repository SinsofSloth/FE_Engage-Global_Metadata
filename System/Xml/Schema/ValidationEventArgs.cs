// Namespace: System.Xml.Schema
public class ValidationEventArgs : EventArgs // TypeDefIndex: 1941
{
	// Fields
	private XmlSchemaException ex; // 0x10
	private XmlSeverityType severity; // 0x18

	// Properties
	public XmlSeverityType Severity { get; }
	public XmlSchemaException Exception { get; }

	// Methods

	// RVA: 0x19B02E0 Offset: 0x19B03E1 VA: 0x19B02E0
	internal void .ctor(XmlSchemaException ex) { }

	// RVA: 0x19BC370 Offset: 0x19BC471 VA: 0x19BC370
	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x19BC410 Offset: 0x19BC511 VA: 0x19BC410
	public XmlSeverityType get_Severity() { }

	// RVA: 0x19BC420 Offset: 0x19BC521 VA: 0x19BC420
	public XmlSchemaException get_Exception() { }
}

