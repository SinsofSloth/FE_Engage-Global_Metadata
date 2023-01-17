// Namespace: System.Xml.Schema
public sealed class XmlSchemaValidator // TypeDefIndex: 2048
{
	// Fields
	private XmlSchemaSet schemaSet; // 0x10
	private XmlSchemaValidationFlags validationFlags; // 0x18
	private int startIDConstraint; // 0x1C
	private bool isRoot; // 0x20
	private bool rootHasSchema; // 0x21
	private bool attrValid; // 0x22
	private bool checkEntity; // 0x23
	private SchemaInfo compiledSchemaInfo; // 0x28
	private IDtdInfo dtdSchemaInfo; // 0x30
	private Hashtable validatedNamespaces; // 0x38
	private HWStack validationStack; // 0x40
	private ValidationState context; // 0x48
	private ValidatorState currentState; // 0x50
	private Hashtable attPresence; // 0x58
	private SchemaAttDef wildID; // 0x60
	private Hashtable IDs; // 0x68
	private IdRefNode idRefListHead; // 0x70
	private XmlQualifiedName contextQName; // 0x78
	private string NsXs; // 0x80
	private string NsXsi; // 0x88
	private string NsXmlNs; // 0x90
	private string NsXml; // 0x98
	private XmlSchemaObject partialValidationType; // 0xA0
	private StringBuilder textValue; // 0xA8
	private ValidationEventHandler eventHandler; // 0xB0
	private object validationEventSender; // 0xB8
	private XmlNameTable nameTable; // 0xC0
	private IXmlLineInfo positionInfo; // 0xC8
	private IXmlLineInfo dummyPositionInfo; // 0xD0
	private XmlResolver xmlResolver; // 0xD8
	private Uri sourceUri; // 0xE0
	private string sourceUriString; // 0xE8
	private IXmlNamespaceResolver nsResolver; // 0xF0
	private XmlSchemaContentProcessing processContents; // 0xF8
	private string xsiTypeString; // 0x100
	private string xsiNilString; // 0x108
	private string xsiSchemaLocationString; // 0x110
	private string xsiNoNamespaceSchemaLocationString; // 0x118
	private static readonly XmlSchemaDatatype dtQName; // 0x0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private static XmlSchemaParticle[] EmptyParticleArray; // 0x18
	private static XmlSchemaAttribute[] EmptyAttributeArray; // 0x20
	private XmlCharType xmlCharType; // 0x120
	internal static bool[,] ValidStates; // 0x28
	private static string[] MethodNames; // 0x30

	// Properties
	public XmlResolver XmlResolver { set; }
	public IXmlLineInfo LineInfoProvider { set; }
	public Uri SourceUri { set; }
	public object ValidationEventSender { set; }
	internal XmlSchemaSet SchemaSet { get; }
	internal XmlSchemaValidationFlags ValidationFlags { get; }
	internal XmlSchemaContentType CurrentContentType { get; }
	private bool StrictlyAssessed { get; }
	private bool HasSchema { get; }
	private bool HasIdentityConstraints { get; }
	internal bool ProcessIdentityConstraints { get; }
	internal bool ReportValidationWarnings { get; }
	internal bool ProcessSchemaHints { get; }

	// Methods

	// RVA: 0x1972C40 Offset: 0x1972D41 VA: 0x1972C40
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0x1972E60 Offset: 0x1972F61 VA: 0x1972E60
	private void Init() { }

	// RVA: 0x19733E0 Offset: 0x19734E1 VA: 0x19733E0
	private void Reset() { }

	// RVA: 0x1973560 Offset: 0x1973661 VA: 0x1973560
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1973570 Offset: 0x1973671 VA: 0x1973570
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0x1973590 Offset: 0x1973691 VA: 0x1973590
	public void set_SourceUri(Uri value) { }

	// RVA: 0x19735E0 Offset: 0x19736E1 VA: 0x19735E0
	public void set_ValidationEventSender(object value) { }

	// RVA: 0x19735F0 Offset: 0x19736F1 VA: 0x19735F0
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1973680 Offset: 0x1973781 VA: 0x1973680
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1973710 Offset: 0x1973811 VA: 0x1973710
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0x1973F60 Offset: 0x1974061 VA: 0x1973F60
	public void Initialize() { }

	// RVA: 0x1974150 Offset: 0x1974251 VA: 0x1974150
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0x1974490 Offset: 0x1974591 VA: 0x1974490
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x1976290 Offset: 0x1976391 VA: 0x1976290
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1976300 Offset: 0x1976401 VA: 0x1976300
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1977850 Offset: 0x1977951 VA: 0x1977850
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1977AC0 Offset: 0x1977BC1 VA: 0x1977AC0
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0x1977B30 Offset: 0x1977C31 VA: 0x1977B30
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x1978530 Offset: 0x1978631 VA: 0x1978530
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0x19785A0 Offset: 0x19786A1 VA: 0x19785A0
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x19787D0 Offset: 0x19788D1 VA: 0x19787D0
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1978D20 Offset: 0x1978E21 VA: 0x1978D20
	public void EndValidation() { }

	// RVA: 0x1978FC0 Offset: 0x19790C1 VA: 0x1978FC0
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x1979A30 Offset: 0x1979B31 VA: 0x1979A30
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x1979A40 Offset: 0x1979B41 VA: 0x1979A40
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x1979A50 Offset: 0x1979B51 VA: 0x1979A50
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0x1979A70 Offset: 0x1979B71 VA: 0x1979A70
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0x1979AA0 Offset: 0x1979BA1 VA: 0x1979AA0
	private bool get_StrictlyAssessed() { }

	// RVA: 0x1979AE0 Offset: 0x1979BE1 VA: 0x1979AE0
	private bool get_HasSchema() { }

	// RVA: 0x1979B30 Offset: 0x1979C31 VA: 0x1979B30
	internal string GetConcatenatedValue() { }

	// RVA: 0x19787E0 Offset: 0x19788E1 VA: 0x19787E0
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0x19752B0 Offset: 0x19753B1 VA: 0x19752B0
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x1974B50 Offset: 0x1974C51 VA: 0x1974B50
	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	// RVA: 0x197BD70 Offset: 0x197BE71 VA: 0x197BD70
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0x1979B40 Offset: 0x1979C41 VA: 0x1979B40
	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x1979E30 Offset: 0x1979F31 VA: 0x1979E30
	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x197D190 Offset: 0x197D291 VA: 0x197D190
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0x1977FA0 Offset: 0x19780A1 VA: 0x1977FA0
	private void SaveTextValue(object value) { }

	// RVA: 0x1973290 Offset: 0x1973391 VA: 0x1973290
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x197B600 Offset: 0x197B701 VA: 0x197B600
	private void Pop() { }

	// RVA: 0x1975060 Offset: 0x1975161 VA: 0x1975060
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0x1975690 Offset: 0x1975791 VA: 0x1975690
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	// RVA: 0x1975E10 Offset: 0x1975F11 VA: 0x1975E10
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0x1976010 Offset: 0x1976111 VA: 0x1976010
	private void CheckElementProperties() { }

	// RVA: 0x1976110 Offset: 0x1976211 VA: 0x1976110
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x1976E80 Offset: 0x1976F81 VA: 0x1976E80
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0x197DAE0 Offset: 0x197DBE1 VA: 0x197DAE0
	private void AddXmlNamespaceSchema() { }

	// RVA: 0x197A250 Offset: 0x197A351 VA: 0x197A250
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0x197B720 Offset: 0x197B821 VA: 0x197B720
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x1973490 Offset: 0x1973591 VA: 0x1973490
	internal void RecompileSchemaSet() { }

	// RVA: 0x197DDC0 Offset: 0x197DEC1 VA: 0x197DDC0
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0x1977120 Offset: 0x1977221 VA: 0x1977120
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0x197CE50 Offset: 0x197CF51 VA: 0x197CE50
	private object CheckElementValue(string stringValue) { }

	// RVA: 0x1977400 Offset: 0x1977501 VA: 0x1977400
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0x197E080 Offset: 0x197E181 VA: 0x197E080
	private object FindId(string name) { }

	// RVA: 0x1978E20 Offset: 0x1978F21 VA: 0x1978E20
	private void CheckForwardRefs() { }

	// RVA: 0x1977590 Offset: 0x1977691 VA: 0x1977590
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x197D250 Offset: 0x197D351 VA: 0x197D250
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0x197E350 Offset: 0x197E451 VA: 0x197E350
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0x1973550 Offset: 0x1973651 VA: 0x1973550
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0x1974870 Offset: 0x1974971 VA: 0x1974870
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0x1974B00 Offset: 0x1974C01 VA: 0x1974B00
	private void ClearPSVI() { }

	// RVA: 0x1977920 Offset: 0x1977A21 VA: 0x1977920
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0x1976170 Offset: 0x1976271 VA: 0x1976170
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0x19796A0 Offset: 0x19797A1 VA: 0x19796A0
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0x197D260 Offset: 0x197D361 VA: 0x197D260
	private void AddIdentityConstraints() { }

	// RVA: 0x197D6B0 Offset: 0x197D7B1 VA: 0x197D6B0
	private void ElementIdentityConstraints() { }

	// RVA: 0x19775B0 Offset: 0x19776B1 VA: 0x19775B0
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0x197A9B0 Offset: 0x197AAB1 VA: 0x197A9B0
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0x197C2B0 Offset: 0x197C3B1 VA: 0x197C2B0
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x197A320 Offset: 0x197A421 VA: 0x197A320
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x1978130 Offset: 0x1978231 VA: 0x1978130
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0x197E930 Offset: 0x197EA31 VA: 0x197E930
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0x197E4D0 Offset: 0x197E5D1 VA: 0x197E4D0
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0x197EAB0 Offset: 0x197EBB1 VA: 0x197EAB0
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0x1977F20 Offset: 0x1978021 VA: 0x1977F20
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0x197BFD0 Offset: 0x197C0D1 VA: 0x197BFD0
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0x1977FE0 Offset: 0x19780E1 VA: 0x1977FE0
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0x197E0A0 Offset: 0x197E1A1 VA: 0x197E0A0
	private void ProcessEntity(string name) { }

	// RVA: 0x197D1E0 Offset: 0x197D2E1 VA: 0x197D1E0
	private void SendValidationEvent(string code) { }

	// RVA: 0x1976F50 Offset: 0x1977051 VA: 0x1976F50
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x1976D10 Offset: 0x1976E11 VA: 0x1976D10
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0x197C040 Offset: 0x197C141 VA: 0x197C040
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0x197DBB0 Offset: 0x197DCB1 VA: 0x197DBB0
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0x1973D10 Offset: 0x1973E11 VA: 0x1973D10
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0x197E360 Offset: 0x197E461 VA: 0x197E360
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0x197BC00 Offset: 0x197BD01 VA: 0x197BC00
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1973B60 Offset: 0x1973C61 VA: 0x1973B60
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x197E230 Offset: 0x197E331 VA: 0x197E230
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x197E410 Offset: 0x197E511 VA: 0x197E410
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x197ECF0 Offset: 0x197EDF1 VA: 0x197ECF0
	private static void .cctor() { }
}

