// Namespace: System.Xml.Schema
public class XmlSchemaType : XmlSchemaAnnotated // TypeDefIndex: 2041
{
	// Fields
	private string name; // 0x50
	private XmlSchemaDerivationMethod final; // 0x58
	private XmlSchemaDerivationMethod derivedBy; // 0x5C
	private XmlSchemaType baseSchemaType; // 0x60
	private XmlSchemaDatatype datatype; // 0x68
	private XmlSchemaDerivationMethod finalResolved; // 0x70
	private SchemaElementDecl elementDecl; // 0x78
	private XmlQualifiedName qname; // 0x80
	private XmlSchemaType redefined; // 0x88
	private XmlSchemaContentType contentType; // 0x90

	// Properties
	[XmlAttributeAttribute] // RVA: 0x4BC40 Offset: 0x4BD41 VA: 0x4BC40
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x4BC80 Offset: 0x4BD81 VA: 0x4BC80
	[DefaultValueAttribute] // RVA: 0x4BC80 Offset: 0x4BD81 VA: 0x4BC80
	public XmlSchemaDerivationMethod Final { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4BD20 Offset: 0x4BE21 VA: 0x4BD20
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x4BD30 Offset: 0x4BE31 VA: 0x4BD30
	public XmlSchemaDerivationMethod FinalResolved { get; }
	[XmlIgnoreAttribute] // RVA: 0x4BD40 Offset: 0x4BE41 VA: 0x4BD40
	public XmlSchemaType BaseXmlSchemaType { get; }
	[XmlIgnoreAttribute] // RVA: 0x4BD50 Offset: 0x4BE51 VA: 0x4BD50
	public XmlSchemaDerivationMethod DerivedBy { get; }
	[XmlIgnoreAttribute] // RVA: 0x4BD60 Offset: 0x4BE61 VA: 0x4BD60
	public XmlSchemaDatatype Datatype { get; }
	[XmlIgnoreAttribute] // RVA: 0x4BD70 Offset: 0x4BE71 VA: 0x4BD70
	public virtual bool IsMixed { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4BD80 Offset: 0x4BE81 VA: 0x4BD80
	public XmlTypeCode TypeCode { get; }
	[XmlIgnoreAttribute] // RVA: 0x4BD90 Offset: 0x4BE91 VA: 0x4BD90
	internal XmlValueConverter ValueConverter { get; }
	internal XmlSchemaContentType SchemaContentType { get; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4BDA0 Offset: 0x4BEA1 VA: 0x4BDA0
	internal XmlSchemaType Redefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4BDB0 Offset: 0x4BEB1 VA: 0x4BDB0
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x1971F90 Offset: 0x1972091 VA: 0x1971F90
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0x1972000 Offset: 0x1972101 VA: 0x1972000
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x19722F0 Offset: 0x19723F1 VA: 0x19722F0
	public string get_Name() { }

	// RVA: 0x1972300 Offset: 0x1972401 VA: 0x1972300
	public void set_Name(string value) { }

	// RVA: 0x1972310 Offset: 0x1972411 VA: 0x1972310
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x1972320 Offset: 0x1972421 VA: 0x1972320
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1965440 Offset: 0x1965541 VA: 0x1965440
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1972330 Offset: 0x1972431 VA: 0x1972330
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x1972340 Offset: 0x1972441 VA: 0x1972340
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x1972350 Offset: 0x1972451 VA: 0x1972350
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x1972360 Offset: 0x1972461 VA: 0x1972360
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x1972370 Offset: 0x1972471 VA: 0x1972370 Slot: 14
	public virtual bool get_IsMixed() { }

	// RVA: 0x1972380 Offset: 0x1972481 VA: 0x1972380 Slot: 15
	public virtual void set_IsMixed(bool value) { }

	// RVA: 0x1972390 Offset: 0x1972491 VA: 0x1972390
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0x19724A0 Offset: 0x19725A1 VA: 0x19724A0
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0x1972530 Offset: 0x1972631 VA: 0x1972530
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0x19617D0 Offset: 0x19618D1 VA: 0x19617D0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1972540 Offset: 0x1972641 VA: 0x1972540
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1972550 Offset: 0x1972651 VA: 0x1972550
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x1972560 Offset: 0x1972661 VA: 0x1972560
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1972570 Offset: 0x1972671 VA: 0x1972570
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0x1961830 Offset: 0x1961931 VA: 0x1961830
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x1961800 Offset: 0x1961901 VA: 0x1961800
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x1972580 Offset: 0x1972681 VA: 0x1972580
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x1972590 Offset: 0x1972691 VA: 0x1972590
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0x19725A0 Offset: 0x19726A1 VA: 0x19725A0
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0x19725B0 Offset: 0x19726B1 VA: 0x19725B0
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x1972820 Offset: 0x1972921 VA: 0x1972820
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x1972920 Offset: 0x1972A21 VA: 0x1972920 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x1972930 Offset: 0x1972A31 VA: 0x1972930 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1961CF0 Offset: 0x1961DF1 VA: 0x1961CF0
	public void .ctor() { }
}

