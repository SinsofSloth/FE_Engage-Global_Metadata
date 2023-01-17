// Namespace: UnityEngine.Rendering
[DebuggerDisplayAttribute] // RVA: 0x3BE90 Offset: 0x3BF91 VA: 0x3BE90
[Serializable]
public class NoInterpClampedIntParameter : VolumeParameter<int> // TypeDefIndex: 4660
{
	// Fields
	public int min; // 0x18
	public int max; // 0x1C

	// Properties
	public override int value { get; set; }

	// Methods

	// RVA: 0x1A120C0 Offset: 0x1A121C1 VA: 0x1A120C0 Slot: 12
	public override int get_value() { }

	// RVA: 0x1A120D0 Offset: 0x1A121D1 VA: 0x1A120D0 Slot: 13
	public override void set_value(int value) { }

	// RVA: 0x1A12110 Offset: 0x1A12211 VA: 0x1A12110
	public void .ctor(int value, int min, int max, bool overrideState = False) { }
}

