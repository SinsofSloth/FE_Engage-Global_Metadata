// Namespace: nn.hid
public struct AnalogStickState // TypeDefIndex: 14616
{
	// Fields
	public const int Max = 32767;
	public int x; // 0x0
	public int y; // 0x4

	// Properties
	public float fx { get; }
	public float fy { get; }

	// Methods

	// RVA: 0x20F2340 Offset: 0x20F2441 VA: 0x20F2340
	public float get_fx() { }

	// RVA: 0x20F2360 Offset: 0x20F2461 VA: 0x20F2360
	public float get_fy() { }

	// RVA: 0x20F2380 Offset: 0x20F2481 VA: 0x20F2380
	public void Clear() { }

	// RVA: 0x20F2390 Offset: 0x20F2491 VA: 0x20F2390 Slot: 3
	public override string ToString() { }
}

