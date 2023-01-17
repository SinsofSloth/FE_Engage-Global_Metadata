// Namespace: System.Xml.Schema
public class XmlSchemaComplexContentRestriction : XmlSchemaContent // TypeDefIndex: 1977
{
	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[XmlAttributeAttribute] // RVA: 0x49240 Offset: 0x49341 VA: 0x49240
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x49280 Offset: 0x49381 VA: 0x49280
	[XmlElementAttribute] // RVA: 0x49280 Offset: 0x49381 VA: 0x49280
	[XmlElementAttribute] // RVA: 0x49280 Offset: 0x49381 VA: 0x49280
	[XmlElementAttribute] // RVA: 0x49280 Offset: 0x49381 VA: 0x49280
	public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] // RVA: 0x493F0 Offset: 0x494F1 VA: 0x493F0
	[XmlElementAttribute] // RVA: 0x493F0 Offset: 0x494F1 VA: 0x493F0
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x494C0 Offset: 0x495C1 VA: 0x494C0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x1960DC0 Offset: 0x1960EC1 VA: 0x1960DC0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1960DD0 Offset: 0x1960ED1 VA: 0x1960DD0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x1960E80 Offset: 0x1960F81 VA: 0x1960E80
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x1960E90 Offset: 0x1960F91 VA: 0x1960E90
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x1960EA0 Offset: 0x1960FA1 VA: 0x1960EA0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1960EB0 Offset: 0x1960FB1 VA: 0x1960EB0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1960EC0 Offset: 0x1960FC1 VA: 0x1960EC0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1960ED0 Offset: 0x1960FD1 VA: 0x1960ED0
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1960EE0 Offset: 0x1960FE1 VA: 0x1960EE0
	public void .ctor() { }
}

