// Namespace: nn.irsensor
public struct Finger : IEquatable<Finger> // TypeDefIndex: 14575
{
	// Fields
	public bool isValid; // 0x0
	public Float2 tip; // 0x4
	public float tipDepthFactor; // 0xC
	public Float2 root; // 0x10
	public int protrusionIndex; // 0x18

	// Methods

	// RVA: 0x2A22C10 Offset: 0x2A22D11 VA: 0x2A22C10 Slot: 3
	public override string ToString() { }

	// RVA: 0x2A22E80 Offset: 0x2A22F81 VA: 0x2A22E80
	public static bool op_Equality(Finger lhs, Finger rhs) { }

	// RVA: 0x2A22F20 Offset: 0x2A23021 VA: 0x2A22F20
	public static bool op_Inequality(Finger lhs, Finger rhs) { }

	// RVA: 0x2A22FE0 Offset: 0x2A230E1 VA: 0x2A22FE0 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x2A230F0 Offset: 0x2A231F1 VA: 0x2A230F0 Slot: 4
	public bool Equals(Finger other) { }

	// RVA: 0x2A231B0 Offset: 0x2A232B1 VA: 0x2A231B0 Slot: 2
	public override int GetHashCode() { }
}

