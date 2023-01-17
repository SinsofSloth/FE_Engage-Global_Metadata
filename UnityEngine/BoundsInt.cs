// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x43C0D0 Offset: 0x43C1D1 VA: 0x43C0D0
public struct BoundsInt : IEquatable<BoundsInt>, IFormattable // TypeDefIndex: 3427
{
	// Fields
	private Vector3Int m_Position; // 0x0
	private Vector3Int m_Size; // 0xC

	// Properties
	public Vector3Int position { get; }
	public Vector3Int size { get; }

	// Methods

	// RVA: 0x2F0D090 Offset: 0x2F0D191 VA: 0x2F0D090
	public Vector3Int get_position() { }

	// RVA: 0x2F0D0A0 Offset: 0x2F0D1A1 VA: 0x2F0D0A0
	public Vector3Int get_size() { }

	// RVA: 0x2F0D0B0 Offset: 0x2F0D1B1 VA: 0x2F0D0B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F0D140 Offset: 0x2F0D241 VA: 0x2F0D140 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2F0D280 Offset: 0x2F0D381 VA: 0x2F0D280 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2F0D320 Offset: 0x2F0D421 VA: 0x2F0D320 Slot: 4
	public bool Equals(BoundsInt other) { }

	// RVA: 0x2F0D470 Offset: 0x2F0D571 VA: 0x2F0D470 Slot: 2
	public override int GetHashCode() { }
}

