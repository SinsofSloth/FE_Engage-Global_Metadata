// Namespace: nn.irsensor
public struct MomentProcessorConfig : IEquatable<MomentProcessorConfig> // TypeDefIndex: 14607
{
	// Fields
	public IrCameraConfig irCameraConfig; // 0x0
	public Rect windowOfInterest; // 0x18
	public MomentProcessorPreprocess preprocess; // 0x20
	public int preprocessIntensityThreshold; // 0x24

	// Methods

	// RVA: 0x2279FF0 Offset: 0x227A0F1 VA: 0x2279FF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x227A220 Offset: 0x227A321 VA: 0x227A220
	public static bool op_Equality(MomentProcessorConfig lhs, MomentProcessorConfig rhs) { }

	// RVA: 0x227A2D0 Offset: 0x227A3D1 VA: 0x227A2D0
	public static bool op_Inequality(MomentProcessorConfig lhs, MomentProcessorConfig rhs) { }

	// RVA: 0x227A380 Offset: 0x227A481 VA: 0x227A380 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x227A490 Offset: 0x227A591 VA: 0x227A490 Slot: 4
	public bool Equals(MomentProcessorConfig other) { }

	// RVA: 0x227A540 Offset: 0x227A641 VA: 0x227A540 Slot: 2
	public override int GetHashCode() { }
}

