// Namespace: System.Xml.Schema
internal sealed class NfaContentValidator : ContentValidator // TypeDefIndex: 1827
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private SymbolsDictionary symbols; // 0x28
	private Positions positions; // 0x30
	private int endMarkerPos; // 0x38

	// Methods

	// RVA: 0x3242800 Offset: 0x3242901 VA: 0x3242800
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x3242900 Offset: 0x3242A01 VA: 0x3242900 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x3242A10 Offset: 0x3242B11 VA: 0x3242A10 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x3242D40 Offset: 0x3242E41 VA: 0x3242D40 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x3242D90 Offset: 0x3242E91 VA: 0x3242D90 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x3243010 Offset: 0x3243111 VA: 0x3243010 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

