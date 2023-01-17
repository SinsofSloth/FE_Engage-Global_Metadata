// Namespace: System.Xml
public abstract class XmlCharacterData : XmlLinkedNode // TypeDefIndex: 1689
{
	// Fields
	private string data; // 0x20

	// Properties
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public virtual string Data { get; set; }

	// Methods

	// RVA: 0x1A9FCD0 Offset: 0x1A9FDD1 VA: 0x1A9FCD0
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x1AA0B50 Offset: 0x1AA0C51 VA: 0x1AA0B50 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1AA0B60 Offset: 0x1AA0C61 VA: 0x1AA0B60 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1AA0B70 Offset: 0x1AA0C71 VA: 0x1AA0B70 Slot: 33
	public override string get_InnerText() { }

	// RVA: 0x1AA0B80 Offset: 0x1AA0C81 VA: 0x1AA0B80 Slot: 34
	public override void set_InnerText(string value) { }

	// RVA: 0x1AA0B90 Offset: 0x1AA0C91 VA: 0x1AA0B90 Slot: 45
	public virtual string get_Data() { }

	// RVA: 0x1AA0C00 Offset: 0x1AA0D01 VA: 0x1AA0C00 Slot: 46
	public virtual void set_Data(string value) { }

	// RVA: 0x1AA0CD0 Offset: 0x1AA0DD1 VA: 0x1AA0CD0
	internal bool CheckOnData(string data) { }
}

