// Namespace: UnityEngine.Rendering
[DebuggerDisplayAttribute] // RVA: 0x3C110 Offset: 0x3C211 VA: 0x3C110
[Serializable]
public class NoInterpFloatRangeParameter : VolumeParameter<Vector2> // TypeDefIndex: 4670
{
	// Fields
	public float min; // 0x1C
	public float max; // 0x20

	// Properties
	public override Vector2 value { get; set; }

	// Methods

	// RVA: 0x1A12400 Offset: 0x1A12501 VA: 0x1A12400 Slot: 12
	public override Vector2 get_value() { }

	// RVA: 0x1A12410 Offset: 0x1A12511 VA: 0x1A12410 Slot: 13
	public override void set_value(Vector2 value) { }

	// RVA: 0x1A12460 Offset: 0x1A12561 VA: 0x1A12460
	public void .ctor(Vector2 value, float min, float max, bool overrideState = False) { }
}

