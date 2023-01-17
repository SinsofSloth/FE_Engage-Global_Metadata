// Namespace: UnityEngine.Rendering
[DebuggerDisplayAttribute] // RVA: 0x3C090 Offset: 0x3C191 VA: 0x3C090
[Serializable]
public class NoInterpClampedFloatParameter : VolumeParameter<float> // TypeDefIndex: 4668
{
	// Fields
	public float min; // 0x18
	public float max; // 0x1C

	// Properties
	public override float value { get; set; }

	// Methods

	// RVA: 0x1A11FF0 Offset: 0x1A120F1 VA: 0x1A11FF0 Slot: 12
	public override float get_value() { }

	// RVA: 0x1A12000 Offset: 0x1A12101 VA: 0x1A12000 Slot: 13
	public override void set_value(float value) { }

	// RVA: 0x1A12030 Offset: 0x1A12131 VA: 0x1A12030
	public void .ctor(float value, float min, float max, bool overrideState = False) { }
}

