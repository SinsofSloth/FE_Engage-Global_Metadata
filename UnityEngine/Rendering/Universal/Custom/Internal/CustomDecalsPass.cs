// Namespace: UnityEngine.Rendering.Universal.Custom.Internal
public sealed class CustomDecalsPass : ScriptableRenderPass // TypeDefIndex: 5447
{
	// Fields
	private const string m_ProfilerTag = "Custom Decals";
	private ProfilingSampler m_ProfilingSampler; // 0x70
	private RenderTargetHandle m_DecalShadowHandle; // 0x78
	private RenderTargetHandle m_DepthHandle; // 0xA8
	private FilteringSettings m_FilteringSettings; // 0xD8
	private ShaderTagId m_DecalShaderTagId; // 0xF0
	private int m_ScaleBiasId; // 0xF4
	private Material m_CopyDepthMaterial; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x483B20 Offset: 0x483C21 VA: 0x483B20
	private RenderTargetHandle <preColorAttachment>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x483B30 Offset: 0x483C31 VA: 0x483B30
	private RenderTargetHandle <preDepthAttachment>k__BackingField; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x483B40 Offset: 0x483C41 VA: 0x483B40
	private RenderTargetIdentifier <srcDepth>k__BackingField; // 0x160
	private bool m_IsOcclusionCasterEnabled; // 0x188
	private float m_OcclusionStrength; // 0x18C
	private float m_OcclusionBlackToAlbedo; // 0x190

	// Properties
	public RenderTargetHandle preColorAttachment { get; set; }
	public RenderTargetHandle preDepthAttachment { get; set; }
	public RenderTargetIdentifier srcDepth { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x484FF0 Offset: 0x4850F1 VA: 0x484FF0
	// RVA: 0x2D31140 Offset: 0x2D31241 VA: 0x2D31140
	public RenderTargetHandle get_preColorAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x485000 Offset: 0x485101 VA: 0x485000
	// RVA: 0x2D31160 Offset: 0x2D31261 VA: 0x2D31160
	public void set_preColorAttachment(RenderTargetHandle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x485010 Offset: 0x485111 VA: 0x485010
	// RVA: 0x2D31180 Offset: 0x2D31281 VA: 0x2D31180
	public RenderTargetHandle get_preDepthAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x485020 Offset: 0x485121 VA: 0x485020
	// RVA: 0x2D311A0 Offset: 0x2D312A1 VA: 0x2D311A0
	public void set_preDepthAttachment(RenderTargetHandle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x485030 Offset: 0x485131 VA: 0x485030
	// RVA: 0x2D311C0 Offset: 0x2D312C1 VA: 0x2D311C0
	public RenderTargetIdentifier get_srcDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x485040 Offset: 0x485141 VA: 0x485040
	// RVA: 0x2D311E0 Offset: 0x2D312E1 VA: 0x2D311E0
	public void set_srcDepth(RenderTargetIdentifier value) { }

	// RVA: 0x2D31200 Offset: 0x2D31301 VA: 0x2D31200
	public void .ctor(RenderPassEvent evt, LayerMask layerMask, Material copyDepthMaterial) { }

	// RVA: 0x2D31430 Offset: 0x2D31531 VA: 0x2D31430 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D32000 Offset: 0x2D32101 VA: 0x2D32000 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x2D32090 Offset: 0x2D32191 VA: 0x2D32090
	public void SetOcclusionParams(DecalOcclusionParams p) { }
}

