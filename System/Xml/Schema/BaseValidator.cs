// Namespace: System.Xml.Schema
internal class BaseValidator // TypeDefIndex: 1797
{
	// Fields
	private XmlSchemaCollection schemaCollection; // 0x10
	private IValidationEventHandling eventHandling; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaNames schemaNames; // 0x28
	private PositionInfo positionInfo; // 0x30
	private XmlResolver xmlResolver; // 0x38
	private Uri baseUri; // 0x40
	protected SchemaInfo schemaInfo; // 0x48
	protected XmlValidatingReaderImpl reader; // 0x50
	protected XmlQualifiedName elementName; // 0x58
	protected ValidationState context; // 0x60
	protected StringBuilder textValue; // 0x68
	protected string textString; // 0x70
	protected bool hasSibling; // 0x78
	protected bool checkDatatype; // 0x79

	// Properties
	public XmlValidatingReaderImpl Reader { get; }
	public XmlSchemaCollection SchemaCollection { get; }
	public XmlNameTable NameTable { get; }
	public SchemaNames SchemaNames { get; }
	public PositionInfo PositionInfo { get; }
	public XmlResolver XmlResolver { get; set; }
	public Uri BaseUri { get; set; }
	public ValidationEventHandler EventHandler { get; }
	public SchemaInfo SchemaInfo { get; }
	public IDtdInfo DtdInfo { set; }
	public virtual bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1A25010 Offset: 0x1A25111 VA: 0x1A25010
	public void .ctor(BaseValidator other) { }

	// RVA: 0x1A22DD0 Offset: 0x1A22ED1 VA: 0x1A22DD0
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1A250D0 Offset: 0x1A251D1 VA: 0x1A250D0
	public XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x1A250E0 Offset: 0x1A251E1 VA: 0x1A250E0
	public XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x1A250F0 Offset: 0x1A251F1 VA: 0x1A250F0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1A232D0 Offset: 0x1A233D1 VA: 0x1A232D0
	public SchemaNames get_SchemaNames() { }

	// RVA: 0x1A25100 Offset: 0x1A25201 VA: 0x1A25100
	public PositionInfo get_PositionInfo() { }

	// RVA: 0x1A25110 Offset: 0x1A25211 VA: 0x1A25110
	public XmlResolver get_XmlResolver() { }

	// RVA: 0x1A25120 Offset: 0x1A25221 VA: 0x1A25120
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1A25130 Offset: 0x1A25231 VA: 0x1A25130
	public Uri get_BaseUri() { }

	// RVA: 0x1A25140 Offset: 0x1A25241 VA: 0x1A25140
	public void set_BaseUri(Uri value) { }

	// RVA: 0x1A25150 Offset: 0x1A25251 VA: 0x1A25150
	public ValidationEventHandler get_EventHandler() { }

	// RVA: 0x1A25240 Offset: 0x1A25341 VA: 0x1A25240
	public SchemaInfo get_SchemaInfo() { }

	// RVA: 0x1A25250 Offset: 0x1A25351 VA: 0x1A25250
	public void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x1A25340 Offset: 0x1A25441 VA: 0x1A25340 Slot: 4
	public virtual bool get_PreserveWhitespace() { }

	// RVA: 0x1A25350 Offset: 0x1A25451 VA: 0x1A25350 Slot: 5
	public virtual void Validate() { }

	// RVA: 0x1A25360 Offset: 0x1A25461 VA: 0x1A25360 Slot: 6
	public virtual void CompleteValidation() { }

	// RVA: 0x1A25370 Offset: 0x1A25471 VA: 0x1A25370 Slot: 7
	public virtual object FindId(string name) { }

	// RVA: 0x1A25380 Offset: 0x1A25481 VA: 0x1A25380
	public void ValidateText() { }

	// RVA: 0x1A258E0 Offset: 0x1A259E1 VA: 0x1A258E0
	public void ValidateWhitespace() { }

	// RVA: 0x1A25870 Offset: 0x1A25971 VA: 0x1A25870
	private void SaveTextValue(string value) { }

	// RVA: 0x1A25A60 Offset: 0x1A25B61 VA: 0x1A25A60
	protected void SendValidationEvent(string code) { }

	// RVA: 0x1A25790 Offset: 0x1A25891 VA: 0x1A25790
	protected void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x1A256B0 Offset: 0x1A257B1 VA: 0x1A256B0
	protected void SendValidationEvent(string code, string arg) { }

	// RVA: 0x1A25AD0 Offset: 0x1A25BD1 VA: 0x1A25AD0
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1A25BD0 Offset: 0x1A25CD1 VA: 0x1A25BD0
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x1A25CB0 Offset: 0x1A25DB1 VA: 0x1A25CB0
	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x1A25AE0 Offset: 0x1A25BE1 VA: 0x1A25AE0
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1A25D90 Offset: 0x1A25E91 VA: 0x1A25D90
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0x1A25F50 Offset: 0x1A26051 VA: 0x1A25F50
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0x1A26140 Offset: 0x1A26241 VA: 0x1A26140
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }
}

