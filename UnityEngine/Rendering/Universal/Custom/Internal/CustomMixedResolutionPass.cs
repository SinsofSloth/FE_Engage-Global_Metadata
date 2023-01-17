// Namespace: UnityEngine.Rendering.Universal.Custom.Internal
public sealed class CustomMixedResolutionPass : ScriptableRenderPass // TypeDefIndex: 5453
{
	// Fields
	private const string m_ProfilerTag = "Custom Mixed Resolution";
	private ProfilingSampler m_ProfilingSampler; // 0x70
	private RenderTargetHandle m_HalfColorHandle; // 0x78
	private RenderTargetHandle m_HalfDepthHandle; // 0xA8
	private RenderTargetHandle m_EffectSoftParticleDepthHandle; // 0xD8
	private RenderTargetHandle m_EdgeHandle; // 0x108
	private Material m_CopyDepthMaterial; // 0x138
	private Material m_CompositeMaterial; // 0x140
	private Mesh m_FullScreenTriangle; // 0x148
	private FilteringSettings m_FilteringSettings; // 0x150
	private ShaderTagId m_EffectTagId; // 0x168
	private RenderStateBlock m_MixedRenderState; // 0x16C
	[CompilerGeneratedAttribute] // RVA: 0x483B60 Offset: 0x483C61 VA: 0x483B60
	private CustomMixedResolutionPass.DownsampleType <downsampleType>k__BackingField; // 0x1D8
	[CompilerGeneratedAttribute] // RVA: 0x483B70 Offset: 0x483C71 VA: 0x483B70
	private CustomMixedResolutionPass.CompositeType <compositeType>k__BackingField; // 0x1DC
	[CompilerGeneratedAttribute] // RVA: 0x483B80 Offset: 0x483C81 VA: 0x483B80
	private bool <mixHalfAndFull>k__BackingField; // 0x1E0
	[CompilerGeneratedAttribute] // RVA: 0x483B90 Offset: 0x483C91 VA: 0x483B90
	private RenderTargetIdentifier <srcDepth>k__BackingField; // 0x1E8

	// Properties
	public CustomMixedResolutionPass.DownsampleType downsampleType { get; set; }
	public CustomMixedResolutionPass.CompositeType compositeType { get; set; }
	public bool mixHalfAndFull { get; set; }
	public RenderTargetIdentifier srcDepth { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x485070 Offset: 0x485171 VA: 0x485070
	// RVA: 0x2D37FE0 Offset: 0x2D380E1 VA: 0x2D37FE0
	public CustomMixedResolutionPass.DownsampleType get_downsampleType() { }

	[CompilerGeneratedAttribute] // RVA: 0x485080 Offset: 0x485181 VA: 0x485080
	// RVA: 0x2D37FF0 Offset: 0x2D380F1 VA: 0x2D37FF0
	public void set_downsampleType(CustomMixedResolutionPass.DownsampleType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x485090 Offset: 0x485191 VA: 0x485090
	// RVA: 0x2D38000 Offset: 0x2D38101 VA: 0x2D38000
	public CustomMixedResolutionPass.CompositeType get_compositeType() { }

	[CompilerGeneratedAttribute] // RVA: 0x4850A0 Offset: 0x4851A1 VA: 0x4850A0
	// RVA: 0x2D38010 Offset: 0x2D38111 VA: 0x2D38010
	public void set_compositeType(CustomMixedResolutionPass.CompositeType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4850B0 Offset: 0x4851B1 VA: 0x4850B0
	// RVA: 0x2D38020 Offset: 0x2D38121 VA: 0x2D38020
	public bool get_mixHalfAndFull() { }

	[CompilerGeneratedAttribute] // RVA: 0x4850C0 Offset: 0x4851C1 VA: 0x4850C0
	// RVA: 0x2D38030 Offset: 0x2D38131 VA: 0x2D38030
	public void set_mixHalfAndFull(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4850D0 Offset: 0x4851D1 VA: 0x4850D0
	// RVA: 0x2D38040 Offset: 0x2D38141 VA: 0x2D38040
	public RenderTargetIdentifier get_srcDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x4850E0 Offset: 0x4851E1 VA: 0x4850E0
	// RVA: 0x2D38060 Offset: 0x2D38161 VA: 0x2D38060
	public void set_srcDepth(RenderTargetIdentifier value) { }

	// RVA: 0x2D34620 Offset: 0x2D34721 VA: 0x2D34620
	public void .ctor(RenderPassEvent evt, LayerMask layerMask, Material copyDepthMaterial, Material compositeMaterial) { }

	// RVA: 0x2D38080 Offset: 0x2D38181 VA: 0x2D38080 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }
}

