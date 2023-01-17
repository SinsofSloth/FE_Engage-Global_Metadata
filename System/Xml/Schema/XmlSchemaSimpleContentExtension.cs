// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContentExtension : XmlSchemaContent // TypeDefIndex: 2032
{
	// Fields
	private XmlSchemaObjectCollection attributes; // 0x50
	private XmlSchemaAnyAttribute anyAttribute; // 0x58
	private XmlQualifiedName baseTypeName; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x4AE10 Offset: 0x4AF11 VA: 0x4AE10
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x4AE50 Offset: 0x4AF51 VA: 0x4AE50
	[XmlElementAttribute] // RVA: 0x4AE50 Offset: 0x4AF51 VA: 0x4AE50
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x4AF20 Offset: 0x4B021 VA: 0x4AF20
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x1971240 Offset: 0x1971341 VA: 0x1971240
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1962F30 Offset: 0x1963031 VA: 0x1962F30
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x1971250 Offset: 0x1971351 VA: 0x1971250
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1971260 Offset: 0x1971361 VA: 0x1971260
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1971270 Offset: 0x1971371 VA: 0x1971270
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1971280 Offset: 0x1971381 VA: 0x1971280
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1971290 Offset: 0x1971391 VA: 0x1971290
	public void .ctor() { }
}

