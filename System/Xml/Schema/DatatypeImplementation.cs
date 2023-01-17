// Namespace: System.Xml.Schema
internal abstract class DatatypeImplementation : XmlSchemaDatatype // TypeDefIndex: 1837
{
	// Fields
	private XmlSchemaDatatypeVariety variety; // 0x10
	private RestrictionFacets restriction; // 0x18
	private DatatypeImplementation baseType; // 0x20
	private XmlValueConverter valueConverter; // 0x28
	private XmlSchemaType parentSchemaType; // 0x30
	private static Hashtable builtinTypes; // 0x0
	private static XmlSchemaSimpleType[] enumToTypeCode; // 0x8
	private static XmlSchemaSimpleType anySimpleType; // 0x10
	private static XmlSchemaSimpleType anyAtomicType; // 0x18
	private static XmlSchemaSimpleType untypedAtomicType; // 0x20
	private static XmlSchemaSimpleType yearMonthDurationType; // 0x28
	private static XmlSchemaSimpleType dayTimeDurationType; // 0x30
	private static XmlSchemaSimpleType normalizedStringTypeV1Compat; // 0x38
	private static XmlSchemaSimpleType tokenTypeV1Compat; // 0x40
	internal static XmlQualifiedName QnAnySimpleType; // 0x48
	internal static XmlQualifiedName QnAnyType; // 0x50
	internal static FacetsChecker stringFacetsChecker; // 0x58
	internal static FacetsChecker miscFacetsChecker; // 0x60
	internal static FacetsChecker numeric2FacetsChecker; // 0x68
	internal static FacetsChecker binaryFacetsChecker; // 0x70
	internal static FacetsChecker dateTimeFacetsChecker; // 0x78
	internal static FacetsChecker durationFacetsChecker; // 0x80
	internal static FacetsChecker listFacetsChecker; // 0x88
	internal static FacetsChecker qnameFacetsChecker; // 0x90
	internal static FacetsChecker unionFacetsChecker; // 0x98
	private static readonly DatatypeImplementation c_anySimpleType; // 0xA0
	private static readonly DatatypeImplementation c_anyURI; // 0xA8
	private static readonly DatatypeImplementation c_base64Binary; // 0xB0
	private static readonly DatatypeImplementation c_boolean; // 0xB8
	private static readonly DatatypeImplementation c_byte; // 0xC0
	private static readonly DatatypeImplementation c_char; // 0xC8
	private static readonly DatatypeImplementation c_date; // 0xD0
	private static readonly DatatypeImplementation c_dateTime; // 0xD8
	private static readonly DatatypeImplementation c_dateTimeNoTz; // 0xE0
	private static readonly DatatypeImplementation c_dateTimeTz; // 0xE8
	private static readonly DatatypeImplementation c_day; // 0xF0
	private static readonly DatatypeImplementation c_decimal; // 0xF8
	private static readonly DatatypeImplementation c_double; // 0x100
	private static readonly DatatypeImplementation c_doubleXdr; // 0x108
	private static readonly DatatypeImplementation c_duration; // 0x110
	private static readonly DatatypeImplementation c_ENTITY; // 0x118
	private static readonly DatatypeImplementation c_ENTITIES; // 0x120
	private static readonly DatatypeImplementation c_ENUMERATION; // 0x128
	private static readonly DatatypeImplementation c_fixed; // 0x130
	private static readonly DatatypeImplementation c_float; // 0x138
	private static readonly DatatypeImplementation c_floatXdr; // 0x140
	private static readonly DatatypeImplementation c_hexBinary; // 0x148
	private static readonly DatatypeImplementation c_ID; // 0x150
	private static readonly DatatypeImplementation c_IDREF; // 0x158
	private static readonly DatatypeImplementation c_IDREFS; // 0x160
	private static readonly DatatypeImplementation c_int; // 0x168
	private static readonly DatatypeImplementation c_integer; // 0x170
	private static readonly DatatypeImplementation c_language; // 0x178
	private static readonly DatatypeImplementation c_long; // 0x180
	private static readonly DatatypeImplementation c_month; // 0x188
	private static readonly DatatypeImplementation c_monthDay; // 0x190
	private static readonly DatatypeImplementation c_Name; // 0x198
	private static readonly DatatypeImplementation c_NCName; // 0x1A0
	private static readonly DatatypeImplementation c_negativeInteger; // 0x1A8
	private static readonly DatatypeImplementation c_NMTOKEN; // 0x1B0
	private static readonly DatatypeImplementation c_NMTOKENS; // 0x1B8
	private static readonly DatatypeImplementation c_nonNegativeInteger; // 0x1C0
	private static readonly DatatypeImplementation c_nonPositiveInteger; // 0x1C8
	private static readonly DatatypeImplementation c_normalizedString; // 0x1D0
	private static readonly DatatypeImplementation c_NOTATION; // 0x1D8
	private static readonly DatatypeImplementation c_positiveInteger; // 0x1E0
	private static readonly DatatypeImplementation c_QName; // 0x1E8
	private static readonly DatatypeImplementation c_QNameXdr; // 0x1F0
	private static readonly DatatypeImplementation c_short; // 0x1F8
	private static readonly DatatypeImplementation c_string; // 0x200
	private static readonly DatatypeImplementation c_time; // 0x208
	private static readonly DatatypeImplementation c_timeNoTz; // 0x210
	private static readonly DatatypeImplementation c_timeTz; // 0x218
	private static readonly DatatypeImplementation c_token; // 0x220
	private static readonly DatatypeImplementation c_unsignedByte; // 0x228
	private static readonly DatatypeImplementation c_unsignedInt; // 0x230
	private static readonly DatatypeImplementation c_unsignedLong; // 0x238
	private static readonly DatatypeImplementation c_unsignedShort; // 0x240
	private static readonly DatatypeImplementation c_uuid; // 0x248
	private static readonly DatatypeImplementation c_year; // 0x250
	private static readonly DatatypeImplementation c_yearMonth; // 0x258
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; // 0x260
	internal static readonly DatatypeImplementation c_tokenV1Compat; // 0x268
	private static readonly DatatypeImplementation c_anyAtomicType; // 0x270
	private static readonly DatatypeImplementation c_dayTimeDuration; // 0x278
	private static readonly DatatypeImplementation c_untypedAtomicType; // 0x280
	private static readonly DatatypeImplementation c_yearMonthDuration; // 0x288
	private static readonly DatatypeImplementation[] c_tokenizedTypes; // 0x290
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; // 0x298
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes; // 0x2A0
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes; // 0x2A8

	// Properties
	internal static XmlSchemaSimpleType AnySimpleType { get; }
	internal static XmlSchemaSimpleType UntypedAtomicType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override XmlValueConverter ValueConverter { get; }
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	public override XmlSchemaDatatypeVariety Variety { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFacets Restriction { get; }
	internal override bool HasLexicalFacets { get; }
	internal override bool HasValueFacets { get; }
	protected DatatypeImplementation Base { get; }
	internal abstract Type ListValueType { get; }
	internal abstract RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x358C2F0 Offset: 0x358C3F1 VA: 0x358C2F0
	private static void .cctor() { }

	// RVA: 0x3592BF0 Offset: 0x3592CF1 VA: 0x3592BF0
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x3592C60 Offset: 0x3592D61 VA: 0x3592C60
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x3592CD0 Offset: 0x3592DD1 VA: 0x3592CD0
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x3592D60 Offset: 0x3592E61 VA: 0x3592D60
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x3592DF0 Offset: 0x3592EF1 VA: 0x3592DF0
	internal static DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x3592EE0 Offset: 0x3592FE1 VA: 0x3592EE0
	private static DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x3592FD0 Offset: 0x35930D1 VA: 0x3592FD0
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x35930C0 Offset: 0x35931C1 VA: 0x35930C0
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x3592330 Offset: 0x3592431 VA: 0x3592330
	internal static void CreateBuiltinTypes() { }

	// RVA: 0x3593300 Offset: 0x3593401 VA: 0x3593300
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x3593390 Offset: 0x3593491 VA: 0x3593390
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x3593460 Offset: 0x3593561 VA: 0x3593460
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x3593690 Offset: 0x3593791 VA: 0x3593690
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x35938C0 Offset: 0x35939C1 VA: 0x35938C0
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x3593930 Offset: 0x3593A31 VA: 0x3593930
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x3593AB0 Offset: 0x3593BB1 VA: 0x3593AB0 Slot: 20
	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x3593BD0 Offset: 0x3593CD1 VA: 0x3593BD0 Slot: 21
	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x3590FA0 Offset: 0x35910A1 VA: 0x3590FA0
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x3593D50 Offset: 0x3593E51 VA: 0x3593D50
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x3593EE0 Offset: 0x3593FE1 VA: 0x3593EE0 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x3593EF0 Offset: 0x3593FF1 VA: 0x3593EF0 Slot: 9
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x3594230 Offset: 0x3594331 VA: 0x3594230 Slot: 23
	internal override bool IsEqual(object o1, object o2) { }

	// RVA: 0x3594260 Offset: 0x3594361 VA: 0x3594260 Slot: 24
	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x3594350 Offset: 0x3594451 VA: 0x3594350 Slot: 25
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3594360 Offset: 0x3594461 VA: 0x3594360 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x35943D0 Offset: 0x35944D1 VA: 0x35943D0 Slot: 12
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0x3594430 Offset: 0x3594531 VA: 0x3594430 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x3594440 Offset: 0x3594541 VA: 0x3594440 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x35944C0 Offset: 0x35945C1 VA: 0x35944C0 Slot: 7
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x35944D0 Offset: 0x35945D1 VA: 0x35944D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x35944E0 Offset: 0x35945E1 VA: 0x35944E0 Slot: 13
	internal override RestrictionFacets get_Restriction() { }

	// RVA: 0x35944F0 Offset: 0x35945F1 VA: 0x35944F0 Slot: 10
	internal override bool get_HasLexicalFacets() { }

	// RVA: 0x3594520 Offset: 0x3594621 VA: 0x3594520 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x3594550 Offset: 0x3594651 VA: 0x3594550
	protected DatatypeImplementation get_Base() { }

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract Type get_ListValueType();

	// RVA: -1 Offset: -1 Slot: 27
	internal abstract RestrictionFlags get_ValidRestrictionFlags();

	// RVA: 0x3594560 Offset: 0x3594661 VA: 0x3594560 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x3594570 Offset: 0x3594671 VA: 0x3594570 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x35947B0 Offset: 0x35948B1 VA: 0x35947B0 Slot: 15
	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x3594910 Offset: 0x3594A11 VA: 0x3594910 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x3594740 Offset: 0x3594841 VA: 0x3594740
	internal string GetTypeName() { }

	// RVA: 0x3594D40 Offset: 0x3594E41 VA: 0x3594D40
	protected int Compare(byte[] value1, byte[] value2) { }

	// RVA: 0x3594DC0 Offset: 0x3594EC1 VA: 0x3594DC0
	protected void .ctor() { }
}

