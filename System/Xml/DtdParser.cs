// Namespace: System.Xml
internal class DtdParser : IDtdParser // TypeDefIndex: 1734
{
	// Fields
	private IDtdParserAdapter readerAdapter; // 0x10
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaInfo schemaInfo; // 0x28
	private XmlCharType xmlCharType; // 0x30
	private string systemId; // 0x38
	private string publicId; // 0x40
	private bool normalize; // 0x48
	private bool validate; // 0x49
	private bool supportNamespaces; // 0x4A
	private bool v1Compat; // 0x4B
	private char[] chars; // 0x50
	private int charsUsed; // 0x58
	private int curPos; // 0x5C
	private DtdParser.ScanningFunction scanningFunction; // 0x60
	private DtdParser.ScanningFunction nextScaningFunction; // 0x64
	private DtdParser.ScanningFunction savedScanningFunction; // 0x68
	private bool whitespaceSeen; // 0x6C
	private int tokenStartPos; // 0x70
	private int colonPos; // 0x74
	private StringBuilder internalSubsetValueSb; // 0x78
	private int externalEntitiesDepth; // 0x80
	private int currentEntityId; // 0x84
	private bool freeFloatingDtd; // 0x88
	private bool hasFreeFloatingInternalSubset; // 0x89
	private StringBuilder stringBuilder; // 0x90
	private int condSectionDepth; // 0x98
	private LineInfo literalLineInfo; // 0x9C
	private char literalQuoteChar; // 0xA4
	private string documentBaseUri; // 0xA8
	private string externalDtdBaseUri; // 0xB0
	private Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations; // 0xB8
	private int[] condSectionEntityIds; // 0xC0

	// Properties
	private bool ParsingInternalSubset { get; }
	private bool IgnoreEntityReferences { get; }
	private bool SaveInternalSubsetValue { get; }
	private bool ParsingTopLevelMarkup { get; }
	private bool SupportNamespaces { get; }
	private bool Normalize { get; }
	private int LineNo { get; }
	private int LinePos { get; }
	private string BaseUriStr { get; }

	// Methods

	// RVA: 0x35A0B70 Offset: 0x35A0C71 VA: 0x35A0B70
	private void .ctor() { }

	// RVA: 0x35A0C80 Offset: 0x35A0D81 VA: 0x35A0C80
	internal static IDtdParser Create() { }

	// RVA: 0x35A0CE0 Offset: 0x35A0DE1 VA: 0x35A0CE0
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x35A10F0 Offset: 0x35A11F1 VA: 0x35A10F0
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x35A1620 Offset: 0x35A1721 VA: 0x35A1620 Slot: 4
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x35A18A0 Offset: 0x35A19A1 VA: 0x35A18A0 Slot: 5
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x35A18D0 Offset: 0x35A19D1 VA: 0x35A18D0
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x35A18E0 Offset: 0x35A19E1 VA: 0x35A18E0
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x35A18F0 Offset: 0x35A19F1 VA: 0x35A18F0
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x35A19D0 Offset: 0x35A1AD1 VA: 0x35A19D0
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0x35A1A00 Offset: 0x35A1B01 VA: 0x35A1A00
	private bool get_SupportNamespaces() { }

	// RVA: 0x35A1A10 Offset: 0x35A1B11 VA: 0x35A1A10
	private bool get_Normalize() { }

	// RVA: 0x35A1660 Offset: 0x35A1761 VA: 0x35A1660
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x35A1A90 Offset: 0x35A1B91 VA: 0x35A1A90
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x35A1A20 Offset: 0x35A1B21 VA: 0x35A1A20
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x35A3610 Offset: 0x35A3711 VA: 0x35A3610
	private void ParseInternalSubset() { }

	// RVA: 0x35A3620 Offset: 0x35A3721 VA: 0x35A3620
	private void ParseExternalSubset() { }

	// RVA: 0x35A37E0 Offset: 0x35A38E1 VA: 0x35A37E0
	private void ParseSubset() { }

	// RVA: 0x35A3CE0 Offset: 0x35A3DE1 VA: 0x35A3CE0
	private void ParseAttlistDecl() { }

	// RVA: 0x35A5DB0 Offset: 0x35A5EB1 VA: 0x35A5DB0
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x35A6580 Offset: 0x35A6681 VA: 0x35A6580
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x35A43B0 Offset: 0x35A44B1 VA: 0x35A43B0
	private void ParseElementDecl() { }

	// RVA: 0x35A70C0 Offset: 0x35A71C1 VA: 0x35A70C0
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x35A7530 Offset: 0x35A7631 VA: 0x35A7530
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x35A6D90 Offset: 0x35A6E91 VA: 0x35A6D90
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x35A47B0 Offset: 0x35A48B1 VA: 0x35A47B0
	private void ParseEntityDecl() { }

	// RVA: 0x35A4BB0 Offset: 0x35A4CB1 VA: 0x35A4BB0
	private void ParseNotationDecl() { }

	// RVA: 0x35A6A20 Offset: 0x35A6B21 VA: 0x35A6A20
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x35A4EC0 Offset: 0x35A4FC1 VA: 0x35A4EC0
	private void ParseComment() { }

	// RVA: 0x35A5180 Offset: 0x35A5281 VA: 0x35A5180
	private void ParsePI() { }

	// RVA: 0x35A53F0 Offset: 0x35A54F1 VA: 0x35A53F0
	private void ParseCondSection() { }

	// RVA: 0x35A2EC0 Offset: 0x35A2FC1 VA: 0x35A2EC0
	private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId) { }

	// RVA: 0x35A2100 Offset: 0x35A2201 VA: 0x35A2100
	private DtdParser.Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x35A7FA0 Offset: 0x35A80A1 VA: 0x35A7FA0
	private DtdParser.Token ScanSubsetContent() { }

	// RVA: 0x35A7F10 Offset: 0x35A8011 VA: 0x35A7F10
	private DtdParser.Token ScanNameExpected() { }

	// RVA: 0x35A7F40 Offset: 0x35A8041 VA: 0x35A7F40
	private DtdParser.Token ScanQNameExpected() { }

	// RVA: 0x35A7F70 Offset: 0x35A8071 VA: 0x35A7F70
	private DtdParser.Token ScanNmtokenExpected() { }

	// RVA: 0x35A8860 Offset: 0x35A8961 VA: 0x35A8860
	private DtdParser.Token ScanDoctype1() { }

	// RVA: 0x35A8A60 Offset: 0x35A8B61 VA: 0x35A8A60
	private DtdParser.Token ScanDoctype2() { }

	// RVA: 0x35AB600 Offset: 0x35AB701 VA: 0x35AB600
	private DtdParser.Token ScanClosingTag() { }

	// RVA: 0x35A8B60 Offset: 0x35A8C61 VA: 0x35A8B60
	private DtdParser.Token ScanElement1() { }

	// RVA: 0x35A8DC0 Offset: 0x35A8EC1 VA: 0x35A8DC0
	private DtdParser.Token ScanElement2() { }

	// RVA: 0x35A8FF0 Offset: 0x35A90F1 VA: 0x35A8FF0
	private DtdParser.Token ScanElement3() { }

	// RVA: 0x35A9090 Offset: 0x35A9191 VA: 0x35A9090
	private DtdParser.Token ScanElement4() { }

	// RVA: 0x35A91C0 Offset: 0x35A92C1 VA: 0x35A91C0
	private DtdParser.Token ScanElement5() { }

	// RVA: 0x35A9300 Offset: 0x35A9401 VA: 0x35A9300
	private DtdParser.Token ScanElement6() { }

	// RVA: 0x35A93F0 Offset: 0x35A94F1 VA: 0x35A93F0
	private DtdParser.Token ScanElement7() { }

	// RVA: 0x35A9460 Offset: 0x35A9561 VA: 0x35A9460
	private DtdParser.Token ScanAttlist1() { }

	// RVA: 0x35A9530 Offset: 0x35A9631 VA: 0x35A9530
	private DtdParser.Token ScanAttlist2() { }

	// RVA: 0x35A9D80 Offset: 0x35A9E81 VA: 0x35A9D80
	private DtdParser.Token ScanAttlist3() { }

	// RVA: 0x35A9E30 Offset: 0x35A9F31 VA: 0x35A9E30
	private DtdParser.Token ScanAttlist4() { }

	// RVA: 0x35A9F20 Offset: 0x35AA021 VA: 0x35A9F20
	private DtdParser.Token ScanAttlist5() { }

	// RVA: 0x35AA010 Offset: 0x35AA111 VA: 0x35AA010
	private DtdParser.Token ScanAttlist6() { }

	// RVA: 0x35AA4B0 Offset: 0x35AA5B1 VA: 0x35AA4B0
	private DtdParser.Token ScanAttlist7() { }

	// RVA: 0x35ABCE0 Offset: 0x35ABDE1 VA: 0x35ABCE0
	private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType) { }

	// RVA: 0x35AC990 Offset: 0x35ACA91 VA: 0x35AC990
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x35AA580 Offset: 0x35AA681 VA: 0x35AA580
	private DtdParser.Token ScanNotation1() { }

	// RVA: 0x35AA750 Offset: 0x35AA851 VA: 0x35AA750
	private DtdParser.Token ScanSystemId() { }

	// RVA: 0x35AA950 Offset: 0x35AAA51 VA: 0x35AA950
	private DtdParser.Token ScanEntity1() { }

	// RVA: 0x35AA9E0 Offset: 0x35AAAE1 VA: 0x35AA9E0
	private DtdParser.Token ScanEntity2() { }

	// RVA: 0x35AABE0 Offset: 0x35AACE1 VA: 0x35AABE0
	private DtdParser.Token ScanEntity3() { }

	// RVA: 0x35AA810 Offset: 0x35AA911 VA: 0x35AA810
	private DtdParser.Token ScanPublicId1() { }

	// RVA: 0x35AA8D0 Offset: 0x35AA9D1 VA: 0x35AA8D0
	private DtdParser.Token ScanPublicId2() { }

	// RVA: 0x35AAD10 Offset: 0x35AAE11 VA: 0x35AAD10
	private DtdParser.Token ScanCondSection1() { }

	// RVA: 0x35AB070 Offset: 0x35AB171 VA: 0x35AB070
	private DtdParser.Token ScanCondSection2() { }

	// RVA: 0x35AB110 Offset: 0x35AB211 VA: 0x35AB110
	private DtdParser.Token ScanCondSection3() { }

	// RVA: 0x35AB930 Offset: 0x35ABA31 VA: 0x35AB930
	private void ScanName() { }

	// RVA: 0x35AB940 Offset: 0x35ABA41 VA: 0x35AB940
	private void ScanQName() { }

	// RVA: 0x35ACCE0 Offset: 0x35ACDE1 VA: 0x35ACCE0
	private void ScanQName(bool isQName) { }

	// RVA: 0x35AD000 Offset: 0x35AD101 VA: 0x35AD000
	private bool ReadDataInName() { }

	// RVA: 0x35AB950 Offset: 0x35ABA51 VA: 0x35AB950
	private void ScanNmtoken() { }

	// RVA: 0x35ABAE0 Offset: 0x35ABBE1 VA: 0x35ABAE0
	private bool EatPublicKeyword() { }

	// RVA: 0x35ABBE0 Offset: 0x35ABCE1 VA: 0x35ABBE0
	private bool EatSystemKeyword() { }

	// RVA: 0x35A2D40 Offset: 0x35A2E41 VA: 0x35A2D40
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x35A6A00 Offset: 0x35A6B01 VA: 0x35A6A00
	private string GetNameString() { }

	// RVA: 0x35A6CA0 Offset: 0x35A6DA1 VA: 0x35A6CA0
	private string GetNmtokenString() { }

	// RVA: 0x35A6D30 Offset: 0x35A6E31 VA: 0x35A6D30
	private string GetValue() { }

	// RVA: 0x35A6CC0 Offset: 0x35A6DC1 VA: 0x35A6CC0
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x35AB6A0 Offset: 0x35AB7A1 VA: 0x35AB6A0
	private int ReadData() { }

	// RVA: 0x35A1F70 Offset: 0x35A2071 VA: 0x35A1F70
	private void LoadParsingBuffer() { }

	// RVA: 0x35A3600 Offset: 0x35A3701 VA: 0x35A3600
	private void SaveParsingBuffer() { }

	// RVA: 0x35A5890 Offset: 0x35A5991 VA: 0x35A5890
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x35A7DE0 Offset: 0x35A7EE1 VA: 0x35A7DE0
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x35AD280 Offset: 0x35AD381 VA: 0x35AD280
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x35AB770 Offset: 0x35AB871 VA: 0x35AB770
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x35ACAF0 Offset: 0x35ACBF1 VA: 0x35ACAF0
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x35A56B0 Offset: 0x35A57B1 VA: 0x35A56B0
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x35A6830 Offset: 0x35A6931 VA: 0x35A6830
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x35A1E10 Offset: 0x35A1F11 VA: 0x35A1E10
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x35A6820 Offset: 0x35A6921 VA: 0x35A6820
	private bool IsAttributeValueType(DtdParser.Token token) { }

	// RVA: 0x35A5A70 Offset: 0x35A5B71 VA: 0x35A5A70
	private int get_LineNo() { }

	// RVA: 0x35A5B20 Offset: 0x35A5C21 VA: 0x35A5B20
	private int get_LinePos() { }

	// RVA: 0x35A1CE0 Offset: 0x35A1DE1 VA: 0x35A1CE0
	private string get_BaseUriStr() { }

	// RVA: 0x35A2CA0 Offset: 0x35A2DA1 VA: 0x35A2CA0
	private void OnUnexpectedError() { }

	// RVA: 0x35A5370 Offset: 0x35A5471 VA: 0x35A5370
	private void Throw(int curPos, string res) { }

	// RVA: 0x35A75B0 Offset: 0x35A76B1 VA: 0x35A75B0
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x35A7A70 Offset: 0x35A7B71 VA: 0x35A7A70
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x35A5BE0 Offset: 0x35A5CE1 VA: 0x35A5BE0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x35A15A0 Offset: 0x35A16A1 VA: 0x35A15A0
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x35A7D50 Offset: 0x35A7E51 VA: 0x35A7D50
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x35A5A60 Offset: 0x35A5B61 VA: 0x35A5A60
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x35A7890 Offset: 0x35A7991 VA: 0x35A7890
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x35A7E40 Offset: 0x35A7F41 VA: 0x35A7E40
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x35AD050 Offset: 0x35AD151 VA: 0x35AD050
	internal static string StripSpaces(string value) { }
}

