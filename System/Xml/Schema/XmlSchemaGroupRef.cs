// Namespace: System.Xml.Schema
public class XmlSchemaGroupRef : XmlSchemaParticle // TypeDefIndex: 2007
{
	// Fields
	private XmlQualifiedName refName; // 0x78
	private XmlSchemaGroupBase particle; // 0x80
	private XmlSchemaGroup refined; // 0x88

	// Properties
	[XmlAttributeAttribute] // RVA: 0x4A4F0 Offset: 0x4A5F1 VA: 0x4A4F0
	public XmlQualifiedName RefName { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A530 Offset: 0x4A631 VA: 0x4A530
	internal XmlSchemaGroup Redefined { get; set; }

	// Methods

	// RVA: 0x1966C30 Offset: 0x1966D31 VA: 0x1966C30
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x19638D0 Offset: 0x19639D1 VA: 0x19638D0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x1966C40 Offset: 0x1966D41 VA: 0x1966C40
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x1966C50 Offset: 0x1966D51 VA: 0x1966C50
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x1966C60 Offset: 0x1966D61 VA: 0x1966C60
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x1966C70 Offset: 0x1966D71 VA: 0x1966C70
	public void .ctor() { }
}

