// Namespace: System.Xml.Schema
public class XmlSchemaElement : XmlSchemaParticle // TypeDefIndex: 1986
{
	// Fields
	private bool isAbstract; // 0x74
	private bool hasAbstractAttribute; // 0x75
	private bool isNillable; // 0x76
	private bool hasNillableAttribute; // 0x77
	private bool isLocalTypeDerivationChecked; // 0x78
	private XmlSchemaDerivationMethod block; // 0x7C
	private XmlSchemaDerivationMethod final; // 0x80
	private XmlSchemaForm form; // 0x84
	private string defaultValue; // 0x88
	private string fixedValue; // 0x90
	private string name; // 0x98
	private XmlQualifiedName refName; // 0xA0
	private XmlQualifiedName substitutionGroup; // 0xA8
	private XmlQualifiedName typeName; // 0xB0
	private XmlSchemaType type; // 0xB8
	private XmlQualifiedName qualifiedName; // 0xC0
	private XmlSchemaType elementType; // 0xC8
	private XmlSchemaDerivationMethod blockResolved; // 0xD0
	private XmlSchemaDerivationMethod finalResolved; // 0xD4
	private XmlSchemaObjectCollection constraints; // 0xD8
	private SchemaElementDecl elementDecl; // 0xE0

	// Properties
	[DefaultValueAttribute] // RVA: 0x49B00 Offset: 0x49C01 VA: 0x49B00
	[XmlAttributeAttribute] // RVA: 0x49B00 Offset: 0x49C01 VA: 0x49B00
	public bool IsAbstract { get; set; }
	[DefaultValueAttribute] // RVA: 0x49B50 Offset: 0x49C51 VA: 0x49B50
	[XmlAttributeAttribute] // RVA: 0x49B50 Offset: 0x49C51 VA: 0x49B50
	public XmlSchemaDerivationMethod Block { get; set; }
	[DefaultValueAttribute] // RVA: 0x49BF0 Offset: 0x49CF1 VA: 0x49BF0
	[XmlAttributeAttribute] // RVA: 0x49BF0 Offset: 0x49CF1 VA: 0x49BF0
	public string DefaultValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x49C40 Offset: 0x49D41 VA: 0x49C40
	[XmlAttributeAttribute] // RVA: 0x49C40 Offset: 0x49D41 VA: 0x49C40
	public XmlSchemaDerivationMethod Final { get; set; }
	[DefaultValueAttribute] // RVA: 0x49CE0 Offset: 0x49DE1 VA: 0x49CE0
	[XmlAttributeAttribute] // RVA: 0x49CE0 Offset: 0x49DE1 VA: 0x49CE0
	public string FixedValue { get; set; }
	[XmlAttributeAttribute] // RVA: 0x49D30 Offset: 0x49E31 VA: 0x49D30
	[DefaultValueAttribute] // RVA: 0x49D30 Offset: 0x49E31 VA: 0x49D30
	public XmlSchemaForm Form { get; set; }
	[DefaultValueAttribute] // RVA: 0x49DD0 Offset: 0x49ED1 VA: 0x49DD0
	[XmlAttributeAttribute] // RVA: 0x49DD0 Offset: 0x49ED1 VA: 0x49DD0
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x49E30 Offset: 0x49F31 VA: 0x49E30
	[DefaultValueAttribute] // RVA: 0x49E30 Offset: 0x49F31 VA: 0x49E30
	public bool IsNillable { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x49E80 Offset: 0x49F81 VA: 0x49E80
	internal bool HasNillableAttribute { get; }
	[XmlIgnoreAttribute] // RVA: 0x49E90 Offset: 0x49F91 VA: 0x49E90
	internal bool HasAbstractAttribute { get; }
	[XmlAttributeAttribute] // RVA: 0x49EA0 Offset: 0x49FA1 VA: 0x49EA0
	public XmlQualifiedName RefName { get; set; }
	[XmlAttributeAttribute] // RVA: 0x49EE0 Offset: 0x49FE1 VA: 0x49EE0
	public XmlQualifiedName SubstitutionGroup { get; set; }
	[XmlAttributeAttribute] // RVA: 0x49F20 Offset: 0x4A021 VA: 0x49F20
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x49F60 Offset: 0x4A061 VA: 0x49F60
	[XmlElementAttribute] // RVA: 0x49F60 Offset: 0x4A061 VA: 0x49F60
	public XmlSchemaType SchemaType { get; set; }
	[XmlElementAttribute] // RVA: 0x4A030 Offset: 0x4A131 VA: 0x4A030
	[XmlElementAttribute] // RVA: 0x4A030 Offset: 0x4A131 VA: 0x4A030
	[XmlElementAttribute] // RVA: 0x4A030 Offset: 0x4A131 VA: 0x4A030
	public XmlSchemaObjectCollection Constraints { get; }
	[XmlIgnoreAttribute] // RVA: 0x4A150 Offset: 0x4A251 VA: 0x4A150
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x4A160 Offset: 0x4A261 VA: 0x4A160
	public XmlSchemaType ElementSchemaType { get; }
	[XmlIgnoreAttribute] // RVA: 0x4A170 Offset: 0x4A271 VA: 0x4A170
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnoreAttribute] // RVA: 0x4A180 Offset: 0x4A281 VA: 0x4A180
	public XmlSchemaDerivationMethod FinalResolved { get; }
	internal bool HasConstraints { get; }
	internal bool IsLocalTypeDerivationChecked { get; set; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A190 Offset: 0x4A291 VA: 0x4A190
	internal override string NameAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A1A0 Offset: 0x4A2A1 VA: 0x4A1A0
	internal override string NameString { get; }

	// Methods

	// RVA: 0x1964EE0 Offset: 0x1964FE1 VA: 0x1964EE0
	public bool get_IsAbstract() { }

	// RVA: 0x1964EF0 Offset: 0x1964FF1 VA: 0x1964EF0
	public void set_IsAbstract(bool value) { }

	// RVA: 0x1964F10 Offset: 0x1965011 VA: 0x1964F10
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x1964F20 Offset: 0x1965021 VA: 0x1964F20
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1964F30 Offset: 0x1965031 VA: 0x1964F30
	public string get_DefaultValue() { }

	// RVA: 0x1964F40 Offset: 0x1965041 VA: 0x1964F40
	public void set_DefaultValue(string value) { }

	// RVA: 0x1964F50 Offset: 0x1965051 VA: 0x1964F50
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x1964F60 Offset: 0x1965061 VA: 0x1964F60
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1964F70 Offset: 0x1965071 VA: 0x1964F70
	public string get_FixedValue() { }

	// RVA: 0x1964F80 Offset: 0x1965081 VA: 0x1964F80
	public void set_FixedValue(string value) { }

	// RVA: 0x1964F90 Offset: 0x1965091 VA: 0x1964F90
	public XmlSchemaForm get_Form() { }

	// RVA: 0x1964FA0 Offset: 0x19650A1 VA: 0x1964FA0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x1964FB0 Offset: 0x19650B1 VA: 0x1964FB0
	public string get_Name() { }

	// RVA: 0x1964FC0 Offset: 0x19650C1 VA: 0x1964FC0
	public void set_Name(string value) { }

	// RVA: 0x1964FD0 Offset: 0x19650D1 VA: 0x1964FD0
	public bool get_IsNillable() { }

	// RVA: 0x1964FE0 Offset: 0x19650E1 VA: 0x1964FE0
	public void set_IsNillable(bool value) { }

	// RVA: 0x1965000 Offset: 0x1965101 VA: 0x1965000
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x1965010 Offset: 0x1965111 VA: 0x1965010
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x1965020 Offset: 0x1965121 VA: 0x1965020
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1965030 Offset: 0x1965131 VA: 0x1965030
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x19650E0 Offset: 0x19651E1 VA: 0x19650E0
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x19650F0 Offset: 0x19651F1 VA: 0x19650F0
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x19651A0 Offset: 0x19652A1 VA: 0x19651A0
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x19651B0 Offset: 0x19652B1 VA: 0x19651B0
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x1965260 Offset: 0x1965361 VA: 0x1965260
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x1965270 Offset: 0x1965371 VA: 0x1965270
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x1965280 Offset: 0x1965381 VA: 0x1965280
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0x1965310 Offset: 0x1965411 VA: 0x1965310
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1965320 Offset: 0x1965421 VA: 0x1965320
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x1965330 Offset: 0x1965431 VA: 0x1965330
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x1965340 Offset: 0x1965441 VA: 0x1965340
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x1965350 Offset: 0x1965451 VA: 0x1965350
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1965360 Offset: 0x1965461 VA: 0x1965360
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0x1965370 Offset: 0x1965471 VA: 0x1965370
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1965380 Offset: 0x1965481 VA: 0x1965380
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1965390 Offset: 0x1965491 VA: 0x1965390
	internal bool get_HasConstraints() { }

	// RVA: 0x19653C0 Offset: 0x19654C1 VA: 0x19653C0
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x19653D0 Offset: 0x19654D1 VA: 0x19653D0
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x19653E0 Offset: 0x19654E1 VA: 0x19653E0
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x19653F0 Offset: 0x19654F1 VA: 0x19653F0
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x1965400 Offset: 0x1965501 VA: 0x1965400 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x1965410 Offset: 0x1965511 VA: 0x1965410 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1965420 Offset: 0x1965521 VA: 0x1965420 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x1965430 Offset: 0x1965531 VA: 0x1965430 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x19639B0 Offset: 0x1963AB1 VA: 0x19639B0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1965470 Offset: 0x1965571 VA: 0x1965470
	public void .ctor() { }
}

