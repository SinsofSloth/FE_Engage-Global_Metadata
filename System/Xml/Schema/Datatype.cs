// Namespace: System.Xml.Schema
internal class Datatype_uuid : Datatype_anySimpleType // TypeDefIndex: 1899
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x359F070 Offset: 0x359F171 VA: 0x359F070 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x359F0E0 Offset: 0x359F1E1 VA: 0x359F0E0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x359F150 Offset: 0x359F251 VA: 0x359F150 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x359F160 Offset: 0x359F261 VA: 0x359F160 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x359F210 Offset: 0x359F311 VA: 0x359F210 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x359F3F0 Offset: 0x359F4F1 VA: 0x359F3F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x3591FE0 Offset: 0x35920E1 VA: 0x3591FE0
	public void .ctor() { }

	// RVA: 0x359F4D0 Offset: 0x359F5D1 VA: 0x359F4D0
	private static void .cctor() { }
}

