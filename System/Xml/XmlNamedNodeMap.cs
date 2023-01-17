// Namespace: System.Xml
public class XmlNamedNodeMap : IEnumerable // TypeDefIndex: 1708
{
	// Fields
	internal XmlNode parent; // 0x10
	internal XmlNamedNodeMap.SmallXmlNodeList nodes; // 0x18

	// Properties
	public virtual int Count { get; }

	// Methods

	// RVA: 0x32E8C10 Offset: 0x32E8D11 VA: 0x32E8C10
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x32F6BC0 Offset: 0x32F6CC1 VA: 0x32F6BC0 Slot: 5
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x32F6D80 Offset: 0x32F6E81 VA: 0x32F6D80 Slot: 6
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x32F6FF0 Offset: 0x32F70F1 VA: 0x32F6FF0 Slot: 7
	public virtual int get_Count() { }

	// RVA: 0x32F7000 Offset: 0x32F7101 VA: 0x32F7000 Slot: 8
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x32F6C80 Offset: 0x32F6D81 VA: 0x32F6C80
	internal int FindNodeOffset(string name) { }

	// RVA: 0x32F6E50 Offset: 0x32F6F51 VA: 0x32F6E50
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x32F7010 Offset: 0x32F7111 VA: 0x32F7010 Slot: 9
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x32F7180 Offset: 0x32F7281 VA: 0x32F7180 Slot: 10
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x32F7230 Offset: 0x32F7331 VA: 0x32F7230 Slot: 11
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x32F6F90 Offset: 0x32F7091 VA: 0x32F6F90
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x32F73A0 Offset: 0x32F74A1 VA: 0x32F73A0 Slot: 12
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }
}

