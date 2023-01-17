// Namespace: System.Xml
public class XmlEntity : XmlNode // TypeDefIndex: 1698
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string notationName; // 0x28
	private string name; // 0x30
	private string unparsedReplacementStr; // 0x38
	private string baseURI; // 0x40
	private XmlLinkedNode lastChild; // 0x48
	private bool childrenFoliating; // 0x50

	// Properties
	public override bool IsReadOnly { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string InnerText { get; set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlNodeType NodeType { get; }
	public string SystemId { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0x32EAE00 Offset: 0x32EAF01 VA: 0x32EAE00
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x32EAF60 Offset: 0x32EB061 VA: 0x32EAF60 Slot: 27
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x32EAFC0 Offset: 0x32EB0C1 VA: 0x32EAFC0 Slot: 32
	public override bool get_IsReadOnly() { }

	// RVA: 0x32EAFD0 Offset: 0x32EB0D1 VA: 0x32EAFD0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x32EAFE0 Offset: 0x32EB0E1 VA: 0x32EAFE0 Slot: 31
	public override string get_LocalName() { }

	// RVA: 0x32EAFF0 Offset: 0x32EB0F1 VA: 0x32EAFF0 Slot: 33
	public override string get_InnerText() { }

	// RVA: 0x32EB000 Offset: 0x32EB101 VA: 0x32EB000 Slot: 34
	public override void set_InnerText(string value) { }

	// RVA: 0x32EB060 Offset: 0x32EB161 VA: 0x32EB060 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x32EB070 Offset: 0x32EB171 VA: 0x32EB070 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x32EB230 Offset: 0x32EB331 VA: 0x32EB230 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x32EB240 Offset: 0x32EB341 VA: 0x32EB240 Slot: 24
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x32EB280 Offset: 0x32EB381 VA: 0x32EB280 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32EB290 Offset: 0x32EB391 VA: 0x32EB290
	public string get_SystemId() { }

	// RVA: 0x32EB2A0 Offset: 0x32EB3A1 VA: 0x32EB2A0 Slot: 35
	public override void set_InnerXml(string value) { }

	// RVA: 0x32EB300 Offset: 0x32EB401 VA: 0x32EB300 Slot: 36
	public override string get_BaseURI() { }

	// RVA: 0x32EB310 Offset: 0x32EB411 VA: 0x32EB310
	internal void SetBaseURI(string inBaseURI) { }
}

