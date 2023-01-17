// Namespace: System.Xml
public class XmlNodeChangedEventArgs : EventArgs // TypeDefIndex: 1710
{
	// Fields
	private XmlNodeChangedAction action; // 0x10
	private XmlNode node; // 0x18
	private XmlNode oldParent; // 0x20
	private XmlNode newParent; // 0x28
	private string oldValue; // 0x30
	private string newValue; // 0x38

	// Properties
	public XmlNodeChangedAction Action { get; }

	// Methods

	// RVA: 0x32F9A30 Offset: 0x32F9B31 VA: 0x32F9A30
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x32F9B20 Offset: 0x32F9C21 VA: 0x32F9B20
	public XmlNodeChangedAction get_Action() { }
}

