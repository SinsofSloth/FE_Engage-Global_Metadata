// Namespace: System.Xml.XPath
public class XPathDocument // TypeDefIndex: 1771
{
	// Fields
	private XPathNode[] pageXmlNmsp; // 0x10
	private int idxXmlNmsp; // 0x18
	private XmlNameTable nameTable; // 0x20
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; // 0x28

	// Properties
	internal XmlNameTable NameTable { get; }

	// Methods

	// RVA: 0x19BC570 Offset: 0x19BC671 VA: 0x19BC570
	internal XmlNameTable get_NameTable() { }

	// RVA: 0x19BC580 Offset: 0x19BC681 VA: 0x19BC580
	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	// RVA: 0x19BC5C0 Offset: 0x19BC6C1 VA: 0x19BC5C0
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }
}

