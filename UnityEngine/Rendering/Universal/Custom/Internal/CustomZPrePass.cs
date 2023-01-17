// Namespace: UnityEngine.Rendering.Universal.Custom.Internal
public sealed class CustomZPrePass : ScriptableRenderPass // TypeDefIndex: 5461
{
	// Fields
	private const string m_ProfilerTag = "Custom ZPre";
	private ProfilingSampler m_ProfilingSampler; // 0x70
	private FilteringSettings m_OpaqueFilter; // 0x78
	private FilteringSettings m_AlphaTestFilter; // 0x90
	private ShaderTagId m_ShaderTagId; // 0xA8
	private List<ShaderTagId> m_ShaderTagIdList; // 0xB0
	private ShaderTagId m_MapCustomDepthShaderTagId; // 0xB8
	private ShaderTagId m_MapLeafDepthShaderTagId; // 0xBC
	private Material m_OverrideMaterial; // 0xC0
	private bool m_IsOverrideEnabled; // 0xC8
	private SortingCriteria m_SortingCriteria; // 0xCC

	// Methods

	// RVA: 0x2D34290 Offset: 0x2D34391 VA: 0x2D34290
	public void .ctor(RenderPassEvent evt, LayerMask layerMask, Material overrideMaterial) { }

	// RVA: 0x2D3B650 Offset: 0x2D3B751 VA: 0x2D3B650
	public void SetOverrideEnabled(bool isEnabled) { }

	// RVA: 0x2D36160 Offset: 0x2D36261 VA: 0x2D36160
	public void SetSortingCriteria(ZPrepassSortingCriteria criteria) { }

	// RVA: 0x2D3B660 Offset: 0x2D3B761 VA: 0x2D3B660 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D3BA50 Offset: 0x2D3BB51 VA: 0x2D3BA50
	private int SetupCommonDrawSettings(ref DrawingSettings drawSettings, int shaderPassIndex) { }

	// RVA: 0x2D3BB40 Offset: 0x2D3BC41 VA: 0x2D3BB40
	private int SetupCustomDepthDrawSettings(ref DrawingSettings drawSettings, int shaderPassIndex) { }
}

