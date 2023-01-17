// Namespace: System.Xml.Schema
internal class XmlMiscConverter : XmlBaseConverter // TypeDefIndex: 2058
{
	// Methods

	// RVA: 0x32F4000 Offset: 0x32F4101 VA: 0x32F4000
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x32F4080 Offset: 0x32F4181 VA: 0x32F4080
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x32F4130 Offset: 0x32F4231 VA: 0x32F4130 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32F4870 Offset: 0x32F4971 VA: 0x32F4870 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32F4FA0 Offset: 0x32F50A1 VA: 0x32F4FA0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32F4710 Offset: 0x32F4811 VA: 0x32F4710
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32F4E10 Offset: 0x32F4F11 VA: 0x32F4E10
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

