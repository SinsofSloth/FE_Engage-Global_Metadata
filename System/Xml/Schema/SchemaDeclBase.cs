// Namespace: System.Xml.Schema
internal abstract class SchemaDeclBase // TypeDefIndex: 1930
{
	// Fields
	protected XmlQualifiedName name; // 0x10
	protected string prefix; // 0x18
	protected bool isDeclaredInExternal; // 0x20
	protected SchemaDeclBase.Use presence; // 0x24
	protected XmlSchemaType schemaType; // 0x28
	protected XmlSchemaDatatype datatype; // 0x30
	protected string defaultValueRaw; // 0x38
	protected object defaultValueTyped; // 0x40
	protected long maxLength; // 0x48
	protected long minLength; // 0x50
	protected List<string> values; // 0x58

	// Properties
	internal XmlQualifiedName Name { get; set; }
	internal string Prefix { get; set; }
	internal bool IsDeclaredInExternal { get; set; }
	internal SchemaDeclBase.Use Presence { get; set; }
	internal long MaxLength { get; set; }
	internal long MinLength { get; set; }
	internal XmlSchemaType SchemaType { get; set; }
	internal XmlSchemaDatatype Datatype { get; set; }
	internal List<string> Values { get; set; }
	internal string DefaultValueRaw { get; set; }
	internal object DefaultValueTyped { get; set; }

	// Methods

	// RVA: 0x19AD640 Offset: 0x19AD741 VA: 0x19AD640
	protected void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x19AD710 Offset: 0x19AD811 VA: 0x19AD710
	protected void .ctor() { }

	// RVA: 0x19AD7A0 Offset: 0x19AD8A1 VA: 0x19AD7A0
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x19AD7B0 Offset: 0x19AD8B1 VA: 0x19AD7B0
	internal void set_Name(XmlQualifiedName value) { }

	// RVA: 0x19AD7C0 Offset: 0x19AD8C1 VA: 0x19AD7C0
	internal string get_Prefix() { }

	// RVA: 0x19AD830 Offset: 0x19AD931 VA: 0x19AD830
	internal void set_Prefix(string value) { }

	// RVA: 0x19AD840 Offset: 0x19AD941 VA: 0x19AD840
	internal bool get_IsDeclaredInExternal() { }

	// RVA: 0x19AD850 Offset: 0x19AD951 VA: 0x19AD850
	internal void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x19AD860 Offset: 0x19AD961 VA: 0x19AD860
	internal SchemaDeclBase.Use get_Presence() { }

	// RVA: 0x19AD870 Offset: 0x19AD971 VA: 0x19AD870
	internal void set_Presence(SchemaDeclBase.Use value) { }

	// RVA: 0x19AD880 Offset: 0x19AD981 VA: 0x19AD880
	internal long get_MaxLength() { }

	// RVA: 0x19AD890 Offset: 0x19AD991 VA: 0x19AD890
	internal void set_MaxLength(long value) { }

	// RVA: 0x19AD8A0 Offset: 0x19AD9A1 VA: 0x19AD8A0
	internal long get_MinLength() { }

	// RVA: 0x19AD8B0 Offset: 0x19AD9B1 VA: 0x19AD8B0
	internal void set_MinLength(long value) { }

	// RVA: 0x19AD8C0 Offset: 0x19AD9C1 VA: 0x19AD8C0
	internal XmlSchemaType get_SchemaType() { }

	// RVA: 0x19AD8D0 Offset: 0x19AD9D1 VA: 0x19AD8D0
	internal void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x19AD8E0 Offset: 0x19AD9E1 VA: 0x19AD8E0
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x19AD8F0 Offset: 0x19AD9F1 VA: 0x19AD8F0
	internal void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0x19AD900 Offset: 0x19ADA01 VA: 0x19AD900
	internal void AddValue(string value) { }

	// RVA: 0x19AD9B0 Offset: 0x19ADAB1 VA: 0x19AD9B0
	internal List<string> get_Values() { }

	// RVA: 0x19AD9C0 Offset: 0x19ADAC1 VA: 0x19AD9C0
	internal void set_Values(List<string> value) { }

	// RVA: 0x19AD9D0 Offset: 0x19ADAD1 VA: 0x19AD9D0
	internal string get_DefaultValueRaw() { }

	// RVA: 0x19ADA40 Offset: 0x19ADB41 VA: 0x19ADA40
	internal void set_DefaultValueRaw(string value) { }

	// RVA: 0x19ADA50 Offset: 0x19ADB51 VA: 0x19ADA50
	internal object get_DefaultValueTyped() { }

	// RVA: 0x19ADA60 Offset: 0x19ADB61 VA: 0x19ADA60
	internal void set_DefaultValueTyped(object value) { }

	// RVA: 0x19ADA70 Offset: 0x19ADB71 VA: 0x19ADA70
	internal bool CheckEnumeration(object pVal) { }

	// RVA: 0x19ADB30 Offset: 0x19ADC31 VA: 0x19ADB30
	internal bool CheckValue(object pVal) { }
}

