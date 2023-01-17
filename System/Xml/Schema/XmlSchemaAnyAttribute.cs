// Namespace: System.Xml.Schema
public class XmlSchemaAnyAttribute : XmlSchemaAnnotated // TypeDefIndex: 1965
{
	// Fields
	private string ns; // 0x50
	private XmlSchemaContentProcessing processContents; // 0x58
	private NamespaceList namespaceList; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x48600 Offset: 0x48701 VA: 0x48600
	public string Namespace { set; }
	[DefaultValueAttribute] // RVA: 0x48640 Offset: 0x48741 VA: 0x48640
	[XmlAttributeAttribute] // RVA: 0x48640 Offset: 0x48741 VA: 0x48640
	public XmlSchemaContentProcessing ProcessContents { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x486E0 Offset: 0x487E1 VA: 0x486E0
	internal NamespaceList NamespaceList { get; }
	[XmlIgnoreAttribute] // RVA: 0x486F0 Offset: 0x487F1 VA: 0x486F0
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }

	// Methods

	// RVA: 0x195E990 Offset: 0x195EA91 VA: 0x195E990
	public void set_Namespace(string value) { }

	// RVA: 0x195E9A0 Offset: 0x195EAA1 VA: 0x195E9A0
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0x195E9B0 Offset: 0x195EAB1 VA: 0x195E9B0
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x195E9C0 Offset: 0x195EAC1 VA: 0x195E9C0
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x195E9D0 Offset: 0x195EAD1 VA: 0x195E9D0
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x195E9F0 Offset: 0x195EAF1 VA: 0x195E9F0
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x195EA80 Offset: 0x195EB81 VA: 0x195EA80
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x195EB30 Offset: 0x195EC31 VA: 0x195EB30
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x195EB50 Offset: 0x195EC51 VA: 0x195EB50
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x195EB60 Offset: 0x195EC61 VA: 0x195EB60
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x195EC30 Offset: 0x195ED31 VA: 0x195EC30
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x195EC20 Offset: 0x195ED21 VA: 0x195EC20
	public void .ctor() { }
}

