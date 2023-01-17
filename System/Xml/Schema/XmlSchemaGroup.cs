// Namespace: System.Xml.Schema
public class XmlSchemaGroup : XmlSchemaAnnotated // TypeDefIndex: 2005
{
	// Fields
	private string name; // 0x50
	private XmlSchemaGroupBase particle; // 0x58
	private XmlSchemaParticle canonicalParticle; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaGroup redefined; // 0x70
	private int selfReferenceCount; // 0x78

	// Properties
	[XmlAttributeAttribute] // RVA: 0x4A330 Offset: 0x4A431 VA: 0x4A330
	public string Name { get; set; }
	[XmlElementAttribute] // RVA: 0x4A370 Offset: 0x4A471 VA: 0x4A370
	[XmlElementAttribute] // RVA: 0x4A370 Offset: 0x4A471 VA: 0x4A370
	[XmlElementAttribute] // RVA: 0x4A370 Offset: 0x4A471 VA: 0x4A370
	public XmlSchemaGroupBase Particle { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A490 Offset: 0x4A591 VA: 0x4A490
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x4A4A0 Offset: 0x4A5A1 VA: 0x4A4A0
	internal XmlSchemaParticle CanonicalParticle { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A4B0 Offset: 0x4A5B1 VA: 0x4A4B0
	internal XmlSchemaGroup Redefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A4C0 Offset: 0x4A5C1 VA: 0x4A4C0
	internal int SelfReferenceCount { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A4D0 Offset: 0x4A5D1 VA: 0x4A4D0
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x19668F0 Offset: 0x19669F1 VA: 0x19668F0
	public string get_Name() { }

	// RVA: 0x1966900 Offset: 0x1966A01 VA: 0x1966900
	public void set_Name(string value) { }

	// RVA: 0x1966910 Offset: 0x1966A11 VA: 0x1966910
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x1966920 Offset: 0x1966A21 VA: 0x1966920
	public void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x1966930 Offset: 0x1966A31 VA: 0x1966930
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1966940 Offset: 0x1966A41 VA: 0x1966940
	internal XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0x1966950 Offset: 0x1966A51 VA: 0x1966950
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x1966960 Offset: 0x1966A61 VA: 0x1966960
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x1966970 Offset: 0x1966A71 VA: 0x1966970
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x1966980 Offset: 0x1966A81 VA: 0x1966980
	internal int get_SelfReferenceCount() { }

	// RVA: 0x1966990 Offset: 0x1966A91 VA: 0x1966990
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x19669A0 Offset: 0x1966AA1 VA: 0x19669A0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x19669B0 Offset: 0x1966AB1 VA: 0x19669B0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x19669C0 Offset: 0x1966AC1 VA: 0x19669C0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x19669D0 Offset: 0x1966AD1 VA: 0x19669D0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x19669E0 Offset: 0x1966AE1 VA: 0x19669E0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1966BA0 Offset: 0x1966CA1 VA: 0x1966BA0
	public void .ctor() { }
}

