// Namespace: System.Xml.Schema
public class XmlSchemaAttribute : XmlSchemaAnnotated // TypeDefIndex: 1967
{
	// Fields
	private string defaultValue; // 0x50
	private string fixedValue; // 0x58
	private string name; // 0x60
	private XmlSchemaForm form; // 0x68
	private XmlSchemaUse use; // 0x6C
	private XmlQualifiedName refName; // 0x70
	private XmlQualifiedName typeName; // 0x78
	private XmlQualifiedName qualifiedName; // 0x80
	private XmlSchemaSimpleType type; // 0x88
	private XmlSchemaSimpleType attributeType; // 0x90
	private SchemaAttDef attDef; // 0x98

	// Properties
	[XmlAttributeAttribute] // RVA: 0x487A0 Offset: 0x488A1 VA: 0x487A0
	[DefaultValueAttribute] // RVA: 0x487A0 Offset: 0x488A1 VA: 0x487A0
	public string DefaultValue { get; set; }
	[XmlAttributeAttribute] // RVA: 0x487F0 Offset: 0x488F1 VA: 0x487F0
	[DefaultValueAttribute] // RVA: 0x487F0 Offset: 0x488F1 VA: 0x487F0
	public string FixedValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x48840 Offset: 0x48941 VA: 0x48840
	[XmlAttributeAttribute] // RVA: 0x48840 Offset: 0x48941 VA: 0x48840
	public XmlSchemaForm Form { get; set; }
	[XmlAttributeAttribute] // RVA: 0x488E0 Offset: 0x489E1 VA: 0x488E0
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x48920 Offset: 0x48A21 VA: 0x48920
	public XmlQualifiedName RefName { get; set; }
	[XmlAttributeAttribute] // RVA: 0x48960 Offset: 0x48A61 VA: 0x48960
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x489A0 Offset: 0x48AA1 VA: 0x489A0
	public XmlSchemaSimpleType SchemaType { get; set; }
	[DefaultValueAttribute] // RVA: 0x489E0 Offset: 0x48AE1 VA: 0x489E0
	[XmlAttributeAttribute] // RVA: 0x489E0 Offset: 0x48AE1 VA: 0x489E0
	public XmlSchemaUse Use { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x48A80 Offset: 0x48B81 VA: 0x48A80
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x48A90 Offset: 0x48B91 VA: 0x48A90
	public XmlSchemaSimpleType AttributeSchemaType { get; }
	[XmlIgnoreAttribute] // RVA: 0x48AA0 Offset: 0x48BA1 VA: 0x48AA0
	internal XmlSchemaDatatype Datatype { get; }
	internal SchemaAttDef AttDef { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x48AB0 Offset: 0x48BB1 VA: 0x48AB0
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x195ED20 Offset: 0x195EE21 VA: 0x195ED20
	public string get_DefaultValue() { }

	// RVA: 0x195ED30 Offset: 0x195EE31 VA: 0x195ED30
	public void set_DefaultValue(string value) { }

	// RVA: 0x195ED40 Offset: 0x195EE41 VA: 0x195ED40
	public string get_FixedValue() { }

	// RVA: 0x195ED50 Offset: 0x195EE51 VA: 0x195ED50
	public void set_FixedValue(string value) { }

	// RVA: 0x195ED60 Offset: 0x195EE61 VA: 0x195ED60
	public XmlSchemaForm get_Form() { }

	// RVA: 0x195ED70 Offset: 0x195EE71 VA: 0x195ED70
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x195ED80 Offset: 0x195EE81 VA: 0x195ED80
	public string get_Name() { }

	// RVA: 0x195ED90 Offset: 0x195EE91 VA: 0x195ED90
	public void set_Name(string value) { }

	// RVA: 0x195EDA0 Offset: 0x195EEA1 VA: 0x195EDA0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x195EDB0 Offset: 0x195EEB1 VA: 0x195EDB0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x195EE60 Offset: 0x195EF61 VA: 0x195EE60
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x195EE70 Offset: 0x195EF71 VA: 0x195EE70
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x195EF20 Offset: 0x195F021 VA: 0x195EF20
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x195EF30 Offset: 0x195F031 VA: 0x195EF30
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0x195EF40 Offset: 0x195F041 VA: 0x195EF40
	public XmlSchemaUse get_Use() { }

	// RVA: 0x195EF50 Offset: 0x195F051 VA: 0x195EF50
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x195EF60 Offset: 0x195F061 VA: 0x195EF60
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x195EF70 Offset: 0x195F071 VA: 0x195EF70
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x195EF80 Offset: 0x195F081 VA: 0x195EF80
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x195EFA0 Offset: 0x195F0A1 VA: 0x195EFA0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x195EFB0 Offset: 0x195F0B1 VA: 0x195EFB0
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0x195EFC0 Offset: 0x195F0C1 VA: 0x195EFC0
	internal SchemaAttDef get_AttDef() { }

	// RVA: 0x195EFD0 Offset: 0x195F0D1 VA: 0x195EFD0
	internal void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x195EFE0 Offset: 0x195F0E1 VA: 0x195EFE0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x195EFF0 Offset: 0x195F0F1 VA: 0x195EFF0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x195F000 Offset: 0x195F101 VA: 0x195F000 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x195F0F0 Offset: 0x195F1F1 VA: 0x195F0F0
	public void .ctor() { }
}

