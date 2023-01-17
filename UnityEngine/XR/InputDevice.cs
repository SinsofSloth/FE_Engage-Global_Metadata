// Namespace: UnityEngine.XR
[UsedByNativeCodeAttribute] // RVA: 0x58920 Offset: 0x58A21 VA: 0x58920
[NativeConditionalAttribute] // RVA: 0x58920 Offset: 0x58A21 VA: 0x58920
public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 4866
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private bool m_Initialized; // 0x8

	// Properties
	private ulong deviceId { get; }

	// Methods

	// RVA: 0x1C4E930 Offset: 0x1C4EA31 VA: 0x1C4E930
	internal void .ctor(ulong deviceId) { }

	// RVA: 0x1C4E940 Offset: 0x1C4EA41 VA: 0x1C4E940
	private ulong get_deviceId() { }

	// RVA: 0x1C4E960 Offset: 0x1C4EA61 VA: 0x1C4E960 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C4EA10 Offset: 0x1C4EB11 VA: 0x1C4EA10 Slot: 4
	public bool Equals(InputDevice other) { }

	// RVA: 0x1C4EA40 Offset: 0x1C4EB41 VA: 0x1C4EA40 Slot: 2
	public override int GetHashCode() { }
}

