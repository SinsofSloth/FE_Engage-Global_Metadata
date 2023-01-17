// Namespace: System.Xml.Schema
public class XmlSchemaInfo : IXmlSchemaInfo // TypeDefIndex: 2015
{
	// Fields
	private bool isDefault; // 0x10
	private bool isNil; // 0x11
	private XmlSchemaElement schemaElement; // 0x18
	private XmlSchemaAttribute schemaAttribute; // 0x20
	private XmlSchemaType schemaType; // 0x28
	private XmlSchemaSimpleType memberType; // 0x30
	private XmlSchemaValidity validity; // 0x38
	private XmlSchemaContentType contentType; // 0x3C

	// Properties
	public XmlSchemaValidity Validity { get; set; }
	public bool IsDefault { get; set; }
	public bool IsNil { get; set; }
	public XmlSchemaSimpleType MemberType { get; set; }
	public XmlSchemaType SchemaType { get; set; }
	public XmlSchemaElement SchemaElement { get; set; }
	public XmlSchemaAttribute SchemaAttribute { get; set; }
	internal XmlSchemaType XmlType { get; }
	internal bool HasDefaultValue { get; }
	internal bool IsUnionType { get; }

	// Methods

	// RVA: 0x1966F90 Offset: 0x1967091 VA: 0x1966F90
	public void .ctor() { }

	// RVA: 0x1967070 Offset: 0x1967171 VA: 0x1967070
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x19670F0 Offset: 0x19671F1 VA: 0x19670F0 Slot: 4
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0x1967100 Offset: 0x1967201 VA: 0x1967100
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x1967110 Offset: 0x1967211 VA: 0x1967110 Slot: 5
	public bool get_IsDefault() { }

	// RVA: 0x1967120 Offset: 0x1967221 VA: 0x1967120
	public void set_IsDefault(bool value) { }

	// RVA: 0x1967130 Offset: 0x1967231 VA: 0x1967130 Slot: 6
	public bool get_IsNil() { }

	// RVA: 0x1967140 Offset: 0x1967241 VA: 0x1967140
	public void set_IsNil(bool value) { }

	// RVA: 0x1967150 Offset: 0x1967251 VA: 0x1967150 Slot: 7
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x1967160 Offset: 0x1967261 VA: 0x1967160
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x1967170 Offset: 0x1967271 VA: 0x1967170 Slot: 8
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x1967180 Offset: 0x1967281 VA: 0x1967180
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x19671D0 Offset: 0x19672D1 VA: 0x19671D0 Slot: 9
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x19671E0 Offset: 0x19672E1 VA: 0x19671E0
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x1967230 Offset: 0x1967331 VA: 0x1967230 Slot: 10
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1967240 Offset: 0x1967341 VA: 0x1967240
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x1967290 Offset: 0x1967391 VA: 0x1967290
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x19672B0 Offset: 0x19673B1 VA: 0x19672B0
	internal bool get_HasDefaultValue() { }

	// RVA: 0x19672E0 Offset: 0x19673E1 VA: 0x19672E0
	internal bool get_IsUnionType() { }

	// RVA: 0x1967000 Offset: 0x1967101 VA: 0x1967000
	internal void Clear() { }
}

