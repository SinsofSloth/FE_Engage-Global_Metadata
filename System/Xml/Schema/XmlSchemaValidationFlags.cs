// Namespace: System.Xml.Schema
[FlagsAttribute] // RVA: 0x47310 Offset: 0x47411 VA: 0x47310
public enum XmlSchemaValidationFlags // TypeDefIndex: 2045
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaValidationFlags None = 0;
	public const XmlSchemaValidationFlags ProcessInlineSchema = 1;
	public const XmlSchemaValidationFlags ProcessSchemaLocation = 2;
	public const XmlSchemaValidationFlags ReportValidationWarnings = 4;
	public const XmlSchemaValidationFlags ProcessIdentityConstraints = 8;
	public const XmlSchemaValidationFlags AllowXmlAttributes = 16;
}

