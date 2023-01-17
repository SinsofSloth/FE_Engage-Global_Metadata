// Namespace: nn.irsensor
public struct IrCameraConfig : IEquatable<IrCameraConfig> // TypeDefIndex: 14604
{
	// Fields
	public long exposureTimeNanoSeconds; // 0x0
	public IrCameraLightTarget lightTarget; // 0x8
	public int gain; // 0xC
	public bool isNegativeImageUsed; // 0x10

	// Methods

	// RVA: 0x2B600D0 Offset: 0x2B601D1 VA: 0x2B600D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2B602F0 Offset: 0x2B603F1 VA: 0x2B602F0
	public static bool op_Equality(IrCameraConfig lhs, IrCameraConfig rhs) { }

	// RVA: 0x2B60350 Offset: 0x2B60451 VA: 0x2B60350
	public static bool op_Inequality(IrCameraConfig lhs, IrCameraConfig rhs) { }

	// RVA: 0x2B603B0 Offset: 0x2B604B1 VA: 0x2B603B0 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x2B604A0 Offset: 0x2B605A1 VA: 0x2B604A0 Slot: 4
	public bool Equals(IrCameraConfig other) { }

	// RVA: 0x2B60500 Offset: 0x2B60601 VA: 0x2B60500 Slot: 2
	public override int GetHashCode() { }
}

