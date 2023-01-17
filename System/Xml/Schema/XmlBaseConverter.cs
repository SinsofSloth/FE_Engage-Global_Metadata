// Namespace: System.Xml.Schema
internal abstract class XmlBaseConverter : XmlValueConverter // TypeDefIndex: 2053
{
	// Fields
	private XmlSchemaType schemaType; // 0x10
	private XmlTypeCode typeCode; // 0x18
	private Type clrTypeDefault; // 0x20
	protected static readonly Type ICollectionType; // 0x0
	protected static readonly Type IEnumerableType; // 0x8
	protected static readonly Type IListType; // 0x10
	protected static readonly Type ObjectArrayType; // 0x18
	protected static readonly Type StringArrayType; // 0x20
	protected static readonly Type XmlAtomicValueArrayType; // 0x28
	protected static readonly Type DecimalType; // 0x30
	protected static readonly Type Int32Type; // 0x38
	protected static readonly Type Int64Type; // 0x40
	protected static readonly Type StringType; // 0x48
	protected static readonly Type XmlAtomicValueType; // 0x50
	protected static readonly Type ObjectType; // 0x58
	protected static readonly Type ByteType; // 0x60
	protected static readonly Type Int16Type; // 0x68
	protected static readonly Type SByteType; // 0x70
	protected static readonly Type UInt16Type; // 0x78
	protected static readonly Type UInt32Type; // 0x80
	protected static readonly Type UInt64Type; // 0x88
	protected static readonly Type XPathItemType; // 0x90
	protected static readonly Type DoubleType; // 0x98
	protected static readonly Type SingleType; // 0xA0
	protected static readonly Type DateTimeType; // 0xA8
	protected static readonly Type DateTimeOffsetType; // 0xB0
	protected static readonly Type BooleanType; // 0xB8
	protected static readonly Type ByteArrayType; // 0xC0
	protected static readonly Type XmlQualifiedNameType; // 0xC8
	protected static readonly Type UriType; // 0xD0
	protected static readonly Type TimeSpanType; // 0xD8
	protected static readonly Type XPathNavigatorType; // 0xE0

	// Properties
	protected XmlSchemaType SchemaType { get; }
	protected XmlTypeCode TypeCode { get; }
	protected string XmlTypeName { get; }
	protected Type DefaultClrType { get; }

	// Methods

	// RVA: 0x1A97FE0 Offset: 0x1A980E1 VA: 0x1A97FE0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1A8EAC0 Offset: 0x1A8EBC1 VA: 0x1A8EAC0
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1A980E0 Offset: 0x1A981E1 VA: 0x1A980E0
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x1A98150 Offset: 0x1A98251 VA: 0x1A98150
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x1A981B0 Offset: 0x1A982B1 VA: 0x1A981B0 Slot: 7
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x1A982B0 Offset: 0x1A983B1 VA: 0x1A982B0 Slot: 6
	public override bool ToBoolean(double value) { }

	// RVA: 0x1A983B0 Offset: 0x1A984B1 VA: 0x1A983B0 Slot: 5
	public override bool ToBoolean(int value) { }

	// RVA: 0x1A984B0 Offset: 0x1A985B1 VA: 0x1A984B0 Slot: 4
	public override bool ToBoolean(long value) { }

	// RVA: 0x1A985B0 Offset: 0x1A986B1 VA: 0x1A985B0 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1A98680 Offset: 0x1A98781 VA: 0x1A98680 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1A98750 Offset: 0x1A98851 VA: 0x1A98750 Slot: 33
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x1A98850 Offset: 0x1A98951 VA: 0x1A98850 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1A98960 Offset: 0x1A98A61 VA: 0x1A98960 Slot: 36
	public override DateTime ToDateTime(double value) { }

	// RVA: 0x1A98A60 Offset: 0x1A98B61 VA: 0x1A98A60 Slot: 34
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x1A98B60 Offset: 0x1A98C61 VA: 0x1A98B60 Slot: 35
	public override DateTime ToDateTime(long value) { }

	// RVA: 0x1A98C60 Offset: 0x1A98D61 VA: 0x1A98C60 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1A98D30 Offset: 0x1A98E31 VA: 0x1A98D30 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1A98E00 Offset: 0x1A98F01 VA: 0x1A98E00 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1A98F10 Offset: 0x1A99011 VA: 0x1A98F10 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1A98FF0 Offset: 0x1A990F1 VA: 0x1A98FF0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1A990D0 Offset: 0x1A991D1 VA: 0x1A990D0 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1A991B0 Offset: 0x1A992B1 VA: 0x1A991B0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1A99290 Offset: 0x1A99391 VA: 0x1A99290 Slot: 24
	public override double ToDouble(bool value) { }

	// RVA: 0x1A99390 Offset: 0x1A99491 VA: 0x1A99390 Slot: 27
	public override double ToDouble(DateTime value) { }

	// RVA: 0x1A99490 Offset: 0x1A99591 VA: 0x1A99490 Slot: 25
	public override double ToDouble(int value) { }

	// RVA: 0x1A99590 Offset: 0x1A99691 VA: 0x1A99590 Slot: 26
	public override double ToDouble(long value) { }

	// RVA: 0x1A99690 Offset: 0x1A99791 VA: 0x1A99690 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1A99760 Offset: 0x1A99861 VA: 0x1A99760 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1A99830 Offset: 0x1A99931 VA: 0x1A99830 Slot: 10
	public override int ToInt32(bool value) { }

	// RVA: 0x1A99930 Offset: 0x1A99A31 VA: 0x1A99930 Slot: 13
	public override int ToInt32(DateTime value) { }

	// RVA: 0x1A99A30 Offset: 0x1A99B31 VA: 0x1A99A30 Slot: 12
	public override int ToInt32(double value) { }

	// RVA: 0x1A99B30 Offset: 0x1A99C31 VA: 0x1A99B30 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x1A99C30 Offset: 0x1A99D31 VA: 0x1A99C30 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1A99D00 Offset: 0x1A99E01 VA: 0x1A99D00 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1A99DD0 Offset: 0x1A99ED1 VA: 0x1A99DD0 Slot: 16
	public override long ToInt64(bool value) { }

	// RVA: 0x1A99ED0 Offset: 0x1A99FD1 VA: 0x1A99ED0 Slot: 19
	public override long ToInt64(DateTime value) { }

	// RVA: 0x1A99FD0 Offset: 0x1A9A0D1 VA: 0x1A99FD0 Slot: 18
	public override long ToInt64(double value) { }

	// RVA: 0x1A9A0D0 Offset: 0x1A9A1D1 VA: 0x1A9A0D0 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1A9A1D0 Offset: 0x1A9A2D1 VA: 0x1A9A1D0 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1A9A2A0 Offset: 0x1A9A3A1 VA: 0x1A9A2A0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1A9A370 Offset: 0x1A9A471 VA: 0x1A9A370 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1A9A470 Offset: 0x1A9A571 VA: 0x1A9A470 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1A9A540 Offset: 0x1A9A641 VA: 0x1A9A540 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1A9A610 Offset: 0x1A9A711 VA: 0x1A9A610 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1A9A700 Offset: 0x1A9A801 VA: 0x1A9A700 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1A9A7F0 Offset: 0x1A9A8F1 VA: 0x1A9A7F0 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1A9A8F0 Offset: 0x1A9A9F1 VA: 0x1A9A8F0 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1A9A9F0 Offset: 0x1A9AAF1 VA: 0x1A9A9F0 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1A9AAE0 Offset: 0x1A9ABE1 VA: 0x1A9AAE0 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1A9ABD0 Offset: 0x1A9ACD1 VA: 0x1A9ABD0 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1A9ACC0 Offset: 0x1A9ADC1 VA: 0x1A9ACC0 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1A9ADB0 Offset: 0x1A9AEB1 VA: 0x1A9ADB0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A9AE80 Offset: 0x1A9AF81 VA: 0x1A9AE80 Slot: 51
	public override string ToString(object value) { }

	// RVA: 0x1A9AEA0 Offset: 0x1A9AFA1 VA: 0x1A9AEA0 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1A9AF30 Offset: 0x1A9B031 VA: 0x1A9AF30 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1A9AFC0 Offset: 0x1A9B0C1 VA: 0x1A9AFC0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1A9B060 Offset: 0x1A9B161 VA: 0x1A9B060 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1A9B0F0 Offset: 0x1A9B1F1 VA: 0x1A9B0F0 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1A9B180 Offset: 0x1A9B281 VA: 0x1A9B180 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1A9B210 Offset: 0x1A9B311 VA: 0x1A9B210 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A9B220 Offset: 0x1A9B321 VA: 0x1A9B220 Slot: 60
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x1A9B240 Offset: 0x1A9B341 VA: 0x1A9B240
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x1A9B250 Offset: 0x1A9B351 VA: 0x1A9B250
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x1A9B260 Offset: 0x1A9B361 VA: 0x1A9B260
	protected string get_XmlTypeName() { }

	// RVA: 0x1A9B4B0 Offset: 0x1A9B5B1 VA: 0x1A9B4B0
	protected Type get_DefaultClrType() { }

	// RVA: 0x1A92840 Offset: 0x1A92941 VA: 0x1A92840
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x1A92C10 Offset: 0x1A92D11 VA: 0x1A92C10
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x1A9B390 Offset: 0x1A9B491 VA: 0x1A9B390
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x1A9B4C0 Offset: 0x1A9B5C1 VA: 0x1A9B4C0 Slot: 62
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A9B510 Offset: 0x1A9B611 VA: 0x1A9B510
	protected static byte[] StringToBase64Binary(string value) { }

	// RVA: 0x1A9B690 Offset: 0x1A9B791 VA: 0x1A9B690
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x1A9B720 Offset: 0x1A9B821 VA: 0x1A9B720
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x1A9B7B0 Offset: 0x1A9B8B1 VA: 0x1A9B7B0
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x1A9B820 Offset: 0x1A9B921 VA: 0x1A9B820
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x1A9B890 Offset: 0x1A9B991 VA: 0x1A9B890
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x1A9B920 Offset: 0x1A9BA21 VA: 0x1A9B920
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x1A9B9B0 Offset: 0x1A9BAB1 VA: 0x1A9B9B0
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x1A9BA40 Offset: 0x1A9BB41 VA: 0x1A9BA40
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x1A9BAD0 Offset: 0x1A9BBD1 VA: 0x1A9BAD0
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x1A9BB60 Offset: 0x1A9BC61 VA: 0x1A9BB60
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x1A9BBF0 Offset: 0x1A9BCF1 VA: 0x1A9BBF0
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x1A9BC80 Offset: 0x1A9BD81 VA: 0x1A9BC80
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x1A9BD10 Offset: 0x1A9BE11 VA: 0x1A9BD10
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x1A9BDA0 Offset: 0x1A9BEA1 VA: 0x1A9BDA0
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x1A9BE30 Offset: 0x1A9BF31 VA: 0x1A9BE30
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x1A9BEC0 Offset: 0x1A9BFC1 VA: 0x1A9BEC0
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x1A9BF50 Offset: 0x1A9C051 VA: 0x1A9BF50
	protected static byte[] StringToHexBinary(string value) { }

	// RVA: 0x1A9C150 Offset: 0x1A9C251 VA: 0x1A9C150
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A9C3F0 Offset: 0x1A9C4F1 VA: 0x1A9C3F0
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x1A9C480 Offset: 0x1A9C581 VA: 0x1A9C480
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x1A9C510 Offset: 0x1A9C611 VA: 0x1A9C510
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x1A9C580 Offset: 0x1A9C681 VA: 0x1A9C580
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x1A9C590 Offset: 0x1A9C691 VA: 0x1A9C590
	protected static string Base64BinaryToString(byte[] value) { }

	// RVA: 0x1A9C600 Offset: 0x1A9C701 VA: 0x1A9C600
	protected static string DateToString(DateTime value) { }

	// RVA: 0x1A9C650 Offset: 0x1A9C751 VA: 0x1A9C650
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x1A9C6A0 Offset: 0x1A9C7A1 VA: 0x1A9C6A0
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x1A9C710 Offset: 0x1A9C811 VA: 0x1A9C710
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x1A9C780 Offset: 0x1A9C881 VA: 0x1A9C780
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x1A9C7D0 Offset: 0x1A9C8D1 VA: 0x1A9C7D0
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x1A9C820 Offset: 0x1A9C921 VA: 0x1A9C820
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x1A9C870 Offset: 0x1A9C971 VA: 0x1A9C870
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x1A9C8C0 Offset: 0x1A9C9C1 VA: 0x1A9C8C0
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x1A9C910 Offset: 0x1A9CA11 VA: 0x1A9C910
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1A9C960 Offset: 0x1A9CA61 VA: 0x1A9C960
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1A9C9B0 Offset: 0x1A9CAB1 VA: 0x1A9C9B0
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1A9CA00 Offset: 0x1A9CB01 VA: 0x1A9CA00
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1A9CA50 Offset: 0x1A9CB51 VA: 0x1A9CA50
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1A9CAA0 Offset: 0x1A9CBA1 VA: 0x1A9CAA0
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1A9CAF0 Offset: 0x1A9CBF1 VA: 0x1A9CAF0
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1A9CB40 Offset: 0x1A9CC41 VA: 0x1A9CB40
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A9CD40 Offset: 0x1A9CE41 VA: 0x1A9CD40
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x1A9CD90 Offset: 0x1A9CE91 VA: 0x1A9CD90
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1A9CDE0 Offset: 0x1A9CEE1 VA: 0x1A9CDE0
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x1A9CE50 Offset: 0x1A9CF51 VA: 0x1A9CE50
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x1A9CE80 Offset: 0x1A9CF81 VA: 0x1A9CE80
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x1A9D0D0 Offset: 0x1A9D1D1 VA: 0x1A9D0D0
	protected static long DecimalToInt64(Decimal value) { }

	// RVA: 0x1A9D2E0 Offset: 0x1A9D3E1 VA: 0x1A9D2E0
	protected static ulong DecimalToUInt64(Decimal value) { }

	// RVA: 0x1A9D4E0 Offset: 0x1A9D5E1 VA: 0x1A9D4E0
	protected static byte Int32ToByte(int value) { }

	// RVA: 0x1A9D640 Offset: 0x1A9D741 VA: 0x1A9D640
	protected static short Int32ToInt16(int value) { }

	// RVA: 0x1A9D760 Offset: 0x1A9D861 VA: 0x1A9D760
	protected static sbyte Int32ToSByte(int value) { }

	// RVA: 0x1A9D880 Offset: 0x1A9D981 VA: 0x1A9D880
	protected static ushort Int32ToUInt16(int value) { }

	// RVA: 0x1A9D9A0 Offset: 0x1A9DAA1 VA: 0x1A9D9A0
	protected static int Int64ToInt32(long value) { }

	// RVA: 0x1A9DB00 Offset: 0x1A9DC01 VA: 0x1A9DB00
	protected static uint Int64ToUInt32(long value) { }

	// RVA: 0x1A9DC20 Offset: 0x1A9DD21 VA: 0x1A9DC20
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x1A9DCB0 Offset: 0x1A9DDB1 VA: 0x1A9DCB0
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x1A9DD40 Offset: 0x1A9DE41 VA: 0x1A9DD40
	private static void .cctor() { }
}

