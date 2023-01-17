// Namespace: System.Xml.Schema
internal sealed class DfaContentValidator : ContentValidator // TypeDefIndex: 1826
{
	// Fields
	private int[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x359FDC0 Offset: 0x359FEC1 VA: 0x359FDC0
	internal void .ctor(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x359FE90 Offset: 0x359FF91 VA: 0x359FE90 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x359FF00 Offset: 0x35A0001 VA: 0x359FF00 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x35A0020 Offset: 0x35A0121 VA: 0x35A0020 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x35A0030 Offset: 0x35A0131 VA: 0x35A0030 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x35A01F0 Offset: 0x35A02F1 VA: 0x35A01F0 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

