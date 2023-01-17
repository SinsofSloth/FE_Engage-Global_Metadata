// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroup : XmlSchemaAnnotated // TypeDefIndex: 1968
{
	// Fields
	private string name; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaAttributeGroup redefined; // 0x70
	private XmlSchemaObjectTable attributeUses; // 0x78
	private XmlSchemaAnyAttribute attributeWildcard; // 0x80
	private int selfReferenceCount; // 0x88

	// Properties
	[XmlAttributeAttribute] // RVA: 0x48AC0 Offset: 0x48BC1 VA: 0x48AC0
	public string Name { get; set; }
	[XmlElementAttribute] // RVA: 0x48B00 Offset: 0x48C01 VA: 0x48B00
	[XmlElementAttribute] // RVA: 0x48B00 Offset: 0x48C01 VA: 0x48B00
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x48BD0 Offset: 0x48CD1 VA: 0x48BD0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x48C10 Offset: 0x48D11 VA: 0x48C10
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x48C20 Offset: 0x48D21 VA: 0x48C20
	internal XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnoreAttribute] // RVA: 0x48C30 Offset: 0x48D31 VA: 0x48C30
	internal XmlSchemaAnyAttribute AttributeWildcard { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x48C40 Offset: 0x48D41 VA: 0x48C40
	internal XmlSchemaAttributeGroup Redefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x48C50 Offset: 0x48D51 VA: 0x48C50
	internal int SelfReferenceCount { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x48C60 Offset: 0x48D61 VA: 0x48C60
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x195F1B0 Offset: 0x195F2B1 VA: 0x195F1B0
	public string get_Name() { }

	// RVA: 0x195F1C0 Offset: 0x195F2C1 VA: 0x195F1C0
	public void set_Name(string value) { }

	// RVA: 0x195F1D0 Offset: 0x195F2D1 VA: 0x195F1D0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x195F1E0 Offset: 0x195F2E1 VA: 0x195F1E0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x195F1F0 Offset: 0x195F2F1 VA: 0x195F1F0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x195F200 Offset: 0x195F301 VA: 0x195F200
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x195F210 Offset: 0x195F311 VA: 0x195F210
	internal XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x195F380 Offset: 0x195F481 VA: 0x195F380
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x195F390 Offset: 0x195F491 VA: 0x195F390
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x195F3A0 Offset: 0x195F4A1 VA: 0x195F3A0
	internal XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x195F3B0 Offset: 0x195F4B1 VA: 0x195F3B0
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x195F3C0 Offset: 0x195F4C1 VA: 0x195F3C0
	internal int get_SelfReferenceCount() { }

	// RVA: 0x195F3D0 Offset: 0x195F4D1 VA: 0x195F3D0
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x195F3E0 Offset: 0x195F4E1 VA: 0x195F3E0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x195F3F0 Offset: 0x195F4F1 VA: 0x195F3F0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x195F400 Offset: 0x195F501 VA: 0x195F400
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x195F410 Offset: 0x195F511 VA: 0x195F410 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x195F940 Offset: 0x195FA41 VA: 0x195F940
	public void .ctor() { }
}

