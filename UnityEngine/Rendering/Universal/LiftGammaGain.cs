// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F690 Offset: 0x47F791 VA: 0x47F690
[Serializable]
public sealed class LiftGammaGain : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5298
{
	// Fields
	[TooltipAttribute] // RVA: 0x482270 Offset: 0x482371 VA: 0x482270
	public Vector4Parameter lift; // 0x38
	[TooltipAttribute] // RVA: 0x4822B0 Offset: 0x4823B1 VA: 0x4822B0
	public Vector4Parameter gamma; // 0x40
	[TooltipAttribute] // RVA: 0x4822F0 Offset: 0x4823F1 VA: 0x4822F0
	public Vector4Parameter gain; // 0x48

	// Methods

	// RVA: 0x3149860 Offset: 0x3149961 VA: 0x3149860 Slot: 8
	public bool IsActive() { }

	// RVA: 0x3149930 Offset: 0x3149A31 VA: 0x3149930 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x3149940 Offset: 0x3149A41 VA: 0x3149940
	public void .ctor() { }
}

