// Namespace: UnityEngine.XR
[NativeHeaderAttribute] // RVA: 0x58970 Offset: 0x58A71 VA: 0x58970
[RequiredByNativeCodeAttribute] // RVA: 0x58970 Offset: 0x58A71 VA: 0x58970
[NativeHeaderAttribute] // RVA: 0x58970 Offset: 0x58A71 VA: 0x58970
[NativeHeaderAttribute] // RVA: 0x58970 Offset: 0x58A71 VA: 0x58970
[StaticAccessorAttribute] // RVA: 0x58970 Offset: 0x58A71 VA: 0x58970
[NativeConditionalAttribute] // RVA: 0x58970 Offset: 0x58A71 VA: 0x58970
public struct Hand : IEquatable<Hand> // TypeDefIndex: 4867
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x1C4E7D0 Offset: 0x1C4E8D1 VA: 0x1C4E7D0
	internal ulong get_deviceId() { }

	// RVA: 0x1C4E7E0 Offset: 0x1C4E8E1 VA: 0x1C4E7E0
	internal uint get_featureIndex() { }

	// RVA: 0x1C4E7F0 Offset: 0x1C4E8F1 VA: 0x1C4E7F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C4E890 Offset: 0x1C4E991 VA: 0x1C4E890 Slot: 4
	public bool Equals(Hand other) { }

	// RVA: 0x1C4E8C0 Offset: 0x1C4E9C1 VA: 0x1C4E8C0 Slot: 2
	public override int GetHashCode() { }
}

