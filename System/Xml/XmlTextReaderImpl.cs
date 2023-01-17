// Namespace: System.Xml
internal class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1675
{
	// Fields
	private readonly bool useAsync; // 0x10
	private XmlTextReaderImpl.LaterInitParam laterInitParam; // 0x18
	private XmlCharType xmlCharType; // 0x20
	private XmlTextReaderImpl.ParsingState ps; // 0x28
	private XmlTextReaderImpl.ParsingFunction parsingFunction; // 0xA0
	private XmlTextReaderImpl.ParsingFunction nextParsingFunction; // 0xA4
	private XmlTextReaderImpl.ParsingFunction nextNextParsingFunction; // 0xA8
	private XmlTextReaderImpl.NodeData[] nodes; // 0xB0
	private XmlTextReaderImpl.NodeData curNode; // 0xB8
	private int index; // 0xC0
	private int curAttrIndex; // 0xC4
	private int attrCount; // 0xC8
	private int attrHashtable; // 0xCC
	private int attrDuplWalkCount; // 0xD0
	private bool attrNeedNamespaceLookup; // 0xD4
	private bool fullAttrCleanup; // 0xD5
	private XmlTextReaderImpl.NodeData[] attrDuplSortingArray; // 0xD8
	private XmlNameTable nameTable; // 0xE0
	private bool nameTableFromSettings; // 0xE8
	private XmlResolver xmlResolver; // 0xF0
	private string url; // 0xF8
	private bool normalize; // 0x100
	private bool supportNamespaces; // 0x101
	private WhitespaceHandling whitespaceHandling; // 0x104
	private DtdProcessing dtdProcessing; // 0x108
	private EntityHandling entityHandling; // 0x10C
	private bool ignorePIs; // 0x110
	private bool ignoreComments; // 0x111
	private bool checkCharacters; // 0x112
	private int lineNumberOffset; // 0x114
	private int linePositionOffset; // 0x118
	private bool closeInput; // 0x11C
	private long maxCharactersInDocument; // 0x120
	private long maxCharactersFromEntities; // 0x128
	private bool v1Compat; // 0x130
	private XmlNamespaceManager namespaceManager; // 0x138
	private string lastPrefix; // 0x140
	private XmlTextReaderImpl.XmlContext xmlContext; // 0x148
	private XmlTextReaderImpl.ParsingState[] parsingStatesStack; // 0x150
	private int parsingStatesStackTop; // 0x158
	private string reportedBaseUri; // 0x160
	private Encoding reportedEncoding; // 0x168
	private IDtdInfo dtdInfo; // 0x170
	private XmlNodeType fragmentType; // 0x178
	private XmlParserContext fragmentParserContext; // 0x180
	private bool fragment; // 0x188
	private IncrementalReadDecoder incReadDecoder; // 0x190
	private XmlTextReaderImpl.IncrementalReadState incReadState; // 0x198
	private LineInfo incReadLineInfo; // 0x19C
	private int incReadDepth; // 0x1A4
	private int incReadLeftStartPos; // 0x1A8
	private int incReadLeftEndPos; // 0x1AC
	private int attributeValueBaseEntityId; // 0x1B0
	private bool emptyEntityInAttributeResolved; // 0x1B4
	private IValidationEventHandling validationEventHandling; // 0x1B8
	private XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse; // 0x1C0
	private bool validatingReaderCompatFlag; // 0x1C8
	private bool addDefaultAttributesAndNormalize; // 0x1C9
	private StringBuilder stringBuilder; // 0x1D0
	private bool rootElementParsed; // 0x1D8
	private bool standalone; // 0x1D9
	private int nextEntityId; // 0x1DC
	private XmlTextReaderImpl.ParsingMode parsingMode; // 0x1E0
	private ReadState readState; // 0x1E4
	private IDtdEntityInfo lastEntity; // 0x1E8
	private bool afterResetState; // 0x1F0
	private int documentStartBytePos; // 0x1F4
	private int readValueOffset; // 0x1F8
	private long charactersInDocument; // 0x200
	private long charactersFromEntities; // 0x208
	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities; // 0x210
	private bool disableUndeclaredEntityCheck; // 0x218
	private XmlReader outerReader; // 0x220
	private bool xmlResolverIsSet; // 0x228
	private string Xml; // 0x230
	private string XmlNs; // 0x238
	private Task<Tuple<int, int, int, bool>> parseText_dummyTask; // 0x240

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
	public override bool CanResolveEntity { get; }
	public override int AttributeCount { get; }
	internal XmlReader OuterReader { set; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal bool Namespaces { set; }
	internal EntityHandling EntityHandling { set; }
	internal bool IsResolverSet { get; }
	internal XmlResolver XmlResolver { set; }
	internal XmlNameTable DtdParserProxy_NameTable { get; }
	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver { get; }
	internal bool DtdParserProxy_DtdValidation { get; }
	internal bool DtdParserProxy_Normalization { get; }
	internal bool DtdParserProxy_Namespaces { get; }
	internal bool DtdParserProxy_V1CompatibilityMode { get; }
	internal Uri DtdParserProxy_BaseUri { get; }
	internal bool DtdParserProxy_IsEof { get; }
	internal char[] DtdParserProxy_ParsingBuffer { get; }
	internal int DtdParserProxy_ParsingBufferLength { get; }
	internal int DtdParserProxy_CurrentPosition { get; set; }
	internal int DtdParserProxy_EntityStackLength { get; }
	internal bool DtdParserProxy_IsEntityEolNormalized { get; }
	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling { get; }
	internal int DtdParserProxy_LineNo { get; }
	internal int DtdParserProxy_LineStartPosition { get; }
	private bool IsResolverNull { get; }
	private bool InAttributeValueIterator { get; }
	private bool DtdValidation { get; }
	private bool InEntity { get; }
	internal override IDtdInfo DtdInfo { get; }
	internal IValidationEventHandling ValidationEventHandling { set; }
	internal XmlTextReaderImpl.OnDefaultAttributeUseDelegate OnDefaultAttributeUse { set; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal XmlNodeType FragmentType { get; }
	internal object InternalSchemaType { set; }
	internal object InternalTypedValue { get; set; }
	internal bool StandAlone { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool V1Compat { get; }
	internal bool DisableUndeclaredEntityCheck { set; }

	// Methods

	// RVA: 0x1BAC580 Offset: 0x1BAC681 VA: 0x1BAC580
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0x1BAC9C0 Offset: 0x1BACAC1 VA: 0x1BAC9C0
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0x1BABB20 Offset: 0x1BABC21 VA: 0x1BABB20
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x1BABD50 Offset: 0x1BABE51 VA: 0x1BABD50
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x1BAD210 Offset: 0x1BAD311 VA: 0x1BAD210
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0x1BAD310 Offset: 0x1BAD411 VA: 0x1BAD310
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0x1BAD7E0 Offset: 0x1BAD8E1 VA: 0x1BAD7E0
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0x1BAD940 Offset: 0x1BADA41 VA: 0x1BAD940
	private void FinishInitUriString() { }

	// RVA: 0x1BADFE0 Offset: 0x1BAE0E1 VA: 0x1BADFE0
	internal void .ctor(Stream stream, byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0x1BAE300 Offset: 0x1BAE401 VA: 0x1BAE300
	private void FinishInitStream() { }

	// RVA: 0x1BAE3E0 Offset: 0x1BAE4E1 VA: 0x1BAE3E0
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0x1BAE500 Offset: 0x1BAE601 VA: 0x1BAE500
	private void FinishInitTextReader() { }

	// RVA: 0x1BAE5C0 Offset: 0x1BAE6C1 VA: 0x1BAE5C0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1BAE720 Offset: 0x1BAE821 VA: 0x1BAE720 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1BAE730 Offset: 0x1BAE831 VA: 0x1BAE730 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1BAE750 Offset: 0x1BAE851 VA: 0x1BAE750 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1BAE760 Offset: 0x1BAE861 VA: 0x1BAE760 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1BAE770 Offset: 0x1BAE871 VA: 0x1BAE770 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1BAE780 Offset: 0x1BAE881 VA: 0x1BAE780 Slot: 11
	public override string get_Value() { }

	// RVA: 0x1BAE990 Offset: 0x1BAEA91 VA: 0x1BAE990 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1BAE9A0 Offset: 0x1BAEAA1 VA: 0x1BAE9A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1BAE9B0 Offset: 0x1BAEAB1 VA: 0x1BAE9B0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1BAE9C0 Offset: 0x1BAEAC1 VA: 0x1BAE9C0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1BAE9D0 Offset: 0x1BAEAD1 VA: 0x1BAE9D0 Slot: 29
	public override ReadState get_ReadState() { }

	// RVA: 0x1BAE9E0 Offset: 0x1BAEAE1 VA: 0x1BAE9E0 Slot: 27
	public override bool get_EOF() { }

	// RVA: 0x1BAE9F0 Offset: 0x1BAEAF1 VA: 0x1BAE9F0 Slot: 30
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1BAEA00 Offset: 0x1BAEB01 VA: 0x1BAEA00 Slot: 32
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1BAEA10 Offset: 0x1BAEB11 VA: 0x1BAEA10 Slot: 17
	public override int get_AttributeCount() { }

	// RVA: 0x1BAEA20 Offset: 0x1BAEB21 VA: 0x1BAEA20 Slot: 18
	public override string GetAttribute(string name) { }

	// RVA: 0x1BAED20 Offset: 0x1BAEE21 VA: 0x1BAED20 Slot: 19
	public override string GetAttribute(int i) { }

	// RVA: 0x1BAEDD0 Offset: 0x1BAEED1 VA: 0x1BAEDD0 Slot: 20
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1BAF0D0 Offset: 0x1BAF1D1 VA: 0x1BAF0D0 Slot: 21
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1BAF240 Offset: 0x1BAF341 VA: 0x1BAF240 Slot: 22
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1BAF370 Offset: 0x1BAF471 VA: 0x1BAF370 Slot: 23
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1BAF4B0 Offset: 0x1BAF5B1 VA: 0x1BAF4B0 Slot: 24
	public override bool MoveToElement() { }

	// RVA: 0x1BAF5F0 Offset: 0x1BAF6F1 VA: 0x1BAF5F0
	private void FinishInit() { }

	// RVA: 0x1BAF620 Offset: 0x1BAF721 VA: 0x1BAF620 Slot: 26
	public override bool Read() { }

	// RVA: 0x1BB20B0 Offset: 0x1BB21B1 VA: 0x1BB20B0 Slot: 28
	public override void Close() { }

	// RVA: 0x1BB2220 Offset: 0x1BB2321 VA: 0x1BB2220 Slot: 31
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1BB2250 Offset: 0x1BB2351 VA: 0x1BB2250 Slot: 25
	public override bool ReadAttributeValue() { }

	// RVA: 0x1BB2A30 Offset: 0x1BB2B31 VA: 0x1BB2A30 Slot: 33
	public override void ResolveEntity() { }

	// RVA: 0x1BB3150 Offset: 0x1BB3251 VA: 0x1BB3150
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0x1BAC0E0 Offset: 0x1BAC1E1 VA: 0x1BAC0E0 Slot: 37
	public int get_LineNumber() { }

	// RVA: 0x1BAC100 Offset: 0x1BAC201 VA: 0x1BAC100 Slot: 38
	public int get_LinePosition() { }

	// RVA: 0x1BB3160 Offset: 0x1BB3261 VA: 0x1BB3160 Slot: 39
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1BB3180 Offset: 0x1BB3281 VA: 0x1BB3180 Slot: 40
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1BB3190 Offset: 0x1BB3291 VA: 0x1BB3190 Slot: 41
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1BAC130 Offset: 0x1BAC231 VA: 0x1BAC130
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1BAC190 Offset: 0x1BAC291 VA: 0x1BAC190
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x1BB31B0 Offset: 0x1BB32B1 VA: 0x1BB31B0
	internal void set_Namespaces(bool value) { }

	// RVA: 0x1BAC1C0 Offset: 0x1BAC2C1 VA: 0x1BAC1C0
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x1BB33A0 Offset: 0x1BB34A1 VA: 0x1BB33A0
	internal bool get_IsResolverSet() { }

	// RVA: 0x1BAC2F0 Offset: 0x1BAC3F1 VA: 0x1BAC2F0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1BB33B0 Offset: 0x1BB34B1 VA: 0x1BB33B0
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0x1BB33C0 Offset: 0x1BB34C1 VA: 0x1BB33C0
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0x1BB33D0 Offset: 0x1BB34D1 VA: 0x1BB33D0
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0x1BB33F0 Offset: 0x1BB34F1 VA: 0x1BB33F0
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0x1BB3400 Offset: 0x1BB3501 VA: 0x1BB3400
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0x1BB3410 Offset: 0x1BB3511 VA: 0x1BB3410
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0x1BB3420 Offset: 0x1BB3521 VA: 0x1BB3420
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x1BB34E0 Offset: 0x1BB35E1 VA: 0x1BB34E0
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x1BB34F0 Offset: 0x1BB35F1 VA: 0x1BB34F0
	internal char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x1BB3500 Offset: 0x1BB3601 VA: 0x1BB3500
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0x1BB3510 Offset: 0x1BB3611 VA: 0x1BB3510
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0x1BB3520 Offset: 0x1BB3621 VA: 0x1BB3520
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0x1BB3530 Offset: 0x1BB3631 VA: 0x1BB3530
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0x1BB3540 Offset: 0x1BB3641 VA: 0x1BB3540
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x1BB3550 Offset: 0x1BB3651 VA: 0x1BB3550
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0x1BB3560 Offset: 0x1BB3661 VA: 0x1BB3560
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x1BB35A0 Offset: 0x1BB36A1 VA: 0x1BB35A0
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0x1BB35B0 Offset: 0x1BB36B1 VA: 0x1BB35B0
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0x1BB35C0 Offset: 0x1BB36C1 VA: 0x1BB35C0
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0x1BB3A00 Offset: 0x1BB3B01 VA: 0x1BB3A00
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1BB3B50 Offset: 0x1BB3C51 VA: 0x1BB3B50
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1BB3C50 Offset: 0x1BB3D51 VA: 0x1BB3C50
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0x1BB4000 Offset: 0x1BB4101 VA: 0x1BB4000
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0x1BB4490 Offset: 0x1BB4591 VA: 0x1BB4490
	private bool get_IsResolverNull() { }

	// RVA: 0x1BB44F0 Offset: 0x1BB45F1 VA: 0x1BB44F0
	private XmlResolver GetTempResolver() { }

	// RVA: 0x1BB4570 Offset: 0x1BB4671 VA: 0x1BB4570
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x1BB4D50 Offset: 0x1BB4E51 VA: 0x1BB4D50
	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x1BB4EC0 Offset: 0x1BB4FC1 VA: 0x1BB4EC0
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1BB56C0 Offset: 0x1BB57C1 VA: 0x1BB56C0
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1BB59D0 Offset: 0x1BB5AD1 VA: 0x1BB59D0
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0x1BB5A70 Offset: 0x1BB5B71 VA: 0x1BB5A70
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1BB5C20 Offset: 0x1BB5D21 VA: 0x1BB5C20
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x1BB5D20 Offset: 0x1BB5E21 VA: 0x1BB5D20
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0x1BB5DE0 Offset: 0x1BB5EE1 VA: 0x1BB5DE0
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0x1BB5EA0 Offset: 0x1BB5FA1 VA: 0x1BB5EA0
	private void Throw(int pos, string res) { }

	// RVA: 0x1BAE2A0 Offset: 0x1BAE3A1 VA: 0x1BAE2A0
	private void Throw(string res) { }

	// RVA: 0x1BB5F10 Offset: 0x1BB6011 VA: 0x1BB5F10
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0x1BB5D40 Offset: 0x1BB5E41 VA: 0x1BB5D40
	private void Throw(string res, string arg) { }

	// RVA: 0x1BB5FC0 Offset: 0x1BB60C1 VA: 0x1BB5FC0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x1BB5E00 Offset: 0x1BB5F01 VA: 0x1BB5E00
	private void Throw(string res, string[] args) { }

	// RVA: 0x1BB6050 Offset: 0x1BB6151 VA: 0x1BB6050
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0x1BB60E0 Offset: 0x1BB61E1 VA: 0x1BB60E0
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0x1BB59E0 Offset: 0x1BB5AE1 VA: 0x1BB59E0
	private void Throw(Exception e) { }

	// RVA: 0x1BB61A0 Offset: 0x1BB62A1 VA: 0x1BB61A0
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0x1BB1E00 Offset: 0x1BB1F01 VA: 0x1BB1E00
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0x1BB6240 Offset: 0x1BB6341 VA: 0x1BB6240
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0x1BB62C0 Offset: 0x1BB63C1 VA: 0x1BB62C0
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0x1BB6350 Offset: 0x1BB6451 VA: 0x1BB6350
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x1BB6180 Offset: 0x1BB6281 VA: 0x1BB6180
	private void SetErrorState() { }

	// RVA: 0x1BB4340 Offset: 0x1BB4441 VA: 0x1BB4340
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0x1BB63D0 Offset: 0x1BB64D1 VA: 0x1BB63D0
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0x1BAEFE0 Offset: 0x1BAF0E1 VA: 0x1BAEFE0
	private bool get_InAttributeValueIterator() { }

	// RVA: 0x1BAF010 Offset: 0x1BAF111 VA: 0x1BAF010
	private void FinishAttributeValueIterator() { }

	// RVA: 0x1BB33E0 Offset: 0x1BB34E1 VA: 0x1BB33E0
	private bool get_DtdValidation() { }

	// RVA: 0x1BAD170 Offset: 0x1BAD271 VA: 0x1BAD170
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0x1BAD1F0 Offset: 0x1BAD2F1 VA: 0x1BAD1F0
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1BB6600 Offset: 0x1BB6701 VA: 0x1BB6600
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0x1BB6660 Offset: 0x1BB6761 VA: 0x1BB6660
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1BADCA0 Offset: 0x1BADDA1 VA: 0x1BADCA0
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0x1BAD300 Offset: 0x1BAD401 VA: 0x1BAD300
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0x1BB6A30 Offset: 0x1BB6B31 VA: 0x1BB6A30
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0x1BAD440 Offset: 0x1BAD541 VA: 0x1BAD440
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0x1BAD550 Offset: 0x1BAD651 VA: 0x1BAD550
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0x1BADF70 Offset: 0x1BAE071 VA: 0x1BADF70
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0x1BB0690 Offset: 0x1BB0791 VA: 0x1BB0690
	private void OpenUrl() { }

	// RVA: 0x1BB6D80 Offset: 0x1BB6E81 VA: 0x1BB6D80
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0x1BB6670 Offset: 0x1BB6771 VA: 0x1BB6670
	private Encoding DetectEncoding() { }

	// RVA: 0x1BB68B0 Offset: 0x1BB69B1 VA: 0x1BB68B0
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0x1BB6ED0 Offset: 0x1BB6FD1 VA: 0x1BB6ED0
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0x1BB70F0 Offset: 0x1BB71F1 VA: 0x1BB70F0
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0x1BB7040 Offset: 0x1BB7141 VA: 0x1BB7040
	private void UnDecodeChars() { }

	// RVA: 0x1BB7430 Offset: 0x1BB7531 VA: 0x1BB7430
	private void SwitchEncodingToUTF8() { }

	// RVA: 0x1BB35D0 Offset: 0x1BB36D1 VA: 0x1BB35D0
	private int ReadData() { }

	// RVA: 0x1BB74D0 Offset: 0x1BB75D1 VA: 0x1BB74D0
	private int GetChars(int maxCharsCount) { }

	// RVA: 0x1BB75F0 Offset: 0x1BB76F1 VA: 0x1BB75F0
	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	// RVA: 0x1BB20C0 Offset: 0x1BB21C1 VA: 0x1BB20C0
	internal void Close(bool closeInput) { }

	// RVA: 0x1BB77F0 Offset: 0x1BB78F1 VA: 0x1BB77F0
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0x1BB08C0 Offset: 0x1BB09C1 VA: 0x1BB08C0
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0x1BB0100 Offset: 0x1BB0201 VA: 0x1BB0100
	private bool ParseDocumentContent() { }

	// RVA: 0x1BAFD70 Offset: 0x1BAFE71 VA: 0x1BAFD70
	private bool ParseElementContent() { }

	// RVA: 0x1BB9070 Offset: 0x1BB9171 VA: 0x1BB9070
	private void ThrowUnclosedElements() { }

	// RVA: 0x1BB7D60 Offset: 0x1BB7E61 VA: 0x1BB7D60
	private void ParseElement() { }

	// RVA: 0x1BB98D0 Offset: 0x1BB99D1 VA: 0x1BB98D0
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0x1BB8C60 Offset: 0x1BB8D61 VA: 0x1BB8C60
	private void ParseEndElement() { }

	// RVA: 0x1BBAB50 Offset: 0x1BBAC51 VA: 0x1BBAB50
	private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag) { }

	// RVA: 0x1BB9200 Offset: 0x1BB9301 VA: 0x1BB9200
	private void ParseAttributes() { }

	// RVA: 0x1BBA2B0 Offset: 0x1BBA3B1 VA: 0x1BBA2B0
	private void ElementNamespaceLookup() { }

	// RVA: 0x1BBAA10 Offset: 0x1BBAB11 VA: 0x1BBAA10
	private void AttributeNamespaceLookup() { }

	// RVA: 0x1BBBE50 Offset: 0x1BBBF51 VA: 0x1BBBE50
	private void AttributeDuplCheck() { }

	// RVA: 0x1BBB980 Offset: 0x1BBBA81 VA: 0x1BBB980
	private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1BBBB00 Offset: 0x1BBBC01 VA: 0x1BBBB00
	private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1BBBBC0 Offset: 0x1BBBCC1 VA: 0x1BBBBC0
	private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1BBAF90 Offset: 0x1BBB091 VA: 0x1BBAF90
	private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1BBC4D0 Offset: 0x1BBC5D1 VA: 0x1BBC4D0
	private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk) { }

	// RVA: 0x1BB85F0 Offset: 0x1BB86F1 VA: 0x1BB85F0
	private bool ParseText() { }

	// RVA: 0x1BBC690 Offset: 0x1BBC791 VA: 0x1BBC690
	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	// RVA: 0x1BAE7D0 Offset: 0x1BAE8D1 VA: 0x1BAE7D0
	private void FinishPartialValue() { }

	// RVA: 0x1BAE880 Offset: 0x1BAE981 VA: 0x1BAE880
	private void FinishOtherValueIterator() { }

	// RVA: 0x1BB1EA0 Offset: 0x1BB1FA1 VA: 0x1BB1EA0
	private void SkipPartialTextValue() { }

	// RVA: 0x1BB1EF0 Offset: 0x1BB1FF1 VA: 0x1BB1EF0
	private void FinishReadValueChunk() { }

	// RVA: 0x1BB1F10 Offset: 0x1BB2011 VA: 0x1BB1F10
	private void FinishReadContentAsBinary() { }

	// RVA: 0x1BB1FE0 Offset: 0x1BB20E1 VA: 0x1BB1FE0
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0x1BB8A00 Offset: 0x1BB8B01 VA: 0x1BB8A00
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0x1BB19A0 Offset: 0x1BB1AA1 VA: 0x1BB19A0
	private void ParseEntityReference() { }

	// RVA: 0x1BB8280 Offset: 0x1BB8381 VA: 0x1BB8280
	private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos) { }

	// RVA: 0x1BB2C80 Offset: 0x1BB2D81 VA: 0x1BB2C80
	private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0x1BB7420 Offset: 0x1BB7521 VA: 0x1BB7420
	private bool get_InEntity() { }

	// RVA: 0x1BB64A0 Offset: 0x1BB65A1 VA: 0x1BB64A0
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0x1BB1A20 Offset: 0x1BB1B21 VA: 0x1BB1A20
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0x1BBD070 Offset: 0x1BBD171 VA: 0x1BBD070
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0x1BB79C0 Offset: 0x1BB7AC1 VA: 0x1BB79C0
	private bool ParsePI() { }

	// RVA: 0x1BB3CA0 Offset: 0x1BB3DA1 VA: 0x1BB3CA0
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0x1BBD0F0 Offset: 0x1BBD1F1 VA: 0x1BBD0F0
	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	// RVA: 0x1BB79D0 Offset: 0x1BB7AD1 VA: 0x1BB79D0
	private bool ParseComment() { }

	// RVA: 0x1BB7A40 Offset: 0x1BB7B41 VA: 0x1BB7A40
	private void ParseCData() { }

	// RVA: 0x1BB41F0 Offset: 0x1BB42F1 VA: 0x1BB41F0
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0x1BBD4A0 Offset: 0x1BBD5A1 VA: 0x1BBD4A0
	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	// RVA: 0x1BB7A50 Offset: 0x1BB7B51 VA: 0x1BB7A50
	private bool ParseDoctypeDecl() { }

	// RVA: 0x1BBDA20 Offset: 0x1BBDB21 VA: 0x1BBDA20
	private void ParseDtd() { }

	// RVA: 0x1BBDD50 Offset: 0x1BBDE51 VA: 0x1BBDD50
	private void SkipDtd() { }

	// RVA: 0x1BBE120 Offset: 0x1BBE221 VA: 0x1BBE120
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0x1BBE1E0 Offset: 0x1BBE2E1 VA: 0x1BBE1E0
	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	// RVA: 0x1BB53A0 Offset: 0x1BB54A1 VA: 0x1BB53A0
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0x1BBCE80 Offset: 0x1BBCF81 VA: 0x1BBCE80
	private int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x1BB3AA0 Offset: 0x1BB3BA1 VA: 0x1BB3AA0
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x1BBE660 Offset: 0x1BBE761 VA: 0x1BBE660
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x1BB3BD0 Offset: 0x1BB3CD1 VA: 0x1BB3BD0
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1BBECF0 Offset: 0x1BBEDF1 VA: 0x1BBECF0
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1BB7820 Offset: 0x1BB7921 VA: 0x1BB7820
	private int ParseName() { }

	// RVA: 0x1BB91F0 Offset: 0x1BB92F1 VA: 0x1BB91F0
	private int ParseQName(out int colonPos) { }

	// RVA: 0x1BBEFE0 Offset: 0x1BBF0E1 VA: 0x1BBEFE0
	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	// RVA: 0x1BBF360 Offset: 0x1BBF461 VA: 0x1BBF360
	private bool ReadDataInName(ref int pos) { }

	// RVA: 0x1BBC540 Offset: 0x1BBC641 VA: 0x1BBC540
	private string ParseEntityName() { }

	// RVA: 0x1BB18F0 Offset: 0x1BB19F1 VA: 0x1BB18F0
	private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x1BBF3B0 Offset: 0x1BBF4B1 VA: 0x1BBF3B0
	private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x1BB5B70 Offset: 0x1BB5C71 VA: 0x1BB5B70
	private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0x1BBADE0 Offset: 0x1BBAEE1 VA: 0x1BBADE0
	private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0x1BBF500 Offset: 0x1BBF601 VA: 0x1BBF500
	private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x1BB1940 Offset: 0x1BB1A41 VA: 0x1BB1940
	private void PopElementContext() { }

	// RVA: 0x1BB3580 Offset: 0x1BB3681 VA: 0x1BB3580
	private void OnNewLine(int pos) { }

	// RVA: 0x1BB1D60 Offset: 0x1BB1E61 VA: 0x1BB1D60
	private void OnEof() { }

	// RVA: 0x1BBC1A0 Offset: 0x1BBC2A1 VA: 0x1BBC1A0
	private string LookupNamespace(XmlTextReaderImpl.NodeData node) { }

	// RVA: 0x1BBC2E0 Offset: 0x1BBC3E1 VA: 0x1BBC2E0
	private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1BB1840 Offset: 0x1BB1941 VA: 0x1BB1840
	private void ResetAttributes() { }

	// RVA: 0x1BBF6B0 Offset: 0x1BBF7B1 VA: 0x1BBF6B0
	private void FullAttributeCleanup() { }

	// RVA: 0x1BBC250 Offset: 0x1BBC351 VA: 0x1BBC250
	private void PushXmlContext() { }

	// RVA: 0x1BBF670 Offset: 0x1BBF771 VA: 0x1BBF670
	private void PopXmlContext() { }

	// RVA: 0x1BBD030 Offset: 0x1BBD131 VA: 0x1BBD030
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0x1BBCE30 Offset: 0x1BBCF31 VA: 0x1BBCE30
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0x1BB5020 Offset: 0x1BB5121 VA: 0x1BB5020
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0x1BBF750 Offset: 0x1BBF851 VA: 0x1BBF750
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0x1BB4690 Offset: 0x1BB4791 VA: 0x1BB4690
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1BB4A20 Offset: 0x1BB4B21 VA: 0x1BB4A20
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1BB4DD0 Offset: 0x1BB4ED1 VA: 0x1BB4DD0
	private void PopEntity() { }

	// RVA: 0x1BBF9B0 Offset: 0x1BBFAB1 VA: 0x1BBF9B0
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1BBFB80 Offset: 0x1BBFC81 VA: 0x1BBFB80
	private void UnregisterEntity() { }

	// RVA: 0x1BB5740 Offset: 0x1BB5841 VA: 0x1BB5740
	private void PushParsingState() { }

	// RVA: 0x1BB7770 Offset: 0x1BB7871 VA: 0x1BB7770
	private void PopParsingState() { }

	// RVA: 0x1BBFBE0 Offset: 0x1BBFCE1 VA: 0x1BBFBE0
	private int IncrementalRead() { }

	// RVA: 0x1BB1B90 Offset: 0x1BB1C91 VA: 0x1BB1B90
	private void FinishIncrementalRead() { }

	// RVA: 0x1BB1C20 Offset: 0x1BB1D21 VA: 0x1BB1C20
	private bool ParseFragmentAttribute() { }

	// RVA: 0x1BB2530 Offset: 0x1BB2631 VA: 0x1BB2530
	private bool ParseAttributeValueChunk() { }

	// RVA: 0x1BB1CB0 Offset: 0x1BB1DB1 VA: 0x1BB1CB0
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0x1BB7A30 Offset: 0x1BB7B31 VA: 0x1BB7A30
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x1BB7810 Offset: 0x1BB7911 VA: 0x1BB7810
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0x1BB7D50 Offset: 0x1BB7E51 VA: 0x1BB7D50
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x1BB7850 Offset: 0x1BB7951 VA: 0x1BB7850
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0x1BB7D40 Offset: 0x1BB7E41 VA: 0x1BB7D40
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0x1BC0520 Offset: 0x1BC0621 VA: 0x1BC0520
	private string ParseUnexpectedToken() { }

	// RVA: 0x1BBAD50 Offset: 0x1BBAE51 VA: 0x1BBAD50
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0x1BAEB40 Offset: 0x1BAEC41 VA: 0x1BAEB40
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0x1BAEC40 Offset: 0x1BAED41 VA: 0x1BAEC40
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0x1BBCEF0 Offset: 0x1BBCFF1 VA: 0x1BBCEF0
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0x1BB6B30 Offset: 0x1BB6C31 VA: 0x1BB6B30
	private void ParseDtdFromParserContext() { }

	// RVA: 0x1BBCF80 Offset: 0x1BBD081 VA: 0x1BBCF80
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0x1BACF20 Offset: 0x1BAD021 VA: 0x1BACF20
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x1BC0600 Offset: 0x1BC0701 VA: 0x1BC0600 Slot: 36
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x1BC0610 Offset: 0x1BC0711 VA: 0x1BC0610
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0x1BC0790 Offset: 0x1BC0891 VA: 0x1BC0790
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0x1BC07A0 Offset: 0x1BC08A1 VA: 0x1BC07A0
	internal void set_OnDefaultAttributeUse(XmlTextReaderImpl.OnDefaultAttributeUseDelegate value) { }

	// RVA: 0x1BAC490 Offset: 0x1BAC591 VA: 0x1BAC490
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x1BC07B0 Offset: 0x1BC08B1 VA: 0x1BC07B0
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0x1BC07C0 Offset: 0x1BC08C1 VA: 0x1BC07C0
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0x1BC07D0 Offset: 0x1BC08D1 VA: 0x1BC07D0
	internal XmlResolver GetResolver() { }

	// RVA: 0x1BC0820 Offset: 0x1BC0921 VA: 0x1BC0820
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0x1BC0830 Offset: 0x1BC0931 VA: 0x1BC0830
	internal object get_InternalTypedValue() { }

	// RVA: 0x1BC0840 Offset: 0x1BC0941 VA: 0x1BC0840
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0x1BC0850 Offset: 0x1BC0951 VA: 0x1BC0850
	internal bool get_StandAlone() { }

	// RVA: 0x1BC0860 Offset: 0x1BC0961 VA: 0x1BC0860 Slot: 35
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1BC0870 Offset: 0x1BC0971 VA: 0x1BC0870
	internal bool get_V1Compat() { }

	// RVA: 0x1BBA370 Offset: 0x1BBA471 VA: 0x1BBA370
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData) { }

	// RVA: 0x1BC0AB0 Offset: 0x1BC0BB1 VA: 0x1BC0AB0
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0x1BC0880 Offset: 0x1BC0981 VA: 0x1BC0880
	private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0x1BC0CF0 Offset: 0x1BC0DF1 VA: 0x1BC0CF0
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0x1BAE1A0 Offset: 0x1BAE2A1 VA: 0x1BAE1A0
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0x1BB58E0 Offset: 0x1BB59E1 VA: 0x1BB58E0
	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	// RVA: 0x1BC0D00 Offset: 0x1BC0E01 VA: 0x1BC0D00
	internal static string StripSpaces(string value) { }

	// RVA: 0x1BC0F30 Offset: 0x1BC1031 VA: 0x1BC0F30
	internal static void StripSpaces(char[] value, int index, ref int len) { }

	// RVA: 0x1BB74A0 Offset: 0x1BB75A1 VA: 0x1BB74A0
	internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0x1BB74C0 Offset: 0x1BB75C1 VA: 0x1BB74C0
	internal static void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count) { }
}

