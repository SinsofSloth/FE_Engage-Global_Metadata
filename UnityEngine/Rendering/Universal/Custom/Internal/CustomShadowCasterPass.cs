// Namespace: UnityEngine.Rendering.Universal.Custom.Internal
public sealed class CustomShadowCasterPass : ScriptableRenderPass // TypeDefIndex: 5455
{
	// Fields
	private const int k_MaxCascades = 1;
	private const int k_ShadowmapBufferBits = 16;
	private float m_MaxShadowDistanceSq; // 0x70
	private int m_ShadowmapWidth; // 0x74
	private int m_ShadowmapHeight; // 0x78
	private int m_ShadowCasterCascadesCount; // 0x7C
	private bool m_SupportsBoxFilterForShadows; // 0x80
	private RenderTargetHandle m_CustomShadowmap; // 0x88
	private RenderTexture m_CustomShadowmapTexture; // 0xB8
	private Matrix4x4[] m_CustomShadowMatrices; // 0xC0
	private ShadowSliceData[] m_CascadeSlices; // 0xC8
	private Vector4[] m_CascadeSplitDistances; // 0xD0
	private const string m_ProfilerTag = "Render Custom Shadowmap";
	private ProfilingSampler m_ProfilingSampler; // 0xD8

	// Methods

	// RVA: 0x2D33B50 Offset: 0x2D33C51 VA: 0x2D33B50
	public void .ctor(RenderPassEvent evt) { }

	// RVA: 0x2D36180 Offset: 0x2D36281 VA: 0x2D36180
	public bool Setup(ref RenderingData renderingData) { }

	// RVA: 0x2D397D0 Offset: 0x2D398D1 VA: 0x2D397D0 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x2D398D0 Offset: 0x2D399D1 VA: 0x2D398D0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D39E90 Offset: 0x2D39F91 VA: 0x2D39E90 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x2D39630 Offset: 0x2D39731 VA: 0x2D39630
	private void Clear() { }

	// RVA: 0x2D39900 Offset: 0x2D39A01 VA: 0x2D39900
	private void RenderShadowmap(ref ScriptableRenderContext context, ref CullingResults cullResults, ref LightData lightData, ref ShadowData shadowData) { }

	// RVA: 0x2D39F90 Offset: 0x2D3A091 VA: 0x2D39F90
	private void SetupCustomShadowReceiverConstants(CommandBuffer cmd, VisibleLight shadowLight, bool softShadows) { }
}

