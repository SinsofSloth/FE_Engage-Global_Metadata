// Namespace: System.Xml.Schema
internal sealed class AllElementsContentValidator : ContentValidator // TypeDefIndex: 1830
{
	// Fields
	private Hashtable elements; // 0x18
	private object[] particles; // 0x20
	private BitSet isRequired; // 0x28
	private int countRequired; // 0x30

	// Properties
	public override bool IsEmptiable { get; }

	// Methods

	// RVA: 0x1A20FA0 Offset: 0x1A210A1 VA: 0x1A20FA0
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0x1A211B0 Offset: 0x1A212B1 VA: 0x1A211B0
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0x1A213F0 Offset: 0x1A214F1 VA: 0x1A213F0 Slot: 4
	public override bool get_IsEmptiable() { }

	// RVA: 0x1A21410 Offset: 0x1A21511 VA: 0x1A21410 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1A21500 Offset: 0x1A21601 VA: 0x1A21500 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1A21700 Offset: 0x1A21801 VA: 0x1A21700 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1A21760 Offset: 0x1A21861 VA: 0x1A21760 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1A21B70 Offset: 0x1A21C71 VA: 0x1A21B70 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

