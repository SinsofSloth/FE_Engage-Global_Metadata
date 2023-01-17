// Namespace: System.Xml.Schema
internal class Datatype_List : Datatype_anySimpleType // TypeDefIndex: 1838
{
	// Fields
	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

	// Properties
	public override Type ValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override Type ListValueType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x3594E40 Offset: 0x3594F41 VA: 0x3594E40 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3593C70 Offset: 0x3593D71 VA: 0x3593C70
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x35951B0 Offset: 0x35952B1 VA: 0x35951B0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x3595450 Offset: 0x3595551 VA: 0x3595450 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3595460 Offset: 0x3595561 VA: 0x3595460 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x3595470 Offset: 0x3595571 VA: 0x3595470 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3595490 Offset: 0x3595591 VA: 0x3595490 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3595500 Offset: 0x3595601 VA: 0x3595500 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3595510 Offset: 0x3595611 VA: 0x3595510 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x3595520 Offset: 0x3595621 VA: 0x3595520 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x3595B50 Offset: 0x3595C51 VA: 0x3595B50 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }
}

// Namespace: System.Xml.Schema
internal class Datatype_union : Datatype_anySimpleType // TypeDefIndex: 1839
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XmlSchemaSimpleType[] types; // 0x38

	// Properties
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x359D120 Offset: 0x359D221 VA: 0x359D120 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3593E20 Offset: 0x3593F21 VA: 0x3593E20
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x359D130 Offset: 0x359D231 VA: 0x359D130 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x359D230 Offset: 0x359D331 VA: 0x359D230 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x359D2A0 Offset: 0x359D3A1 VA: 0x359D2A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359D2B0 Offset: 0x359D3B1 VA: 0x359D2B0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359D320 Offset: 0x359D421 VA: 0x359D320 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x359D390 Offset: 0x359D491 VA: 0x359D390 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x359D3A0 Offset: 0x359D4A1 VA: 0x359D3A0
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x3593BE0 Offset: 0x3593CE1 VA: 0x3593BE0
	internal bool HasAtomicMembers() { }

	// RVA: 0x3594190 Offset: 0x3594291 VA: 0x3594190
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x359D3B0 Offset: 0x359D4B1 VA: 0x359D3B0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x359D5D0 Offset: 0x359D6D1 VA: 0x359D5D0 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x359DAB0 Offset: 0x359DBB1 VA: 0x359DAB0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_anySimpleType : DatatypeImplementation // TypeDefIndex: 1840
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override Type ListValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x35971D0 Offset: 0x35972D1 VA: 0x35971D0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3597240 Offset: 0x3597341 VA: 0x3597240 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x35972B0 Offset: 0x35973B1 VA: 0x35972B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3597320 Offset: 0x3597421 VA: 0x3597320 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3597330 Offset: 0x3597431 VA: 0x3597330 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x35973A0 Offset: 0x35974A1 VA: 0x35973A0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x35973B0 Offset: 0x35974B1 VA: 0x35973B0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x35973C0 Offset: 0x35974C1 VA: 0x35973C0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x35973D0 Offset: 0x35974D1 VA: 0x35973D0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x3597420 Offset: 0x3597521 VA: 0x3597420 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3590700 Offset: 0x3590801 VA: 0x3590700
	public void .ctor() { }

	// RVA: 0x3597460 Offset: 0x3597561 VA: 0x3597460
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_anyAtomicType : Datatype_anySimpleType // TypeDefIndex: 1841
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x3597140 Offset: 0x3597241 VA: 0x3597140 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x35971B0 Offset: 0x35972B1 VA: 0x35971B0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x35971C0 Offset: 0x35972C1 VA: 0x35971C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3592190 Offset: 0x3592291 VA: 0x3592190
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_untypedAtomicType : Datatype_anyAtomicType // TypeDefIndex: 1842
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x359EFE0 Offset: 0x359F0E1 VA: 0x359EFE0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x359F050 Offset: 0x359F151 VA: 0x359F050 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x359F060 Offset: 0x359F161 VA: 0x359F060 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x35922B0 Offset: 0x35923B1 VA: 0x35922B0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_string : Datatype_anySimpleType // TypeDefIndex: 1843
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x359CF20 Offset: 0x359D021 VA: 0x359CF20 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x359CF30 Offset: 0x359D031 VA: 0x359CF30 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x359CF40 Offset: 0x359D041 VA: 0x359CF40 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359CFB0 Offset: 0x359D0B1 VA: 0x359CFB0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359CFC0 Offset: 0x359D0C1 VA: 0x359CFC0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x359CFD0 Offset: 0x359D0D1 VA: 0x359CFD0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x359CFE0 Offset: 0x359D0E1 VA: 0x359CFE0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3591B90 Offset: 0x3591C91 VA: 0x3591B90
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_boolean : Datatype_anySimpleType // TypeDefIndex: 1844
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x3597FA0 Offset: 0x35980A1 VA: 0x3597FA0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3597FB0 Offset: 0x35980B1 VA: 0x3597FB0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3598020 Offset: 0x3598121 VA: 0x3598020 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3598030 Offset: 0x3598131 VA: 0x3598030 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x35980A0 Offset: 0x35981A1 VA: 0x35980A0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3598110 Offset: 0x3598211 VA: 0x3598110 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x3598120 Offset: 0x3598221 VA: 0x3598120 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x3598130 Offset: 0x3598231 VA: 0x3598130 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x35981D0 Offset: 0x35982D1 VA: 0x35981D0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x35908D0 Offset: 0x35909D1 VA: 0x35908D0
	public void .ctor() { }

	// RVA: 0x3598300 Offset: 0x3598401 VA: 0x3598300
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_float : Datatype_anySimpleType // TypeDefIndex: 1845
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x359ACC0 Offset: 0x359ADC1 VA: 0x359ACC0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x359ACD0 Offset: 0x359ADD1 VA: 0x359ACD0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359AD40 Offset: 0x359AE41 VA: 0x359AD40 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359AD50 Offset: 0x359AE51 VA: 0x359AD50 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x359ADC0 Offset: 0x359AEC1 VA: 0x359ADC0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x359AE30 Offset: 0x359AF31 VA: 0x359AE30 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x359AE40 Offset: 0x359AF41 VA: 0x359AE40 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x359AE50 Offset: 0x359AF51 VA: 0x359AE50 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x359AEF0 Offset: 0x359AFF1 VA: 0x359AEF0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3591220 Offset: 0x3591321 VA: 0x3591220
	public void .ctor() { }

	// RVA: 0x359B060 Offset: 0x359B161 VA: 0x359B060
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_double : Datatype_anySimpleType // TypeDefIndex: 1846
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x3599D10 Offset: 0x3599E11 VA: 0x3599D10 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3599D20 Offset: 0x3599E21 VA: 0x3599D20 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3599D90 Offset: 0x3599E91 VA: 0x3599D90 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3599DA0 Offset: 0x3599EA1 VA: 0x3599DA0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3599E10 Offset: 0x3599F11 VA: 0x3599E10 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3599E80 Offset: 0x3599F81 VA: 0x3599E80 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x3599E90 Offset: 0x3599F91 VA: 0x3599E90 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x3599EA0 Offset: 0x3599FA1 VA: 0x3599EA0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x3599F40 Offset: 0x359A041 VA: 0x3599F40 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3590DC0 Offset: 0x3590EC1 VA: 0x3590DC0
	public void .ctor() { }

	// RVA: 0x359A0B0 Offset: 0x359A1B1 VA: 0x359A0B0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_decimal : Datatype_anySimpleType // TypeDefIndex: 1847
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x35997F0 Offset: 0x35998F1 VA: 0x35997F0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3599800 Offset: 0x3599901 VA: 0x3599800 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3599870 Offset: 0x3599971 VA: 0x3599870 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3599880 Offset: 0x3599981 VA: 0x3599880 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x35998F0 Offset: 0x35999F1 VA: 0x35998F0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3599960 Offset: 0x3599A61 VA: 0x3599960 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x3599970 Offset: 0x3599A71 VA: 0x3599970 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x3599980 Offset: 0x3599A81 VA: 0x3599980 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x3599A20 Offset: 0x3599B21 VA: 0x3599A20 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3590D10 Offset: 0x3590E11 VA: 0x3590D10
	public void .ctor() { }

	// RVA: 0x3599B90 Offset: 0x3599C91 VA: 0x3599B90
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_duration : Datatype_anySimpleType // TypeDefIndex: 1848
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x359A3D0 Offset: 0x359A4D1 VA: 0x359A3D0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x359A3E0 Offset: 0x359A4E1 VA: 0x359A3E0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359A450 Offset: 0x359A551 VA: 0x359A450 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359A460 Offset: 0x359A561 VA: 0x359A460 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x359A4D0 Offset: 0x359A5D1 VA: 0x359A4D0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x359A540 Offset: 0x359A641 VA: 0x359A540 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x359A550 Offset: 0x359A651 VA: 0x359A550 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x359A560 Offset: 0x359A661 VA: 0x359A560 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x359A600 Offset: 0x359A701 VA: 0x359A600 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3590EE0 Offset: 0x3590FE1 VA: 0x3590EE0
	public void .ctor() { }

	// RVA: 0x359A7F0 Offset: 0x359A8F1 VA: 0x359A7F0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonthDuration : Datatype_duration // TypeDefIndex: 1849
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x359F5D0 Offset: 0x359F6D1 VA: 0x359F5D0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x359F7C0 Offset: 0x359F8C1 VA: 0x359F7C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x35922C0 Offset: 0x35923C1 VA: 0x35922C0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dayTimeDuration : Datatype_duration // TypeDefIndex: 1850
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x35995F0 Offset: 0x35996F1 VA: 0x35995F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x35997E0 Offset: 0x35998E1 VA: 0x35997E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3592240 Offset: 0x3592341 VA: 0x3592240
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeBase : Datatype_anySimpleType // TypeDefIndex: 1851
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XsdDateTimeFlags dateTimeFlags; // 0x38

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x3598EA0 Offset: 0x3598FA1 VA: 0x3598EA0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3598EB0 Offset: 0x3598FB1 VA: 0x3598EB0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3598F20 Offset: 0x3599021 VA: 0x3598F20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3598DE0 Offset: 0x3598EE1 VA: 0x3598DE0
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x3598F30 Offset: 0x3599031 VA: 0x3598F30 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3598FA0 Offset: 0x35990A1 VA: 0x3598FA0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3599010 Offset: 0x3599111 VA: 0x3599010 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x3599020 Offset: 0x3599121 VA: 0x3599020 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x3599030 Offset: 0x3599131 VA: 0x3599030 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x3599150 Offset: 0x3599251 VA: 0x3599150 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3599500 Offset: 0x3599601 VA: 0x3599500
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 1852
{
	// Methods

	// RVA: 0x3590BC0 Offset: 0x3590CC1 VA: 0x3590BC0
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 1853
{
	// Methods

	// RVA: 0x3590C30 Offset: 0x3590D31 VA: 0x3590C30
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTime : Datatype_dateTimeBase // TypeDefIndex: 1854
{
	// Methods

	// RVA: 0x3590B50 Offset: 0x3590C51 VA: 0x3590B50
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_timeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 1855
{
	// Methods

	// RVA: 0x3591CB0 Offset: 0x3591DB1 VA: 0x3591CB0
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_timeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 1856
{
	// Methods

	// RVA: 0x3591D20 Offset: 0x3591E21 VA: 0x3591D20
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_time : Datatype_dateTimeBase // TypeDefIndex: 1857
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x359D0E0 Offset: 0x359D1E1 VA: 0x359D0E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3591C40 Offset: 0x3591D41 VA: 0x3591C40
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_date : Datatype_dateTimeBase // TypeDefIndex: 1858
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x3598DD0 Offset: 0x3598ED1 VA: 0x3598DD0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3590AE0 Offset: 0x3590BE1 VA: 0x3590AE0
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonth : Datatype_dateTimeBase // TypeDefIndex: 1859
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x359F5C0 Offset: 0x359F6C1 VA: 0x359F5C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3592100 Offset: 0x3592201 VA: 0x3592100
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_year : Datatype_dateTimeBase // TypeDefIndex: 1860
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x359F5B0 Offset: 0x359F6B1 VA: 0x359F5B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3592090 Offset: 0x3592191 VA: 0x3592090
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_monthDay : Datatype_dateTimeBase // TypeDefIndex: 1861
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x359C3D0 Offset: 0x359C4D1 VA: 0x359C3D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3591620 Offset: 0x3591721 VA: 0x3591620
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_day : Datatype_dateTimeBase // TypeDefIndex: 1862
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x35995E0 Offset: 0x35996E1 VA: 0x35995E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3590CA0 Offset: 0x3590DA1 VA: 0x3590CA0
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_month : Datatype_dateTimeBase // TypeDefIndex: 1863
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x359C3C0 Offset: 0x359C4C1 VA: 0x359C3C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x35915B0 Offset: 0x35916B1 VA: 0x35915B0
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_hexBinary : Datatype_anySimpleType // TypeDefIndex: 1864
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x359B350 Offset: 0x359B451 VA: 0x359B350 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x359B360 Offset: 0x359B461 VA: 0x359B360 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359B3D0 Offset: 0x359B4D1 VA: 0x359B3D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359B3E0 Offset: 0x359B4E1 VA: 0x359B3E0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x359B450 Offset: 0x359B551 VA: 0x359B450 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x359B4C0 Offset: 0x359B5C1 VA: 0x359B4C0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x359B4D0 Offset: 0x359B5D1 VA: 0x359B4D0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x359B4E0 Offset: 0x359B5E1 VA: 0x359B4E0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x359B5F0 Offset: 0x359B6F1 VA: 0x359B5F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3591340 Offset: 0x3591441 VA: 0x3591340
	public void .ctor() { }

	// RVA: 0x359B7D0 Offset: 0x359B8D1 VA: 0x359B7D0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_base64Binary : Datatype_anySimpleType // TypeDefIndex: 1865
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x3597A40 Offset: 0x3597B41 VA: 0x3597A40 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3597A50 Offset: 0x3597B51 VA: 0x3597A50 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3597AC0 Offset: 0x3597BC1 VA: 0x3597AC0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3597AD0 Offset: 0x3597BD1 VA: 0x3597AD0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3597B40 Offset: 0x3597C41 VA: 0x3597B40 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3597BB0 Offset: 0x3597CB1 VA: 0x3597BB0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x3597BC0 Offset: 0x3597CC1 VA: 0x3597BC0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x3597BD0 Offset: 0x3597CD1 VA: 0x3597BD0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x3597CE0 Offset: 0x3597DE1 VA: 0x3597CE0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3590820 Offset: 0x3590921 VA: 0x3590820
	public void .ctor() { }

	// RVA: 0x3597EC0 Offset: 0x3597FC1 VA: 0x3597EC0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_anyURI : Datatype_anySimpleType // TypeDefIndex: 1866
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override bool HasValueFacets { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x3597540 Offset: 0x3597641 VA: 0x3597540 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3597550 Offset: 0x3597651 VA: 0x3597550 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x35975C0 Offset: 0x35976C1 VA: 0x35975C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x35975D0 Offset: 0x35976D1 VA: 0x35975D0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3597640 Offset: 0x3597741 VA: 0x3597640 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x3597650 Offset: 0x3597751 VA: 0x3597650 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x35976C0 Offset: 0x35977C1 VA: 0x35976C0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x35976D0 Offset: 0x35977D1 VA: 0x35976D0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x35976E0 Offset: 0x35977E1 VA: 0x35976E0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x35977C0 Offset: 0x35978C1 VA: 0x35977C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3590770 Offset: 0x3590871 VA: 0x3590770
	public void .ctor() { }

	// RVA: 0x3597960 Offset: 0x3597A61 VA: 0x3597960
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_QName : Datatype_anySimpleType // TypeDefIndex: 1867
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x3596810 Offset: 0x3596911 VA: 0x3596810 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3596820 Offset: 0x3596921 VA: 0x3596820 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3596890 Offset: 0x3596991 VA: 0x3596890 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x35968A0 Offset: 0x35969A1 VA: 0x35968A0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x35968B0 Offset: 0x35969B1 VA: 0x35968B0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x35968C0 Offset: 0x35969C1 VA: 0x35968C0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3596930 Offset: 0x3596A31 VA: 0x3596930 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x35969A0 Offset: 0x3596AA1 VA: 0x35969A0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x35969B0 Offset: 0x3596AB1 VA: 0x35969B0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x35919C0 Offset: 0x3591AC1 VA: 0x35919C0
	public void .ctor() { }

	// RVA: 0x3596C20 Offset: 0x3596D21 VA: 0x3596C20
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedString : Datatype_string // TypeDefIndex: 1868
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x359C880 Offset: 0x359C981 VA: 0x359C880 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359C890 Offset: 0x359C991 VA: 0x359C890 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x359C8A0 Offset: 0x359C9A1 VA: 0x359C8A0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x3591850 Offset: 0x3591951 VA: 0x3591850
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedStringV1Compat : Datatype_string // TypeDefIndex: 1869
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x359C8B0 Offset: 0x359C9B1 VA: 0x359C8B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359C8C0 Offset: 0x359C9C1 VA: 0x359C8C0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x3592170 Offset: 0x3592271 VA: 0x3592170
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_token : Datatype_normalizedString // TypeDefIndex: 1870
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x359D0F0 Offset: 0x359D1F1 VA: 0x359D0F0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359D100 Offset: 0x359D201 VA: 0x359D100 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x3591D90 Offset: 0x3591E91 VA: 0x3591D90
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat // TypeDefIndex: 1871
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x359D110 Offset: 0x359D211 VA: 0x359D110 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3592180 Offset: 0x3592281 VA: 0x3592180
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_language : Datatype_token // TypeDefIndex: 1872
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x359BED0 Offset: 0x359BFD1 VA: 0x359BED0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3591530 Offset: 0x3591631 VA: 0x3591530
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_NMTOKEN : Datatype_token // TypeDefIndex: 1873
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x3596100 Offset: 0x3596201 VA: 0x3596100 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3596110 Offset: 0x3596211 VA: 0x3596110 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x3591760 Offset: 0x3591861 VA: 0x3591760
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_Name : Datatype_token // TypeDefIndex: 1874
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x3596800 Offset: 0x3596901 VA: 0x3596800 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3591690 Offset: 0x3591791 VA: 0x3591690
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_NCName : Datatype_Name // TypeDefIndex: 1875
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x3595FD0 Offset: 0x35960D1 VA: 0x3595FD0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3595FE0 Offset: 0x35960E1 VA: 0x3595FE0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x35916A0 Offset: 0x35917A1 VA: 0x35916A0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_ID : Datatype_NCName // TypeDefIndex: 1876
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x3594E00 Offset: 0x3594F01 VA: 0x3594E00 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3594E10 Offset: 0x3594F11 VA: 0x3594E10 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x35913F0 Offset: 0x35914F1 VA: 0x35913F0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_IDREF : Datatype_NCName // TypeDefIndex: 1877
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x3594E20 Offset: 0x3594F21 VA: 0x3594E20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3594E30 Offset: 0x3594F31 VA: 0x3594E30 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x3591400 Offset: 0x3591501 VA: 0x3591400
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_ENTITY : Datatype_NCName // TypeDefIndex: 1878
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x3594DD0 Offset: 0x3594ED1 VA: 0x3594DD0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3594DE0 Offset: 0x3594EE1 VA: 0x3594DE0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x3590F90 Offset: 0x3591091 VA: 0x3590F90
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_NOTATION : Datatype_anySimpleType // TypeDefIndex: 1879
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x3596120 Offset: 0x3596221 VA: 0x3596120 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3596130 Offset: 0x3596231 VA: 0x3596130 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x35961A0 Offset: 0x35962A1 VA: 0x35961A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x35961B0 Offset: 0x35962B1 VA: 0x35961B0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x35961C0 Offset: 0x35962C1 VA: 0x35961C0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x35961D0 Offset: 0x35962D1 VA: 0x35961D0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3596240 Offset: 0x3596341 VA: 0x3596240 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x35962B0 Offset: 0x35963B1 VA: 0x35962B0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x35962C0 Offset: 0x35963C1 VA: 0x35962C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3596530 Offset: 0x3596631 VA: 0x3596530 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x3591860 Offset: 0x3591961 VA: 0x3591860
	public void .ctor() { }

	// RVA: 0x3596720 Offset: 0x3596821 VA: 0x3596720
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_integer : Datatype_decimal // TypeDefIndex: 1880
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x359BD80 Offset: 0x359BE81 VA: 0x359BD80 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359BD90 Offset: 0x359BE91 VA: 0x359BD90 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x35914C0 Offset: 0x35915C1 VA: 0x35914C0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_nonPositiveInteger : Datatype_integer // TypeDefIndex: 1881
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x359C6F0 Offset: 0x359C7F1 VA: 0x359C6F0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359C760 Offset: 0x359C861 VA: 0x359C760 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359C770 Offset: 0x359C871 VA: 0x359C770 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x35917E0 Offset: 0x35918E1 VA: 0x35917E0
	public void .ctor() { }

	// RVA: 0x359C780 Offset: 0x359C881 VA: 0x359C780
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_negativeInteger : Datatype_nonPositiveInteger // TypeDefIndex: 1882
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x359C3E0 Offset: 0x359C4E1 VA: 0x359C3E0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359C450 Offset: 0x359C551 VA: 0x359C450 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x35916B0 Offset: 0x35917B1 VA: 0x35916B0
	public void .ctor() { }

	// RVA: 0x359C460 Offset: 0x359C561 VA: 0x359C460
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_long : Datatype_integer // TypeDefIndex: 1883
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	internal override bool HasValueFacets { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x359BEE0 Offset: 0x359BFE1 VA: 0x359BEE0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359BF50 Offset: 0x359C051 VA: 0x359BF50 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x359BF60 Offset: 0x359C061 VA: 0x359BF60 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359BF70 Offset: 0x359C071 VA: 0x359BF70 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x359C010 Offset: 0x359C111 VA: 0x359C010 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x359C080 Offset: 0x359C181 VA: 0x359C080 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x359C0F0 Offset: 0x359C1F1 VA: 0x359C0F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3591540 Offset: 0x3591641 VA: 0x3591540
	public void .ctor() { }

	// RVA: 0x359C260 Offset: 0x359C361 VA: 0x359C260
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_int : Datatype_long // TypeDefIndex: 1884
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x359B8B0 Offset: 0x359B9B1 VA: 0x359B8B0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359B920 Offset: 0x359BA21 VA: 0x359B920 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359B930 Offset: 0x359BA31 VA: 0x359B930 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x359B9D0 Offset: 0x359BAD1 VA: 0x359B9D0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x359BA40 Offset: 0x359BB41 VA: 0x359BA40 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x359BAB0 Offset: 0x359BBB1 VA: 0x359BAB0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3591410 Offset: 0x3591511 VA: 0x3591410
	public void .ctor() { }

	// RVA: 0x359BC20 Offset: 0x359BD21 VA: 0x359BC20
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_short : Datatype_int // TypeDefIndex: 1885
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x359CA50 Offset: 0x359CB51 VA: 0x359CA50 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359CAC0 Offset: 0x359CBC1 VA: 0x359CAC0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359CAD0 Offset: 0x359CBD1 VA: 0x359CAD0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x359CB70 Offset: 0x359CC71 VA: 0x359CB70 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x359CBE0 Offset: 0x359CCE1 VA: 0x359CBE0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x359CC50 Offset: 0x359CD51 VA: 0x359CC50 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3591B20 Offset: 0x3591C21 VA: 0x3591B20
	public void .ctor() { }

	// RVA: 0x359CDC0 Offset: 0x359CEC1 VA: 0x359CDC0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_byte : Datatype_short // TypeDefIndex: 1886
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x35983E0 Offset: 0x35984E1 VA: 0x35983E0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3598450 Offset: 0x3598551 VA: 0x3598450 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3598460 Offset: 0x3598561 VA: 0x3598460 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x3598500 Offset: 0x3598601 VA: 0x3598500 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3598570 Offset: 0x3598671 VA: 0x3598570 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x35985E0 Offset: 0x35986E1 VA: 0x35985E0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3590980 Offset: 0x3590A81 VA: 0x3590980
	public void .ctor() { }

	// RVA: 0x3598750 Offset: 0x3598851 VA: 0x3598750
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_nonNegativeInteger : Datatype_integer // TypeDefIndex: 1887
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x359C560 Offset: 0x359C661 VA: 0x359C560 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359C5D0 Offset: 0x359C6D1 VA: 0x359C5D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359C5E0 Offset: 0x359C6E1 VA: 0x359C5E0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x3591770 Offset: 0x3591871 VA: 0x3591770
	public void .ctor() { }

	// RVA: 0x359C5F0 Offset: 0x359C6F1 VA: 0x359C5F0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedLong : Datatype_nonNegativeInteger // TypeDefIndex: 1888
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x359E590 Offset: 0x359E691 VA: 0x359E590 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359E600 Offset: 0x359E701 VA: 0x359E600 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359E610 Offset: 0x359E711 VA: 0x359E610 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x359E6B0 Offset: 0x359E7B1 VA: 0x359E6B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x359E720 Offset: 0x359E821 VA: 0x359E720 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x359E790 Offset: 0x359E891 VA: 0x359E790 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3591E80 Offset: 0x3591F81 VA: 0x3591E80
	public void .ctor() { }

	// RVA: 0x359E950 Offset: 0x359EA51 VA: 0x359E950
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedInt : Datatype_unsignedLong // TypeDefIndex: 1889
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x359E090 Offset: 0x359E191 VA: 0x359E090 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359E100 Offset: 0x359E201 VA: 0x359E100 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359E110 Offset: 0x359E211 VA: 0x359E110 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x359E1B0 Offset: 0x359E2B1 VA: 0x359E1B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x359E220 Offset: 0x359E321 VA: 0x359E220 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x359E290 Offset: 0x359E391 VA: 0x359E290 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3591E10 Offset: 0x3591F11 VA: 0x3591E10
	public void .ctor() { }

	// RVA: 0x359E400 Offset: 0x359E501 VA: 0x359E400
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedShort : Datatype_unsignedInt // TypeDefIndex: 1890
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x359EAE0 Offset: 0x359EBE1 VA: 0x359EAE0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359EB50 Offset: 0x359EC51 VA: 0x359EB50 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359EB60 Offset: 0x359EC61 VA: 0x359EB60 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x359EC00 Offset: 0x359ED01 VA: 0x359EC00 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x359EC70 Offset: 0x359ED71 VA: 0x359EC70 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x359ECE0 Offset: 0x359EDE1 VA: 0x359ECE0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3591F30 Offset: 0x3592031 VA: 0x3591F30
	public void .ctor() { }

	// RVA: 0x359EE50 Offset: 0x359EF51 VA: 0x359EE50
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedByte : Datatype_unsignedShort // TypeDefIndex: 1891
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x359DB90 Offset: 0x359DC91 VA: 0x359DB90 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359DC00 Offset: 0x359DD01 VA: 0x359DC00 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x359DC10 Offset: 0x359DD11 VA: 0x359DC10 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x359DCB0 Offset: 0x359DDB1 VA: 0x359DCB0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x359DD20 Offset: 0x359DE21 VA: 0x359DD20 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x359DD90 Offset: 0x359DE91 VA: 0x359DD90 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3591DA0 Offset: 0x3591EA1 VA: 0x3591DA0
	public void .ctor() { }

	// RVA: 0x359DF00 Offset: 0x359E001 VA: 0x359DF00
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_positiveInteger : Datatype_nonNegativeInteger // TypeDefIndex: 1892
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x359C8D0 Offset: 0x359C9D1 VA: 0x359C8D0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x359C940 Offset: 0x359CA41 VA: 0x359C940 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3591910 Offset: 0x3591A11 VA: 0x3591910
	public void .ctor() { }

	// RVA: 0x359C950 Offset: 0x359CA51 VA: 0x359C950
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_doubleXdr : Datatype_double // TypeDefIndex: 1893
{
	// Methods

	// RVA: 0x359A190 Offset: 0x359A291 VA: 0x359A190 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x3590E70 Offset: 0x3590F71 VA: 0x3590E70
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_floatXdr : Datatype_float // TypeDefIndex: 1894
{
	// Methods

	// RVA: 0x359B140 Offset: 0x359B241 VA: 0x359B140 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x35912D0 Offset: 0x35913D1 VA: 0x35912D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_QNameXdr : Datatype_anySimpleType // TypeDefIndex: 1895
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x3596D00 Offset: 0x3596E01 VA: 0x3596D00 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x3596D10 Offset: 0x3596E11 VA: 0x3596D10 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x3596F80 Offset: 0x3597081 VA: 0x3596F80 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3596FF0 Offset: 0x35970F1 VA: 0x3596FF0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3591A70 Offset: 0x3591B71 VA: 0x3591A70
	public void .ctor() { }

	// RVA: 0x3597060 Offset: 0x3597161 VA: 0x3597060
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_ENUMERATION : Datatype_NMTOKEN // TypeDefIndex: 1896
{
	// Properties
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x3594DF0 Offset: 0x3594EF1 VA: 0x3594DF0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x35911A0 Offset: 0x35912A1 VA: 0x35911A0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_char : Datatype_anySimpleType // TypeDefIndex: 1897
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x35988B0 Offset: 0x35989B1 VA: 0x35988B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3598920 Offset: 0x3598A21 VA: 0x3598920 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x3598990 Offset: 0x3598A91 VA: 0x3598990 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x35989A0 Offset: 0x3598AA1 VA: 0x35989A0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x3598A40 Offset: 0x3598B41 VA: 0x3598A40 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x3598C10 Offset: 0x3598D11 VA: 0x3598C10 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3590A30 Offset: 0x3590B31 VA: 0x3590A30
	public void .ctor() { }

	// RVA: 0x3598CF0 Offset: 0x3598DF1 VA: 0x3598CF0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_fixed : Datatype_decimal // TypeDefIndex: 1898
{
	// Methods

	// RVA: 0x359A8D0 Offset: 0x359A9D1 VA: 0x359A8D0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x359AB60 Offset: 0x359AC61 VA: 0x359AB60 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x35911B0 Offset: 0x35912B1 VA: 0x35911B0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_uuid : Datatype_anySimpleType // TypeDefIndex: 1899
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x359F070 Offset: 0x359F171 VA: 0x359F070 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x359F0E0 Offset: 0x359F1E1 VA: 0x359F0E0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x359F150 Offset: 0x359F251 VA: 0x359F150 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x359F160 Offset: 0x359F261 VA: 0x359F160 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x359F210 Offset: 0x359F311 VA: 0x359F210 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x359F3F0 Offset: 0x359F4F1 VA: 0x359F3F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3591FE0 Offset: 0x35920E1 VA: 0x3591FE0
	public void .ctor() { }

	// RVA: 0x359F4D0 Offset: 0x359F5D1 VA: 0x359F4D0
	private static void .cctor() { }
}

