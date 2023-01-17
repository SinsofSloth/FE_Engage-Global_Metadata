// Namespace: UnityEngine.Rendering
[DebuggerDisplayAttribute] // RVA: 0x3C0D0 Offset: 0x3C1D1 VA: 0x3C0D0
[Serializable]
public class FloatRangeParameter : VolumeParameter<Vector2> // TypeDefIndex: 4669
{
	// Fields
	public float min; // 0x1C
	public float max; // 0x20

	// Properties
	public override Vector2 value { get; set; }

	// Methods

	// RVA: 0x1A0FF50 Offset: 0x1A10051 VA: 0x1A0FF50 Slot: 12
	public override Vector2 get_value() { }

	// RVA: 0x1A0FF60 Offset: 0x1A10061 VA: 0x1A0FF60 Slot: 13
	public override void set_value(Vector2 value) { }

	// RVA: 0x1A0FFB0 Offset: 0x1A100B1 VA: 0x1A0FFB0
	public void .ctor(Vector2 value, float min, float max, bool overrideState = False) { }

	// RVA: 0x1A10040 Offset: 0x1A10141 VA: 0x1A10040 Slot: 14
	public override void Interp(Vector2 from, Vector2 to, float t) { }
}

