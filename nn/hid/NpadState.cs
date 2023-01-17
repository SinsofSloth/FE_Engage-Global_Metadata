// Namespace: nn.hid
public struct NpadState // TypeDefIndex: 14643
{
	// Fields
	public long samplingNumber; // 0x0
	public NpadButton buttons; // 0x8
	public AnalogStickState analogStickL; // 0x10
	public AnalogStickState analogStickR; // 0x18
	public NpadAttribute attributes; // 0x20
	public NpadButton preButtons; // 0x28

	// Methods

	// RVA: 0x2361130 Offset: 0x2361231 VA: 0x2361130
	public void Clear() { }

	// RVA: 0x2361170 Offset: 0x2361271 VA: 0x2361170
	public bool GetButton(NpadButton button) { }

	// RVA: 0x2361180 Offset: 0x2361281 VA: 0x2361180
	public bool GetButtonDown(NpadButton button) { }

	// RVA: 0x23611B0 Offset: 0x23612B1 VA: 0x23611B0
	public bool GetButtonUp(NpadButton button) { }

	// RVA: 0x23611E0 Offset: 0x23612E1 VA: 0x23611E0 Slot: 3
	public override string ToString() { }
}

