// Namespace: System.Xml.Schema
public interface IXmlSchemaInfo // TypeDefIndex: 1915
{
	// Properties
	public abstract XmlSchemaValidity Validity { get; }
	public abstract bool IsDefault { get; }
	public abstract bool IsNil { get; }
	public abstract XmlSchemaSimpleType MemberType { get; }
	public abstract XmlSchemaType SchemaType { get; }
	public abstract XmlSchemaElement SchemaElement { get; }
	public abstract XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlSchemaValidity get_Validity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsDefault();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsNil();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract XmlSchemaSimpleType get_MemberType();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract XmlSchemaType get_SchemaType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XmlSchemaElement get_SchemaElement();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlSchemaAttribute get_SchemaAttribute();
}

