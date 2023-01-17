// Namespace: System.Xml.Schema
internal sealed class SchemaCollectionPreprocessor : BaseProcessor // TypeDefIndex: 1928
{
	// Fields
	private XmlSchema schema; // 0x40
	private string targetNamespace; // 0x48
	private bool buildinIncluded; // 0x50
	private XmlSchemaForm elementFormDefault; // 0x54
	private XmlSchemaForm attributeFormDefault; // 0x58
	private XmlSchemaDerivationMethod blockDefault; // 0x5C
	private XmlSchemaDerivationMethod finalDefault; // 0x60
	private Hashtable schemaLocations; // 0x68
	private Hashtable referenceNamespaces; // 0x70
	private string Xmlns; // 0x78
	private XmlResolver xmlResolver; // 0x80

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0x1A6A780 Offset: 0x1A6A881 VA: 0x1A6A780
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1A6A790 Offset: 0x1A6A891 VA: 0x1A6A790
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0x1A6A9F0 Offset: 0x1A6AAF1 VA: 0x1A6A9F0
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x1A6DA90 Offset: 0x1A6DB91 VA: 0x1A6DA90
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1A6ABF0 Offset: 0x1A6ACF1 VA: 0x1A6ABF0
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0x1A6DC70 Offset: 0x1A6DD71 VA: 0x1A6DC70
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x1A6B8D0 Offset: 0x1A6B9D1 VA: 0x1A6B8D0
	private void Preprocess(XmlSchema schema, string targetNamespace, SchemaCollectionPreprocessor.Compositor compositor) { }

	// RVA: 0x1A6DF80 Offset: 0x1A6E081 VA: 0x1A6DF80
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0x1A70DC0 Offset: 0x1A70EC1 VA: 0x1A70DC0
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0x1A70770 Offset: 0x1A70871 VA: 0x1A70770
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x1A70810 Offset: 0x1A70911 VA: 0x1A70810
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1A70CB0 Offset: 0x1A70DB1 VA: 0x1A70CB0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x1A70990 Offset: 0x1A70A91 VA: 0x1A70990
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x1A6EF20 Offset: 0x1A6F021 VA: 0x1A6EF20
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1A71640 Offset: 0x1A71741 VA: 0x1A71640
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1A713E0 Offset: 0x1A714E1 VA: 0x1A713E0
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x1A6F0B0 Offset: 0x1A6F1B1 VA: 0x1A6F0B0
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1A70050 Offset: 0x1A70151 VA: 0x1A70050
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x1A72020 Offset: 0x1A72121 VA: 0x1A72020
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x1A71CB0 Offset: 0x1A71DB1 VA: 0x1A71CB0
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x1A723B0 Offset: 0x1A724B1 VA: 0x1A723B0
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x1A6FA70 Offset: 0x1A6FB71 VA: 0x1A6FA70
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x1A6F1C0 Offset: 0x1A6F2C1 VA: 0x1A6F1C0
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x1A702B0 Offset: 0x1A703B1 VA: 0x1A702B0
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x1A70490 Offset: 0x1A70591 VA: 0x1A70490
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x1A726F0 Offset: 0x1A727F1 VA: 0x1A726F0
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1A71990 Offset: 0x1A71A91 VA: 0x1A71990
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x1A6B6A0 Offset: 0x1A6B7A1 VA: 0x1A6B6A0
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1A710D0 Offset: 0x1A711D1 VA: 0x1A710D0
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1A71810 Offset: 0x1A71911 VA: 0x1A71810
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x1A6DE80 Offset: 0x1A6DF81 VA: 0x1A6DE80
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x1A6DE90 Offset: 0x1A6DF91 VA: 0x1A6DE90
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x1A6DAA0 Offset: 0x1A6DBA1 VA: 0x1A6DAA0
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x1A6DB50 Offset: 0x1A6DC51 VA: 0x1A6DB50
	private Stream GetSchemaEntity(Uri ruri) { }
}

