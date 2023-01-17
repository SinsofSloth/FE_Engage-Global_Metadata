// Namespace: UnityEngine.Rendering.Universal.Custom.Internal
public sealed class CustomSpecialReflectionPass : ScriptableRenderPass // TypeDefIndex: 5458
{
	// Fields
	private FilteringSettings m_FilteringSettings; // 0x70
	private ShaderTagId m_ShaderTagId; // 0x88
	private ProfilingSampler m_ProfilingSampler; // 0x90
	private static readonly int s_DrawObjectPassDataPropID; // 0x0
	private bool m_CustomViewport; // 0x98
	private Rect m_CustomViewportRect; // 0x9C
	private Rect m_OriginalViewportRect; // 0xAC

	// Methods

	// RVA: 0x2D3AA90 Offset: 0x2D3AB91 VA: 0x2D3AA90
	public void .ctor(string profilerTag, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask) { }

	// RVA: 0x2D3AC70 Offset: 0x2D3AD71 VA: 0x2D3AC70
	public void EnableCustomViewport(float originalW, float originalH, float customW, float customH) { }

	// RVA: 0x2D3ACF0 Offset: 0x2D3ADF1 VA: 0x2D3ACF0
	public void DisableCustomViewport() { }

	// RVA: 0x2D3AD00 Offset: 0x2D3AE01 VA: 0x2D3AD00 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D3AF90 Offset: 0x2D3B091 VA: 0x2D3AF90
	private static void .cctor() { }
}

