// Namespace: UnityEngine.Rendering.Universal.Internal
public class AdditionalLightsShadowCasterPass : ScriptableRenderPass // TypeDefIndex: 5398
{
	// Fields
	public static int m_AdditionalShadowsBufferId; // 0x0
	public static int m_AdditionalShadowsIndicesId; // 0x4
	private bool m_UseStructuredBuffer; // 0x70
	private const int k_ShadowmapBufferBits = 16;
	private RenderTargetHandle m_AdditionalLightsShadowmap; // 0x78
	private RenderTexture m_AdditionalLightsShadowmapTexture; // 0xA8
	private int m_ShadowmapWidth; // 0xB0
	private int m_ShadowmapHeight; // 0xB4
	private ShadowSliceData[] m_AdditionalLightSlices; // 0xB8
	private Matrix4x4[] m_AdditionalLightsWorldToShadow; // 0xC0
	private Vector4[] m_AdditionalLightsShadowParams; // 0xC8
	private ShaderInput.ShadowData[] m_AdditionalLightsShadowData; // 0xD0
	private List<int> m_AdditionalShadowCastingLightIndices; // 0xD8
	private List<int> m_AdditionalShadowCastingLightIndicesMap; // 0xE0
	private List<int> m_ShadowCastingLightIndicesMap; // 0xE8
	private bool m_SupportsBoxFilterForShadows; // 0xF0
	private ProfilingSampler m_ProfilingSetupSampler; // 0xF8

	// Methods

	// RVA: 0x2D26BF0 Offset: 0x2D26CF1 VA: 0x2D26BF0
	public void .ctor(RenderPassEvent evt) { }

	// RVA: 0x2D27060 Offset: 0x2D27161 VA: 0x2D27060
	public bool Setup(ref RenderingData renderingData) { }

	// RVA: 0x2D280C0 Offset: 0x2D281C1 VA: 0x2D280C0 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x2D281C0 Offset: 0x2D282C1 VA: 0x2D281C0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D287C0 Offset: 0x2D288C1 VA: 0x2D287C0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x2D288C0 Offset: 0x2D289C1 VA: 0x2D288C0
	public int GetShadowLightIndexFromLightIndex(int visibleLightIndex) { }

	// RVA: 0x2D27EF0 Offset: 0x2D27FF1 VA: 0x2D27EF0
	private void Clear() { }

	// RVA: 0x2D28200 Offset: 0x2D28301 VA: 0x2D28200
	private void RenderAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref CullingResults cullResults, ref LightData lightData, ref ShadowData shadowData) { }

	// RVA: 0x2D28960 Offset: 0x2D28A61 VA: 0x2D28960
	private void SetupAdditionalLightsShadowReceiverConstants(CommandBuffer cmd, ref ShadowData shadowData, bool softShadows) { }

	// RVA: 0x2D27F70 Offset: 0x2D28071 VA: 0x2D27F70
	private bool IsValidShadowCastingLight(ref LightData lightData, int i) { }
}

