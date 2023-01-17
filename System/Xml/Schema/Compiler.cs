// Namespace: System.Xml.Schema
internal sealed class Compiler : BaseProcessor // TypeDefIndex: 1939
{
	// Fields
	private string restrictionErrorMsg; // 0x40
	private XmlSchemaObjectTable attributes; // 0x48
	private XmlSchemaObjectTable attributeGroups; // 0x50
	private XmlSchemaObjectTable elements; // 0x58
	private XmlSchemaObjectTable schemaTypes; // 0x60
	private XmlSchemaObjectTable groups; // 0x68
	private XmlSchemaObjectTable notations; // 0x70
	private XmlSchemaObjectTable examplars; // 0x78
	private XmlSchemaObjectTable identityConstraints; // 0x80
	private Stack complexTypeStack; // 0x88
	private Hashtable schemasToCompile; // 0x90
	private Hashtable importedSchemas; // 0x98
	private XmlSchema schemaForSchema; // 0xA0

	// Methods

	// RVA: 0x1A28D30 Offset: 0x1A28E31 VA: 0x1A28D30
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1A28F80 Offset: 0x1A29081 VA: 0x1A28F80
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0x1A2BB40 Offset: 0x1A2BC41 VA: 0x1A2BB40
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0x1A2DCD0 Offset: 0x1A2DDD1 VA: 0x1A2DCD0
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0x1A2AC80 Offset: 0x1A2AD81 VA: 0x1A2AC80
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x1A2DE60 Offset: 0x1A2DF61 VA: 0x1A2DE60
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0x1A29010 Offset: 0x1A29111 VA: 0x1A29010
	internal bool Compile() { }

	// RVA: 0x1A2D660 Offset: 0x1A2D761 VA: 0x1A2D660
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1A2D780 Offset: 0x1A2D881 VA: 0x1A2D780
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1A2D7E0 Offset: 0x1A2D8E1 VA: 0x1A2D7E0
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1A2DC20 Offset: 0x1A2DD21 VA: 0x1A2DC20
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1A2D430 Offset: 0x1A2D531 VA: 0x1A2D430
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x1A328E0 Offset: 0x1A329E1 VA: 0x1A328E0
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1A2D730 Offset: 0x1A2D831 VA: 0x1A2D730
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x1A329C0 Offset: 0x1A32AC1 VA: 0x1A329C0
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1A31A30 Offset: 0x1A31B31 VA: 0x1A31A30
	private void ProcessSubstitutionGroups() { }

	// RVA: 0x1A32B70 Offset: 0x1A32C71 VA: 0x1A32B70
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x1A32770 Offset: 0x1A32871 VA: 0x1A32770
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0x1A32860 Offset: 0x1A32961 VA: 0x1A32860
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0x1A2DF70 Offset: 0x1A2E071 VA: 0x1A2DF70
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x1A2F420 Offset: 0x1A2F521 VA: 0x1A2F420
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1A33DB0 Offset: 0x1A33EB1 VA: 0x1A33DB0
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1A34150 Offset: 0x1A34251 VA: 0x1A34150
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x1A2E830 Offset: 0x1A2E931 VA: 0x1A2E830
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1A34260 Offset: 0x1A34361 VA: 0x1A34260
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x1A344B0 Offset: 0x1A345B1 VA: 0x1A344B0
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x1A34990 Offset: 0x1A34A91 VA: 0x1A34990
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x1A34DC0 Offset: 0x1A34EC1 VA: 0x1A34DC0
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x1A32190 Offset: 0x1A32291 VA: 0x1A32190
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x1A33370 Offset: 0x1A33471 VA: 0x1A33370
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1A36610 Offset: 0x1A36711 VA: 0x1A36610
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1A32FB0 Offset: 0x1A330B1 VA: 0x1A32FB0
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0x1A39640 Offset: 0x1A39741 VA: 0x1A39640
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0x1A381C0 Offset: 0x1A382C1 VA: 0x1A381C0
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0x1A38800 Offset: 0x1A38901 VA: 0x1A38800
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0x1A38AE0 Offset: 0x1A38BE1 VA: 0x1A38AE0
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0x1A390F0 Offset: 0x1A391F1 VA: 0x1A390F0
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0x1A37460 Offset: 0x1A37561 VA: 0x1A37460
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0x1A376F0 Offset: 0x1A377F1 VA: 0x1A376F0
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1A39990 Offset: 0x1A39A91 VA: 0x1A39990
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x1A39BA0 Offset: 0x1A39CA1 VA: 0x1A39BA0
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x1A39D50 Offset: 0x1A39E51 VA: 0x1A39D50
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x1A39E60 Offset: 0x1A39F61 VA: 0x1A39E60
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x1A3A300 Offset: 0x1A3A401 VA: 0x1A3A300
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0x1A3B380 Offset: 0x1A3B481 VA: 0x1A3B380
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1A3ABB0 Offset: 0x1A3ACB1 VA: 0x1A3ABB0
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1A3AFC0 Offset: 0x1A3B0C1 VA: 0x1A3AFC0
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x1A3B510 Offset: 0x1A3B611 VA: 0x1A3B510
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1A3B8A0 Offset: 0x1A3B9A1 VA: 0x1A3B8A0
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1A3C200 Offset: 0x1A3C301 VA: 0x1A3C200
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x1A3C300 Offset: 0x1A3C401 VA: 0x1A3C300
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x1A398E0 Offset: 0x1A399E1 VA: 0x1A398E0
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x1A3BB00 Offset: 0x1A3BC01 VA: 0x1A3BB00
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x1A3C410 Offset: 0x1A3C511 VA: 0x1A3C410
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1A36810 Offset: 0x1A36911 VA: 0x1A36810
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x1A2E060 Offset: 0x1A2E161 VA: 0x1A2E060
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1A35100 Offset: 0x1A35201 VA: 0x1A35100
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x1A33450 Offset: 0x1A33551 VA: 0x1A33450
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0x1A3C570 Offset: 0x1A3C671 VA: 0x1A3C570
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0x1A3C4D0 Offset: 0x1A3C5D1 VA: 0x1A3C4D0
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1A3C430 Offset: 0x1A3C531 VA: 0x1A3C430
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1A30B10 Offset: 0x1A30C11 VA: 0x1A30B10
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x1A3C690 Offset: 0x1A3C791 VA: 0x1A3C690
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0x1A31340 Offset: 0x1A31441 VA: 0x1A31340
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x1A2FD70 Offset: 0x1A2FE71 VA: 0x1A2FD70
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x1A368B0 Offset: 0x1A369B1 VA: 0x1A368B0
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x1A3C830 Offset: 0x1A3C931 VA: 0x1A3C830
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x1A3CDC0 Offset: 0x1A3CEC1 VA: 0x1A3CDC0
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x1A331E0 Offset: 0x1A332E1 VA: 0x1A331E0
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0x1A31910 Offset: 0x1A31A11 VA: 0x1A31910
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x1A33CC0 Offset: 0x1A33DC1 VA: 0x1A33CC0
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x1A373B0 Offset: 0x1A374B1 VA: 0x1A373B0
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x1A37240 Offset: 0x1A37341 VA: 0x1A37240
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0x1A39860 Offset: 0x1A39961 VA: 0x1A39860
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0x1A3B990 Offset: 0x1A3BA91 VA: 0x1A3B990
	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }
}

