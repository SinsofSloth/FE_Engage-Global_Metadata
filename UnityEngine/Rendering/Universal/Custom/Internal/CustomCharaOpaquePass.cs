// Namespace: UnityEngine.Rendering.Universal.Custom.Internal
public sealed class CustomCharaOpaquePass : ScriptableRenderPass // TypeDefIndex: 5446
{
	// Fields
	private const string m_ProfilerTag = "Custom Opaques Chara";
	private const string m_ProfilerTag2 = "Custom Opaques Chara Outline";
	private const string m_ProfilerTag3 = "Custom Opaques Chara Silhouette";
	private const string m_ProfilerTag4 = "Custom Opaques Chara Depth";
	private ProfilingSampler m_ProfilingSampler; // 0x70
	private ProfilingSampler m_ProfilingSampler2; // 0x78
	private ProfilingSampler m_ProfilingSampler3; // 0x80
	private ProfilingSampler m_ProfilingSampler4; // 0x88
	private static readonly int s_DrawObjectPassDataPropID; // 0x0
	private FilteringSettings m_FilteringSettings; // 0x90
	private ShaderTagId m_BaseShaderTagId; // 0xA8
	private ShaderTagId m_HairShaderTagId; // 0xAC
	private ShaderTagId m_EyeShaderTagId; // 0xB0
	private ShaderTagId m_BrowShadowShaderTagId; // 0xB4
	private ShaderTagId m_OpaqueBlendShaderTagId; // 0xB8
	private ShaderTagId m_OutlineShaderTagId; // 0xBC
	private ShaderTagId m_SilhouetteShaderTagId; // 0xC0
	private ShaderTagId m_DepthOnlyShaderTagId; // 0xC4
	private RenderStateBlock m_OverrideRenderStateBlock; // 0xC8
	private DepthState m_OverrideDepthState; // 0x134
	[CompilerGeneratedAttribute] // RVA: 0x483AE0 Offset: 0x483BE1 VA: 0x483AE0
	private bool <statusRenderingFlag>k__BackingField; // 0x136
	[CompilerGeneratedAttribute] // RVA: 0x483AF0 Offset: 0x483BF1 VA: 0x483AF0
	private bool <silhouetteFlag>k__BackingField; // 0x137
	[CompilerGeneratedAttribute] // RVA: 0x483B00 Offset: 0x483C01 VA: 0x483B00
	private bool <outlineFlag>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x483B10 Offset: 0x483C11 VA: 0x483B10
	private bool <zprepassFlag>k__BackingField; // 0x139
	private bool m_CustomViewport; // 0x13A
	private Rect m_CustomViewportRect; // 0x13C
	private Rect m_OriginalViewportRect; // 0x14C

	// Properties
	public bool statusRenderingFlag { get; set; }
	public bool silhouetteFlag { get; set; }
	public bool outlineFlag { get; set; }
	public bool zprepassFlag { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x484F70 Offset: 0x485071 VA: 0x484F70
	// RVA: 0x2D2FFB0 Offset: 0x2D300B1 VA: 0x2D2FFB0
	public bool get_statusRenderingFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x484F80 Offset: 0x485081 VA: 0x484F80
	// RVA: 0x2D2FFC0 Offset: 0x2D300C1 VA: 0x2D2FFC0
	public void set_statusRenderingFlag(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484F90 Offset: 0x485091 VA: 0x484F90
	// RVA: 0x2D2FFD0 Offset: 0x2D300D1 VA: 0x2D2FFD0
	public bool get_silhouetteFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x484FA0 Offset: 0x4850A1 VA: 0x484FA0
	// RVA: 0x2D2FFE0 Offset: 0x2D300E1 VA: 0x2D2FFE0
	public void set_silhouetteFlag(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484FB0 Offset: 0x4850B1 VA: 0x484FB0
	// RVA: 0x2D2FFF0 Offset: 0x2D300F1 VA: 0x2D2FFF0
	public bool get_outlineFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x484FC0 Offset: 0x4850C1 VA: 0x484FC0
	// RVA: 0x2D30000 Offset: 0x2D30101 VA: 0x2D30000
	public void set_outlineFlag(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484FD0 Offset: 0x4850D1 VA: 0x484FD0
	// RVA: 0x2D30010 Offset: 0x2D30111 VA: 0x2D30010
	public bool get_zprepassFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x484FE0 Offset: 0x4850E1 VA: 0x484FE0
	// RVA: 0x2D30020 Offset: 0x2D30121 VA: 0x2D30020
	public void set_zprepassFlag(bool value) { }

	// RVA: 0x2D30030 Offset: 0x2D30131 VA: 0x2D30030
	public void .ctor(RenderPassEvent evt, LayerMask layerMask) { }

	// RVA: 0x2D30520 Offset: 0x2D30621 VA: 0x2D30520
	public void EnableCustomViewport(float originalW, float originalH, float customW, float customH) { }

	// RVA: 0x2D305A0 Offset: 0x2D306A1 VA: 0x2D305A0
	public void DisableCustomViewport() { }

	// RVA: 0x2D305B0 Offset: 0x2D306B1 VA: 0x2D305B0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D30EE0 Offset: 0x2D30FE1 VA: 0x2D30EE0
	private static void .cctor() { }
}

