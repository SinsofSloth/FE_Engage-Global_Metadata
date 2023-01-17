// Namespace: System.Xml
internal class XmlUnspecifiedAttribute : XmlAttribute // TypeDefIndex: 1717
{
	// Fields
	private bool fSpecified; // 0x28

	// Properties
	public override bool Specified { get; }
	public override string InnerText { set; }

	// Methods

	// RVA: 0x19EE430 Offset: 0x19EE531 VA: 0x19EE430
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x19EE440 Offset: 0x19EE541 VA: 0x19EE440 Slot: 45
	public override bool get_Specified() { }

	// RVA: 0x19EE450 Offset: 0x19EE551 VA: 0x19EE450 Slot: 27
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x19EE580 Offset: 0x19EE681 VA: 0x19EE580 Slot: 34
	public override void set_InnerText(string value) { }

	// RVA: 0x19EE5B0 Offset: 0x19EE6B1 VA: 0x19EE5B0 Slot: 21
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x19EE5E0 Offset: 0x19EE6E1 VA: 0x19EE5E0 Slot: 22
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x19EE610 Offset: 0x19EE711 VA: 0x19EE610
	internal void SetSpecified(bool f) { }
}

