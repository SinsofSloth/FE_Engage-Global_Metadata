// Namespace: System.Xml.Schema
internal class XmlAnyConverter : XmlBaseConverter // TypeDefIndex: 2061
{
	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x1A8EA50 Offset: 0x1A8EB51 VA: 0x1A8EA50
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1A8EBD0 Offset: 0x1A8ECD1 VA: 0x1A8EBD0 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1A8EF10 Offset: 0x1A8F011 VA: 0x1A8EF10 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1A8F0F0 Offset: 0x1A8F1F1 VA: 0x1A8F0F0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1A8F2E0 Offset: 0x1A8F3E1 VA: 0x1A8F2E0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1A8F4D0 Offset: 0x1A8F5D1 VA: 0x1A8F4D0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1A8F6B0 Offset: 0x1A8F7B1 VA: 0x1A8F6B0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1A8F890 Offset: 0x1A8F991 VA: 0x1A8F890 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1A8FA70 Offset: 0x1A8FB71 VA: 0x1A8FA70 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1A8FC60 Offset: 0x1A8FD61 VA: 0x1A8FC60 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1A900B0 Offset: 0x1A901B1 VA: 0x1A900B0 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1A90360 Offset: 0x1A90461 VA: 0x1A90360 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1A90660 Offset: 0x1A90761 VA: 0x1A90660 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1A90920 Offset: 0x1A90A21 VA: 0x1A90920 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1A90BD0 Offset: 0x1A90CD1 VA: 0x1A90BD0 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1A90E80 Offset: 0x1A90F81 VA: 0x1A90E80 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A91160 Offset: 0x1A91261 VA: 0x1A91160 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A8EDB0 Offset: 0x1A8EEB1 VA: 0x1A8EDB0
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A8FF20 Offset: 0x1A90021 VA: 0x1A8FF20
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A92B50 Offset: 0x1A92C51 VA: 0x1A92B50
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x1A92EA0 Offset: 0x1A92FA1 VA: 0x1A92EA0
	private static void .cctor() { }
}

