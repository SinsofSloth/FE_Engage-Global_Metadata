// Namespace: System.Xml
internal class DomNameTable // TypeDefIndex: 1685
{
	// Fields
	private XmlName[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private XmlDocument ownerDocument; // 0x20
	private XmlNameTable nameTable; // 0x28

	// Methods

	// RVA: 0x35A03D0 Offset: 0x35A04D1 VA: 0x35A03D0
	public void .ctor(XmlDocument document) { }

	// RVA: 0x35A0480 Offset: 0x35A0581 VA: 0x35A0480
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x35A05F0 Offset: 0x35A06F1 VA: 0x35A05F0
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x35A0850 Offset: 0x35A0951 VA: 0x35A0850
	private void Grow() { }
}

