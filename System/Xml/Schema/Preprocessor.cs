// Namespace: System.Xml.Schema
internal sealed class Preprocessor : BaseProcessor // TypeDefIndex: 1922
{
	// Fields
	private string Xmlns; // 0x40
	private string NsXsi; // 0x48
	private string targetNamespace; // 0x50
	private XmlSchema rootSchema; // 0x58
	private XmlSchema currentSchema; // 0x60
	private XmlSchemaForm elementFormDefault; // 0x68
	private XmlSchemaForm attributeFormDefault; // 0x6C
	private XmlSchemaDerivationMethod blockDefault; // 0x70
	private XmlSchemaDerivationMethod finalDefault; // 0x74
	private Hashtable schemaLocations; // 0x78
	private Hashtable chameleonSchemas; // 0x80
	private Hashtable referenceNamespaces; // 0x88
	private Hashtable processedExternals; // 0x90
	private SortedList lockList; // 0x98
	private XmlReaderSettings readerSettings; // 0xA0
	private XmlSchema rootSchemaForRedefine; // 0xA8
	private ArrayList redefinedList; // 0xB0
	private static XmlSchema builtInSchemaForXmlNS; // 0x0
	private XmlResolver xmlResolver; // 0xB8

	// Properties
	internal XmlResolver XmlResolver { set; }
	internal XmlReaderSettings ReaderSettings { set; }
	internal Hashtable SchemaLocations { set; }
	internal Hashtable ChameleonSchemas { set; }
	internal XmlSchema RootSchema { get; }

	// Methods

	// RVA: 0x32484B0 Offset: 0x32485B1 VA: 0x32484B0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x32485C0 Offset: 0x32486C1 VA: 0x32485C0
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0x324C270 Offset: 0x324C371 VA: 0x324C270
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x324C330 Offset: 0x324C431 VA: 0x324C330
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0x324C3C0 Offset: 0x324C4C1 VA: 0x324C3C0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x324C3D0 Offset: 0x324C4D1 VA: 0x324C3D0
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x324C3E0 Offset: 0x324C4E1 VA: 0x324C3E0
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x324C3F0 Offset: 0x324C4F1 VA: 0x324C3F0
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x324C400 Offset: 0x324C501 VA: 0x324C400
	internal XmlSchema get_RootSchema() { }

	// RVA: 0x3249A20 Offset: 0x3249B21 VA: 0x3249A20
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0x3248C40 Offset: 0x3248D41 VA: 0x3248C40
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0x324BC60 Offset: 0x324BD61 VA: 0x324BC60
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0x324C460 Offset: 0x324C561 VA: 0x324C460
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x324C680 Offset: 0x324C781 VA: 0x324C680
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0x3249BA0 Offset: 0x3249CA1 VA: 0x3249BA0
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0x324CD80 Offset: 0x324CE81 VA: 0x324CD80
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0x324AF10 Offset: 0x324B011 VA: 0x324AF10
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0x324F710 Offset: 0x324F811 VA: 0x324F710
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0x324F670 Offset: 0x324F771 VA: 0x324F670
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0x324CC60 Offset: 0x324CD61 VA: 0x324CC60
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0x324FEA0 Offset: 0x324FFA1 VA: 0x324FEA0
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0x324F850 Offset: 0x324F951 VA: 0x324F850
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x324F900 Offset: 0x324FA01 VA: 0x324F900
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x324FD90 Offset: 0x324FE91 VA: 0x324FD90
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x324FA70 Offset: 0x324FB71 VA: 0x324FA70
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x324DDD0 Offset: 0x324DED1 VA: 0x324DDD0
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x32506F0 Offset: 0x32507F1 VA: 0x32506F0
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x32504A0 Offset: 0x32505A1 VA: 0x32504A0
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x324DF60 Offset: 0x324E061 VA: 0x324DF60
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x324EF00 Offset: 0x324F001 VA: 0x324EF00
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x3251230 Offset: 0x3251331 VA: 0x3251230
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x3250ED0 Offset: 0x3250FD1 VA: 0x3250ED0
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x32515C0 Offset: 0x32516C1 VA: 0x32515C0
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x324E930 Offset: 0x324EA31 VA: 0x324E930
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x324E070 Offset: 0x324E171 VA: 0x324E070
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x324F160 Offset: 0x324F261 VA: 0x324F160
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x324F340 Offset: 0x324F441 VA: 0x324F340
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x3251900 Offset: 0x3251A01 VA: 0x3251900
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x3250B20 Offset: 0x3250C21 VA: 0x3250B20
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x324C930 Offset: 0x324CA31 VA: 0x324C930
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x32501D0 Offset: 0x32502D1 VA: 0x32501D0
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x32508C0 Offset: 0x32509C1 VA: 0x32508C0
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x324C410 Offset: 0x324C511 VA: 0x324C410
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x324C440 Offset: 0x324C541 VA: 0x324C440
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0x3248B00 Offset: 0x3248C01 VA: 0x3248B00
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x324C810 Offset: 0x324C911 VA: 0x324C810
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x324C820 Offset: 0x324C921 VA: 0x324C820
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x324F5F0 Offset: 0x324F6F1 VA: 0x324F5F0
	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }
}

