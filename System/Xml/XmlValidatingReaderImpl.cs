// Namespace: System.Xml
internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1678
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlTextReaderImpl coreReaderImpl; // 0x18
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x20
	private ValidationType validationType; // 0x28
	private BaseValidator validator; // 0x30
	private XmlSchemaCollection schemaCollection; // 0x38
	private bool processIdentityConstraints; // 0x40
	private XmlValidatingReaderImpl.ParsingFunction parsingFunction; // 0x44
	private XmlValidatingReaderImpl.ValidationEventHandling eventHandling; // 0x48
	private XmlParserContext parserContext; // 0x50
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x58
	private XmlReader outerReader; // 0x60
	private static XmlResolver s_tempResolver; // 0x0

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override int AttributeCount { get; }
	public override bool CanResolveEntity { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal ValidationType ValidationType { get; }
	internal XmlSchemaCollection Schemas { get; }
	internal BaseValidator Validator { get; set; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool StandAlone { get; }
	internal object SchemaTypeObject { set; }
	internal object TypedValueObject { get; set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x19F5620 Offset: 0x19F5721 VA: 0x19F5620
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x19F5C30 Offset: 0x19F5D31 VA: 0x19F5C30 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x19F5CF0 Offset: 0x19F5DF1 VA: 0x19F5CF0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x19F5D00 Offset: 0x19F5E01 VA: 0x19F5D00 Slot: 7
	public override string get_Name() { }

	// RVA: 0x19F5D10 Offset: 0x19F5E11 VA: 0x19F5D10 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x19F5D20 Offset: 0x19F5E21 VA: 0x19F5D20 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x19F5D30 Offset: 0x19F5E31 VA: 0x19F5D30 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x19F5D40 Offset: 0x19F5E41 VA: 0x19F5D40 Slot: 11
	public override string get_Value() { }

	// RVA: 0x19F5D50 Offset: 0x19F5E51 VA: 0x19F5D50 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x19F5D60 Offset: 0x19F5E61 VA: 0x19F5D60 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x19F5D80 Offset: 0x19F5E81 VA: 0x19F5D80 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x19F5DA0 Offset: 0x19F5EA1 VA: 0x19F5DA0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x19F5DC0 Offset: 0x19F5EC1 VA: 0x19F5DC0 Slot: 29
	public override ReadState get_ReadState() { }

	// RVA: 0x19F5DF0 Offset: 0x19F5EF1 VA: 0x19F5DF0 Slot: 27
	public override bool get_EOF() { }

	// RVA: 0x19F5E10 Offset: 0x19F5F11 VA: 0x19F5E10 Slot: 30
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x19F5E30 Offset: 0x19F5F31 VA: 0x19F5E30 Slot: 17
	public override int get_AttributeCount() { }

	// RVA: 0x19F5E50 Offset: 0x19F5F51 VA: 0x19F5E50 Slot: 18
	public override string GetAttribute(string name) { }

	// RVA: 0x19F5E70 Offset: 0x19F5F71 VA: 0x19F5E70 Slot: 19
	public override string GetAttribute(int i) { }

	// RVA: 0x19F5E90 Offset: 0x19F5F91 VA: 0x19F5E90 Slot: 20
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x19F5EE0 Offset: 0x19F5FE1 VA: 0x19F5EE0 Slot: 21
	public override void MoveToAttribute(int i) { }

	// RVA: 0x19F5F20 Offset: 0x19F6021 VA: 0x19F5F20 Slot: 22
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x19F5F70 Offset: 0x19F6071 VA: 0x19F5F70 Slot: 23
	public override bool MoveToNextAttribute() { }

	// RVA: 0x19F5FC0 Offset: 0x19F60C1 VA: 0x19F5FC0 Slot: 24
	public override bool MoveToElement() { }

	// RVA: 0x19F6010 Offset: 0x19F6111 VA: 0x19F6010 Slot: 26
	public override bool Read() { }

	// RVA: 0x19F64A0 Offset: 0x19F65A1 VA: 0x19F64A0 Slot: 28
	public override void Close() { }

	// RVA: 0x19F64E0 Offset: 0x19F65E1 VA: 0x19F64E0 Slot: 31
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x19F6500 Offset: 0x19F6601 VA: 0x19F6500 Slot: 25
	public override bool ReadAttributeValue() { }

	// RVA: 0x19F6570 Offset: 0x19F6671 VA: 0x19F6570 Slot: 32
	public override bool get_CanResolveEntity() { }

	// RVA: 0x19F6580 Offset: 0x19F6681 VA: 0x19F6580 Slot: 33
	public override void ResolveEntity() { }

	// RVA: 0x19F65B0 Offset: 0x19F66B1 VA: 0x19F65B0 Slot: 37
	public int get_LineNumber() { }

	// RVA: 0x19F6680 Offset: 0x19F6781 VA: 0x19F6680 Slot: 38
	public int get_LinePosition() { }

	// RVA: 0x19F6750 Offset: 0x19F6851 VA: 0x19F6750 Slot: 39
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x19F68B0 Offset: 0x19F69B1 VA: 0x19F68B0 Slot: 40
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x19F68C0 Offset: 0x19F69C1 VA: 0x19F68C0 Slot: 41
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x19F6800 Offset: 0x19F6901 VA: 0x19F6800
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x19F6970 Offset: 0x19F6A71 VA: 0x19F6970
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x19F6A20 Offset: 0x19F6B21 VA: 0x19F6A20
	internal ValidationType get_ValidationType() { }

	// RVA: 0x19F6A30 Offset: 0x19F6B31 VA: 0x19F6A30
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x19F6270 Offset: 0x19F6371 VA: 0x19F6270
	private void ParseDtdFromParserContext() { }

	// RVA: 0x19F6A40 Offset: 0x19F6B41 VA: 0x19F6A40
	private void ValidateDtd() { }

	// RVA: 0x19F6420 Offset: 0x19F6521 VA: 0x19F6420
	private void ResolveEntityInternally() { }

	// RVA: 0x19F5AE0 Offset: 0x19F5BE1 VA: 0x19F5AE0
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x19F59F0 Offset: 0x19F5AF1 VA: 0x19F59F0
	private XmlResolver GetResolver() { }

	// RVA: 0x19F6140 Offset: 0x19F6241 VA: 0x19F6140
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x19F6AC0 Offset: 0x19F6BC1 VA: 0x19F6AC0
	internal BaseValidator get_Validator() { }

	// RVA: 0x19F6AD0 Offset: 0x19F6BD1 VA: 0x19F6AD0
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x19F6AE0 Offset: 0x19F6BE1 VA: 0x19F6AE0 Slot: 35
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x19F6B00 Offset: 0x19F6C01 VA: 0x19F6B00
	internal bool get_StandAlone() { }

	// RVA: 0x19F6B10 Offset: 0x19F6C11 VA: 0x19F6B10
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x19F6B20 Offset: 0x19F6C21 VA: 0x19F6B20
	internal object get_TypedValueObject() { }

	// RVA: 0x19F6B30 Offset: 0x19F6C31 VA: 0x19F6B30
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x19F6B40 Offset: 0x19F6C41 VA: 0x19F6B40
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x19F6B50 Offset: 0x19F6C51 VA: 0x19F6B50 Slot: 36
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x19F6B70 Offset: 0x19F6C71 VA: 0x19F6B70
	internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }
}

