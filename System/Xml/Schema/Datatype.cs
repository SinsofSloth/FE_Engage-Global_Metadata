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
internal class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 1852
{
	// Methods

	// RVA: 0x3590BC0 Offset: 0x3590CC1 VA: 0x3590BC0
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
internal class Datatype_timeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 1856
{
	// Methods

	// RVA: 0x3591D20 Offset: 0x3591E21 VA: 0x3591D20
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
internal class Datatype_floatXdr : Datatype_float // TypeDefIndex: 1894
{
	// Methods

	// RVA: 0x359B140 Offset: 0x359B241 VA: 0x359B140 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x35912D0 Offset: 0x35913D1 VA: 0x35912D0
	public void .ctor() { }
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

