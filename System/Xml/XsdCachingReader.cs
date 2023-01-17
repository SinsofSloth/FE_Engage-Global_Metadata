// Namespace: System.Xml
[DefaultMemberAttribute] // RVA: 0x46D30 Offset: 0x46E31 VA: 0x46D30
internal class XsdCachingReader : XmlReader, IXmlLineInfo // TypeDefIndex: 1680
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlNameTable coreReaderNameTable; // 0x18
	private ValidatingReaderNodeData[] contentEvents; // 0x20
	private ValidatingReaderNodeData[] attributeEvents; // 0x28
	private ValidatingReaderNodeData cachedNode; // 0x30
	private XsdCachingReader.CachingReaderState cacheState; // 0x38
	private int contentIndex; // 0x3C
	private int attributeCount; // 0x40
	private bool returnOriginalStringValues; // 0x44
	private CachingEventHandler cacheHandler; // 0x48
	private int currentAttrIndex; // 0x50
	private int currentContentIndex; // 0x54
	private bool readAhead; // 0x58
	private IXmlLineInfo lineInfo; // 0x60
	private ValidatingReaderNodeData textNode; // 0x68

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
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x1A03B50 Offset: 0x1A03C51 VA: 0x1A03B50
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x1A03C60 Offset: 0x1A03D61 VA: 0x1A03C60
	private void Init() { }

	// RVA: 0x1A04090 Offset: 0x1A04191 VA: 0x1A04090
	internal void Reset(XmlReader reader) { }

	// RVA: 0x1A040C0 Offset: 0x1A041C1 VA: 0x1A040C0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1A040D0 Offset: 0x1A041D1 VA: 0x1A040D0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1A040E0 Offset: 0x1A041E1 VA: 0x1A040E0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1A04100 Offset: 0x1A04201 VA: 0x1A04100 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1A04110 Offset: 0x1A04211 VA: 0x1A04110 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1A04120 Offset: 0x1A04221 VA: 0x1A04120 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1A04130 Offset: 0x1A04231 VA: 0x1A04130 Slot: 11
	public override string get_Value() { }

	// RVA: 0x1A04150 Offset: 0x1A04251 VA: 0x1A04150 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1A04160 Offset: 0x1A04261 VA: 0x1A04160 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1A04180 Offset: 0x1A04281 VA: 0x1A04180 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1A04190 Offset: 0x1A04291 VA: 0x1A04190 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1A041A0 Offset: 0x1A042A1 VA: 0x1A041A0 Slot: 17
	public override int get_AttributeCount() { }

	// RVA: 0x1A041B0 Offset: 0x1A042B1 VA: 0x1A041B0 Slot: 18
	public override string GetAttribute(string name) { }

	// RVA: 0x1A04490 Offset: 0x1A04591 VA: 0x1A04490 Slot: 19
	public override string GetAttribute(int i) { }

	// RVA: 0x1A04530 Offset: 0x1A04631 VA: 0x1A04530 Slot: 20
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1A046A0 Offset: 0x1A047A1 VA: 0x1A046A0 Slot: 21
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1A04740 Offset: 0x1A04841 VA: 0x1A04740 Slot: 22
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1A04790 Offset: 0x1A04891 VA: 0x1A04790 Slot: 23
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1A04800 Offset: 0x1A04901 VA: 0x1A04800 Slot: 24
	public override bool MoveToElement() { }

	// RVA: 0x1A04860 Offset: 0x1A04961 VA: 0x1A04860 Slot: 26
	public override bool Read() { }

	// RVA: 0x1A04B10 Offset: 0x1A04C11 VA: 0x1A04B10
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x1A04B90 Offset: 0x1A04C91 VA: 0x1A04B90
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x1A04CC0 Offset: 0x1A04DC1 VA: 0x1A04CC0
	internal void RecordEndElementNode() { }

	// RVA: 0x1A04DD0 Offset: 0x1A04ED1 VA: 0x1A04DD0 Slot: 27
	public override bool get_EOF() { }

	// RVA: 0x1A04E00 Offset: 0x1A04F01 VA: 0x1A04E00 Slot: 28
	public override void Close() { }

	// RVA: 0x1A04E40 Offset: 0x1A04F41 VA: 0x1A04E40 Slot: 29
	public override ReadState get_ReadState() { }

	// RVA: 0x1A04E60 Offset: 0x1A04F61 VA: 0x1A04E60 Slot: 30
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1A04E70 Offset: 0x1A04F71 VA: 0x1A04E70 Slot: 31
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1A04E90 Offset: 0x1A04F91 VA: 0x1A04E90 Slot: 33
	public override void ResolveEntity() { }

	// RVA: 0x1A04ED0 Offset: 0x1A04FD1 VA: 0x1A04ED0 Slot: 25
	public override bool ReadAttributeValue() { }

	// RVA: 0x1A05050 Offset: 0x1A05151 VA: 0x1A05050 Slot: 37
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x1A05060 Offset: 0x1A05161 VA: 0x1A05060 Slot: 38
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x1A05070 Offset: 0x1A05171 VA: 0x1A05070
	internal void SetToReplayMode() { }

	// RVA: 0x1A05090 Offset: 0x1A05191 VA: 0x1A05090
	internal XmlReader GetCoreReader() { }

	// RVA: 0x1A050A0 Offset: 0x1A051A1 VA: 0x1A050A0
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x1A04B00 Offset: 0x1A04C01 VA: 0x1A04B00
	private void ClearAttributesInfo() { }

	// RVA: 0x1A050B0 Offset: 0x1A051B1 VA: 0x1A050B0
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x1A03DB0 Offset: 0x1A03EB1 VA: 0x1A03DB0
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x1A03F40 Offset: 0x1A04041 VA: 0x1A03F40
	private void RecordAttributes() { }

	// RVA: 0x1A04310 Offset: 0x1A04411 VA: 0x1A04310
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x1A043D0 Offset: 0x1A044D1 VA: 0x1A043D0
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x1A04FB0 Offset: 0x1A050B1 VA: 0x1A04FB0
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }
}

