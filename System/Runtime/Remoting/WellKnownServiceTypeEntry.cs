// Namespace: System.Runtime.Remoting
[ComVisibleAttribute] // RVA: 0x474B10 Offset: 0x474C11 VA: 0x474B10
public class WellKnownServiceTypeEntry : TypeEntry // TypeDefIndex: 1118
{
	// Fields
	private Type obj_type; // 0x20
	private string obj_uri; // 0x28
	private WellKnownObjectMode obj_mode; // 0x30

	// Properties
	public WellKnownObjectMode Mode { get; }
	public Type ObjectType { get; }
	public string ObjectUri { get; }

	// Methods

	// RVA: 0x34D1250 Offset: 0x34D1351 VA: 0x34D1250
	public void .ctor(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x34D13D0 Offset: 0x34D14D1 VA: 0x34D13D0
	public WellKnownObjectMode get_Mode() { }

	// RVA: 0x34D13E0 Offset: 0x34D14E1 VA: 0x34D13E0
	public Type get_ObjectType() { }

	// RVA: 0x34D13F0 Offset: 0x34D14F1 VA: 0x34D13F0
	public string get_ObjectUri() { }

	// RVA: 0x34D1400 Offset: 0x34D1501 VA: 0x34D1400 Slot: 3
	public override string ToString() { }
}

