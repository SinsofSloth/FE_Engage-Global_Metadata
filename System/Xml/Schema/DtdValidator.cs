// Namespace: System.Xml.Schema
internal sealed class DtdValidator : BaseValidator // TypeDefIndex: 1901
{
	// Fields
	private static DtdValidator.NamespaceManager namespaceManager; // 0x0
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private Hashtable IDs; // 0x98
	private IdRefNode idRefListHead; // 0xA0
	private bool processIdentityConstraints; // 0xA8

	// Properties
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x323AC20 Offset: 0x323AD21 VA: 0x323AC20
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x323ACE0 Offset: 0x323ADE1 VA: 0x323ACE0
	private void Init() { }

	// RVA: 0x323B050 Offset: 0x323B151 VA: 0x323B050 Slot: 5
	public override void Validate() { }

	// RVA: 0x323B3F0 Offset: 0x323B4F1 VA: 0x323B3F0
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x323B490 Offset: 0x323B591 VA: 0x323B490
	private void ValidatePIComment() { }

	// RVA: 0x323B300 Offset: 0x323B401 VA: 0x323B300
	private void ValidateElement() { }

	// RVA: 0x323B8A0 Offset: 0x323B9A1 VA: 0x323B8A0
	private void ValidateChildElement() { }

	// RVA: 0x323BB00 Offset: 0x323BC01 VA: 0x323BB00
	private void ValidateStartElement() { }

	// RVA: 0x323C3E0 Offset: 0x323C4E1 VA: 0x323C3E0
	private void ValidateEndStartElement() { }

	// RVA: 0x323B9E0 Offset: 0x323BAE1 VA: 0x323B9E0
	private void ProcessElement() { }

	// RVA: 0x323C590 Offset: 0x323C691 VA: 0x323C590 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x323B700 Offset: 0x323B801 VA: 0x323B700
	private void ValidateEndElement() { }

	// RVA: 0x323C800 Offset: 0x323C901 VA: 0x323C800 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x323C820 Offset: 0x323C921 VA: 0x323C820
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x323BEA0 Offset: 0x323BFA1 VA: 0x323BEA0
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x323CAA0 Offset: 0x323CBA1 VA: 0x323CAA0
	internal void AddID(string name, object node) { }

	// RVA: 0x323CBB0 Offset: 0x323CCB1 VA: 0x323CBB0 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x323B560 Offset: 0x323B661 VA: 0x323B560
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x323CBD0 Offset: 0x323CCD1 VA: 0x323CBD0
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x323C6D0 Offset: 0x323C7D1 VA: 0x323C6D0
	private void CheckForwardRefs() { }

	// RVA: 0x323AF50 Offset: 0x323B051 VA: 0x323AF50
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x323C5E0 Offset: 0x323C6E1 VA: 0x323C5E0
	private bool Pop() { }

	// RVA: 0x323CEF0 Offset: 0x323CFF1 VA: 0x323CEF0
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x323D260 Offset: 0x323D361 VA: 0x323D260
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x323D680 Offset: 0x323D781 VA: 0x323D680
	private static void .cctor() { }
}

