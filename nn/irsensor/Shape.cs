// Namespace: nn.irsensor
public struct Shape : IEquatable<Shape> // TypeDefIndex: 14583
{
	// Fields
	public int firstPointIndex; // 0x0
	public int pointCount; // 0x4
	public float intensityAverage; // 0x8
	public Float2 intensityCentroid; // 0xC

	// Methods

	// RVA: 0x232E310 Offset: 0x232E411 VA: 0x232E310 Slot: 3
	public override string ToString() { }

	// RVA: 0x232E520 Offset: 0x232E621 VA: 0x232E520
	public static bool op_Equality(Shape lhs, Shape rhs) { }

	// RVA: 0x232E570 Offset: 0x232E671 VA: 0x232E570
	public static bool op_Inequality(Shape lhs, Shape rhs) { }

	// RVA: 0x232E5D0 Offset: 0x232E6D1 VA: 0x232E5D0 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x232E690 Offset: 0x232E791 VA: 0x232E690 Slot: 4
	public bool Equals(Shape other) { }

	// RVA: 0x232E6E0 Offset: 0x232E7E1 VA: 0x232E6E0 Slot: 2
	public override int GetHashCode() { }
}

