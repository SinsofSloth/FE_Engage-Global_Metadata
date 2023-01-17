// Namespace: UnityEngine.Rendering.Universal.Internal
public class ForwardLights // TypeDefIndex: 5396
{
	// Fields
	private const int k_CustomSpecCubeCount = 2;
	private int m_AdditionalLightsBufferId; // 0x10
	private int m_AdditionalLightsIndicesId; // 0x14
	private const string k_SetupLightConstants = "Setup Light Constants";
	private static readonly ProfilingSampler m_ProfilingSampler; // 0x0
	private MixedLightingSetup m_MixedLightingSetup; // 0x18
	private Vector4[] m_AdditionalLightPositions; // 0x20
	private Vector4[] m_AdditionalLightColors; // 0x28
	private Vector4[] m_AdditionalLightAttenuations; // 0x30
	private Vector4[] m_AdditionalLightSpotDirections; // 0x38
	private Vector4[] m_AdditionalLightOcclusionProbeChannels; // 0x40
	private bool m_UseStructuredBuffer; // 0x48
	private const int k_BatchSimpleLightMaxCount = 16;
	private Vector4[] m_BatchSimpleLightPositions; // 0x50
	private Vector4[] m_BatchSimpleLightColors; // 0x58
	private Vector4[] m_BatchSimpleLightAttenuations; // 0x60

	// Methods

	// RVA: 0x31424E0 Offset: 0x31425E1 VA: 0x31424E0
	public void .ctor() { }

	// RVA: 0x3142BB0 Offset: 0x3142CB1 VA: 0x3142BB0
	public void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x31432E0 Offset: 0x31433E1 VA: 0x31432E0
	private void InitializeLightConstants(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel) { }

	// RVA: 0x3142F30 Offset: 0x3143031 VA: 0x3142F30
	private void SetupShaderLightConstants(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x31434B0 Offset: 0x31435B1 VA: 0x31434B0
	private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData) { }

	// RVA: 0x31435B0 Offset: 0x31436B1 VA: 0x31435B0
	private void SetupCharaLightConstants(CommandBuffer cmd, ref LightData lightData, ref CameraData cameraData) { }

	// RVA: 0x3143870 Offset: 0x3143971 VA: 0x3143870
	private void SetupAdditionalLightConstants(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x3143FF0 Offset: 0x31440F1 VA: 0x3143FF0
	private int SetupPerObjectLightIndices(CullingResults cullResults, ref LightData lightData) { }

	// RVA: 0x3144220 Offset: 0x3144321 VA: 0x3144220
	private static void .cctor() { }
}

