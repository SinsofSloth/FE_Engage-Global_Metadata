// Namespace: System.Xml.Schema
internal sealed class XdrValidator : BaseValidator // TypeDefIndex: 1956
{
	// Fields
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool isProcessContents; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1A8BB60 Offset: 0x1A8BC61 VA: 0x1A8BB60
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x1A8BE00 Offset: 0x1A8BF01 VA: 0x1A8BE00
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1A8BC00 Offset: 0x1A8BD01 VA: 0x1A8BC00
	private void Init() { }

	// RVA: 0x1A8BFC0 Offset: 0x1A8C0C1 VA: 0x1A8BFC0 Slot: 5
	public override void Validate() { }

	// RVA: 0x1A8C280 Offset: 0x1A8C381 VA: 0x1A8C280
	private void ValidateElement() { }

	// RVA: 0x1A8C640 Offset: 0x1A8C741 VA: 0x1A8C640
	private void ValidateChildElement() { }

	// RVA: 0x1A8C090 Offset: 0x1A8C191 VA: 0x1A8C090
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1A8C0A0 Offset: 0x1A8C1A1 VA: 0x1A8C0A0
	private void ProcessInlineSchema() { }

	// RVA: 0x1A8C780 Offset: 0x1A8C881 VA: 0x1A8C780
	private void ProcessElement() { }

	// RVA: 0x1A8C400 Offset: 0x1A8C501 VA: 0x1A8C400
	private void ValidateEndElement() { }

	// RVA: 0x1A8C820 Offset: 0x1A8C921 VA: 0x1A8C820
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x1A8CAF0 Offset: 0x1A8CBF1 VA: 0x1A8CAF0
	private void ValidateStartElement() { }

	// RVA: 0x1A8CE90 Offset: 0x1A8CF91 VA: 0x1A8CE90
	private void ValidateEndStartElement() { }

	// RVA: 0x1A8DA30 Offset: 0x1A8DB31 VA: 0x1A8DA30
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x1A8D810 Offset: 0x1A8D911 VA: 0x1A8D810
	private void LoadSchema(string uri) { }

	// RVA: 0x1A8E080 Offset: 0x1A8E181 VA: 0x1A8E080
	private bool get_HasSchema() { }

	// RVA: 0x1A8E0A0 Offset: 0x1A8E1A1 VA: 0x1A8E0A0 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1A8E0C0 Offset: 0x1A8E1C1 VA: 0x1A8E0C0
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1A8E3C0 Offset: 0x1A8E4C1 VA: 0x1A8E3C0 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1A8D1C0 Offset: 0x1A8D2C1 VA: 0x1A8D1C0
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1A8E5C0 Offset: 0x1A8E6C1 VA: 0x1A8E5C0
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x1A8E320 Offset: 0x1A8E421 VA: 0x1A8E320
	internal void AddID(string name, object node) { }

	// RVA: 0x1A8EA20 Offset: 0x1A8EB21 VA: 0x1A8EA20 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1A8BEB0 Offset: 0x1A8BFB1 VA: 0x1A8BEB0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1A8D770 Offset: 0x1A8D871 VA: 0x1A8D770
	private void Pop() { }

	// RVA: 0x1A8E490 Offset: 0x1A8E591 VA: 0x1A8E490
	private void CheckForwardRefs() { }

	// RVA: 0x1A8D980 Offset: 0x1A8DA81 VA: 0x1A8D980
	private XmlQualifiedName QualifiedName(string name, string ns) { }
}

