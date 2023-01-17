// Namespace: System.Xml
public class XmlSignificantWhitespace : XmlCharacterData // TypeDefIndex: 1715
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x1BAAA40 Offset: 0x1BAAB41 VA: 0x1BAAA40
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1BAAAE0 Offset: 0x1BAABE1 VA: 0x1BAAAE0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1BAAB10 Offset: 0x1BAAC11 VA: 0x1BAAB10 Slot: 31
	public override string get_LocalName() { }

	// RVA: 0x1BAAB40 Offset: 0x1BAAC41 VA: 0x1BAAB40 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1BAAB50 Offset: 0x1BAAC51 VA: 0x1BAAB50 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1BAABE0 Offset: 0x1BAACE1 VA: 0x1BAABE0 Slot: 27
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1BAAC40 Offset: 0x1BAAD41 VA: 0x1BAAC40 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1BAAC50 Offset: 0x1BAAD51 VA: 0x1BAAC50 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1BAACE0 Offset: 0x1BAADE1 VA: 0x1BAACE0 Slot: 44
	internal override bool get_IsText() { }
}

