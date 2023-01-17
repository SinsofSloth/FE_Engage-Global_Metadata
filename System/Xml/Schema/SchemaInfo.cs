// Namespace: System.Xml.Schema
internal class SchemaInfo : IDtdInfo // TypeDefIndex: 1934
{
	// Fields
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls; // 0x10
	private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls; // 0x18
	private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities; // 0x20
	private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities; // 0x28
	private XmlQualifiedName docTypeName; // 0x30
	private string internalDtdSubset; // 0x38
	private bool hasNonCDataAttributes; // 0x40
	private bool hasDefaultAttributes; // 0x41
	private Dictionary<string, bool> targetNamespaces; // 0x48
	private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls; // 0x50
	private int errorCount; // 0x58
	private SchemaType schemaType; // 0x5C
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType; // 0x60
	private Dictionary<string, SchemaNotation> notations; // 0x68

	// Properties
	public XmlQualifiedName DocTypeName { get; set; }
	internal string InternalDtdSubset { set; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities { get; }
	internal SchemaType SchemaType { get; set; }
	internal Dictionary<string, bool> TargetNamespaces { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls { get; }
	internal Dictionary<string, SchemaNotation> Notations { get; }
	internal int ErrorCount { get; set; }
	private bool System.Xml.IDtdInfo.HasDefaultAttributes { get; }
	private bool System.Xml.IDtdInfo.HasNonCDataAttributes { get; }
	private XmlQualifiedName System.Xml.IDtdInfo.Name { get; }
	private string System.Xml.IDtdInfo.InternalDtdSubset { get; }

	// Methods

	// RVA: 0x19AED90 Offset: 0x19AEE91 VA: 0x19AED90
	internal void .ctor() { }

	// RVA: 0x19AEF90 Offset: 0x19AF091 VA: 0x19AEF90
	public XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x19AEFA0 Offset: 0x19AF0A1 VA: 0x19AEFA0
	public void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x19AEFB0 Offset: 0x19AF0B1 VA: 0x19AEFB0
	internal void set_InternalDtdSubset(string value) { }

	// RVA: 0x19AEFC0 Offset: 0x19AF0C1 VA: 0x19AEFC0
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x19AEFD0 Offset: 0x19AF0D1 VA: 0x19AEFD0
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0x19AEFE0 Offset: 0x19AF0E1 VA: 0x19AEFE0
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	// RVA: 0x19AF080 Offset: 0x19AF181 VA: 0x19AF080
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x19AF120 Offset: 0x19AF221 VA: 0x19AF120
	internal SchemaType get_SchemaType() { }

	// RVA: 0x19AF130 Offset: 0x19AF231 VA: 0x19AF130
	internal void set_SchemaType(SchemaType value) { }

	// RVA: 0x19AF140 Offset: 0x19AF241 VA: 0x19AF140
	internal Dictionary<string, bool> get_TargetNamespaces() { }

	// RVA: 0x19AF150 Offset: 0x19AF251 VA: 0x19AF150
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x19AF160 Offset: 0x19AF261 VA: 0x19AF160
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0x19AF170 Offset: 0x19AF271 VA: 0x19AF170
	internal Dictionary<string, SchemaNotation> get_Notations() { }

	// RVA: 0x19AF210 Offset: 0x19AF311 VA: 0x19AF210
	internal int get_ErrorCount() { }

	// RVA: 0x19AF220 Offset: 0x19AF321 VA: 0x19AF220
	internal void set_ErrorCount(int value) { }

	// RVA: 0x19AF230 Offset: 0x19AF331 VA: 0x19AF230
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0x19AF2B0 Offset: 0x19AF3B1 VA: 0x19AF2B0
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0x19AF330 Offset: 0x19AF431 VA: 0x19AF330
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0x19AF3C0 Offset: 0x19AF4C1 VA: 0x19AF3C0
	internal bool HasSchema(string ns) { }

	// RVA: 0x19AF420 Offset: 0x19AF521 VA: 0x19AF420
	internal bool Contains(string ns) { }

	// RVA: 0x19AF480 Offset: 0x19AF581 VA: 0x19AF480
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0x19AF600 Offset: 0x19AF701 VA: 0x19AF600
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	// RVA: 0x19AF850 Offset: 0x19AF951 VA: 0x19AF850
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	// RVA: 0x19AF960 Offset: 0x19AFA61 VA: 0x19AF960
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0x19B06E0 Offset: 0x19B07E1 VA: 0x19B06E0
	internal void Finish() { }

	// RVA: 0x19B0910 Offset: 0x19B0A11 VA: 0x19B0910 Slot: 6
	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x19B0920 Offset: 0x19B0A21 VA: 0x19B0920 Slot: 7
	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x19B0930 Offset: 0x19B0A31 VA: 0x19B0930 Slot: 8
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0x19B0A00 Offset: 0x19B0B01 VA: 0x19B0A00 Slot: 9
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x19B0AC0 Offset: 0x19B0BC1 VA: 0x19B0AC0 Slot: 4
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x19B0AD0 Offset: 0x19B0BD1 VA: 0x19B0AD0 Slot: 5
	private string System.Xml.IDtdInfo.get_InternalDtdSubset() { }
}

