// Namespace: System.Xml.Schema
internal class XmlUnionConverter : XmlBaseConverter // TypeDefIndex: 2064
{
	// Fields
	private XmlValueConverter[] converters; // 0x28
	private bool hasAtomicMember; // 0x30
	private bool hasListMember; // 0x31

	// Methods

	// RVA: 0x19EDD20 Offset: 0x19EDE21 VA: 0x19EDD20
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x19EDF80 Offset: 0x19EE081 VA: 0x19EDF80
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x19EDFF0 Offset: 0x19EE0F1 VA: 0x19EDFF0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

