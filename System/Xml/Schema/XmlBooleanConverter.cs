// Namespace: System.Xml.Schema
internal class XmlBooleanConverter : XmlBaseConverter // TypeDefIndex: 2057
{
	// Methods

	// RVA: 0x1A9E3C0 Offset: 0x1A9E4C1 VA: 0x1A9E3C0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1A9E430 Offset: 0x1A9E531 VA: 0x1A9E430
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1A9E4E0 Offset: 0x1A9E5E1 VA: 0x1A9E4E0 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1A9E7E0 Offset: 0x1A9E8E1 VA: 0x1A9E7E0 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1A9EB00 Offset: 0x1A9EC01 VA: 0x1A9EB00 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1A9EC20 Offset: 0x1A9ED21 VA: 0x1A9EC20 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A9EF50 Offset: 0x1A9F051 VA: 0x1A9EF50 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1A9F2F0 Offset: 0x1A9F3F1 VA: 0x1A9F2F0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A9F670 Offset: 0x1A9F771 VA: 0x1A9F670 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

