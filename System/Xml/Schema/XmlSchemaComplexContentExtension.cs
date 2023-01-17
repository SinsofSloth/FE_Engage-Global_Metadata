// Namespace: System.Xml.Schema
public class XmlSchemaComplexContentExtension : XmlSchemaContent // TypeDefIndex: 1976
{
	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[XmlAttributeAttribute] // RVA: 0x48F80 Offset: 0x49081 VA: 0x48F80
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x48FC0 Offset: 0x490C1 VA: 0x48FC0
	[XmlElementAttribute] // RVA: 0x48FC0 Offset: 0x490C1 VA: 0x48FC0
	[XmlElementAttribute] // RVA: 0x48FC0 Offset: 0x490C1 VA: 0x48FC0
	[XmlElementAttribute] // RVA: 0x48FC0 Offset: 0x490C1 VA: 0x48FC0
	public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] // RVA: 0x49130 Offset: 0x49231 VA: 0x49130
	[XmlElementAttribute] // RVA: 0x49130 Offset: 0x49231 VA: 0x49130
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x49200 Offset: 0x49301 VA: 0x49200
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x1960BD0 Offset: 0x1960CD1 VA: 0x1960BD0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1960BE0 Offset: 0x1960CE1 VA: 0x1960BE0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x1960C90 Offset: 0x1960D91 VA: 0x1960C90
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x1960CA0 Offset: 0x1960DA1 VA: 0x1960CA0
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x1960CB0 Offset: 0x1960DB1 VA: 0x1960CB0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1960CC0 Offset: 0x1960DC1 VA: 0x1960CC0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1960CD0 Offset: 0x1960DD1 VA: 0x1960CD0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1960CE0 Offset: 0x1960DE1 VA: 0x1960CE0
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1960CF0 Offset: 0x1960DF1 VA: 0x1960CF0
	public void .ctor() { }
}

