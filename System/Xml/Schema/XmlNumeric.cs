// Namespace: System.Xml.Schema
internal class XmlNumeric10Converter : XmlBaseConverter // TypeDefIndex: 2054
{
	// Methods

	// RVA: 0x32FA040 Offset: 0x32FA141 VA: 0x32FA040
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x32FA0C0 Offset: 0x32FA1C1 VA: 0x32FA0C0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x32FA170 Offset: 0x32FA271 VA: 0x32FA170 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x32FA260 Offset: 0x32FA361 VA: 0x32FA260 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x32FAB90 Offset: 0x32FAC91 VA: 0x32FAB90 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x32FAC00 Offset: 0x32FAD01 VA: 0x32FAC00 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x32FAD40 Offset: 0x32FAE41 VA: 0x32FAD40 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x32FB190 Offset: 0x32FB291 VA: 0x32FB190 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x32FB1A0 Offset: 0x32FB2A1 VA: 0x32FB1A0 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x32FB2E0 Offset: 0x32FB3E1 VA: 0x32FB2E0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x32FB710 Offset: 0x32FB811 VA: 0x32FB710 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x32FB7E0 Offset: 0x32FB8E1 VA: 0x32FB7E0 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x32FB850 Offset: 0x32FB951 VA: 0x32FB850 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x32FB8C0 Offset: 0x32FB9C1 VA: 0x32FB8C0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32FBD30 Offset: 0x32FBE31 VA: 0x32FBD30 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x32FC690 Offset: 0x32FC791 VA: 0x32FC690 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x32FCB00 Offset: 0x32FCC01 VA: 0x32FCB00 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x32FCF80 Offset: 0x32FD081 VA: 0x32FCF80 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32FD3F0 Offset: 0x32FD4F1 VA: 0x32FD3F0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32FA6D0 Offset: 0x32FA7D1 VA: 0x32FA6D0
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32FC1C0 Offset: 0x32FC2C1 VA: 0x32FC1C0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

