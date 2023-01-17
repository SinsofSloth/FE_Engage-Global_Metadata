// Namespace: System.Xml.Schema
internal sealed class RangeContentValidator : ContentValidator // TypeDefIndex: 1829
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private BitSet positionsWithRangeTerminals; // 0x28
	private SymbolsDictionary symbols; // 0x30
	private Positions positions; // 0x38
	private int minMaxNodesCount; // 0x40
	private int endMarkerPos; // 0x44

	// Methods

	// RVA: 0x1A57C50 Offset: 0x1A57D51 VA: 0x1A57C50
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0x1A57D70 Offset: 0x1A57E71 VA: 0x1A57D70 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1A57EF0 Offset: 0x1A57FF1 VA: 0x1A57EF0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1A587A0 Offset: 0x1A588A1 VA: 0x1A587A0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1A587B0 Offset: 0x1A588B1 VA: 0x1A587B0 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1A58A10 Offset: 0x1A58B11 VA: 0x1A58A10 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

