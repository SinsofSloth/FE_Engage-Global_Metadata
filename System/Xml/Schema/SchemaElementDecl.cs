// Namespace: System.Xml.Schema
internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo // TypeDefIndex: 1931
{
	// Fields
	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; // 0x60
	private List<IDtdDefaultAttributeInfo> defaultAttdefs; // 0x68
	private bool isIdDeclared; // 0x70
	private bool hasNonCDataAttribute; // 0x71
	private bool isAbstract; // 0x72
	private bool isNillable; // 0x73
	private bool hasRequiredAttribute; // 0x74
	private bool isNotationDeclared; // 0x75
	private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes; // 0x78
	private ContentValidator contentValidator; // 0x80
	private XmlSchemaAnyAttribute anyAttribute; // 0x88
	private XmlSchemaDerivationMethod block; // 0x90
	private CompiledIdentityConstraint[] constraints; // 0x98
	private XmlSchemaElement schemaElement; // 0xA0
	internal static readonly SchemaElementDecl Empty; // 0x0

	// Properties
	private bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes { get; }
	internal bool IsIdDeclared { get; set; }
	internal bool HasNonCDataAttribute { get; set; }
	internal bool IsAbstract { get; set; }
	internal bool IsNillable { get; set; }
	internal XmlSchemaDerivationMethod Block { get; set; }
	internal bool IsNotationDeclared { get; set; }
	internal bool HasDefaultAttribute { get; }
	internal bool HasRequiredAttribute { get; }
	internal ContentValidator ContentValidator { get; set; }
	internal XmlSchemaAnyAttribute AnyAttribute { get; set; }
	internal CompiledIdentityConstraint[] Constraints { get; set; }
	internal XmlSchemaElement SchemaElement { get; set; }
	internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs { get; }
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes { get; }

	// Methods

	// RVA: 0x19ADB70 Offset: 0x19ADC71 VA: 0x19ADB70
	internal void .ctor() { }

	// RVA: 0x19ADCB0 Offset: 0x19ADDB1 VA: 0x19ADCB0
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0x19ADE50 Offset: 0x19ADF51 VA: 0x19ADE50
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x19ADF50 Offset: 0x19AE051 VA: 0x19ADF50
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0x19AE050 Offset: 0x19AE151 VA: 0x19AE050 Slot: 4
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x19AE060 Offset: 0x19AE161 VA: 0x19AE060 Slot: 5
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x19AE120 Offset: 0x19AE221 VA: 0x19AE120 Slot: 6
	private IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0x19AE130 Offset: 0x19AE231 VA: 0x19AE130
	internal bool get_IsIdDeclared() { }

	// RVA: 0x19AE140 Offset: 0x19AE241 VA: 0x19AE140
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0x19AE150 Offset: 0x19AE251 VA: 0x19AE150
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0x19AE160 Offset: 0x19AE261 VA: 0x19AE160
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0x19AE170 Offset: 0x19AE271 VA: 0x19AE170
	internal SchemaElementDecl Clone() { }

	// RVA: 0x19AE1E0 Offset: 0x19AE2E1 VA: 0x19AE1E0
	internal bool get_IsAbstract() { }

	// RVA: 0x19AE1F0 Offset: 0x19AE2F1 VA: 0x19AE1F0
	internal void set_IsAbstract(bool value) { }

	// RVA: 0x19AE200 Offset: 0x19AE301 VA: 0x19AE200
	internal bool get_IsNillable() { }

	// RVA: 0x19AE210 Offset: 0x19AE311 VA: 0x19AE210
	internal void set_IsNillable(bool value) { }

	// RVA: 0x19AE220 Offset: 0x19AE321 VA: 0x19AE220
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x19AE230 Offset: 0x19AE331 VA: 0x19AE230
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x19AE240 Offset: 0x19AE341 VA: 0x19AE240
	internal bool get_IsNotationDeclared() { }

	// RVA: 0x19AE250 Offset: 0x19AE351 VA: 0x19AE250
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0x19AE260 Offset: 0x19AE361 VA: 0x19AE260
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0x19AE270 Offset: 0x19AE371 VA: 0x19AE270
	internal bool get_HasRequiredAttribute() { }

	// RVA: 0x19AE280 Offset: 0x19AE381 VA: 0x19AE280
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0x19AE290 Offset: 0x19AE391 VA: 0x19AE290
	internal void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x19AE2A0 Offset: 0x19AE3A1 VA: 0x19AE2A0
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x19AE2B0 Offset: 0x19AE3B1 VA: 0x19AE2B0
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x19AE2C0 Offset: 0x19AE3C1 VA: 0x19AE2C0
	internal CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0x19AE2D0 Offset: 0x19AE3D1 VA: 0x19AE2D0
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x19AE2E0 Offset: 0x19AE3E1 VA: 0x19AE2E0
	internal XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x19AE2F0 Offset: 0x19AE3F1 VA: 0x19AE2F0
	internal void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x19AE300 Offset: 0x19AE401 VA: 0x19AE300
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0x19AE420 Offset: 0x19AE521 VA: 0x19AE420
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x19AE4A0 Offset: 0x19AE5A1 VA: 0x19AE4A0
	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x19AE4B0 Offset: 0x19AE5B1 VA: 0x19AE4B0
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	// RVA: 0x19AE4C0 Offset: 0x19AE5C1 VA: 0x19AE4C0
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0x19AE4D0 Offset: 0x19AE5D1 VA: 0x19AE4D0
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0x19AE760 Offset: 0x19AE861 VA: 0x19AE760
	private static void .cctor() { }
}

