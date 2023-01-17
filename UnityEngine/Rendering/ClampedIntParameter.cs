// Namespace: UnityEngine.Rendering
[DebuggerDisplayAttribute] // RVA: 0x3BE50 Offset: 0x3BF51 VA: 0x3BE50
[Serializable]
public class ClampedIntParameter : IntParameter // TypeDefIndex: 4659
{
	// Fields
	public int min; // 0x18
	public int max; // 0x1C

	// Properties
	public override int value { get; set; }

	// Methods

	// RVA: 0x1B2B9E0 Offset: 0x1B2BAE1 VA: 0x1B2B9E0 Slot: 12
	public override int get_value() { }

	// RVA: 0x1B2B9F0 Offset: 0x1B2BAF1 VA: 0x1B2B9F0 Slot: 13
	public override void set_value(int value) { }

	// RVA: 0x1B2BA30 Offset: 0x1B2BB31 VA: 0x1B2BA30
	public void .ctor(int value, int min, int max, bool overrideState = False) { }
}

