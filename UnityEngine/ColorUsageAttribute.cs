// Namespace: UnityEngine
[AttributeUsageAttribute] // RVA: 0x43E160 Offset: 0x43E261 VA: 0x43E160
public sealed class ColorUsageAttribute : PropertyAttribute // TypeDefIndex: 3562
{
	// Fields
	public readonly bool showAlpha; // 0x10
	public readonly bool hdr; // 0x11
	[ObsoleteAttribute] // RVA: 0x443710 Offset: 0x443811 VA: 0x443710
	public readonly float minBrightness; // 0x14
	[ObsoleteAttribute] // RVA: 0x443750 Offset: 0x443851 VA: 0x443750
	public readonly float maxBrightness; // 0x18
	[ObsoleteAttribute] // RVA: 0x443790 Offset: 0x443891 VA: 0x443790
	public readonly float minExposureValue; // 0x1C
	[ObsoleteAttribute] // RVA: 0x4437D0 Offset: 0x4438D1 VA: 0x4437D0
	public readonly float maxExposureValue; // 0x20

	// Methods

	// RVA: 0x2F15FF0 Offset: 0x2F160F1 VA: 0x2F15FF0
	public void .ctor(bool showAlpha) { }

	// RVA: 0x2F16040 Offset: 0x2F16141 VA: 0x2F16040
	public void .ctor(bool showAlpha, bool hdr) { }
}

