// Namespace: System.Xml.XPath
public abstract class XPathItem // TypeDefIndex: 1774
{
	// Properties
	public abstract XmlSchemaType XmlType { get; }
	public abstract string Value { get; }
	public abstract object TypedValue { get; }
	public abstract Type ValueType { get; }
	public abstract bool ValueAsBoolean { get; }
	public abstract DateTime ValueAsDateTime { get; }
	public abstract double ValueAsDouble { get; }
	public abstract int ValueAsInt { get; }
	public abstract long ValueAsLong { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract XmlSchemaType get_XmlType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object get_TypedValue();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_ValueAsBoolean();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DateTime get_ValueAsDateTime();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract double get_ValueAsDouble();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_ValueAsInt();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_ValueAsLong();

	// RVA: 0x19BE350 Offset: 0x19BE451 VA: 0x19BE350 Slot: 13
	public virtual object ValueAs(Type returnType) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver);

	// RVA: 0x19BE370 Offset: 0x19BE471 VA: 0x19BE370
	protected void .ctor() { }
}

