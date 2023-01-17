// Namespace: System.Xml
public class XmlNotation : XmlNode // TypeDefIndex: 1713
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string name; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public override string InnerXml { set; }

	// Methods

	// RVA: 0x32F3140 Offset: 0x32F3241 VA: 0x32F3140
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x32F9F40 Offset: 0x32FA041 VA: 0x32F9F40 Slot: 6
	public override string get_Name() { }

	// RVA: 0x32F9F50 Offset: 0x32FA051 VA: 0x32F9F50 Slot: 31
	public override string get_LocalName() { }

	// RVA: 0x32F9F60 Offset: 0x32FA061 VA: 0x32F9F60 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32F9F70 Offset: 0x32FA071 VA: 0x32F9F70 Slot: 27
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x32F9FD0 Offset: 0x32FA0D1 VA: 0x32F9FD0 Slot: 32
	public override bool get_IsReadOnly() { }

	// RVA: 0x32F9FE0 Offset: 0x32FA0E1 VA: 0x32F9FE0 Slot: 35
	public override void set_InnerXml(string value) { }
}

