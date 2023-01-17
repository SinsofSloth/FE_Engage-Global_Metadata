// Namespace: System.Xml.Schema
internal sealed class SchemaNotation // TypeDefIndex: 1938
{
	// Fields
	private XmlQualifiedName name; // 0x10
	private string systemLiteral; // 0x18
	private string pubid; // 0x20

	// Properties
	internal XmlQualifiedName Name { get; }
	internal string SystemLiteral { get; set; }
	internal string Pubid { get; set; }

	// Methods

	// RVA: 0x19B5D10 Offset: 0x19B5E11 VA: 0x19B5D10
	internal void .ctor(XmlQualifiedName name) { }

	// RVA: 0x19B5D50 Offset: 0x19B5E51 VA: 0x19B5D50
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x19B5D60 Offset: 0x19B5E61 VA: 0x19B5D60
	internal string get_SystemLiteral() { }

	// RVA: 0x19B5D70 Offset: 0x19B5E71 VA: 0x19B5D70
	internal void set_SystemLiteral(string value) { }

	// RVA: 0x19B5D80 Offset: 0x19B5E81 VA: 0x19B5D80
	internal string get_Pubid() { }

	// RVA: 0x19B5D90 Offset: 0x19B5E91 VA: 0x19B5D90
	internal void set_Pubid(string value) { }
}

