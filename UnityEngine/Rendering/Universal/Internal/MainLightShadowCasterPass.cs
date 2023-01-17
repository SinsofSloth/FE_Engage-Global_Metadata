// Namespace: UnityEngine.Rendering.Universal.Internal
public class MainLightShadowCasterPass : ScriptableRenderPass // TypeDefIndex: 5410
{
	// Fields
	private const int k_MaxCascades = 4;
	private const int k_ShadowmapBufferBits = 16;
	private float m_MaxShadowDistance; // 0x70
	private int m_ShadowmapWidth; // 0x74
	private int m_ShadowmapHeight; // 0x78
	private int m_ShadowCasterCascadesCount; // 0x7C
	private bool m_SupportsBoxFilterForShadows; // 0x80
	private RenderTargetHandle m_MainLightShadowmap; // 0x88
	private RenderTexture m_MainLightShadowmapTexture; // 0xB8
	private Matrix4x4[] m_MainLightShadowMatrices; // 0xC0
	private ShadowSliceData[] m_CascadeSlices; // 0xC8
	private Vector4[] m_CascadeSplitDistances; // 0xD0
	private ProfilingSampler m_ProfilingSetupSampler; // 0xD8

	// Methods

	// RVA: 0x3144E10 Offset: 0x3144F11 VA: 0x3144E10
	public void .ctor(RenderPassEvent evt) { }

	// RVA: 0x3147070 Offset: 0x3147171 VA: 0x3147070
	public bool Setup(ref RenderingData renderingData) { }

	// RVA: 0x314E020 Offset: 0x314E121 VA: 0x314E020 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x314E120 Offset: 0x314E221 VA: 0x314E120 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x314E750 Offset: 0x314E851 VA: 0x314E750 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x314DE80 Offset: 0x314DF81 VA: 0x314DE80
	private void Clear() { }

	// RVA: 0x314E150 Offset: 0x314E251 VA: 0x314E150
	private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref CullingResults cullResults, ref LightData lightData, ref ShadowData shadowData) { }

	// RVA: 0x314E850 Offset: 0x314E951 VA: 0x314E850
	private void SetupMainLightShadowReceiverConstants(CommandBuffer cmd, VisibleLight shadowLight, bool supportsSoftShadows) { }
}

