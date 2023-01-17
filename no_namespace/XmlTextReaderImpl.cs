// Namespace: 
private enum XmlTextReaderImpl.ParsingFunction // TypeDefIndex: 1661
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.ParsingFunction ElementContent = 0;
	public const XmlTextReaderImpl.ParsingFunction NoData = 1;
	public const XmlTextReaderImpl.ParsingFunction OpenUrl = 2;
	public const XmlTextReaderImpl.ParsingFunction SwitchToInteractive = 3;
	public const XmlTextReaderImpl.ParsingFunction SwitchToInteractiveXmlDecl = 4;
	public const XmlTextReaderImpl.ParsingFunction DocumentContent = 5;
	public const XmlTextReaderImpl.ParsingFunction MoveToElementContent = 6;
	public const XmlTextReaderImpl.ParsingFunction PopElementContext = 7;
	public const XmlTextReaderImpl.ParsingFunction PopEmptyElementContext = 8;
	public const XmlTextReaderImpl.ParsingFunction ResetAttributesRootLevel = 9;
	public const XmlTextReaderImpl.ParsingFunction Error = 10;
	public const XmlTextReaderImpl.ParsingFunction Eof = 11;
	public const XmlTextReaderImpl.ParsingFunction ReaderClosed = 12;
	public const XmlTextReaderImpl.ParsingFunction EntityReference = 13;
	public const XmlTextReaderImpl.ParsingFunction InIncrementalRead = 14;
	public const XmlTextReaderImpl.ParsingFunction FragmentAttribute = 15;
	public const XmlTextReaderImpl.ParsingFunction ReportEndEntity = 16;
	public const XmlTextReaderImpl.ParsingFunction AfterResolveEntityInContent = 17;
	public const XmlTextReaderImpl.ParsingFunction AfterResolveEmptyEntityInContent = 18;
	public const XmlTextReaderImpl.ParsingFunction XmlDeclarationFragment = 19;
	public const XmlTextReaderImpl.ParsingFunction GoToEof = 20;
	public const XmlTextReaderImpl.ParsingFunction PartialTextValue = 21;
	public const XmlTextReaderImpl.ParsingFunction InReadAttributeValue = 22;
	public const XmlTextReaderImpl.ParsingFunction InReadValueChunk = 23;
	public const XmlTextReaderImpl.ParsingFunction InReadContentAsBinary = 24;
	public const XmlTextReaderImpl.ParsingFunction InReadElementContentAsBinary = 25;
}

// Namespace: 
private enum XmlTextReaderImpl.ParsingMode // TypeDefIndex: 1662
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.ParsingMode Full = 0;
	public const XmlTextReaderImpl.ParsingMode SkipNode = 1;
	public const XmlTextReaderImpl.ParsingMode SkipContent = 2;
}

// Namespace: 
private enum XmlTextReaderImpl.EntityType // TypeDefIndex: 1663
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.EntityType CharacterDec = 0;
	public const XmlTextReaderImpl.EntityType CharacterHex = 1;
	public const XmlTextReaderImpl.EntityType CharacterNamed = 2;
	public const XmlTextReaderImpl.EntityType Expanded = 3;
	public const XmlTextReaderImpl.EntityType Skipped = 4;
	public const XmlTextReaderImpl.EntityType FakeExpanded = 5;
	public const XmlTextReaderImpl.EntityType Unexpanded = 6;
	public const XmlTextReaderImpl.EntityType ExpandedInAttribute = 7;
}

// Namespace: 
private enum XmlTextReaderImpl.EntityExpandType // TypeDefIndex: 1664
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.EntityExpandType All = 0;
	public const XmlTextReaderImpl.EntityExpandType OnlyGeneral = 1;
	public const XmlTextReaderImpl.EntityExpandType OnlyCharacter = 2;
}

// Namespace: 
private enum XmlTextReaderImpl.IncrementalReadState // TypeDefIndex: 1665
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.IncrementalReadState Text = 0;
	public const XmlTextReaderImpl.IncrementalReadState StartTag = 1;
	public const XmlTextReaderImpl.IncrementalReadState PI = 2;
	public const XmlTextReaderImpl.IncrementalReadState CDATA = 3;
	public const XmlTextReaderImpl.IncrementalReadState Comment = 4;
	public const XmlTextReaderImpl.IncrementalReadState Attributes = 5;
	public const XmlTextReaderImpl.IncrementalReadState AttributeValue = 6;
	public const XmlTextReaderImpl.IncrementalReadState ReadData = 7;
	public const XmlTextReaderImpl.IncrementalReadState EndElement = 8;
	public const XmlTextReaderImpl.IncrementalReadState End = 9;
	public const XmlTextReaderImpl.IncrementalReadState ReadValueChunk_OnCachedValue = 10;
	public const XmlTextReaderImpl.IncrementalReadState ReadValueChunk_OnPartialValue = 11;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_OnCachedValue = 12;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_OnPartialValue = 13;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_End = 14;
}

// Namespace: 
private class XmlTextReaderImpl.LaterInitParam // TypeDefIndex: 1666
{
	// Fields
	public bool useAsync; // 0x10
	public Stream inputStream; // 0x18
	public byte[] inputBytes; // 0x20
	public int inputByteCount; // 0x28
	public Uri inputbaseUri; // 0x30
	public string inputUriStr; // 0x38
	public XmlResolver inputUriResolver; // 0x40
	public XmlParserContext inputContext; // 0x48
	public TextReader inputTextReader; // 0x50
	public XmlTextReaderImpl.InitInputType initType; // 0x58

	// Methods

	// RVA: 0x19A9760 Offset: 0x19A9861 VA: 0x19A9760
	public void .ctor() { }
}

// Namespace: 
private enum XmlTextReaderImpl.InitInputType // TypeDefIndex: 1667
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.InitInputType UriString = 0;
	public const XmlTextReaderImpl.InitInputType Stream = 1;
	public const XmlTextReaderImpl.InitInputType TextReader = 2;
	public const XmlTextReaderImpl.InitInputType Invalid = 3;
}

// Namespace: 
private struct XmlTextReaderImpl.ParsingState // TypeDefIndex: 1668
{
	// Fields
	internal char[] chars; // 0x0
	internal int charPos; // 0x8
	internal int charsUsed; // 0xC
	internal Encoding encoding; // 0x10
	internal bool appendMode; // 0x18
	internal Stream stream; // 0x20
	internal Decoder decoder; // 0x28
	internal byte[] bytes; // 0x30
	internal int bytePos; // 0x38
	internal int bytesUsed; // 0x3C
	internal TextReader textReader; // 0x40
	internal int lineNo; // 0x48
	internal int lineStartPos; // 0x4C
	internal string baseUriStr; // 0x50
	internal Uri baseUri; // 0x58
	internal bool isEof; // 0x60
	internal bool isStreamEof; // 0x61
	internal IDtdEntityInfo entity; // 0x68
	internal int entityId; // 0x70
	internal bool eolNormalized; // 0x74
	internal bool entityResolvedManually; // 0x75

	// Properties
	internal int LineNo { get; }
	internal int LinePos { get; }

	// Methods

	// RVA: 0x19AA590 Offset: 0x19AA691 VA: 0x19AA590
	internal void Clear() { }

	// RVA: 0x19AA680 Offset: 0x19AA781 VA: 0x19AA680
	internal void Close(bool closeInput) { }

	// RVA: 0x19AA6C0 Offset: 0x19AA7C1 VA: 0x19AA6C0
	internal int get_LineNo() { }

	// RVA: 0x19AA6D0 Offset: 0x19AA7D1 VA: 0x19AA6D0
	internal int get_LinePos() { }
}

// Namespace: 
private class XmlTextReaderImpl.XmlContext // TypeDefIndex: 1669
{
	// Fields
	internal XmlSpace xmlSpace; // 0x10
	internal string xmlLang; // 0x18
	internal string defaultNamespace; // 0x20
	internal XmlTextReaderImpl.XmlContext previousContext; // 0x28

	// Methods

	// RVA: 0x19AA6E0 Offset: 0x19AA7E1 VA: 0x19AA6E0
	internal void .ctor() { }

	// RVA: 0x19AA780 Offset: 0x19AA881 VA: 0x19AA780
	internal void .ctor(XmlTextReaderImpl.XmlContext previousContext) { }
}

// Namespace: 
private class XmlTextReaderImpl.NoNamespaceManager : XmlNamespaceManager // TypeDefIndex: 1670
{
	// Properties
	public override string DefaultNamespace { get; }

	// Methods

	// RVA: 0x19A9770 Offset: 0x19A9871 VA: 0x19A9770
	public void .ctor() { }

	// RVA: 0x19A9780 Offset: 0x19A9881 VA: 0x19A9780 Slot: 9
	public override string get_DefaultNamespace() { }

	// RVA: 0x19A97D0 Offset: 0x19A98D1 VA: 0x19A97D0 Slot: 10
	public override void PushScope() { }

	// RVA: 0x19A97E0 Offset: 0x19A98E1 VA: 0x19A97E0 Slot: 11
	public override bool PopScope() { }

	// RVA: 0x19A97F0 Offset: 0x19A98F1 VA: 0x19A97F0 Slot: 12
	public override void AddNamespace(string prefix, string uri) { }

	// RVA: 0x19A9800 Offset: 0x19A9901 VA: 0x19A9800 Slot: 13
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x19A9810 Offset: 0x19A9911 VA: 0x19A9810 Slot: 14
	public override IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x19A9820 Offset: 0x19A9921 VA: 0x19A9820 Slot: 15
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x19A9870 Offset: 0x19A9971 VA: 0x19A9870 Slot: 16
	public override string LookupPrefix(string uri) { }
}

// Namespace: 
internal class XmlTextReaderImpl.DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter // TypeDefIndex: 1671
{
	// Fields
	private XmlTextReaderImpl reader; // 0x10

	// Properties
	private XmlNameTable System.Xml.IDtdParserAdapter.NameTable { get; }
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver { get; }
	private Uri System.Xml.IDtdParserAdapter.BaseUri { get; }
	private bool System.Xml.IDtdParserAdapter.IsEof { get; }
	private char[] System.Xml.IDtdParserAdapter.ParsingBuffer { get; }
	private int System.Xml.IDtdParserAdapter.ParsingBufferLength { get; }
	private int System.Xml.IDtdParserAdapter.CurrentPosition { get; set; }
	private int System.Xml.IDtdParserAdapter.EntityStackLength { get; }
	private bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized { get; }
	private int System.Xml.IDtdParserAdapter.LineNo { get; }
	private int System.Xml.IDtdParserAdapter.LineStartPosition { get; }
	private bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation { get; }
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling { get; }
	private bool System.Xml.IDtdParserAdapterV1.Normalization { get; }
	private bool System.Xml.IDtdParserAdapterV1.Namespaces { get; }
	private bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode { get; }

	// Methods

	// RVA: 0x19A9540 Offset: 0x19A9641 VA: 0x19A9540
	internal void .ctor(XmlTextReaderImpl reader) { }

	// RVA: 0x19A9580 Offset: 0x19A9681 VA: 0x19A9580 Slot: 9
	private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0x19A9590 Offset: 0x19A9691 VA: 0x19A9590 Slot: 10
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0x19A95A0 Offset: 0x19A96A1 VA: 0x19A95A0 Slot: 11
	private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0x19A95B0 Offset: 0x19A96B1 VA: 0x19A95B0 Slot: 18
	private bool System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0x19A95C0 Offset: 0x19A96C1 VA: 0x19A95C0 Slot: 12
	private char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0x19A95D0 Offset: 0x19A96D1 VA: 0x19A95D0 Slot: 13
	private int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0x19A95E0 Offset: 0x19A96E1 VA: 0x19A95E0 Slot: 14
	private int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0x19A95F0 Offset: 0x19A96F1 VA: 0x19A95F0 Slot: 15
	private void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

	// RVA: 0x19A9600 Offset: 0x19A9701 VA: 0x19A9600 Slot: 19
	private int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0x19A9610 Offset: 0x19A9711 VA: 0x19A9610 Slot: 20
	private bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0x19A9620 Offset: 0x19A9721 VA: 0x19A9620 Slot: 22
	private void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

	// RVA: 0x19A9630 Offset: 0x19A9731 VA: 0x19A9630 Slot: 16
	private int System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0x19A9640 Offset: 0x19A9741 VA: 0x19A9640 Slot: 17
	private int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0x19A9650 Offset: 0x19A9751 VA: 0x19A9650 Slot: 21
	private int System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0x19A9660 Offset: 0x19A9761 VA: 0x19A9660 Slot: 23
	private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x19A9670 Offset: 0x19A9771 VA: 0x19A9670 Slot: 24
	private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x19A9680 Offset: 0x19A9781 VA: 0x19A9680 Slot: 25
	private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0x19A9690 Offset: 0x19A9791 VA: 0x19A9690 Slot: 26
	private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0x19A96A0 Offset: 0x19A97A1 VA: 0x19A96A0 Slot: 27
	private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x19A96B0 Offset: 0x19A97B1 VA: 0x19A96B0 Slot: 28
	private bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x19A96C0 Offset: 0x19A97C1 VA: 0x19A96C0 Slot: 29
	private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x19A96D0 Offset: 0x19A97D1 VA: 0x19A96D0 Slot: 30
	private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x19A96E0 Offset: 0x19A97E1 VA: 0x19A96E0 Slot: 33
	private void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0x19A96F0 Offset: 0x19A97F1 VA: 0x19A96F0 Slot: 31
	private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x19A9700 Offset: 0x19A9801 VA: 0x19A9700 Slot: 32
	private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x19A9710 Offset: 0x19A9811 VA: 0x19A9710 Slot: 7
	private bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0x19A9720 Offset: 0x19A9821 VA: 0x19A9720 Slot: 8
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0x19A9730 Offset: 0x19A9831 VA: 0x19A9730 Slot: 5
	private bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0x19A9740 Offset: 0x19A9841 VA: 0x19A9740 Slot: 6
	private bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0x19A9750 Offset: 0x19A9851 VA: 0x19A9750 Slot: 4
	private bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }
}

// Namespace: 
private class XmlTextReaderImpl.NodeData : IComparable // TypeDefIndex: 1672
{
	// Fields
	private static XmlTextReaderImpl.NodeData s_None; // 0x0
	internal XmlNodeType type; // 0x10
	internal string localName; // 0x18
	internal string prefix; // 0x20
	internal string ns; // 0x28
	internal string nameWPrefix; // 0x30
	private string value; // 0x38
	private char[] chars; // 0x40
	private int valueStartPos; // 0x48
	private int valueLength; // 0x4C
	internal LineInfo lineInfo; // 0x50
	internal LineInfo lineInfo2; // 0x58
	internal char quoteChar; // 0x60
	internal int depth; // 0x64
	private bool isEmptyOrDefault; // 0x68
	internal int entityId; // 0x6C
	internal bool xmlContextPushed; // 0x70
	internal XmlTextReaderImpl.NodeData nextAttrValueChunk; // 0x78
	internal object schemaType; // 0x80
	internal object typedValue; // 0x88

	// Properties
	internal static XmlTextReaderImpl.NodeData None { get; }
	internal int LineNo { get; }
	internal int LinePos { get; }
	internal bool IsEmptyElement { get; set; }
	internal bool IsDefaultAttribute { get; set; }
	internal bool ValueBuffered { get; }
	internal string StringValue { get; }

	// Methods

	// RVA: 0x19A9880 Offset: 0x19A9981 VA: 0x19A9880
	internal static XmlTextReaderImpl.NodeData get_None() { }

	// RVA: 0x19A9930 Offset: 0x19A9A31 VA: 0x19A9930
	internal void .ctor() { }

	// RVA: 0x19A9A20 Offset: 0x19A9B21 VA: 0x19A9A20
	internal int get_LineNo() { }

	// RVA: 0x19A9A30 Offset: 0x19A9B31 VA: 0x19A9A30
	internal int get_LinePos() { }

	// RVA: 0x19A9A40 Offset: 0x19A9B41 VA: 0x19A9A40
	internal bool get_IsEmptyElement() { }

	// RVA: 0x19A9A70 Offset: 0x19A9B71 VA: 0x19A9A70
	internal void set_IsEmptyElement(bool value) { }

	// RVA: 0x19A9A80 Offset: 0x19A9B81 VA: 0x19A9A80
	internal bool get_IsDefaultAttribute() { }

	// RVA: 0x19A9AB0 Offset: 0x19A9BB1 VA: 0x19A9AB0
	internal void set_IsDefaultAttribute(bool value) { }

	// RVA: 0x19A9AC0 Offset: 0x19A9BC1 VA: 0x19A9AC0
	internal bool get_ValueBuffered() { }

	// RVA: 0x19A9AD0 Offset: 0x19A9BD1 VA: 0x19A9AD0
	internal string get_StringValue() { }

	// RVA: 0x19A9B30 Offset: 0x19A9C31 VA: 0x19A9B30
	internal void TrimSpacesInValue() { }

	// RVA: 0x19A9970 Offset: 0x19A9A71 VA: 0x19A9970
	internal void Clear(XmlNodeType type) { }

	// RVA: 0x19A9B90 Offset: 0x19A9C91 VA: 0x19A9B90
	internal void ClearName() { }

	// RVA: 0x19A9C40 Offset: 0x19A9D41 VA: 0x19A9C40
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x19A9C50 Offset: 0x19A9D51 VA: 0x19A9C50
	internal void SetLineInfo2(int lineNo, int linePos) { }

	// RVA: 0x19A9C60 Offset: 0x19A9D61 VA: 0x19A9C60
	internal void SetValueNode(XmlNodeType type, string value) { }

	// RVA: 0x19A9CA0 Offset: 0x19A9DA1 VA: 0x19A9CA0
	internal void SetValueNode(XmlNodeType type, char[] chars, int startPos, int len) { }

	// RVA: 0x19A9D00 Offset: 0x19A9E01 VA: 0x19A9D00
	internal void SetNamedNode(XmlNodeType type, string localName) { }

	// RVA: 0x19A9D80 Offset: 0x19A9E81 VA: 0x19A9D80
	internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x19A9E60 Offset: 0x19A9F61 VA: 0x19A9E60
	internal void SetValue(string value) { }

	// RVA: 0x19A9E70 Offset: 0x19A9F71 VA: 0x19A9E70
	internal void SetValue(char[] chars, int startPos, int len) { }

	// RVA: 0x19A9EC0 Offset: 0x19A9FC1 VA: 0x19A9EC0
	internal void OnBufferInvalidated() { }

	// RVA: 0x19A9F20 Offset: 0x19AA021 VA: 0x19A9F20
	internal void CopyTo(int valueOffset, StringBuilder sb) { }

	// RVA: 0x19A9F80 Offset: 0x19AA081 VA: 0x19A9F80
	internal string GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x19AA030 Offset: 0x19AA131 VA: 0x19AA030
	internal string CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x19AA0D0 Offset: 0x19AA1D1 VA: 0x19AA0D0 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }
}

// Namespace: 
private class XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer : IComparer<object> // TypeDefIndex: 1673
{
	// Fields
	private static IComparer<object> s_instance; // 0x0

	// Properties
	internal static IComparer<object> Instance { get; }

	// Methods

	// RVA: 0x19A9100 Offset: 0x19A9201 VA: 0x19A9100
	internal static IComparer<object> get_Instance() { }

	// RVA: 0x19A9170 Offset: 0x19A9271 VA: 0x19A9170 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x19A94C0 Offset: 0x19A95C1 VA: 0x19A94C0
	public void .ctor() { }

	// RVA: 0x19A94D0 Offset: 0x19A95D1 VA: 0x19A94D0
	private static void .cctor() { }
}

// Namespace: 
internal sealed class XmlTextReaderImpl.OnDefaultAttributeUseDelegate : MulticastDelegate // TypeDefIndex: 1674
{
	// Methods

	// RVA: 0x19AA1C0 Offset: 0x19AA2C1 VA: 0x19AA1C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19AA1E0 Offset: 0x19AA2E1 VA: 0x19AA1E0 Slot: 13
	public virtual void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

	// RVA: 0x19AA550 Offset: 0x19AA651 VA: 0x19AA550 Slot: 14
	public virtual IAsyncResult BeginInvoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader, AsyncCallback callback, object object) { }

	// RVA: 0x19AA580 Offset: 0x19AA681 VA: 0x19AA580 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

