// Namespace: UnityEngine.Rendering
[DebuggerDisplayAttribute] // RVA: 0x3C190 Offset: 0x3C291 VA: 0x3C190
[Serializable]
public class NoInterpColorParameter : VolumeParameter<Color> // TypeDefIndex: 4672
{
	// Fields
	public bool hdr; // 0x24
	public bool showAlpha; // 0x25
	public bool showEyeDropper; // 0x26

	// Methods

	// RVA: 0x1A121A0 Offset: 0x1A122A1 VA: 0x1A121A0
	public void .ctor(Color value, bool overrideState = False) { }

	// RVA: 0x1A12240 Offset: 0x1A12341 VA: 0x1A12240
	public void .ctor(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = False) { }
}

