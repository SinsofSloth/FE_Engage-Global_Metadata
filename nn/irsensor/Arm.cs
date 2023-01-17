// Namespace: nn.irsensor
public struct Arm : IEquatable<Arm> // TypeDefIndex: 14577
{
	// Fields
	public bool isValid; // 0x0
	public Float2 wristPosition; // 0x4
	public Float2 armDirection; // 0xC
	public int protrusionIndex; // 0x14

	// Methods

	// RVA: 0x2609630 Offset: 0x2609731 VA: 0x2609630 Slot: 3
	public override string ToString() { }

	// RVA: 0x2609840 Offset: 0x2609941 VA: 0x2609840
	public static bool op_Equality(Arm lhs, Arm rhs) { }

	// RVA: 0x26098D0 Offset: 0x26099D1 VA: 0x26098D0
	public static bool op_Inequality(Arm lhs, Arm rhs) { }

	// RVA: 0x2609970 Offset: 0x2609A71 VA: 0x2609970 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x2609A60 Offset: 0x2609B61 VA: 0x2609A60 Slot: 4
	public bool Equals(Arm other) { }

	// RVA: 0x2609B00 Offset: 0x2609C01 VA: 0x2609B00 Slot: 2
	public override int GetHashCode() { }
}

