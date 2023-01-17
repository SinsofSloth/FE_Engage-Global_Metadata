// Namespace: UnityEngine.Rendering.Universal
[DisallowMultipleRendererFeature] // RVA: 0x47F940 Offset: 0x47FA41 VA: 0x47F940
internal class ScreenSpaceAmbientOcclusion : ScriptableRendererFeature // TypeDefIndex: 5330
{
	// Fields
	[SerializeField] // RVA: 0x482B50 Offset: 0x482C51 VA: 0x482B50
	[HideInInspector] // RVA: 0x482B50 Offset: 0x482C51 VA: 0x482B50
	private Shader m_Shader; // 0x20
	[SerializeField] // RVA: 0x482B90 Offset: 0x482C91 VA: 0x482B90
	private ScreenSpaceAmbientOcclusionSettings m_Settings; // 0x28
	private Material m_Material; // 0x30
	private ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass m_SSAOPass; // 0x38
	private const string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceAmbientOcclusion";
	private const string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC";
	private const string k_NormalReconstructionLowKeyword = "_RECONSTRUCT_NORMAL_LOW";
	private const string k_NormalReconstructionMediumKeyword = "_RECONSTRUCT_NORMAL_MEDIUM";
	private const string k_NormalReconstructionHighKeyword = "_RECONSTRUCT_NORMAL_HIGH";
	private const string k_SourceDepthKeyword = "_SOURCE_DEPTH";
	private const string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS";
	private const string k_SourceGBufferKeyword = "_SOURCE_GBUFFER";

	// Methods

	// RVA: 0x31264B0 Offset: 0x31265B1 VA: 0x31264B0 Slot: 5
	public override void Create() { }

	// RVA: 0x3126720 Offset: 0x3126821 VA: 0x3126720 Slot: 6
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x3126950 Offset: 0x3126A51 VA: 0x3126950 Slot: 7
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3126560 Offset: 0x3126661 VA: 0x3126560
	private bool GetMaterial() { }

	// RVA: 0x31269C0 Offset: 0x3126AC1 VA: 0x31269C0
	public void .ctor() { }
}

