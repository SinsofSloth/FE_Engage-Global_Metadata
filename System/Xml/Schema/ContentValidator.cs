// Namespace: System.Xml.Schema
internal class ContentValidator // TypeDefIndex: 1824
{
	// Fields
	private XmlSchemaContentType contentType; // 0x10
	private bool isOpen; // 0x14
	private bool isEmptiable; // 0x15
	public static readonly ContentValidator Empty; // 0x0
	public static readonly ContentValidator TextOnly; // 0x8
	public static readonly ContentValidator Mixed; // 0x10
	public static readonly ContentValidator Any; // 0x18

	// Properties
	public XmlSchemaContentType ContentType { get; }
	public bool PreserveWhitespace { get; }
	public virtual bool IsEmptiable { get; }
	public bool IsOpen { get; set; }

	// Methods

	// RVA: 0x358BDB0 Offset: 0x358BEB1 VA: 0x358BDB0
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x358BDF0 Offset: 0x358BEF1 VA: 0x358BDF0
	protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x358BE40 Offset: 0x358BF41 VA: 0x358BE40
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x358BE50 Offset: 0x358BF51 VA: 0x358BE50
	public bool get_PreserveWhitespace() { }

	// RVA: 0x358BE70 Offset: 0x358BF71 VA: 0x358BE70 Slot: 4
	public virtual bool get_IsEmptiable() { }

	// RVA: 0x358BE80 Offset: 0x358BF81 VA: 0x358BE80
	public bool get_IsOpen() { }

	// RVA: 0x358BEB0 Offset: 0x358BFB1 VA: 0x358BEB0
	public void set_IsOpen(bool value) { }

	// RVA: 0x358BEC0 Offset: 0x358BFC1 VA: 0x358BEC0 Slot: 5
	public virtual void InitValidation(ValidationState context) { }

	// RVA: 0x358BED0 Offset: 0x358BFD1 VA: 0x358BED0 Slot: 6
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x358BEF0 Offset: 0x358BFF1 VA: 0x358BEF0 Slot: 7
	public virtual bool CompleteValidation(ValidationState context) { }

	// RVA: 0x358BF00 Offset: 0x358C001 VA: 0x358BF00 Slot: 8
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x358BF10 Offset: 0x358C011 VA: 0x358BF10 Slot: 9
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x358BF20 Offset: 0x358C021 VA: 0x358BF20
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x358BFB0 Offset: 0x358C0B1 VA: 0x358BFB0
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x358C1E0 Offset: 0x358C2E1 VA: 0x358C1E0
	private static void .cctor() { }
}

