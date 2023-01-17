// Namespace: nn.hid
public struct VibrationValue // TypeDefIndex: 14729
{
	// Fields
	public const int FrequencyLowDefault = 160;
	public const int FrequencyHighDefault = 320;
	public float amplitudeLow; // 0x0
	public float frequencyLow; // 0x4
	public float amplitudeHigh; // 0x8
	public float frequencyHigh; // 0xC

	// Methods

	// RVA: 0x26C3690 Offset: 0x26C3791 VA: 0x26C3690
	public static VibrationValue Make() { }

	// RVA: 0x26C36D0 Offset: 0x26C37D1 VA: 0x26C36D0
	public static VibrationValue Make(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh) { }

	// RVA: 0x26C36B0 Offset: 0x26C37B1 VA: 0x26C36B0
	public void .ctor(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh) { }

	// RVA: 0x26C36E0 Offset: 0x26C37E1 VA: 0x26C36E0
	public void Set(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh) { }

	// RVA: 0x26C3700 Offset: 0x26C3801 VA: 0x26C3700
	public void Clear() { }

	// RVA: 0x26C3710 Offset: 0x26C3811 VA: 0x26C3710 Slot: 3
	public override string ToString() { }
}

