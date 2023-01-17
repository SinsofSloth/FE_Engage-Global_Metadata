// Namespace: System.Xml.Schema
internal class XmlUntypedConverter : XmlListConverter // TypeDefIndex: 2060
{
	// Fields
	private bool allowListToList; // 0x30
	public static readonly XmlValueConverter Untyped; // 0x0
	public static readonly XmlValueConverter UntypedList; // 0x8

	// Methods

	// RVA: 0x19EE620 Offset: 0x19EE721 VA: 0x19EE620
	protected void .ctor() { }

	// RVA: 0x19EE700 Offset: 0x19EE801 VA: 0x19EE700
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0x19EE7C0 Offset: 0x19EE8C1 VA: 0x19EE7C0 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x19EE870 Offset: 0x19EE971 VA: 0x19EE870 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x19EEBD0 Offset: 0x19EECD1 VA: 0x19EEBD0 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x19EEC80 Offset: 0x19EED81 VA: 0x19EEC80 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x19EEE60 Offset: 0x19EEF61 VA: 0x19EEE60 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x19EEF10 Offset: 0x19EF011 VA: 0x19EEF10 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x19EF0F0 Offset: 0x19EF1F1 VA: 0x19EF0F0 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x19EF1A0 Offset: 0x19EF2A1 VA: 0x19EF1A0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x19EF3A0 Offset: 0x19EF4A1 VA: 0x19EF3A0 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x19EF450 Offset: 0x19EF551 VA: 0x19EF450 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x19EF650 Offset: 0x19EF751 VA: 0x19EF650 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x19EF700 Offset: 0x19EF801 VA: 0x19EF700 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x19EF900 Offset: 0x19EFA01 VA: 0x19EF900 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x19EF9B0 Offset: 0x19EFAB1 VA: 0x19EF9B0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x19EFBB0 Offset: 0x19EFCB1 VA: 0x19EFBB0 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x19EFC60 Offset: 0x19EFD61 VA: 0x19EFC60 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x19EFE60 Offset: 0x19EFF61 VA: 0x19EFE60 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x19EFED0 Offset: 0x19EFFD1 VA: 0x19EFED0 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x19EFF40 Offset: 0x19F0041 VA: 0x19EFF40 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x19EFFC0 Offset: 0x19F00C1 VA: 0x19EFFC0 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x19F0040 Offset: 0x19F0141 VA: 0x19F0040 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x19F00B0 Offset: 0x19F01B1 VA: 0x19F00B0 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x19F0120 Offset: 0x19F0221 VA: 0x19F0120 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x19F0190 Offset: 0x19F0291 VA: 0x19F0190 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x19F0200 Offset: 0x19F0301 VA: 0x19F0200 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x19F11C0 Offset: 0x19F12C1 VA: 0x19F11C0 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x19F1590 Offset: 0x19F1691 VA: 0x19F1590 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x19F1790 Offset: 0x19F1891 VA: 0x19F1790 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x19F19C0 Offset: 0x19F1AC1 VA: 0x19F19C0 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x19F1BE0 Offset: 0x19F1CE1 VA: 0x19F1BE0 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x19F1E00 Offset: 0x19F1F01 VA: 0x19F1E00 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x19F2020 Offset: 0x19F2121 VA: 0x19F2020 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x19F2E70 Offset: 0x19F2F71 VA: 0x19F2E70 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x19EEA70 Offset: 0x19EEB71 VA: 0x19EEA70
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x19F13E0 Offset: 0x19F14E1 VA: 0x19F13E0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x19F4760 Offset: 0x19F4861 VA: 0x19F4760 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x19F4A50 Offset: 0x19F4B51 VA: 0x19F4A50
	private bool SupportsType(Type clrType) { }

	// RVA: 0x19F5060 Offset: 0x19F5161 VA: 0x19F5060
	private static void .cctor() { }
}

