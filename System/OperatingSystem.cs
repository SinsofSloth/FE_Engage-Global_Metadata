// Namespace: System
[ComVisibleAttribute] // RVA: 0x471120 Offset: 0x471221 VA: 0x471120
[Serializable]
public sealed class OperatingSystem : ICloneable, ISerializable // TypeDefIndex: 386
{
	// Fields
	private PlatformID _platform; // 0x10
	private Version _version; // 0x18
	private string _servicePack; // 0x20

	// Properties
	public PlatformID Platform { get; }
	public string ServicePack { get; }

	// Methods

	// RVA: 0x38106D0 Offset: 0x38107D1 VA: 0x38106D0
	public void .ctor(PlatformID platform, Version version) { }

	// RVA: 0x3810870 Offset: 0x3810971 VA: 0x3810870
	private void .ctor(SerializationInfo information, StreamingContext context) { }

	// RVA: 0x3810A70 Offset: 0x3810B71 VA: 0x3810A70
	public PlatformID get_Platform() { }

	// RVA: 0x3810A80 Offset: 0x3810B81 VA: 0x3810A80
	public string get_ServicePack() { }

	// RVA: 0x3810A90 Offset: 0x3810B91 VA: 0x3810A90 Slot: 4
	public object Clone() { }

	// RVA: 0x3810B00 Offset: 0x3810C01 VA: 0x3810B00 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3810BF0 Offset: 0x3810CF1 VA: 0x3810BF0 Slot: 3
	public override string ToString() { }
}

