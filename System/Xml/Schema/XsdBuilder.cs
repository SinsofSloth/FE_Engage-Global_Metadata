// Namespace: System.Xml.Schema
internal sealed class XsdBuilder : SchemaBuilder // TypeDefIndex: 2072
{
	// Fields
	private static readonly XsdBuilder.State[] SchemaElement; // 0x0
	private static readonly XsdBuilder.State[] SchemaSubelements; // 0x8
	private static readonly XsdBuilder.State[] AttributeSubelements; // 0x10
	private static readonly XsdBuilder.State[] ElementSubelements; // 0x18
	private static readonly XsdBuilder.State[] ComplexTypeSubelements; // 0x20
	private static readonly XsdBuilder.State[] SimpleContentSubelements; // 0x28
	private static readonly XsdBuilder.State[] SimpleContentExtensionSubelements; // 0x30
	private static readonly XsdBuilder.State[] SimpleContentRestrictionSubelements; // 0x38
	private static readonly XsdBuilder.State[] ComplexContentSubelements; // 0x40
	private static readonly XsdBuilder.State[] ComplexContentExtensionSubelements; // 0x48
	private static readonly XsdBuilder.State[] ComplexContentRestrictionSubelements; // 0x50
	private static readonly XsdBuilder.State[] SimpleTypeSubelements; // 0x58
	private static readonly XsdBuilder.State[] SimpleTypeRestrictionSubelements; // 0x60
	private static readonly XsdBuilder.State[] SimpleTypeListSubelements; // 0x68
	private static readonly XsdBuilder.State[] SimpleTypeUnionSubelements; // 0x70
	private static readonly XsdBuilder.State[] RedefineSubelements; // 0x78
	private static readonly XsdBuilder.State[] AttributeGroupSubelements; // 0x80
	private static readonly XsdBuilder.State[] GroupSubelements; // 0x88
	private static readonly XsdBuilder.State[] AllSubelements; // 0x90
	private static readonly XsdBuilder.State[] ChoiceSequenceSubelements; // 0x98
	private static readonly XsdBuilder.State[] IdentityConstraintSubelements; // 0xA0
	private static readonly XsdBuilder.State[] AnnotationSubelements; // 0xA8
	private static readonly XsdBuilder.State[] AnnotatedSubelements; // 0xB0
	private static readonly XsdBuilder.XsdAttributeEntry[] SchemaAttributes; // 0xB8
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeAttributes; // 0xC0
	private static readonly XsdBuilder.XsdAttributeEntry[] ElementAttributes; // 0xC8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexTypeAttributes; // 0xD0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentAttributes; // 0xD8
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentExtensionAttributes; // 0xE0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentRestrictionAttributes; // 0xE8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentAttributes; // 0xF0
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentExtensionAttributes; // 0xF8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentRestrictionAttributes; // 0x100
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeAttributes; // 0x108
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeRestrictionAttributes; // 0x110
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeUnionAttributes; // 0x118
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeListAttributes; // 0x120
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupAttributes; // 0x128
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupRefAttributes; // 0x130
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupAttributes; // 0x138
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupRefAttributes; // 0x140
	private static readonly XsdBuilder.XsdAttributeEntry[] ParticleAttributes; // 0x148
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributes; // 0x150
	private static readonly XsdBuilder.XsdAttributeEntry[] IdentityConstraintAttributes; // 0x158
	private static readonly XsdBuilder.XsdAttributeEntry[] SelectorAttributes; // 0x160
	private static readonly XsdBuilder.XsdAttributeEntry[] FieldAttributes; // 0x168
	private static readonly XsdBuilder.XsdAttributeEntry[] NotationAttributes; // 0x170
	private static readonly XsdBuilder.XsdAttributeEntry[] IncludeAttributes; // 0x178
	private static readonly XsdBuilder.XsdAttributeEntry[] ImportAttributes; // 0x180
	private static readonly XsdBuilder.XsdAttributeEntry[] FacetAttributes; // 0x188
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributeAttributes; // 0x190
	private static readonly XsdBuilder.XsdAttributeEntry[] DocumentationAttributes; // 0x198
	private static readonly XsdBuilder.XsdAttributeEntry[] AppinfoAttributes; // 0x1A0
	private static readonly XsdBuilder.XsdAttributeEntry[] RedefineAttributes; // 0x1A8
	private static readonly XsdBuilder.XsdAttributeEntry[] AnnotationAttributes; // 0x1B0
	private static readonly XsdBuilder.XsdEntry[] SchemaEntries; // 0x1B8
	private static readonly int[] DerivationMethodValues; // 0x1C0
	private static readonly string[] DerivationMethodStrings; // 0x1C8
	private static readonly string[] FormStringValues; // 0x1D0
	private static readonly string[] UseStringValues; // 0x1D8
	private static readonly string[] ProcessContentsStringValues; // 0x1E0
	private XmlReader reader; // 0x10
	private PositionInfo positionInfo; // 0x18
	private XsdBuilder.XsdEntry currentEntry; // 0x20
	private XsdBuilder.XsdEntry nextEntry; // 0x28
	private bool hasChild; // 0x30
	private HWStack stateHistory; // 0x38
	private Stack containerStack; // 0x40
	private XmlNameTable nameTable; // 0x48
	private SchemaNames schemaNames; // 0x50
	private XmlNamespaceManager namespaceManager; // 0x58
	private bool canIncludeImport; // 0x60
	private XmlSchema schema; // 0x68
	private XmlSchemaObject xso; // 0x70
	private XmlSchemaElement element; // 0x78
	private XmlSchemaAny anyElement; // 0x80
	private XmlSchemaAttribute attribute; // 0x88
	private XmlSchemaAnyAttribute anyAttribute; // 0x90
	private XmlSchemaComplexType complexType; // 0x98
	private XmlSchemaSimpleType simpleType; // 0xA0
	private XmlSchemaComplexContent complexContent; // 0xA8
	private XmlSchemaComplexContentExtension complexContentExtension; // 0xB0
	private XmlSchemaComplexContentRestriction complexContentRestriction; // 0xB8
	private XmlSchemaSimpleContent simpleContent; // 0xC0
	private XmlSchemaSimpleContentExtension simpleContentExtension; // 0xC8
	private XmlSchemaSimpleContentRestriction simpleContentRestriction; // 0xD0
	private XmlSchemaSimpleTypeUnion simpleTypeUnion; // 0xD8
	private XmlSchemaSimpleTypeList simpleTypeList; // 0xE0
	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction; // 0xE8
	private XmlSchemaGroup group; // 0xF0
	private XmlSchemaGroupRef groupRef; // 0xF8
	private XmlSchemaAll all; // 0x100
	private XmlSchemaChoice choice; // 0x108
	private XmlSchemaSequence sequence; // 0x110
	private XmlSchemaParticle particle; // 0x118
	private XmlSchemaAttributeGroup attributeGroup; // 0x120
	private XmlSchemaAttributeGroupRef attributeGroupRef; // 0x128
	private XmlSchemaNotation notation; // 0x130
	private XmlSchemaIdentityConstraint identityConstraint; // 0x138
	private XmlSchemaXPath xpath; // 0x140
	private XmlSchemaInclude include; // 0x148
	private XmlSchemaImport import; // 0x150
	private XmlSchemaAnnotation annotation; // 0x158
	private XmlSchemaAppInfo appInfo; // 0x160
	private XmlSchemaDocumentation documentation; // 0x168
	private XmlSchemaFacet facet; // 0x170
	private XmlNode[] markup; // 0x178
	private XmlSchemaRedefine redefine; // 0x180
	private ValidationEventHandler validationEventHandler; // 0x188
	private ArrayList unhandledAttributes; // 0x190
	private Hashtable namespaces; // 0x198

	// Properties
	private SchemaNames.Token CurrentElement { get; }
	private SchemaNames.Token ParentElement { get; }
	private XmlSchemaObject ParentContainer { get; }

	// Methods

	// RVA: 0x19F71E0 Offset: 0x19F72E1 VA: 0x19F71E0
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x19F7450 Offset: 0x19F7551 VA: 0x19F7450 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x19F7A10 Offset: 0x19F7B11 VA: 0x19F7A10 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x19F7F60 Offset: 0x19F8061 VA: 0x19F7F60 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0x19F7F70 Offset: 0x19F8071 VA: 0x19F7F70 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x19F7F80 Offset: 0x19F8081 VA: 0x19F7F80 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0x19F7FE0 Offset: 0x19F80E1 VA: 0x19F7FE0 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0x19F8170 Offset: 0x19F8271 VA: 0x19F8170 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0x19F7750 Offset: 0x19F7851 VA: 0x19F7750
	private void Push() { }

	// RVA: 0x19F81B0 Offset: 0x19F82B1 VA: 0x19F81B0
	private void Pop() { }

	// RVA: 0x19F8EB0 Offset: 0x19F8FB1 VA: 0x19F8EB0
	private SchemaNames.Token get_CurrentElement() { }

	// RVA: 0x19F8EC0 Offset: 0x19F8FC1 VA: 0x19F8EC0
	private SchemaNames.Token get_ParentElement() { }

	// RVA: 0x19F8F40 Offset: 0x19F9041 VA: 0x19F8F40
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0x19F8270 Offset: 0x19F8371 VA: 0x19F8270
	private XmlSchemaObject GetContainer(XsdBuilder.State state) { }

	// RVA: 0x19F8430 Offset: 0x19F8531 VA: 0x19F8430
	private void SetContainer(XsdBuilder.State state, object container) { }

	// RVA: 0x19F8FD0 Offset: 0x19F90D1 VA: 0x19F8FD0
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0x19F8FE0 Offset: 0x19F90E1 VA: 0x19F8FE0
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x19F9170 Offset: 0x19F9271 VA: 0x19F9170
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x19F9220 Offset: 0x19F9321 VA: 0x19F9220
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0x19F9230 Offset: 0x19F9331 VA: 0x19F9230
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0x19F9240 Offset: 0x19F9341 VA: 0x19F9240
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0x19F9530 Offset: 0x19F9631 VA: 0x19F9530
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0x19F95A0 Offset: 0x19F96A1 VA: 0x19F95A0
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0x19F95C0 Offset: 0x19F96C1 VA: 0x19F95C0
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0x19F9680 Offset: 0x19F9781 VA: 0x19F9680
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x19F9690 Offset: 0x19F9791 VA: 0x19F9690
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0x19F9750 Offset: 0x19F9851 VA: 0x19F9750
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x19F9760 Offset: 0x19F9861 VA: 0x19F9760
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x19F9770 Offset: 0x19F9871 VA: 0x19F9770
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0x19F9830 Offset: 0x19F9931 VA: 0x19F9830
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x19F9840 Offset: 0x19F9941 VA: 0x19F9840
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0x19F9850 Offset: 0x19F9951 VA: 0x19F9850
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x19F9BA0 Offset: 0x19F9CA1 VA: 0x19F9BA0
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0x19F9BB0 Offset: 0x19F9CB1 VA: 0x19F9BB0
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x19F9BC0 Offset: 0x19F9CC1 VA: 0x19F9BC0
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0x19F9C70 Offset: 0x19F9D71 VA: 0x19F9C70
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0x19F9D20 Offset: 0x19F9E21 VA: 0x19F9D20
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x19F9F20 Offset: 0x19FA021 VA: 0x19F9F20
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0x19F9F30 Offset: 0x19FA031 VA: 0x19F9F30
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0x19F9FA0 Offset: 0x19FA0A1 VA: 0x19F9FA0
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0x19FA0F0 Offset: 0x19FA1F1 VA: 0x19FA0F0
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x19FA280 Offset: 0x19FA381 VA: 0x19FA280
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0x19FA2F0 Offset: 0x19FA3F1 VA: 0x19FA2F0
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0x19FA300 Offset: 0x19FA401 VA: 0x19FA300
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0x19FA3B0 Offset: 0x19FA4B1 VA: 0x19FA3B0
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0x19FA420 Offset: 0x19FA521 VA: 0x19FA420
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0x19FA490 Offset: 0x19FA591 VA: 0x19FA490
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x19FA4A0 Offset: 0x19FA5A1 VA: 0x19FA4A0
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x19FA570 Offset: 0x19FA671 VA: 0x19FA570
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x19FA640 Offset: 0x19FA741 VA: 0x19FA640
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0x19FA650 Offset: 0x19FA751 VA: 0x19FA650
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0x19FA6C0 Offset: 0x19FA7C1 VA: 0x19FA6C0
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x19FA730 Offset: 0x19FA831 VA: 0x19FA730
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0x19FA7A0 Offset: 0x19FA8A1 VA: 0x19FA7A0
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0x19FAAE0 Offset: 0x19FABE1 VA: 0x19FAAE0
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x19FAAF0 Offset: 0x19FABF1 VA: 0x19FAAF0
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x19FAB60 Offset: 0x19FAC61 VA: 0x19FAB60
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0x19FAC20 Offset: 0x19FAD21 VA: 0x19FAC20
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0x19FADE0 Offset: 0x19FAEE1 VA: 0x19FADE0
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0x19FAEA0 Offset: 0x19FAFA1 VA: 0x19FAEA0
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0x19FAF10 Offset: 0x19FB011 VA: 0x19FAF10
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x19FAFD0 Offset: 0x19FB0D1 VA: 0x19FAFD0
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x19FB040 Offset: 0x19FB141 VA: 0x19FB040
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0x19FB200 Offset: 0x19FB301 VA: 0x19FB200
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x19FB270 Offset: 0x19FB371 VA: 0x19FB270
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0x19FB2E0 Offset: 0x19FB3E1 VA: 0x19FB2E0
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x19FB350 Offset: 0x19FB451 VA: 0x19FB350
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x19FB3D0 Offset: 0x19FB4D1 VA: 0x19FB3D0
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x19FB3E0 Offset: 0x19FB4E1 VA: 0x19FB3E0
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0x19FB4E0 Offset: 0x19FB5E1 VA: 0x19FB4E0
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x19FB550 Offset: 0x19FB651 VA: 0x19FB550
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x19FB640 Offset: 0x19FB741 VA: 0x19FB640
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x19FB6B0 Offset: 0x19FB7B1 VA: 0x19FB6B0
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x19FB750 Offset: 0x19FB851 VA: 0x19FB750
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x19FB7C0 Offset: 0x19FB8C1 VA: 0x19FB7C0
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0x19FB8C0 Offset: 0x19FB9C1 VA: 0x19FB8C0
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x19FB9B0 Offset: 0x19FBAB1 VA: 0x19FB9B0
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x19FBA20 Offset: 0x19FBB21 VA: 0x19FBA20
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x19FBB10 Offset: 0x19FBC11 VA: 0x19FBB10
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x19FBB80 Offset: 0x19FBC81 VA: 0x19FBB80
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0x19FBCA0 Offset: 0x19FBDA1 VA: 0x19FBCA0
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x19FBCB0 Offset: 0x19FBDB1 VA: 0x19FBCB0
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x19FBD40 Offset: 0x19FBE41 VA: 0x19FBD40
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x19FBDB0 Offset: 0x19FBEB1 VA: 0x19FBDB0
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x19FC090 Offset: 0x19FC191 VA: 0x19FC090
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x19FC0A0 Offset: 0x19FC1A1 VA: 0x19FC0A0
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x19FC150 Offset: 0x19FC251 VA: 0x19FC150
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0x19FC280 Offset: 0x19FC381 VA: 0x19FC280
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x19FC290 Offset: 0x19FC391 VA: 0x19FC290
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x19FC6A0 Offset: 0x19FC7A1 VA: 0x19FC6A0
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x19FC6B0 Offset: 0x19FC7B1 VA: 0x19FC6B0
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x19FC6C0 Offset: 0x19FC7C1 VA: 0x19FC6C0
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x19FC730 Offset: 0x19FC831 VA: 0x19FC730
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0x19FC7D0 Offset: 0x19FC8D1 VA: 0x19FC7D0
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0x19FC870 Offset: 0x19FC971 VA: 0x19FC870
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0x19FC910 Offset: 0x19FCA11 VA: 0x19FC910
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0x19FC9B0 Offset: 0x19FCAB1 VA: 0x19FC9B0
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x19FC9C0 Offset: 0x19FCAC1 VA: 0x19FC9C0
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x19FCA70 Offset: 0x19FCB71 VA: 0x19FCA70
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0x19FCB10 Offset: 0x19FCC11 VA: 0x19FCB10
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0x19FCB20 Offset: 0x19FCC21 VA: 0x19FCB20
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0x19FCB30 Offset: 0x19FCC31 VA: 0x19FCB30
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0x19FCB40 Offset: 0x19FCC41 VA: 0x19FCB40
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0x19FCE90 Offset: 0x19FCF91 VA: 0x19FCE90
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x19FCF10 Offset: 0x19FD011 VA: 0x19FCF10
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0x19FCF20 Offset: 0x19FD021 VA: 0x19FCF20
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0x19FD060 Offset: 0x19FD161 VA: 0x19FD060
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0x19FD070 Offset: 0x19FD171 VA: 0x19FD070
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0x19FD190 Offset: 0x19FD291 VA: 0x19FD190
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0x19FD260 Offset: 0x19FD361 VA: 0x19FD260
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x19FD270 Offset: 0x19FD371 VA: 0x19FD270
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0x19FD340 Offset: 0x19FD441 VA: 0x19FD340
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x19FD350 Offset: 0x19FD451 VA: 0x19FD350
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0x19FD520 Offset: 0x19FD621 VA: 0x19FD520
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0x19FD5F0 Offset: 0x19FD6F1 VA: 0x19FD5F0
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0x19FD680 Offset: 0x19FD781 VA: 0x19FD680
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0x19FD6A0 Offset: 0x19FD7A1 VA: 0x19FD6A0
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0x19FD770 Offset: 0x19FD871 VA: 0x19FD770
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0x19FD7F0 Offset: 0x19FD8F1 VA: 0x19FD7F0
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0x19FD900 Offset: 0x19FDA01 VA: 0x19FD900
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0x19F9960 Offset: 0x19F9A61 VA: 0x19F9960
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0x19FC330 Offset: 0x19FC431 VA: 0x19FC330
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0x19F75E0 Offset: 0x19F76E1 VA: 0x19F75E0
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x19F7910 Offset: 0x19F7A11 VA: 0x19F7910
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x19FA580 Offset: 0x19FA681 VA: 0x19FA580
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x19FA4B0 Offset: 0x19FA5B1 VA: 0x19FA4B0
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x19FA160 Offset: 0x19FA261 VA: 0x19FA160
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0x19F9090 Offset: 0x19F9191 VA: 0x19F9090
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0x19F9D90 Offset: 0x19F9E91 VA: 0x19F9D90
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0x19F92B0 Offset: 0x19F93B1 VA: 0x19F92B0
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x19FD670 Offset: 0x19FD771 VA: 0x19FD670
	private static string ParseUriReference(string s) { }

	// RVA: 0x19FD920 Offset: 0x19FDA21 VA: 0x19FD920
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0x19F7930 Offset: 0x19F7A31 VA: 0x19F7930
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x19F7E80 Offset: 0x19F7F81 VA: 0x19F7E80
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x19FDAE0 Offset: 0x19FDBE1 VA: 0x19FDAE0
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x19FADD0 Offset: 0x19FAED1 VA: 0x19FADD0
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x19F77F0 Offset: 0x19F78F1 VA: 0x19F77F0
	private void RecordPosition() { }

	// RVA: 0x19FDBC0 Offset: 0x19FDCC1 VA: 0x19FDBC0
	private static void .cctor() { }
}

