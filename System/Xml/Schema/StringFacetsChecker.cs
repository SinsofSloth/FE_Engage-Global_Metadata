// Namespace: System.Xml.Schema
internal class StringFacetsChecker : FacetsChecker // TypeDefIndex: 1909
{
	// Fields
	private static Regex languagePattern; // 0x0

	// Properties
	private static Regex LanguagePattern { get; }

	// Methods

	// RVA: 0x19B6990 Offset: 0x19B6A91 VA: 0x19B6990
	private static Regex get_LanguagePattern() { }

	// RVA: 0x19B6A60 Offset: 0x19B6B61 VA: 0x19B6A60 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x19B6CD0 Offset: 0x19B6DD1 VA: 0x19B6CD0 Slot: 13
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x19B6AC0 Offset: 0x19B6BC1 VA: 0x19B6AC0
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0x19B7120 Offset: 0x19B7221 VA: 0x19B7120 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x19B6F60 Offset: 0x19B7061 VA: 0x19B6F60
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x19B6CE0 Offset: 0x19B6DE1 VA: 0x19B6CE0
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x19B7180 Offset: 0x19B7281 VA: 0x19B7180
	public void .ctor() { }
}

