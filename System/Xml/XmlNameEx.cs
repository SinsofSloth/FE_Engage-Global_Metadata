// Namespace: System.Xml
internal sealed class XmlNameEx : XmlName // TypeDefIndex: 1705
{
	// Fields
	private byte flags; // 0x48
	private XmlSchemaSimpleType memberType; // 0x50
	private XmlSchemaType schemaType; // 0x58
	private object decl; // 0x60

	// Properties
	public override XmlSchemaValidity Validity { get; }
	public override bool IsDefault { get; }
	public override bool IsNil { get; }
	public override XmlSchemaSimpleType MemberType { get; }
	public override XmlSchemaType SchemaType { get; }
	public override XmlSchemaElement SchemaElement { get; }
	public override XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x32F6050 Offset: 0x32F6151 VA: 0x32F6050
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x32F6640 Offset: 0x32F6741 VA: 0x32F6640 Slot: 11
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x32F6660 Offset: 0x32F6761 VA: 0x32F6660 Slot: 12
	public override bool get_IsDefault() { }

	// RVA: 0x32F6670 Offset: 0x32F6771 VA: 0x32F6670 Slot: 13
	public override bool get_IsNil() { }

	// RVA: 0x32F6680 Offset: 0x32F6781 VA: 0x32F6680 Slot: 14
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x32F6690 Offset: 0x32F6791 VA: 0x32F6690 Slot: 15
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x32F66A0 Offset: 0x32F67A1 VA: 0x32F66A0 Slot: 16
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x32F6730 Offset: 0x32F6831 VA: 0x32F6730 Slot: 17
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x32F65E0 Offset: 0x32F66E1 VA: 0x32F65E0
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x32F6600 Offset: 0x32F6701 VA: 0x32F6600
	public void SetIsDefault(bool value) { }

	// RVA: 0x32F6620 Offset: 0x32F6721 VA: 0x32F6620
	public void SetIsNil(bool value) { }

	// RVA: 0x32F67C0 Offset: 0x32F68C1 VA: 0x32F67C0 Slot: 18
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }
}

