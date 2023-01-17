// Namespace: System.Xml
internal class XmlName : IXmlSchemaInfo // TypeDefIndex: 1704
{
	// Fields
	private string prefix; // 0x10
	private string localName; // 0x18
	private string ns; // 0x20
	private string name; // 0x28
	private int hashCode; // 0x30
	internal XmlDocument ownerDoc; // 0x38
	internal XmlName next; // 0x40

	// Properties
	public string LocalName { get; }
	public string NamespaceURI { get; }
	public string Prefix { get; }
	public int HashCode { get; }
	public XmlDocument OwnerDocument { get; }
	public string Name { get; }
	public virtual XmlSchemaValidity Validity { get; }
	public virtual bool IsDefault { get; }
	public virtual bool IsNil { get; }
	public virtual XmlSchemaSimpleType MemberType { get; }
	public virtual XmlSchemaType SchemaType { get; }
	public virtual XmlSchemaElement SchemaElement { get; }
	public virtual XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x32F5E50 Offset: 0x32F5F51 VA: 0x32F5E50
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x32F5F90 Offset: 0x32F6091 VA: 0x32F5F90
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x32F64A0 Offset: 0x32F65A1 VA: 0x32F64A0
	public string get_LocalName() { }

	// RVA: 0x32F64B0 Offset: 0x32F65B1 VA: 0x32F64B0
	public string get_NamespaceURI() { }

	// RVA: 0x32F64C0 Offset: 0x32F65C1 VA: 0x32F64C0
	public string get_Prefix() { }

	// RVA: 0x32F64D0 Offset: 0x32F65D1 VA: 0x32F64D0
	public int get_HashCode() { }

	// RVA: 0x32F64E0 Offset: 0x32F65E1 VA: 0x32F64E0
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x32EA080 Offset: 0x32EA181 VA: 0x32EA080
	public string get_Name() { }

	// RVA: 0x32F64F0 Offset: 0x32F65F1 VA: 0x32F64F0 Slot: 11
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0x32F6500 Offset: 0x32F6601 VA: 0x32F6500 Slot: 12
	public virtual bool get_IsDefault() { }

	// RVA: 0x32F6510 Offset: 0x32F6611 VA: 0x32F6510 Slot: 13
	public virtual bool get_IsNil() { }

	// RVA: 0x32F6520 Offset: 0x32F6621 VA: 0x32F6520 Slot: 14
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x32F6530 Offset: 0x32F6631 VA: 0x32F6530 Slot: 15
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0x32F6540 Offset: 0x32F6641 VA: 0x32F6540 Slot: 16
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x32F6550 Offset: 0x32F6651 VA: 0x32F6550 Slot: 17
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x32F6560 Offset: 0x32F6661 VA: 0x32F6560 Slot: 18
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x32F6570 Offset: 0x32F6671 VA: 0x32F6570
	public static int GetHashCode(string name) { }
}

