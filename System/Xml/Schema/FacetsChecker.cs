// Namespace: System.Xml.Schema
internal abstract class FacetsChecker // TypeDefIndex: 1904
{
	// Methods

	// RVA: 0x323DE10 Offset: 0x323DF11 VA: 0x323DE10 Slot: 4
	internal virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x323E0C0 Offset: 0x323E1C1 VA: 0x323E0C0 Slot: 5
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323E0D0 Offset: 0x323E1D1 VA: 0x323E0D0 Slot: 6
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323E0E0 Offset: 0x323E1E1 VA: 0x323E0E0 Slot: 7
	internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323E0F0 Offset: 0x323E1F1 VA: 0x323E0F0 Slot: 8
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323E100 Offset: 0x323E201 VA: 0x323E100 Slot: 9
	internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323E110 Offset: 0x323E211 VA: 0x323E110 Slot: 10
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323E120 Offset: 0x323E221 VA: 0x323E120 Slot: 11
	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323E130 Offset: 0x323E231 VA: 0x323E130 Slot: 12
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323E140 Offset: 0x323E241 VA: 0x323E140 Slot: 13
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323E150 Offset: 0x323E251 VA: 0x323E150 Slot: 14
	internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323E160 Offset: 0x323E261 VA: 0x323E160 Slot: 15
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323E170 Offset: 0x323E271 VA: 0x323E170 Slot: 16
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x323DE50 Offset: 0x323DF51 VA: 0x323DE50
	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x323DF50 Offset: 0x323E051 VA: 0x323DF50
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x323E180 Offset: 0x323E281 VA: 0x323E180 Slot: 17
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x323E190 Offset: 0x323E291 VA: 0x323E190 Slot: 18
	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x323E500 Offset: 0x323E601 VA: 0x323E500
	internal static Decimal Power(int x, int y) { }

	// RVA: 0x323DD70 Offset: 0x323DE71 VA: 0x323DD70
	protected void .ctor() { }
}

