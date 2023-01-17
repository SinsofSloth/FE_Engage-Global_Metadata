// Namespace: System.Xml.Schema
internal sealed class SchemaCollectionCompiler : BaseProcessor // TypeDefIndex: 1926
{
	// Fields
	private bool compileContentModel; // 0x40
	private XmlSchemaObjectTable examplars; // 0x48
	private Stack complexTypeStack; // 0x50
	private XmlSchema schema; // 0x58

	// Methods

	// RVA: 0x1A59A00 Offset: 0x1A59B01 VA: 0x1A59A00
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0x1A59AD0 Offset: 0x1A59BD1 VA: 0x1A59AD0
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0x1A59B50 Offset: 0x1A59C51 VA: 0x1A59B50
	private void Prepare() { }

	// RVA: 0x1A59F40 Offset: 0x1A5A041 VA: 0x1A59F40
	private void Cleanup() { }

	// RVA: 0x1A5DCB0 Offset: 0x1A5DDB1 VA: 0x1A5DCB0
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0x1A5AD20 Offset: 0x1A5AE21 VA: 0x1A5AD20
	private void Compile() { }

	// RVA: 0x1A5C9A0 Offset: 0x1A5CAA1 VA: 0x1A5C9A0
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x1A5DC70 Offset: 0x1A5DD71 VA: 0x1A5DC70
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1A5D750 Offset: 0x1A5D851 VA: 0x1A5D750
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1A5D7A0 Offset: 0x1A5D8A1 VA: 0x1A5D7A0
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1A5DAD0 Offset: 0x1A5DBD1 VA: 0x1A5DAD0
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1A5DAE0 Offset: 0x1A5DBE1 VA: 0x1A5DAE0
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x1A62720 Offset: 0x1A62821 VA: 0x1A62720
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1A5D720 Offset: 0x1A5D821 VA: 0x1A5D720
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x1A62820 Offset: 0x1A62921 VA: 0x1A62820
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1A5E340 Offset: 0x1A5E441 VA: 0x1A5E340
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0x1A62550 Offset: 0x1A62651 VA: 0x1A62550
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x1A5E7B0 Offset: 0x1A5E8B1 VA: 0x1A5E7B0
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x1A5FD10 Offset: 0x1A5FE11 VA: 0x1A5FD10
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1A62D80 Offset: 0x1A62E81 VA: 0x1A62D80
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1A63120 Offset: 0x1A63221 VA: 0x1A63120
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x1A5EFC0 Offset: 0x1A5F0C1 VA: 0x1A5EFC0
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1A63230 Offset: 0x1A63331 VA: 0x1A63230
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x1A63490 Offset: 0x1A63591 VA: 0x1A63490
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x1A63990 Offset: 0x1A63A91 VA: 0x1A63990
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x1A63E60 Offset: 0x1A63F61 VA: 0x1A63E60
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x1A62400 Offset: 0x1A62501 VA: 0x1A62400
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x1A65530 Offset: 0x1A65631 VA: 0x1A65530
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0x1A62990 Offset: 0x1A62A91 VA: 0x1A62990
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0x1A66890 Offset: 0x1A66991 VA: 0x1A66890
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0x1A669D0 Offset: 0x1A66AD1 VA: 0x1A669D0
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0x1A66F80 Offset: 0x1A67081 VA: 0x1A66F80
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0x1A67450 Offset: 0x1A67551 VA: 0x1A67450
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0x1A679B0 Offset: 0x1A67AB1 VA: 0x1A679B0
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0x1A66270 Offset: 0x1A66371 VA: 0x1A66270
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1A67F50 Offset: 0x1A68051 VA: 0x1A67F50
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x1A68070 Offset: 0x1A68171 VA: 0x1A68070
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x1A680D0 Offset: 0x1A681D1 VA: 0x1A680D0
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x1A68120 Offset: 0x1A68221 VA: 0x1A68120
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x1A683A0 Offset: 0x1A684A1 VA: 0x1A683A0
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1A686F0 Offset: 0x1A687F1 VA: 0x1A686F0
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1A68A90 Offset: 0x1A68B91 VA: 0x1A68A90
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x1A68D90 Offset: 0x1A68E91 VA: 0x1A68D90
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1A69A30 Offset: 0x1A69B31 VA: 0x1A69A30
	private void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x1A69000 Offset: 0x1A69101 VA: 0x1A69000
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1A69820 Offset: 0x1A69921 VA: 0x1A69820
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x1A69920 Offset: 0x1A69A21 VA: 0x1A69920
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x1A67EA0 Offset: 0x1A67FA1 VA: 0x1A67EA0
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x1A690F0 Offset: 0x1A691F1 VA: 0x1A690F0
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x1A69E30 Offset: 0x1A69F31 VA: 0x1A69E30
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1A656B0 Offset: 0x1A657B1 VA: 0x1A656B0
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x1A5E8B0 Offset: 0x1A5E9B1 VA: 0x1A5E8B0
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1A641F0 Offset: 0x1A642F1 VA: 0x1A641F0
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x1A69EF0 Offset: 0x1A69FF1 VA: 0x1A69EF0
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1A69E50 Offset: 0x1A69F51 VA: 0x1A69E50
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1A612C0 Offset: 0x1A613C1 VA: 0x1A612C0
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x1A61D40 Offset: 0x1A61E41 VA: 0x1A61D40
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x1A60630 Offset: 0x1A60731 VA: 0x1A60630
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x1A65750 Offset: 0x1A65851 VA: 0x1A65750
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x1A69F90 Offset: 0x1A6A091 VA: 0x1A69F90
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x1A6A520 Offset: 0x1A6A621 VA: 0x1A6A520
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x1A62320 Offset: 0x1A62421 VA: 0x1A62320
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x1A62C10 Offset: 0x1A62D11 VA: 0x1A62C10
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x1A661B0 Offset: 0x1A662B1 VA: 0x1A661B0
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x1A66040 Offset: 0x1A66141 VA: 0x1A66040
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }
}

