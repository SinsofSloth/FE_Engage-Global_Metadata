// Namespace: System.Xml.Schema
internal class XmlListConverter : XmlBaseConverter // TypeDefIndex: 2063
{
	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x32EDA80 Offset: 0x32EDB81 VA: 0x32EDA80
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x32EDB10 Offset: 0x32EDC11 VA: 0x32EDB10
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x32EDBB0 Offset: 0x32EDCB1 VA: 0x32EDBB0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x32EDC30 Offset: 0x32EDD31 VA: 0x32EDC30
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x32EDE90 Offset: 0x32EDF91 VA: 0x32EDE90 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32EDFB0 Offset: 0x32EE0B1 VA: 0x32EDFB0 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32EEF50 Offset: 0x32EF051 VA: 0x32EEF50
	private bool IsListType(Type type) { }

	// RVA: -1 Offset: -1
	private T[] ToArray<T>(object list, IXmlNamespaceResolver nsResolver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38729F0 Offset: 0x3872AF1 VA: 0x38729F0
	|-XmlListConverter.ToArray<byte[]>
	|-XmlListConverter.ToArray<object>
	|-XmlListConverter.ToArray<string>
	|-XmlListConverter.ToArray<Uri>
	|-XmlListConverter.ToArray<XPathItem>
	|-XmlListConverter.ToArray<XPathNavigator>
	|-XmlListConverter.ToArray<XmlAtomicValue>
	|-XmlListConverter.ToArray<XmlQualifiedName>
	|
	|-RVA: 0x386F1B0 Offset: 0x386F2B1 VA: 0x386F1B0
	|-XmlListConverter.ToArray<bool>
	|
	|-RVA: 0x386F7F0 Offset: 0x386F8F1 VA: 0x386F7F0
	|-XmlListConverter.ToArray<byte>
	|
	|-RVA: 0x386FE30 Offset: 0x386FF31 VA: 0x386FE30
	|-XmlListConverter.ToArray<DateTime>
	|
	|-RVA: 0x3870470 Offset: 0x3870571 VA: 0x3870470
	|-XmlListConverter.ToArray<DateTimeOffset>
	|
	|-RVA: 0x3870AB0 Offset: 0x3870BB1 VA: 0x3870AB0
	|-XmlListConverter.ToArray<Decimal>
	|
	|-RVA: 0x38710F0 Offset: 0x38711F1 VA: 0x38710F0
	|-XmlListConverter.ToArray<double>
	|
	|-RVA: 0x3871730 Offset: 0x3871831 VA: 0x3871730
	|-XmlListConverter.ToArray<short>
	|
	|-RVA: 0x3871D70 Offset: 0x3871E71 VA: 0x3871D70
	|-XmlListConverter.ToArray<int>
	|
	|-RVA: 0x38723B0 Offset: 0x38724B1 VA: 0x38723B0
	|-XmlListConverter.ToArray<long>
	|
	|-RVA: 0x3873030 Offset: 0x3873131 VA: 0x3873030
	|-XmlListConverter.ToArray<sbyte>
	|
	|-RVA: 0x3873670 Offset: 0x3873771 VA: 0x3873670
	|-XmlListConverter.ToArray<float>
	|
	|-RVA: 0x3873CB0 Offset: 0x3873DB1 VA: 0x3873CB0
	|-XmlListConverter.ToArray<TimeSpan>
	|
	|-RVA: 0x38742F0 Offset: 0x38743F1 VA: 0x38742F0
	|-XmlListConverter.ToArray<ushort>
	|
	|-RVA: 0x3874930 Offset: 0x3874A31 VA: 0x3874930
	|-XmlListConverter.ToArray<uint>
	|
	|-RVA: 0x3874F70 Offset: 0x3875071 VA: 0x3874F70
	|-XmlListConverter.ToArray<ulong>
	*/

	// RVA: 0x32EF790 Offset: 0x32EF891 VA: 0x32EF790
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32EF6D0 Offset: 0x32EF7D1 VA: 0x32EF6D0
	private List<string> StringAsList(string value) { }

	// RVA: 0x32EF3B0 Offset: 0x32EF4B1 VA: 0x32EF3B0
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32EF110 Offset: 0x32EF211 VA: 0x32EF110
	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }
}

