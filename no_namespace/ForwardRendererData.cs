// Namespace: 
[ReloadGroupAttribute] // RVA: 0x47F440 Offset: 0x47F541 VA: 0x47F440
[Serializable]
public sealed class ForwardRendererData.ShaderResources // TypeDefIndex: 5282
{
	// Fields
	[ReloadAttribute] // RVA: 0x4813F0 Offset: 0x4814F1 VA: 0x4813F0
	public Shader blitPS; // 0x10
	[ReloadAttribute] // RVA: 0x481430 Offset: 0x481531 VA: 0x481430
	public Shader zprepass; // 0x18
	[ReloadAttribute] // RVA: 0x481470 Offset: 0x481571 VA: 0x481470
	public Shader downsampleDepth; // 0x20
	[ReloadAttribute] // RVA: 0x4814B0 Offset: 0x4815B1 VA: 0x4814B0
	public Shader halfResoComposite; // 0x28
	[ReloadAttribute] // RVA: 0x4814F0 Offset: 0x4815F1 VA: 0x4814F0
	public Shader lightOcclusion; // 0x30
	[ReloadAttribute] // RVA: 0x481530 Offset: 0x481631 VA: 0x481530
	public Shader copyDepthPS; // 0x38
	[ReloadAttribute] // RVA: 0x481570 Offset: 0x481671 VA: 0x481570
	public Shader screenSpaceShadowPS; // 0x40
	[ReloadAttribute] // RVA: 0x4815B0 Offset: 0x4816B1 VA: 0x4815B0
	public Shader samplingPS; // 0x48
	[EditorBrowsableAttribute] // RVA: 0x4815F0 Offset: 0x4816F1 VA: 0x4815F0
	public Shader tileDepthInfoPS; // 0x50
	[EditorBrowsableAttribute] // RVA: 0x481610 Offset: 0x481711 VA: 0x481610
	public Shader tileDeferredPS; // 0x58
	[ReloadAttribute] // RVA: 0x481630 Offset: 0x481731 VA: 0x481630
	public Shader stencilDeferredPS; // 0x60
	[ReloadAttribute] // RVA: 0x481670 Offset: 0x481771 VA: 0x481670
	public Shader fallbackErrorPS; // 0x68
	[ReloadAttribute] // RVA: 0x4816B0 Offset: 0x4817B1 VA: 0x4816B0
	public Shader materialErrorPS; // 0x70

	// Methods

	// RVA: 0x2FA3420 Offset: 0x2FA3521 VA: 0x2FA3420
	public void .ctor() { }
}

// Namespace: 
public enum ForwardRendererData.MixedResolutionFlag // TypeDefIndex: 5283
{
	// Fields
	public int value__; // 0x0
	public const ForwardRendererData.MixedResolutionFlag Off = 0;
	public const ForwardRendererData.MixedResolutionFlag EffectHalfBilinear = 1;
	public const ForwardRendererData.MixedResolutionFlag EffectHalfBilateral2x = 2;
	public const ForwardRendererData.MixedResolutionFlag EffectHalfBilateral4x = 3;
	public const ForwardRendererData.MixedResolutionFlag EffectMixed = 4;
	public const ForwardRendererData.MixedResolutionFlag EffectFull = 5;
	public const ForwardRendererData.MixedResolutionFlag _Count = 6;
}

