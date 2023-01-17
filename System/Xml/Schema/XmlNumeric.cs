// Namespace: System.Xml.Schema
internal class XmlNumeric2Converter : XmlBaseConverter // TypeDefIndex: 2055
{
	// Methods

	// RVA: 0x32FE490 Offset: 0x32FE591 VA: 0x32FE490
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x32FE510 Offset: 0x32FE611 VA: 0x32FE510
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x32FE5C0 Offset: 0x32FE6C1 VA: 0x32FE5C0 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x32FE6C0 Offset: 0x32FE7C1 VA: 0x32FE6C0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x32FEA40 Offset: 0x32FEB41 VA: 0x32FEA40 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x32FEA50 Offset: 0x32FEB51 VA: 0x32FEA50 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x32FEB50 Offset: 0x32FEC51 VA: 0x32FEB50 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x32FEEF0 Offset: 0x32FEFF1 VA: 0x32FEEF0 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x32FEFC0 Offset: 0x32FF0C1 VA: 0x32FEFC0 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x32FF070 Offset: 0x32FF171 VA: 0x32FF070 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32FF400 Offset: 0x32FF501 VA: 0x32FF400 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x32FF7D0 Offset: 0x32FF8D1 VA: 0x32FF7D0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x32FFBD0 Offset: 0x32FFCD1 VA: 0x32FFBD0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

