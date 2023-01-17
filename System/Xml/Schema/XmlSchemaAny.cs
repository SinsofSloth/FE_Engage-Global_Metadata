// Namespace: System.Xml.Schema
public class XmlSchemaAny : XmlSchemaParticle // TypeDefIndex: 1964
{
	// Fields
	private string ns; // 0x78
	private XmlSchemaContentProcessing processContents; // 0x80
	private NamespaceList namespaceList; // 0x88

	// Properties
	[XmlAttributeAttribute] // RVA: 0x484F0 Offset: 0x485F1 VA: 0x484F0
	public string Namespace { get; set; }
	[DefaultValueAttribute] // RVA: 0x48530 Offset: 0x48631 VA: 0x48530
	[XmlAttributeAttribute] // RVA: 0x48530 Offset: 0x48631 VA: 0x48530
	public XmlSchemaContentProcessing ProcessContents { set; }
	[XmlIgnoreAttribute] // RVA: 0x485D0 Offset: 0x486D1 VA: 0x485D0
	internal NamespaceList NamespaceList { get; }
	[XmlIgnoreAttribute] // RVA: 0x485E0 Offset: 0x486E1 VA: 0x485E0
	internal string ResolvedNamespace { get; }
	[XmlIgnoreAttribute] // RVA: 0x485F0 Offset: 0x486F1 VA: 0x485F0
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }
	internal override string NameString { get; }

	// Methods

	// RVA: 0x195E1A0 Offset: 0x195E2A1 VA: 0x195E1A0
	public string get_Namespace() { }

	// RVA: 0x195E1B0 Offset: 0x195E2B1 VA: 0x195E1B0
	public void set_Namespace(string value) { }

	// RVA: 0x195E1C0 Offset: 0x195E2C1 VA: 0x195E1C0
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x195E1D0 Offset: 0x195E2D1 VA: 0x195E1D0
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x195E1E0 Offset: 0x195E2E1 VA: 0x195E1E0
	internal string get_ResolvedNamespace() { }

	// RVA: 0x195E250 Offset: 0x195E351 VA: 0x195E250
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x195E270 Offset: 0x195E371 VA: 0x195E270 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x195E6D0 Offset: 0x195E7D1 VA: 0x195E6D0
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x195E760 Offset: 0x195E861 VA: 0x195E760
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x195E810 Offset: 0x195E911 VA: 0x195E810
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x195E830 Offset: 0x195E931 VA: 0x195E830
	public void .ctor() { }
}

