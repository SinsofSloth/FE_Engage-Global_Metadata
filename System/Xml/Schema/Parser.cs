// Namespace: System.Xml.Schema
internal sealed class Parser // TypeDefIndex: 1919
{
	// Fields
	private SchemaType schemaType; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ValidationEventHandler eventHandler; // 0x28
	private XmlNamespaceManager namespaceManager; // 0x30
	private XmlReader reader; // 0x38
	private PositionInfo positionInfo; // 0x40
	private bool isProcessNamespaces; // 0x48
	private int schemaXmlDepth; // 0x4C
	private int markupDepth; // 0x50
	private SchemaBuilder builder; // 0x58
	private XmlSchema schema; // 0x60
	private SchemaInfo xdrSchema; // 0x68
	private XmlResolver xmlResolver; // 0x70
	private XmlDocument dummyDocument; // 0x78
	private bool processMarkup; // 0x80
	private XmlNode parentNode; // 0x88
	private XmlNamespaceManager annotationNSManager; // 0x90
	private string xmlns; // 0x98
	private XmlCharType xmlCharType; // 0xA0

	// Properties
	public XmlSchema XmlSchema { get; }
	internal XmlResolver XmlResolver { set; }
	public SchemaInfo XdrSchema { get; }

	// Methods

	// RVA: 0x3244670 Offset: 0x3244771 VA: 0x3244670
	public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x3244780 Offset: 0x3244881 VA: 0x3244780
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0x32447D0 Offset: 0x32448D1 VA: 0x32447D0
	public void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0x3245290 Offset: 0x3245391 VA: 0x3245290
	private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	// RVA: 0x32453D0 Offset: 0x32454D1 VA: 0x32453D0
	public SchemaType FinishParsing() { }

	// RVA: 0x32453E0 Offset: 0x32454E1 VA: 0x32453E0
	public XmlSchema get_XmlSchema() { }

	// RVA: 0x32453F0 Offset: 0x32454F1 VA: 0x32453F0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x3245400 Offset: 0x3245501 VA: 0x3245400
	public SchemaInfo get_XdrSchema() { }

	// RVA: 0x3244BE0 Offset: 0x3244CE1 VA: 0x3244BE0
	public bool ParseReaderNode() { }

	// RVA: 0x3245410 Offset: 0x3245511 VA: 0x3245410
	private void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0x3245610 Offset: 0x3245711 VA: 0x3245610
	private XmlElement LoadElementNode(bool root) { }

	// RVA: 0x3245B30 Offset: 0x3245C31 VA: 0x3245B30
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0x32459D0 Offset: 0x3245AD1 VA: 0x32459D0
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x3245C40 Offset: 0x3245D41 VA: 0x3245C40
	private XmlEntityReference LoadEntityReferenceInAttribute() { }
}

