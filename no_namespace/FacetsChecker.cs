// Namespace: 
private struct FacetsChecker.FacetsCompiler.Map // TypeDefIndex: 1902
{
	// Fields
	internal char match; // 0x0
	internal string replacement; // 0x8

	// Methods

	// RVA: 0x19A59F0 Offset: 0x19A5AF1 VA: 0x19A59F0
	internal void .ctor(char m, string r) { }
}

// Namespace: 
private struct FacetsChecker.FacetsCompiler // TypeDefIndex: 1903
{
	// Fields
	private DatatypeImplementation datatype; // 0x0
	private RestrictionFacets derivedRestriction; // 0x8
	private RestrictionFlags baseFlags; // 0x10
	private RestrictionFlags baseFixedFlags; // 0x14
	private RestrictionFlags validRestrictionFlags; // 0x18
	private XmlSchemaDatatype nonNegativeInt; // 0x20
	private XmlSchemaDatatype builtInType; // 0x28
	private XmlTypeCode builtInEnum; // 0x30
	private bool firstPattern; // 0x34
	private StringBuilder regStr; // 0x38
	private XmlSchemaPatternFacet pattern_facet; // 0x40
	private static readonly FacetsChecker.FacetsCompiler.Map[] c_map; // 0x0

	// Methods

	// RVA: 0x19A1FD0 Offset: 0x19A20D1 VA: 0x19A1FD0
	public void .ctor(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

	// RVA: 0x19A2210 Offset: 0x19A2311 VA: 0x19A2210
	internal void CompileLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x19A2840 Offset: 0x19A2941 VA: 0x19A2840
	internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x19A2BB0 Offset: 0x19A2CB1 VA: 0x19A2BB0
	internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x19A2F20 Offset: 0x19A3021 VA: 0x19A2F20
	internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

	// RVA: 0x19A30E0 Offset: 0x19A31E1 VA: 0x19A30E0
	internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x19A3270 Offset: 0x19A3371 VA: 0x19A3270
	internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

	// RVA: 0x19A3630 Offset: 0x19A3731 VA: 0x19A3630
	internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x19A3CA0 Offset: 0x19A3DA1 VA: 0x19A3CA0
	internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x19A3ED0 Offset: 0x19A3FD1 VA: 0x19A3ED0
	internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x19A4100 Offset: 0x19A4201 VA: 0x19A4100
	internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x19A4330 Offset: 0x19A4431 VA: 0x19A4330
	internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x19A46B0 Offset: 0x19A47B1 VA: 0x19A46B0
	internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x19A49C0 Offset: 0x19A4AC1 VA: 0x19A49C0
	internal void FinishFacetCompile() { }

	// RVA: 0x19A3860 Offset: 0x19A3961 VA: 0x19A3860
	private void CheckValue(object value, XmlSchemaFacet facet) { }

	// RVA: 0x19A4F40 Offset: 0x19A5041 VA: 0x19A4F40
	internal void CompileFacetCombinations() { }

	// RVA: 0x19A52C0 Offset: 0x19A53C1 VA: 0x19A52C0
	private void CopyFacetsFromBaseType() { }

	// RVA: 0x19A26C0 Offset: 0x19A27C1 VA: 0x19A26C0
	private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x19A4CC0 Offset: 0x19A4DC1 VA: 0x19A4CC0
	private static string Preprocess(string pattern) { }

	// RVA: 0x19A25B0 Offset: 0x19A26B1 VA: 0x19A25B0
	private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x19A2640 Offset: 0x19A2741 VA: 0x19A2640
	private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x19A27E0 Offset: 0x19A28E1 VA: 0x19A27E0
	private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	// RVA: 0x19A5670 Offset: 0x19A5771 VA: 0x19A5670
	private void SetFlag(RestrictionFlags flag) { }

	// RVA: 0x19A56A0 Offset: 0x19A57A1 VA: 0x19A56A0
	private static void .cctor() { }
}

