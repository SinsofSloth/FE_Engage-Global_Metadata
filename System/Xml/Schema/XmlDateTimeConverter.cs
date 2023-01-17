// Namespace: System.Xml.Schema
internal class XmlDateTimeConverter : XmlBaseConverter // TypeDefIndex: 2056
{
	// Methods

	// RVA: 0x1AA57D0 Offset: 0x1AA58D1 VA: 0x1AA57D0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1AA5840 Offset: 0x1AA5941 VA: 0x1AA5840
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1AA58F0 Offset: 0x1AA59F1 VA: 0x1AA58F0 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1AA5970 Offset: 0x1AA5A71 VA: 0x1AA5970 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1AA5D20 Offset: 0x1AA5E21 VA: 0x1AA5D20 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1AA60C0 Offset: 0x1AA61C1 VA: 0x1AA60C0 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1AA60F0 Offset: 0x1AA61F1 VA: 0x1AA60F0 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1AA64A0 Offset: 0x1AA65A1 VA: 0x1AA64A0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1AA6850 Offset: 0x1AA6951 VA: 0x1AA6850 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1AA6A90 Offset: 0x1AA6B91 VA: 0x1AA6A90 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1AA6CF0 Offset: 0x1AA6DF1 VA: 0x1AA6CF0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1AA7080 Offset: 0x1AA7181 VA: 0x1AA7080 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1AA7450 Offset: 0x1AA7551 VA: 0x1AA7450 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1AA7840 Offset: 0x1AA7941 VA: 0x1AA7840 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

