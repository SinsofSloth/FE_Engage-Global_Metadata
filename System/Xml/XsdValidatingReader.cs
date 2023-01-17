// Namespace: System.Xml
internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1684
{
	// Fields
	private XmlReader coreReader; // 0x10
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x18
	private IXmlNamespaceResolver thisNSResolver; // 0x20
	private XmlSchemaValidator validator; // 0x28
	private XmlResolver xmlResolver; // 0x30
	private ValidationEventHandler validationEvent; // 0x38
	private XsdValidatingReader.ValidatingReaderState validationState; // 0x40
	private XmlValueGetter valueGetter; // 0x48
	private XmlNamespaceManager nsManager; // 0x50
	private bool manageNamespaces; // 0x58
	private bool processInlineSchema; // 0x59
	private bool replayCache; // 0x5A
	private ValidatingReaderNodeData cachedNode; // 0x60
	private AttributePSVIInfo attributePSVI; // 0x68
	private int attributeCount; // 0x70
	private int coreReaderAttributeCount; // 0x74
	private int currentAttrIndex; // 0x78
	private AttributePSVIInfo[] attributePSVINodes; // 0x80
	private ArrayList defaultAttributes; // 0x88
	private Parser inlineSchemaParser; // 0x90
	private object atomicValue; // 0x98
	private XmlSchemaInfo xmlSchemaInfo; // 0xA0
	private string originalAtomicValueString; // 0xA8
	private XmlNameTable coreReaderNameTable; // 0xB0
	private XsdCachingReader cachingReader; // 0xB8
	private ValidatingReaderNodeData textNode; // 0xC0
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsdSchema; // 0xF0
	private string XsiSchemaLocation; // 0xF8
	private string XsiNoNamespaceSchemaLocation; // 0x100
	private XmlCharType xmlCharType; // 0x108
	private IXmlLineInfo lineInfo; // 0x110
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x118
	private XsdValidatingReader.ValidatingReaderState savedState; // 0x120
	private static Type TypeOfString; // 0x0

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
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	private XmlSchemaInfo AttributeSchemaInfo { get; }

	// Methods

	// RVA: 0x19992A0 Offset: 0x19993A1 VA: 0x19992A0
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x1999A10 Offset: 0x1999B11 VA: 0x1999A10
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x1999490 Offset: 0x1999591 VA: 0x1999490
	private void Init() { }

	// RVA: 0x1999820 Offset: 0x1999921 VA: 0x1999820
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x1999A20 Offset: 0x1999B21 VA: 0x1999A20 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1999AE0 Offset: 0x1999BE1 VA: 0x1999AE0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1999B70 Offset: 0x1999C71 VA: 0x1999B70 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1999CB0 Offset: 0x1999DB1 VA: 0x1999CB0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1999CE0 Offset: 0x1999DE1 VA: 0x1999CE0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1999D10 Offset: 0x1999E11 VA: 0x1999D10 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1999D40 Offset: 0x1999E41 VA: 0x1999D40 Slot: 11
	public override string get_Value() { }

	// RVA: 0x1999D70 Offset: 0x1999E71 VA: 0x1999D70 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1999DA0 Offset: 0x1999EA1 VA: 0x1999DA0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1999DC0 Offset: 0x1999EC1 VA: 0x1999DC0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1999DE0 Offset: 0x1999EE1 VA: 0x1999DE0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1999E10 Offset: 0x1999F11 VA: 0x1999E10 Slot: 16
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1999E20 Offset: 0x1999F21 VA: 0x1999E20 Slot: 17
	public override int get_AttributeCount() { }

	// RVA: 0x1999E30 Offset: 0x1999F31 VA: 0x1999E30 Slot: 18
	public override string GetAttribute(string name) { }

	// RVA: 0x199A040 Offset: 0x199A141 VA: 0x199A040 Slot: 19
	public override string GetAttribute(int i) { }

	// RVA: 0x199A130 Offset: 0x199A231 VA: 0x199A130 Slot: 20
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x199A440 Offset: 0x199A541 VA: 0x199A440 Slot: 21
	public override void MoveToAttribute(int i) { }

	// RVA: 0x199A5F0 Offset: 0x199A6F1 VA: 0x199A5F0 Slot: 22
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x199A760 Offset: 0x199A861 VA: 0x199A760 Slot: 23
	public override bool MoveToNextAttribute() { }

	// RVA: 0x199A8D0 Offset: 0x199A9D1 VA: 0x199A8D0 Slot: 24
	public override bool MoveToElement() { }

	// RVA: 0x199A930 Offset: 0x199AA31 VA: 0x199A930 Slot: 26
	public override bool Read() { }

	// RVA: 0x199ADD0 Offset: 0x199AED1 VA: 0x199ADD0 Slot: 27
	public override bool get_EOF() { }

	// RVA: 0x199ADF0 Offset: 0x199AEF1 VA: 0x199ADF0 Slot: 28
	public override void Close() { }

	// RVA: 0x199AE30 Offset: 0x199AF31 VA: 0x199AE30 Slot: 29
	public override ReadState get_ReadState() { }

	// RVA: 0x199AE60 Offset: 0x199AF61 VA: 0x199AE60 Slot: 30
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x199AE70 Offset: 0x199AF71 VA: 0x199AE70 Slot: 31
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x199AF20 Offset: 0x199B021 VA: 0x199AF20 Slot: 33
	public override void ResolveEntity() { }

	// RVA: 0x199AF60 Offset: 0x199B061 VA: 0x199AF60 Slot: 25
	public override bool ReadAttributeValue() { }

	// RVA: 0x199B140 Offset: 0x199B241 VA: 0x199B140 Slot: 38
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x199B4A0 Offset: 0x199B5A1 VA: 0x199B4A0 Slot: 39
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x199B500 Offset: 0x199B601 VA: 0x199B500 Slot: 37
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x199B5B0 Offset: 0x199B6B1 VA: 0x199B5B0 Slot: 40
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x199B740 Offset: 0x199B841 VA: 0x199B740 Slot: 41
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x199B7C0 Offset: 0x199B8C1 VA: 0x199B7C0 Slot: 42
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x199B820 Offset: 0x199B921 VA: 0x199B820 Slot: 43
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x199B870 Offset: 0x199B971 VA: 0x199B870 Slot: 44
	public int get_LineNumber() { }

	// RVA: 0x199B920 Offset: 0x199BA21 VA: 0x199B920 Slot: 45
	public int get_LinePosition() { }

	// RVA: 0x199B9E0 Offset: 0x199BAE1 VA: 0x199B9E0 Slot: 46
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x199BAB0 Offset: 0x199BBB1 VA: 0x199BAB0 Slot: 47
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x199BB80 Offset: 0x199BC81 VA: 0x199BB80 Slot: 48
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x199BC50 Offset: 0x199BD51 VA: 0x199BC50
	private object GetStringValue() { }

	// RVA: 0x199B490 Offset: 0x199B591 VA: 0x199B490
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x199AAE0 Offset: 0x199ABE1 VA: 0x199AAE0
	private void ProcessReaderEvent() { }

	// RVA: 0x199BC60 Offset: 0x199BD61 VA: 0x199BC60
	private void ProcessElementEvent() { }

	// RVA: 0x199C0B0 Offset: 0x199C1B1 VA: 0x199C0B0
	private void ProcessEndElementEvent() { }

	// RVA: 0x199C290 Offset: 0x199C391 VA: 0x199C290
	private void ValidateAttributes() { }

	// RVA: 0x199AD80 Offset: 0x199AE81 VA: 0x199AD80
	private void ClearAttributesInfo() { }

	// RVA: 0x199A220 Offset: 0x199A321 VA: 0x199A220
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x199C730 Offset: 0x199C831 VA: 0x199C730
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x1999EB0 Offset: 0x1999FB1 VA: 0x1999EB0
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x199C7F0 Offset: 0x199C8F1 VA: 0x199C7F0
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x199C5D0 Offset: 0x199C6D1 VA: 0x199C5D0
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x199C240 Offset: 0x199C341 VA: 0x199C240
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x199ACA0 Offset: 0x199ADA1 VA: 0x199ACA0
	private void ProcessInlineSchema() { }

	// RVA: 0x199C950 Offset: 0x199CA51 VA: 0x199C950
	private void ReadAheadForMemberType() { }

	// RVA: 0x199B1D0 Offset: 0x199B2D1 VA: 0x199B1D0
	private void GetIsDefault() { }

	// RVA: 0x199B650 Offset: 0x199B751 VA: 0x199B650
	private void GetMemberType() { }

	// RVA: 0x199C4D0 Offset: 0x199C5D1 VA: 0x199C4D0
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x199B0A0 Offset: 0x199B1A1 VA: 0x199B0A0
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x199CBA0 Offset: 0x199CCA1 VA: 0x199CBA0
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x199C430 Offset: 0x199C531 VA: 0x199C430
	private string GetOriginalAtomicValueStringOfElement() { }
}

