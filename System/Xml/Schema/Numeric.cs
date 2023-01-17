// Namespace: System.Xml.Schema
internal class Numeric10FacetsChecker : FacetsChecker // TypeDefIndex: 1905
{
	// Fields
	private static readonly char[] signs; // 0x0
	private Decimal maxValue; // 0x10
	private Decimal minValue; // 0x20

	// Methods

	// RVA: 0x3243200 Offset: 0x3243301 VA: 0x3243200
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0x3243250 Offset: 0x3243351 VA: 0x3243250 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x32432C0 Offset: 0x32433C1 VA: 0x32432C0 Slot: 6
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3243C00 Offset: 0x3243D01 VA: 0x3243C00 Slot: 7
	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3243CA0 Offset: 0x3243DA1 VA: 0x3243CA0 Slot: 8
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3243D40 Offset: 0x3243E41 VA: 0x3243D40 Slot: 9
	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x3243DE0 Offset: 0x3243EE1 VA: 0x3243DE0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x3243850 Offset: 0x3243951 VA: 0x3243850
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x3243970 Offset: 0x3243A71 VA: 0x3243970
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0x3243E60 Offset: 0x3243F61 VA: 0x3243E60
	private static void .cctor() { }
}

