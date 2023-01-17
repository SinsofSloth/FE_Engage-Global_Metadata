// Namespace: UnityEngine.Rendering.Universal.Custom.Internal
public sealed class CustomBaseOpaquePass : ScriptableRenderPass // TypeDefIndex: 5444
{
	// Fields
	private FilteringSettings m_FilteringSettings; // 0x70
	private RenderStateBlock m_RenderStateBlock; // 0x88
	private ShaderTagId m_DefaultShaderTagId; // 0xF4
	private List<ShaderTagId> m_ShaderTagIdList; // 0xF8
	private string m_ProfilerTag; // 0x100
	private ProfilingSampler m_ProfilingSampler; // 0x108
	private static readonly int s_DrawObjectPassDataPropID; // 0x0
	private ShaderTagId m_NoOverrideStateShaderTagId; // 0x110
	private List<ShaderTagId> m_NoOverrideStateShaderTagIdList; // 0x118
	private DepthState m_DepthState; // 0x120
	private bool m_ZPrepassEnabled; // 0x122
	private bool m_ZPrepassOptimizedSort; // 0x123
	private Material m_BlitMaterial; // 0x128
	private int[] m_SilhouetteColorPropID; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x483AA0 Offset: 0x483BA1 VA: 0x483AA0
	private Vector4[] <silhouetteColors>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x483AB0 Offset: 0x483BB1 VA: 0x483AB0
	private bool <statusRenderingFlag>k__BackingField; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x483AC0 Offset: 0x483BC1 VA: 0x483AC0
	private bool <silhouetteEnabled>k__BackingField; // 0x141
	private bool m_CustomViewport; // 0x142
	private Rect m_CustomViewportRect; // 0x144
	private Rect m_OriginalViewportRect; // 0x154

	// Properties
	public Vector4[] silhouetteColors { get; set; }
	public bool statusRenderingFlag { get; set; }
	public bool silhouetteEnabled { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x484EF0 Offset: 0x484FF1 VA: 0x484EF0
	// RVA: 0x2D2E6B0 Offset: 0x2D2E7B1 VA: 0x2D2E6B0
	public Vector4[] get_silhouetteColors() { }

	[CompilerGeneratedAttribute] // RVA: 0x484F00 Offset: 0x485001 VA: 0x484F00
	// RVA: 0x2D2E6C0 Offset: 0x2D2E7C1 VA: 0x2D2E6C0
	public void set_silhouetteColors(Vector4[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484F10 Offset: 0x485011 VA: 0x484F10
	// RVA: 0x2D2E6D0 Offset: 0x2D2E7D1 VA: 0x2D2E6D0
	public bool get_statusRenderingFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x484F20 Offset: 0x485021 VA: 0x484F20
	// RVA: 0x2D2E6E0 Offset: 0x2D2E7E1 VA: 0x2D2E6E0
	public void set_statusRenderingFlag(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484F30 Offset: 0x485031 VA: 0x484F30
	// RVA: 0x2D2E6F0 Offset: 0x2D2E7F1 VA: 0x2D2E6F0
	public bool get_silhouetteEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x484F40 Offset: 0x485041 VA: 0x484F40
	// RVA: 0x2D2E700 Offset: 0x2D2E801 VA: 0x2D2E700
	public void set_silhouetteEnabled(bool value) { }

	// RVA: 0x2D2E710 Offset: 0x2D2E811 VA: 0x2D2E710
	public void .ctor(string profilerTag, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, Material blitMaterial) { }

	// RVA: 0x2D2EDE0 Offset: 0x2D2EEE1 VA: 0x2D2EDE0
	public void SetZPrepassFlag(bool zprepassEnabled) { }

	// RVA: 0x2D2EDF0 Offset: 0x2D2EEF1 VA: 0x2D2EDF0
	public void SetZPrepassFlag(bool zprepassEnabled, bool zprepassOptimizedSort) { }

	// RVA: 0x2D2ED60 Offset: 0x2D2EE61 VA: 0x2D2ED60
	private void InternalSetZPrepassFlag(bool zprepassEnabled) { }

	// RVA: 0x2D2EEA0 Offset: 0x2D2EFA1 VA: 0x2D2EEA0
	public void EnableCustomViewport(float originalW, float originalH, float customW, float customH) { }

	// RVA: 0x2D2EF20 Offset: 0x2D2F021 VA: 0x2D2EF20
	public void DisableCustomViewport() { }

	// RVA: 0x2D2EF30 Offset: 0x2D2F031 VA: 0x2D2EF30 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D2F5C0 Offset: 0x2D2F6C1 VA: 0x2D2F5C0
	private static void .cctor() { }
}

