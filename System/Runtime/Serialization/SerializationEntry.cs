// Namespace: System.Runtime.Serialization
[ComVisibleAttribute] // RVA: 0x4747A0 Offset: 0x4748A1 VA: 0x4747A0
public struct SerializationEntry // TypeDefIndex: 1021
{
	// Fields
	private Type m_type; // 0x0
	private object m_value; // 0x8
	private string m_name; // 0x10

	// Properties
	public object Value { get; }
	public string Name { get; }

	// Methods

	// RVA: 0x3618160 Offset: 0x3618261 VA: 0x3618160
	public object get_Value() { }

	// RVA: 0x3618170 Offset: 0x3618271 VA: 0x3618170
	public string get_Name() { }

	// RVA: 0x3618180 Offset: 0x3618281 VA: 0x3618180
	internal void .ctor(string entryName, object entryValue, Type entryType) { }
}

