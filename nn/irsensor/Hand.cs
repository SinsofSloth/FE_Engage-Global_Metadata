// Namespace: nn.irsensor
public struct Hand : IEquatable<Hand> // TypeDefIndex: 14582
{
	// Fields
	public int shapeId; // 0x0
	public int protrusionCount; // 0x4
	public Hand.ProtrusionArray8 protrusions; // 0x8
	public HandChirality chirality; // 0x48
	public Hand.Fingers fingers; // 0x4C
	public bool areIndexMiddleFingersTouching; // 0xD8
	public bool areMiddleRingFingersTouching; // 0xD9
	public bool areRingLittleFingersTouching; // 0xDA
	public Palm palm; // 0xDC
	public Arm arm; // 0xEC

	// Methods

	// RVA: 0x2DB9A80 Offset: 0x2DB9B81 VA: 0x2DB9A80
	public static bool op_Equality(Hand lhs, Hand rhs) { }

	// RVA: 0x2DB9D50 Offset: 0x2DB9E51 VA: 0x2DB9D50
	public static bool op_Inequality(Hand lhs, Hand rhs) { }

	// RVA: 0x2DB9DC0 Offset: 0x2DB9EC1 VA: 0x2DB9DC0 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x2DB9E80 Offset: 0x2DB9F81 VA: 0x2DB9E80 Slot: 4
	public bool Equals(Hand other) { }

	// RVA: 0x2DB9EE0 Offset: 0x2DB9FE1 VA: 0x2DB9EE0 Slot: 2
	public override int GetHashCode() { }
}

