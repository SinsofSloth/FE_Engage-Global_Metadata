// Namespace: System.Xml.Schema
internal sealed class XsdValidator : BaseValidator // TypeDefIndex: 2081
{
	// Fields
	private int startIDConstraint; // 0x7C
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlNamespaceManager nsManager; // 0x90
	private bool bManageNamespaces; // 0x98
	private Hashtable IDs; // 0xA0
	private IdRefNode idRefListHead; // 0xA8
	private Parser inlineSchemaParser; // 0xB0
	private XmlSchemaContentProcessing processContents; // 0xB8
	private static readonly XmlSchemaDatatype dtCDATA; // 0x0
	private static readonly XmlSchemaDatatype dtQName; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private string NsXmlNs; // 0xC0
	private string NsXs; // 0xC8
	private string NsXsi; // 0xD0
	private string XsiType; // 0xD8
	private string XsiNil; // 0xE0
	private string XsiSchemaLocation; // 0xE8
	private string XsiNoNamespaceSchemaLocation; // 0xF0
	private string XsdSchema; // 0xF8

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }
	private bool HasIdentityConstraints { get; }

	// Methods

	// RVA: 0x199CBF0 Offset: 0x199CCF1 VA: 0x199CBF0
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x199CFE0 Offset: 0x199D0E1 VA: 0x199CFE0
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x199CC20 Offset: 0x199CD21 VA: 0x199CC20
	private void Init() { }

	// RVA: 0x199D130 Offset: 0x199D231 VA: 0x199D130 Slot: 5
	public override void Validate() { }

	// RVA: 0x199D7F0 Offset: 0x199D8F1 VA: 0x199D7F0 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x199D200 Offset: 0x199D301 VA: 0x199D200
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x199D210 Offset: 0x199D311 VA: 0x199D210
	private void ProcessInlineSchema() { }

	// RVA: 0x199D4C0 Offset: 0x199D5C1 VA: 0x199D4C0
	private void ValidateElement() { }

	// RVA: 0x199D930 Offset: 0x199DA31 VA: 0x199D930
	private object ValidateChildElement() { }

	// RVA: 0x199DB50 Offset: 0x199DC51 VA: 0x199DB50
	private void ProcessElement(object particle) { }

	// RVA: 0x199DF50 Offset: 0x199E051 VA: 0x199DF50
	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	// RVA: 0x199D630 Offset: 0x199D731 VA: 0x199D630
	private void ValidateEndElement() { }

	// RVA: 0x199DE50 Offset: 0x199DF51 VA: 0x199DE50
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x199E6E0 Offset: 0x199E7E1 VA: 0x199E6E0
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x199EB90 Offset: 0x199EC91 VA: 0x199EB90
	private void ValidateStartElement() { }

	// RVA: 0x199F180 Offset: 0x199F281 VA: 0x199F180
	private void ValidateEndStartElement() { }

	// RVA: 0x19A0CC0 Offset: 0x19A0DC1 VA: 0x19A0CC0
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x199F570 Offset: 0x199F671 VA: 0x199F570
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x199EB10 Offset: 0x199EC11 VA: 0x199EB10
	private bool get_HasSchema() { }

	// RVA: 0x19A12A0 Offset: 0x19A13A1 VA: 0x19A12A0 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x19A12C0 Offset: 0x19A13C1 VA: 0x19A12C0
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x199F710 Offset: 0x199F811 VA: 0x199F710
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x19A1520 Offset: 0x19A1621 VA: 0x19A1520
	internal void AddID(string name, object node) { }

	// RVA: 0x19A15C0 Offset: 0x19A16C1 VA: 0x19A15C0 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x199DB00 Offset: 0x199DC01 VA: 0x199DB00
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x199D010 Offset: 0x199D111 VA: 0x199D010
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x19A07C0 Offset: 0x19A08C1 VA: 0x19A07C0
	private void Pop() { }

	// RVA: 0x199D800 Offset: 0x199D901 VA: 0x199D800
	private void CheckForwardRefs() { }

	// RVA: 0x199EB30 Offset: 0x199EC31 VA: 0x199EB30
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x199FBB0 Offset: 0x199FCB1 VA: 0x199FBB0
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x19A15E0 Offset: 0x19A16E1 VA: 0x19A15E0
	private void AddIdentityConstraints() { }

	// RVA: 0x19A19F0 Offset: 0x19A1AF1 VA: 0x19A19F0
	private void ElementIdentityConstraints() { }

	// RVA: 0x19A0910 Offset: 0x19A0A11 VA: 0x19A0910
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x19A0880 Offset: 0x19A0981 VA: 0x19A0880
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x199FBC0 Offset: 0x199FCC1 VA: 0x199FBC0
	private void EndElementIdentityConstraints() { }

	// RVA: 0x19A1D10 Offset: 0x19A1E11 VA: 0x19A1D10
	private static void .cctor() { }
}

