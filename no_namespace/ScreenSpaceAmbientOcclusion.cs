// Namespace: 
private enum ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses // TypeDefIndex: 5328
{
	// Fields
	public int value__; // 0x0
	public const ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses AO = 0;
	public const ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses BlurHorizontal = 1;
	public const ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses BlurVertical = 2;
	public const ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses BlurFinal = 3;
}

// Namespace: 
private class ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass : ScriptableRenderPass // TypeDefIndex: 5329
{
	// Fields
	internal string profilerTag; // 0x70
	internal Material material; // 0x78
	private ScreenSpaceAmbientOcclusionSettings m_CurrentSettings; // 0x80
	private ProfilingSampler m_ProfilingSampler; // 0x88
	private RenderTargetIdentifier m_SSAOTexture1Target; // 0x90
	private RenderTargetIdentifier m_SSAOTexture2Target; // 0xB8
	private RenderTargetIdentifier m_SSAOTexture3Target; // 0xE0
	private RenderTextureDescriptor m_Descriptor; // 0x108
	private const string k_SSAOAmbientOcclusionParamName = "_AmbientOcclusionParam";
	private const string k_SSAOTextureName = "_ScreenSpaceOcclusionTexture";
	private static readonly int s_BaseMapID; // 0x0
	private static readonly int s_SSAOParamsID; // 0x4
	private static readonly int s_SSAOTexture1ID; // 0x8
	private static readonly int s_SSAOTexture2ID; // 0xC
	private static readonly int s_SSAOTexture3ID; // 0x10

	// Methods

	// RVA: 0x2FA4ED0 Offset: 0x2FA4FD1 VA: 0x2FA4ED0
	internal void .ctor() { }

	// RVA: 0x2FA5090 Offset: 0x2FA5191 VA: 0x2FA5090
	internal bool Setup(ScreenSpaceAmbientOcclusionSettings featureSettings) { }

	// RVA: 0x2FA51C0 Offset: 0x2FA52C1 VA: 0x2FA51C0 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2FA5740 Offset: 0x2FA5841 VA: 0x2FA5740 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2FA5DA0 Offset: 0x2FA5EA1 VA: 0x2FA5DA0
	private void Render(CommandBuffer cmd, RenderTargetIdentifier target, ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass) { }

	// RVA: 0x2FA5EE0 Offset: 0x2FA5FE1 VA: 0x2FA5EE0
	private void RenderAndSetBaseMap(CommandBuffer cmd, RenderTargetIdentifier baseMap, RenderTargetIdentifier target, ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass) { }

	// RVA: 0x2FA5FD0 Offset: 0x2FA60D1 VA: 0x2FA5FD0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x2FA6140 Offset: 0x2FA6241 VA: 0x2FA6140
	private static void .cctor() { }
}

