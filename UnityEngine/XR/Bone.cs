// Namespace: UnityEngine.XR
[NativeHeaderAttribute] // RVA: 0x58B30 Offset: 0x58C31 VA: 0x58B30
[NativeConditionalAttribute] // RVA: 0x58B30 Offset: 0x58C31 VA: 0x58B30
[StaticAccessorAttribute] // RVA: 0x58B30 Offset: 0x58C31 VA: 0x58B30
[NativeHeaderAttribute] // RVA: 0x58B30 Offset: 0x58C31 VA: 0x58B30
[NativeHeaderAttribute] // RVA: 0x58B30 Offset: 0x58C31 VA: 0x58B30
[RequiredByNativeCodeAttribute] // RVA: 0x58B30 Offset: 0x58C31 VA: 0x58B30
public struct Bone : IEquatable<Bone> // TypeDefIndex: 4869
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x1C4E520 Offset: 0x1C4E621 VA: 0x1C4E520
	internal ulong get_deviceId() { }

	// RVA: 0x1C4E530 Offset: 0x1C4E631 VA: 0x1C4E530
	internal uint get_featureIndex() { }

	// RVA: 0x1C4E540 Offset: 0x1C4E641 VA: 0x1C4E540 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C4E5E0 Offset: 0x1C4E6E1 VA: 0x1C4E5E0 Slot: 4
	public bool Equals(Bone other) { }

	// RVA: 0x1C4E610 Offset: 0x1C4E711 VA: 0x1C4E610 Slot: 2
	public override int GetHashCode() { }
}

