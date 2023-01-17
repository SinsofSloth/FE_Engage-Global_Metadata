// Namespace: System.Xml
public class XmlProcessingInstruction : XmlLinkedNode // TypeDefIndex: 1714
{
	// Fields
	private string target; // 0x20
	private string data; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public string Data { set; }
	public override string InnerText { get; set; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x32F2BB0 Offset: 0x32F2CB1 VA: 0x32F2BB0
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0x3300780 Offset: 0x3300881 VA: 0x3300780 Slot: 6
	public override string get_Name() { }

	// RVA: 0x33007F0 Offset: 0x33008F1 VA: 0x33007F0 Slot: 31
	public override string get_LocalName() { }

	// RVA: 0x3300800 Offset: 0x3300901 VA: 0x3300800 Slot: 7
	public override string get_Value() { }

	// RVA: 0x3300810 Offset: 0x3300911 VA: 0x3300810 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x33008E0 Offset: 0x33009E1 VA: 0x33008E0
	public void set_Data(string value) { }

	// RVA: 0x33009B0 Offset: 0x3300AB1 VA: 0x33009B0 Slot: 33
	public override string get_InnerText() { }

	// RVA: 0x33009C0 Offset: 0x3300AC1 VA: 0x33009C0 Slot: 34
	public override void set_InnerText(string value) { }

	// RVA: 0x3300A90 Offset: 0x3300B91 VA: 0x3300A90 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x3300AA0 Offset: 0x3300BA1 VA: 0x3300AA0 Slot: 27
	public override XmlNode CloneNode(bool deep) { }
}

