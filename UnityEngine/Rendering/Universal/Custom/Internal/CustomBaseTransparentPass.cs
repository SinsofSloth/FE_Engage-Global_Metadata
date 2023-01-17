// Namespace: UnityEngine.Rendering.Universal.Custom.Internal
public sealed class CustomBaseTransparentPass : ScriptableRenderPass // TypeDefIndex: 5445
{
	// Fields
	private FilteringSettings m_FilteringSettings; // 0x70
	private RenderStateBlock m_RenderStateBlock; // 0x88
	private ShaderTagId m_DefaultShaderTagId; // 0xF4
	private List<ShaderTagId> m_ShaderTagIdList; // 0xF8
	private ShaderTagId m_UnlitShaderTagId; // 0x100
	private string m_ProfilerTag; // 0x108
	private ProfilingSampler m_ProfilingSampler; // 0x110
	private static readonly int s_DrawObjectPassDataPropID; // 0x0
	private List<ShaderTagId> m_NoOverrideStateShaderTagIdList; // 0x118
	private bool m_MixedResolutionEnabled; // 0x120
	private bool m_ShouldSetEffectDepth; // 0x121
	private RenderTargetIdentifier m_EffectDepthId; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x483AD0 Offset: 0x483BD1 VA: 0x483AD0
	private bool <statusRenderingFlag>k__BackingField; // 0x150

	// Properties
	public bool statusRenderingFlag { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x484F50 Offset: 0x485051 VA: 0x484F50
	// RVA: 0x2D2F640 Offset: 0x2D2F741 VA: 0x2D2F640
	public bool get_statusRenderingFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x484F60 Offset: 0x485061 VA: 0x484F60
	// RVA: 0x2D2F650 Offset: 0x2D2F751 VA: 0x2D2F650
	public void set_statusRenderingFlag(bool value) { }

	// RVA: 0x2D2F660 Offset: 0x2D2F761 VA: 0x2D2F660
	public void .ctor(string profilerTag, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask) { }

	// RVA: 0x2D2FA20 Offset: 0x2D2FB21 VA: 0x2D2FA20
	public void SetMixedResolutionEnabled(bool enabled) { }

	// RVA: 0x2D2FA30 Offset: 0x2D2FB31 VA: 0x2D2FA30
	public void SetEffectDepth(int id) { }

	// RVA: 0x2D2FA90 Offset: 0x2D2FB91 VA: 0x2D2FA90 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D2FF30 Offset: 0x2D30031 VA: 0x2D2FF30
	private static void .cctor() { }
}

