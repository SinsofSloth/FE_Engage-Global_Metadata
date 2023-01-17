// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F550 Offset: 0x47F651 VA: 0x47F550
[Serializable]
public sealed class ColorCurves : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5289
{
	// Fields
	public TextureCurveParameter master; // 0x38
	public TextureCurveParameter red; // 0x40
	public TextureCurveParameter green; // 0x48
	public TextureCurveParameter blue; // 0x50
	public TextureCurveParameter hueVsHue; // 0x58
	public TextureCurveParameter hueVsSat; // 0x60
	public TextureCurveParameter satVsSat; // 0x68
	public TextureCurveParameter lumVsSat; // 0x70

	// Methods

	// RVA: 0x2D2A720 Offset: 0x2D2A821 VA: 0x2D2A720 Slot: 8
	public bool IsActive() { }

	// RVA: 0x2D2A730 Offset: 0x2D2A831 VA: 0x2D2A730 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2D2A740 Offset: 0x2D2A841 VA: 0x2D2A740
	public void .ctor() { }
}

