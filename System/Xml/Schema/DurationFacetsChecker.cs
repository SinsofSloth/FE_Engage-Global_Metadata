// Namespace: System.Xml.Schema
internal class DurationFacetsChecker : FacetsChecker // TypeDefIndex: 1907
{
	// Methods

	// RVA: 0x323D700 Offset: 0x323D801 VA: 0x323D700 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323D820 Offset: 0x323D921 VA: 0x323D820 Slot: 15
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323DCD0 Offset: 0x323DDD1 VA: 0x323DCD0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x323DBB0 Offset: 0x323DCB1 VA: 0x323DBB0
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x323DD60 Offset: 0x323DE61 VA: 0x323DD60
	public void .ctor() { }
}

