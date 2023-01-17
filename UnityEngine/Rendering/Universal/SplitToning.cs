// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F790 Offset: 0x47F891 VA: 0x47F790
[Serializable]
public sealed class SplitToning : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5306
{
	// Fields
	[TooltipAttribute] // RVA: 0x482670 Offset: 0x482771 VA: 0x482670
	public ColorParameter shadows; // 0x38
	[TooltipAttribute] // RVA: 0x4826B0 Offset: 0x4827B1 VA: 0x4826B0
	public ColorParameter highlights; // 0x40
	[TooltipAttribute] // RVA: 0x4826F0 Offset: 0x4827F1 VA: 0x4826F0
	public ClampedFloatParameter balance; // 0x48

	// Methods

	// RVA: 0x31358F0 Offset: 0x31359F1 VA: 0x31358F0 Slot: 8
	public bool IsActive() { }

	// RVA: 0x3135980 Offset: 0x3135A81 VA: 0x3135980 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x3135990 Offset: 0x3135A91 VA: 0x3135990
	public void .ctor() { }
}

