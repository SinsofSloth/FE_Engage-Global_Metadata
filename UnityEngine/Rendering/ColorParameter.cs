// Namespace: UnityEngine.Rendering
[DebuggerDisplayAttribute] // RVA: 0x3C150 Offset: 0x3C251 VA: 0x3C150
[Serializable]
public class ColorParameter : VolumeParameter<Color> // TypeDefIndex: 4671
{
	// Fields
	public bool hdr; // 0x24
	public bool showAlpha; // 0x25
	public bool showEyeDropper; // 0x26

	// Methods

	// RVA: 0x1B2BA70 Offset: 0x1B2BB71 VA: 0x1B2BA70
	public void .ctor(Color value, bool overrideState = False) { }

	// RVA: 0x1B2BB10 Offset: 0x1B2BC11 VA: 0x1B2BB10
	public void .ctor(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = False) { }

	// RVA: 0x1B2BBF0 Offset: 0x1B2BCF1 VA: 0x1B2BBF0 Slot: 14
	public override void Interp(Color from, Color to, float t) { }
}

