// Namespace: nn.irsensor
public struct MomentStatistic : IEquatable<MomentStatistic> // TypeDefIndex: 14608
{
	// Fields
	public float averageIntensity; // 0x0
	public Float2 centroid; // 0x4

	// Methods

	// RVA: 0x227A5C0 Offset: 0x227A6C1 VA: 0x227A5C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x227A690 Offset: 0x227A791 VA: 0x227A690
	public static bool op_Equality(MomentStatistic lhs, MomentStatistic rhs) { }

	// RVA: 0x227A6C0 Offset: 0x227A7C1 VA: 0x227A6C0
	public static bool op_Inequality(MomentStatistic lhs, MomentStatistic rhs) { }

	// RVA: 0x227A710 Offset: 0x227A811 VA: 0x227A710 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x227A7B0 Offset: 0x227A8B1 VA: 0x227A7B0 Slot: 4
	public bool Equals(MomentStatistic other) { }

	// RVA: 0x227A7E0 Offset: 0x227A8E1 VA: 0x227A7E0 Slot: 2
	public override int GetHashCode() { }
}

