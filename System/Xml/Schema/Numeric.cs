// Namespace: System.Xml.Schema
internal class Numeric2FacetsChecker : FacetsChecker // TypeDefIndex: 1906
{
	// Methods

	// RVA: 0x3243F00 Offset: 0x3244001 VA: 0x3243F00 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3243F60 Offset: 0x3244061 VA: 0x3243F60 Slot: 11
	internal override Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3244310 Offset: 0x3244411 VA: 0x3244310 Slot: 12
	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3244320 Offset: 0x3244421 VA: 0x3244320 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x3244250 Offset: 0x3244351 VA: 0x3244250
	private bool MatchEnumeration(double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x3244420 Offset: 0x3244521 VA: 0x3244420
	public void .ctor() { }
}

