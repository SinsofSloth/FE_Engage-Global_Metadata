// Namespace: UnityEngine.Rendering
[DebuggerDisplayAttribute] // RVA: 0x3C050 Offset: 0x3C151 VA: 0x3C050
[Serializable]
public class ClampedFloatParameter : FloatParameter // TypeDefIndex: 4667
{
	// Fields
	public float min; // 0x18
	public float max; // 0x1C

	// Properties
	public override float value { get; set; }

	// Methods

	// RVA: 0x1B2B960 Offset: 0x1B2BA61 VA: 0x1B2B960 Slot: 12
	public override float get_value() { }

	// RVA: 0x1B2B970 Offset: 0x1B2BA71 VA: 0x1B2B970 Slot: 13
	public override void set_value(float value) { }

	// RVA: 0x1B2B9A0 Offset: 0x1B2BAA1 VA: 0x1B2B9A0
	public void .ctor(float value, float min, float max, bool overrideState = False) { }
}

