// Namespace: UnityEngine.XR
[NativeConditionalAttribute] // RVA: 0x588B0 Offset: 0x589B1 VA: 0x588B0
[RequiredByNativeCodeAttribute] // RVA: 0x588B0 Offset: 0x589B1 VA: 0x588B0
[NativeHeaderAttribute] // RVA: 0x588B0 Offset: 0x589B1 VA: 0x588B0
public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 4865
{
	// Fields
	internal string m_Name; // 0x0
	[NativeNameAttribute] // RVA: 0x593C0 Offset: 0x594C1 VA: 0x593C0
	internal InputFeatureType m_InternalType; // 0x8

	// Properties
	public string name { get; }
	internal InputFeatureType internalType { get; }

	// Methods

	// RVA: 0x1C4EB60 Offset: 0x1C4EC61 VA: 0x1C4EB60
	public string get_name() { }

	// RVA: 0x1C4EB70 Offset: 0x1C4EC71 VA: 0x1C4EB70
	internal InputFeatureType get_internalType() { }

	// RVA: 0x1C4EB80 Offset: 0x1C4EC81 VA: 0x1C4EB80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C4EC20 Offset: 0x1C4ED21 VA: 0x1C4EC20 Slot: 4
	public bool Equals(InputFeatureUsage other) { }

	// RVA: 0x1C4EC70 Offset: 0x1C4ED71 VA: 0x1C4EC70 Slot: 2
	public override int GetHashCode() { }
}

