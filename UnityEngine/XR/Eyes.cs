// Namespace: UnityEngine.XR
[StaticAccessorAttribute] // RVA: 0x58A50 Offset: 0x58B51 VA: 0x58A50
[NativeHeaderAttribute] // RVA: 0x58A50 Offset: 0x58B51 VA: 0x58A50
[NativeConditionalAttribute] // RVA: 0x58A50 Offset: 0x58B51 VA: 0x58A50
[RequiredByNativeCodeAttribute] // RVA: 0x58A50 Offset: 0x58B51 VA: 0x58A50
[NativeHeaderAttribute] // RVA: 0x58A50 Offset: 0x58B51 VA: 0x58A50
[NativeHeaderAttribute] // RVA: 0x58A50 Offset: 0x58B51 VA: 0x58A50
public struct Eyes : IEquatable<Eyes> // TypeDefIndex: 4868
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x1C4E680 Offset: 0x1C4E781 VA: 0x1C4E680
	internal ulong get_deviceId() { }

	// RVA: 0x1C4E690 Offset: 0x1C4E791 VA: 0x1C4E690
	internal uint get_featureIndex() { }

	// RVA: 0x1C4E6A0 Offset: 0x1C4E7A1 VA: 0x1C4E6A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C4E740 Offset: 0x1C4E841 VA: 0x1C4E740 Slot: 4
	public bool Equals(Eyes other) { }

	// RVA: 0x1C4E770 Offset: 0x1C4E871 VA: 0x1C4E770 Slot: 2
	public override int GetHashCode() { }
}

