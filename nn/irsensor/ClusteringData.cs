// Namespace: nn.irsensor
public struct ClusteringData : IEquatable<ClusteringData> // TypeDefIndex: 14564
{
	// Fields
	public float averageIntensity; // 0x0
	public Float2 centroid; // 0x4
	public int pixelCount; // 0xC
	public Rect bound; // 0x10

	// Methods

	// RVA: 0x22C7A10 Offset: 0x22C7B11 VA: 0x22C7A10 Slot: 3
	public override string ToString() { }

	// RVA: 0x22C7C00 Offset: 0x22C7D01 VA: 0x22C7C00
	public static bool op_Equality(ClusteringData lhs, ClusteringData rhs) { }

	// RVA: 0x22C7C70 Offset: 0x22C7D71 VA: 0x22C7C70
	public static bool op_Inequality(ClusteringData lhs, ClusteringData rhs) { }

	// RVA: 0x22C7CF0 Offset: 0x22C7DF1 VA: 0x22C7CF0 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x22C7DD0 Offset: 0x22C7ED1 VA: 0x22C7DD0 Slot: 4
	public bool Equals(ClusteringData other) { }

	// RVA: 0x22C7E50 Offset: 0x22C7F51 VA: 0x22C7E50 Slot: 2
	public override int GetHashCode() { }
}

