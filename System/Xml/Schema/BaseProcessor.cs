// Namespace: System.Xml.Schema
internal class BaseProcessor // TypeDefIndex: 1796
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private ValidationEventHandler eventHandler; // 0x20
	private XmlSchemaCompilationSettings compilationSettings; // 0x28
	private int errorCount; // 0x30
	private string NsXml; // 0x38

	// Properties
	protected XmlNameTable NameTable { get; }
	protected SchemaNames SchemaNames { get; }
	protected ValidationEventHandler EventHandler { get; }
	protected XmlSchemaCompilationSettings CompilationSettings { get; }
	protected bool HasErrors { get; }

	// Methods

	// RVA: 0x1A23B10 Offset: 0x1A23C11 VA: 0x1A23B10
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1A23BA0 Offset: 0x1A23CA1 VA: 0x1A23BA0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1A23C80 Offset: 0x1A23D81 VA: 0x1A23C80
	protected XmlNameTable get_NameTable() { }

	// RVA: 0x1A23C90 Offset: 0x1A23D91 VA: 0x1A23C90
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x1A23D40 Offset: 0x1A23E41 VA: 0x1A23D40
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x1A23D50 Offset: 0x1A23E51 VA: 0x1A23D50
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x1A23D60 Offset: 0x1A23E61 VA: 0x1A23D60
	protected bool get_HasErrors() { }

	// RVA: 0x1A23D70 Offset: 0x1A23E71 VA: 0x1A23D70
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x1A24260 Offset: 0x1A24361 VA: 0x1A24260
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x1A244C0 Offset: 0x1A245C1 VA: 0x1A244C0
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x1A24390 Offset: 0x1A24491 VA: 0x1A24390
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x1A246E0 Offset: 0x1A247E1 VA: 0x1A246E0
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0x1A245E0 Offset: 0x1A246E1 VA: 0x1A245E0
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0x1A248B0 Offset: 0x1A249B1 VA: 0x1A248B0
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0x1A24A60 Offset: 0x1A24B61 VA: 0x1A24A60
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0x1A24BA0 Offset: 0x1A24CA1 VA: 0x1A24BA0
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1A24D70 Offset: 0x1A24E71 VA: 0x1A24D70
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x1A24E00 Offset: 0x1A24F01 VA: 0x1A24E00
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1A24EB0 Offset: 0x1A24FB1 VA: 0x1A24EB0
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x1A247E0 Offset: 0x1A248E1 VA: 0x1A247E0
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1A24F50 Offset: 0x1A25051 VA: 0x1A24F50
	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }
}

