// Namespace: System.Xml.Schema
public sealed class XmlAtomicValue : XPathItem, ICloneable // TypeDefIndex: 1959
{
	// Fields
	private XmlSchemaType xmlType; // 0x10
	private object objVal; // 0x18
	private TypeCode clrType; // 0x20
	private XmlAtomicValue.Union unionVal; // 0x28
	private XmlAtomicValue.NamespacePrefixForQName nsPrefix; // 0x30

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override Type ValueType { get; }
	public override object TypedValue { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public override string Value { get; }

	// Methods

	// RVA: 0x1A8FE80 Offset: 0x1A8FF81 VA: 0x1A8FE80
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x1A902C0 Offset: 0x1A903C1 VA: 0x1A902C0
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x1A90880 Offset: 0x1A90981 VA: 0x1A90880
	internal void .ctor(XmlSchemaType xmlType, double value) { }

	// RVA: 0x1A90B30 Offset: 0x1A90C31 VA: 0x1A90B30
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x1A90DE0 Offset: 0x1A90EE1 VA: 0x1A90DE0
	internal void .ctor(XmlSchemaType xmlType, long value) { }

	// RVA: 0x1A910A0 Offset: 0x1A911A1 VA: 0x1A910A0
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x1A94C20 Offset: 0x1A94D21 VA: 0x1A94C20
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A905A0 Offset: 0x1A906A1 VA: 0x1A905A0
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x1A92930 Offset: 0x1A92A31 VA: 0x1A92930
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A94F00 Offset: 0x1A95001 VA: 0x1A94F00 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: 0x1A94F10 Offset: 0x1A95011 VA: 0x1A94F10 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x1A94F20 Offset: 0x1A95021 VA: 0x1A94F20 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x1A94F40 Offset: 0x1A95041 VA: 0x1A94F40 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x1A95100 Offset: 0x1A95201 VA: 0x1A95100 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x1A951E0 Offset: 0x1A952E1 VA: 0x1A951E0 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x1A952D0 Offset: 0x1A953D1 VA: 0x1A952D0 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x1A953C0 Offset: 0x1A954C1 VA: 0x1A953C0 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x1A954B0 Offset: 0x1A955B1 VA: 0x1A954B0 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x1A955A0 Offset: 0x1A956A1 VA: 0x1A955A0 Slot: 14
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1A957D0 Offset: 0x1A958D1 VA: 0x1A957D0 Slot: 5
	public override string get_Value() { }

	// RVA: 0x1A958D0 Offset: 0x1A959D1 VA: 0x1A958D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A94E10 Offset: 0x1A94F11 VA: 0x1A94E10
	private string GetPrefixFromQName(string value) { }
}

