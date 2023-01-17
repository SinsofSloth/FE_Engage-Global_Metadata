// Namespace: System.Xml
public abstract class XmlLinkedNode : XmlNode // TypeDefIndex: 1702
{
	// Fields
	internal XmlLinkedNode next; // 0x18

	// Properties
	public override XmlNode PreviousSibling { get; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x32E8A40 Offset: 0x32E8B41 VA: 0x32E8A40
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x32ED9A0 Offset: 0x32EDAA1 VA: 0x32ED9A0 Slot: 12
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x32EDA20 Offset: 0x32EDB21 VA: 0x32EDA20 Slot: 13
	public override XmlNode get_NextSibling() { }
}

