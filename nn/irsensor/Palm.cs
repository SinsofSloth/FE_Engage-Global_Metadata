// Namespace: nn.irsensor
public struct Palm : IEquatable<Palm> // TypeDefIndex: 14576
{
	// Fields
	public Float2 center; // 0x0
	public float area; // 0x8
	public float depthFactor; // 0xC

	// Methods

	// RVA: 0x2365610 Offset: 0x2365711 VA: 0x2365610 Slot: 3
	public override string ToString() { }

	// RVA: 0x23656F0 Offset: 0x23657F1 VA: 0x23656F0
	public static bool op_Equality(Palm lhs, Palm rhs) { }

	// RVA: 0x2365750 Offset: 0x2365851 VA: 0x2365750
	public static bool op_Inequality(Palm lhs, Palm rhs) { }

	// RVA: 0x23657B0 Offset: 0x23658B1 VA: 0x23657B0 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x2365870 Offset: 0x2365971 VA: 0x2365870 Slot: 4
	public bool Equals(Palm other) { }

	// RVA: 0x23658D0 Offset: 0x23659D1 VA: 0x23658D0 Slot: 2
	public override int GetHashCode() { }
}

