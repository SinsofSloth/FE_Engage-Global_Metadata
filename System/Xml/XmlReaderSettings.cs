// Namespace: System.Xml
public sealed class XmlReaderSettings // TypeDefIndex: 1658
{
	// Fields
	private bool useAsync; // 0x10
	private XmlNameTable nameTable; // 0x18
	private XmlResolver xmlResolver; // 0x20
	private int lineNumberOffset; // 0x28
	private int linePositionOffset; // 0x2C
	private ConformanceLevel conformanceLevel; // 0x30
	private bool checkCharacters; // 0x34
	private long maxCharactersInDocument; // 0x38
	private long maxCharactersFromEntities; // 0x40
	private bool ignoreWhitespace; // 0x48
	private bool ignorePIs; // 0x49
	private bool ignoreComments; // 0x4A
	private DtdProcessing dtdProcessing; // 0x4C
	private ValidationType validationType; // 0x50
	private XmlSchemaValidationFlags validationFlags; // 0x54
	private XmlSchemaSet schemas; // 0x58
	private ValidationEventHandler valEventHandler; // 0x60
	private bool closeInput; // 0x68
	private bool isReadOnly; // 0x69
	[CompilerGeneratedAttribute] // RVA: 0x473E0 Offset: 0x474E1 VA: 0x473E0
	private bool <IsXmlResolverSet>k__BackingField; // 0x6A
	private static Nullable<bool> s_enableLegacyXmlSettings; // 0x0

	// Properties
	public bool Async { get; set; }
	public XmlNameTable NameTable { get; set; }
	internal bool IsXmlResolverSet { get; set; }
	public XmlResolver XmlResolver { set; }
	public int LineNumberOffset { get; set; }
	public int LinePositionOffset { get; set; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; set; }
	public long MaxCharactersInDocument { get; set; }
	public long MaxCharactersFromEntities { get; set; }
	public bool IgnoreWhitespace { get; set; }
	public bool IgnoreProcessingInstructions { get; set; }
	public bool IgnoreComments { get; set; }
	public DtdProcessing DtdProcessing { get; set; }
	public bool CloseInput { get; set; }
	public ValidationType ValidationType { get; set; }
	public XmlSchemaValidationFlags ValidationFlags { get; set; }
	public XmlSchemaSet Schemas { get; set; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0x3301CC0 Offset: 0x3301DC1 VA: 0x3301CC0
	public void .ctor() { }

	// RVA: 0x3302230 Offset: 0x3302331 VA: 0x3302230
	public bool get_Async() { }

	// RVA: 0x3302240 Offset: 0x3302341 VA: 0x3302240
	public void set_Async(bool value) { }

	// RVA: 0x3302360 Offset: 0x3302461 VA: 0x3302360
	public XmlNameTable get_NameTable() { }

	// RVA: 0x3302370 Offset: 0x3302471 VA: 0x3302370
	public void set_NameTable(XmlNameTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x47800 Offset: 0x47901 VA: 0x47800
	// RVA: 0x33023E0 Offset: 0x33024E1 VA: 0x33023E0
	internal bool get_IsXmlResolverSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x47810 Offset: 0x47911 VA: 0x47810
	// RVA: 0x33023F0 Offset: 0x33024F1 VA: 0x33023F0
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0x3302400 Offset: 0x3302501 VA: 0x3302400
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x3302480 Offset: 0x3302581 VA: 0x3302480
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0x3302490 Offset: 0x3302591 VA: 0x3302490
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x33024A0 Offset: 0x33025A1 VA: 0x33024A0
	public int get_LineNumberOffset() { }

	// RVA: 0x33024B0 Offset: 0x33025B1 VA: 0x33024B0
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x3302510 Offset: 0x3302611 VA: 0x3302510
	public int get_LinePositionOffset() { }

	// RVA: 0x3302520 Offset: 0x3302621 VA: 0x3302520
	public void set_LinePositionOffset(int value) { }

	// RVA: 0x3302580 Offset: 0x3302681 VA: 0x3302580
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x3302590 Offset: 0x3302691 VA: 0x3302590
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x3302640 Offset: 0x3302741 VA: 0x3302640
	public bool get_CheckCharacters() { }

	// RVA: 0x3302650 Offset: 0x3302751 VA: 0x3302650
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x33026C0 Offset: 0x33027C1 VA: 0x33026C0
	public long get_MaxCharactersInDocument() { }

	// RVA: 0x33026D0 Offset: 0x33027D1 VA: 0x33026D0
	public void set_MaxCharactersInDocument(long value) { }

	// RVA: 0x3302780 Offset: 0x3302881 VA: 0x3302780
	public long get_MaxCharactersFromEntities() { }

	// RVA: 0x3302790 Offset: 0x3302891 VA: 0x3302790
	public void set_MaxCharactersFromEntities(long value) { }

	// RVA: 0x3302840 Offset: 0x3302941 VA: 0x3302840
	public bool get_IgnoreWhitespace() { }

	// RVA: 0x3302850 Offset: 0x3302951 VA: 0x3302850
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0x33028C0 Offset: 0x33029C1 VA: 0x33028C0
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0x33028D0 Offset: 0x33029D1 VA: 0x33028D0
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0x3302940 Offset: 0x3302A41 VA: 0x3302940
	public bool get_IgnoreComments() { }

	// RVA: 0x3302950 Offset: 0x3302A51 VA: 0x3302950
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x33029C0 Offset: 0x3302AC1 VA: 0x33029C0
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0x33029D0 Offset: 0x3302AD1 VA: 0x33029D0
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x3302A80 Offset: 0x3302B81 VA: 0x3302A80
	public bool get_CloseInput() { }

	// RVA: 0x3302A90 Offset: 0x3302B91 VA: 0x3302A90
	public void set_CloseInput(bool value) { }

	// RVA: 0x3302B00 Offset: 0x3302C01 VA: 0x3302B00
	public ValidationType get_ValidationType() { }

	// RVA: 0x3302B10 Offset: 0x3302C11 VA: 0x3302B10
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x3302BC0 Offset: 0x3302CC1 VA: 0x3302BC0
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x3302BD0 Offset: 0x3302CD1 VA: 0x3302BD0
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0x32F0010 Offset: 0x32F0111 VA: 0x32F0010
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0x3302C80 Offset: 0x3302D81 VA: 0x3302C80
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x3302CF0 Offset: 0x3302DF1 VA: 0x3302CF0
	public XmlReaderSettings Clone() { }

	// RVA: 0x3302D60 Offset: 0x3302E61 VA: 0x3302D60
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x3301CF0 Offset: 0x3301DF1 VA: 0x3301CF0
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x3301F40 Offset: 0x3302041 VA: 0x3301F40
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x3302EB0 Offset: 0x3302FB1 VA: 0x3302EB0
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x33022B0 Offset: 0x33023B1 VA: 0x33022B0
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x3302220 Offset: 0x3302321 VA: 0x3302220
	private void Initialize() { }

	// RVA: 0x3302EC0 Offset: 0x3302FC1 VA: 0x3302EC0
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0x3302F90 Offset: 0x3303091 VA: 0x3302F90
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x3302D70 Offset: 0x3302E71 VA: 0x3302D70
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0x33031B0 Offset: 0x33032B1 VA: 0x33031B0
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0x3302FF0 Offset: 0x33030F1 VA: 0x3302FF0
	internal static bool EnableLegacyXmlSettings() { }
}

