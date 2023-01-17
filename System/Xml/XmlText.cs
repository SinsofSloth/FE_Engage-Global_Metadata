// Namespace: System.Xml
public class XmlText : XmlCharacterData // TypeDefIndex: 1716
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x1BAB7B0 Offset: 0x1BAB8B1 VA: 0x1BAB7B0
	internal void .ctor(string strData) { }

	// RVA: 0x1BAB7C0 Offset: 0x1BAB8C1 VA: 0x1BAB7C0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1BAB7D0 Offset: 0x1BAB8D1 VA: 0x1BAB7D0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1BAB800 Offset: 0x1BAB901 VA: 0x1BAB800 Slot: 31
	public override string get_LocalName() { }

	// RVA: 0x1BAB830 Offset: 0x1BAB931 VA: 0x1BAB830 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1BAB840 Offset: 0x1BAB941 VA: 0x1BAB840 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1BAB8D0 Offset: 0x1BAB9D1 VA: 0x1BAB8D0 Slot: 27
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1BAB930 Offset: 0x1BABA31 VA: 0x1BAB930 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1BAB940 Offset: 0x1BABA41 VA: 0x1BAB940 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1BABA20 Offset: 0x1BABB21 VA: 0x1BABA20 Slot: 44
	internal override bool get_IsText() { }
}

