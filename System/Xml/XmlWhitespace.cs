// Namespace: System.Xml
public class XmlWhitespace : XmlCharacterData // TypeDefIndex: 1718
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x19F6F30 Offset: 0x19F7031 VA: 0x19F6F30
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x19F6FD0 Offset: 0x19F70D1 VA: 0x19F6FD0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x19F7000 Offset: 0x19F7101 VA: 0x19F7000 Slot: 31
	public override string get_LocalName() { }

	// RVA: 0x19F7030 Offset: 0x19F7131 VA: 0x19F7030 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x19F7040 Offset: 0x19F7141 VA: 0x19F7040 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x19F70D0 Offset: 0x19F71D1 VA: 0x19F70D0 Slot: 7
	public override string get_Value() { }

	// RVA: 0x19F70E0 Offset: 0x19F71E1 VA: 0x19F70E0 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x19F7170 Offset: 0x19F7271 VA: 0x19F7170 Slot: 27
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x19F71D0 Offset: 0x19F72D1 VA: 0x19F71D0 Slot: 44
	internal override bool get_IsText() { }
}

