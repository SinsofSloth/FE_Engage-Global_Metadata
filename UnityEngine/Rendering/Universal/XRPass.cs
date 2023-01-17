// Namespace: UnityEngine.Rendering.Universal
internal class XRPass // TypeDefIndex: 5379
{
	// Fields
	internal List<XRView> views; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x482F10 Offset: 0x483011 VA: 0x482F10
	private bool <xrSdkEnabled>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x482F20 Offset: 0x483021 VA: 0x482F20
	private bool <copyDepth>k__BackingField; // 0x19
	[CompilerGeneratedAttribute] // RVA: 0x482F30 Offset: 0x483031 VA: 0x482F30
	private int <multipassId>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x482F40 Offset: 0x483041 VA: 0x482F40
	private int <cullingPassId>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x482F50 Offset: 0x483051 VA: 0x482F50
	private RenderTargetIdentifier <renderTarget>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x482F60 Offset: 0x483061 VA: 0x482F60
	private RenderTextureDescriptor <renderTargetDesc>k__BackingField; // 0x50
	private static RenderTargetIdentifier invalidRT; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x482F70 Offset: 0x483071 VA: 0x482F70
	private bool <renderTargetIsRenderTexture>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x482F80 Offset: 0x483081 VA: 0x482F80
	private ScriptableCullingParameters <cullingParams>k__BackingField; // 0x88
	private Material occlusionMeshMaterial; // 0x6A8
	private Mesh occlusionMeshCombined; // 0x6B0
	private int occlusionMeshCombinedHashCode; // 0x6B8
	private XRPass.CustomMirrorView customMirrorView; // 0x6C0
	private const string k_XRCustomMirrorTag = "XR Custom Mirror View";
	private static ProfilingSampler _XRCustomMirrorProfilingSampler; // 0x28
	private const string k_XROcclusionTag = "XR Occlusion Mesh";
	private static ProfilingSampler _XROcclusionProfilingSampler; // 0x30
	private Vector4[] stereoEyeIndices; // 0x6C8
	private Matrix4x4[] stereoProjectionMatrix; // 0x6D0
	private Matrix4x4[] stereoViewMatrix; // 0x6D8
	private Matrix4x4[] stereoCameraProjectionMatrix; // 0x6E0

	// Properties
	internal bool enabled { get; }
	internal bool xrSdkEnabled { get; set; }
	internal bool copyDepth { get; set; }
	internal int multipassId { get; set; }
	internal int cullingPassId { get; set; }
	internal RenderTargetIdentifier renderTarget { get; set; }
	internal RenderTextureDescriptor renderTargetDesc { get; set; }
	internal bool renderTargetValid { get; }
	internal bool renderTargetIsRenderTexture { get; set; }
	internal ScriptableCullingParameters cullingParams { get; set; }
	internal int viewCount { get; }
	internal bool singlePassEnabled { get; }
	internal bool isOcclusionMeshSupported { get; }
	internal bool hasValidOcclusionMesh { get; }

	// Methods

	// RVA: 0x2F95720 Offset: 0x2F95821 VA: 0x2F95720
	internal bool get_enabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x4848B0 Offset: 0x4849B1 VA: 0x4848B0
	// RVA: 0x2F9E440 Offset: 0x2F9E541 VA: 0x2F9E440
	internal bool get_xrSdkEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x4848C0 Offset: 0x4849C1 VA: 0x4848C0
	// RVA: 0x2F9E450 Offset: 0x2F9E551 VA: 0x2F9E450
	private void set_xrSdkEnabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4848D0 Offset: 0x4849D1 VA: 0x4848D0
	// RVA: 0x2F9E460 Offset: 0x2F9E561 VA: 0x2F9E460
	internal bool get_copyDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x4848E0 Offset: 0x4849E1 VA: 0x4848E0
	// RVA: 0x2F9E470 Offset: 0x2F9E571 VA: 0x2F9E470
	private void set_copyDepth(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4848F0 Offset: 0x4849F1 VA: 0x4848F0
	// RVA: 0x2F9E480 Offset: 0x2F9E581 VA: 0x2F9E480
	internal int get_multipassId() { }

	[CompilerGeneratedAttribute] // RVA: 0x484900 Offset: 0x484A01 VA: 0x484900
	// RVA: 0x2F9E490 Offset: 0x2F9E591 VA: 0x2F9E490
	private void set_multipassId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484910 Offset: 0x484A11 VA: 0x484910
	// RVA: 0x2F9E4A0 Offset: 0x2F9E5A1 VA: 0x2F9E4A0
	internal int get_cullingPassId() { }

	[CompilerGeneratedAttribute] // RVA: 0x484920 Offset: 0x484A21 VA: 0x484920
	// RVA: 0x2F9E4B0 Offset: 0x2F9E5B1 VA: 0x2F9E4B0
	private void set_cullingPassId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484930 Offset: 0x484A31 VA: 0x484930
	// RVA: 0x2F9E4C0 Offset: 0x2F9E5C1 VA: 0x2F9E4C0
	internal RenderTargetIdentifier get_renderTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x484940 Offset: 0x484A41 VA: 0x484940
	// RVA: 0x2F9E4E0 Offset: 0x2F9E5E1 VA: 0x2F9E4E0
	private void set_renderTarget(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484950 Offset: 0x484A51 VA: 0x484950
	// RVA: 0x2F9E500 Offset: 0x2F9E601 VA: 0x2F9E500
	internal RenderTextureDescriptor get_renderTargetDesc() { }

	[CompilerGeneratedAttribute] // RVA: 0x484960 Offset: 0x484A61 VA: 0x484960
	// RVA: 0x2F9E530 Offset: 0x2F9E631 VA: 0x2F9E530
	private void set_renderTargetDesc(RenderTextureDescriptor value) { }

	// RVA: 0x2F9E550 Offset: 0x2F9E651 VA: 0x2F9E550
	internal bool get_renderTargetValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x484970 Offset: 0x484A71 VA: 0x484970
	// RVA: 0x2F9E640 Offset: 0x2F9E741 VA: 0x2F9E640
	internal bool get_renderTargetIsRenderTexture() { }

	[CompilerGeneratedAttribute] // RVA: 0x484980 Offset: 0x484A81 VA: 0x484980
	// RVA: 0x2F9E650 Offset: 0x2F9E751 VA: 0x2F9E650
	private void set_renderTargetIsRenderTexture(bool value) { }

	// RVA: 0x2F9E660 Offset: 0x2F9E761 VA: 0x2F9E660
	internal Matrix4x4 GetProjMatrix(int viewIndex = 0) { }

	// RVA: 0x2F9E6F0 Offset: 0x2F9E7F1 VA: 0x2F9E6F0
	internal Matrix4x4 GetViewMatrix(int viewIndex = 0) { }

	// RVA: 0x2F9E7A0 Offset: 0x2F9E8A1 VA: 0x2F9E7A0
	internal int GetTextureArraySlice(int viewIndex = 0) { }

	// RVA: 0x2F9E810 Offset: 0x2F9E911 VA: 0x2F9E810
	internal Rect GetViewport(int viewIndex = 0) { }

	[CompilerGeneratedAttribute] // RVA: 0x484990 Offset: 0x484A91 VA: 0x484990
	// RVA: 0x2F9E890 Offset: 0x2F9E991 VA: 0x2F9E890
	internal ScriptableCullingParameters get_cullingParams() { }

	[CompilerGeneratedAttribute] // RVA: 0x4849A0 Offset: 0x484AA1 VA: 0x4849A0
	// RVA: 0x2F9E8A0 Offset: 0x2F9E9A1 VA: 0x2F9E8A0
	private void set_cullingParams(ScriptableCullingParameters value) { }

	// RVA: 0x2F9E8C0 Offset: 0x2F9E9C1 VA: 0x2F9E8C0
	internal int get_viewCount() { }

	// RVA: 0x2F9E910 Offset: 0x2F9EA11 VA: 0x2F9E910
	internal bool get_singlePassEnabled() { }

	// RVA: 0x2F9E960 Offset: 0x2F9EA61 VA: 0x2F9E960
	internal bool get_isOcclusionMeshSupported() { }

	// RVA: 0x2F9EA40 Offset: 0x2F9EB41 VA: 0x2F9EA40
	internal bool get_hasValidOcclusionMesh() { }

	// RVA: 0x2F9EBE0 Offset: 0x2F9ECE1 VA: 0x2F9EBE0
	internal void SetCustomMirrorView(XRPass.CustomMirrorView callback) { }

	// RVA: 0x2F9DA40 Offset: 0x2F9DB41 VA: 0x2F9DA40
	internal static XRPass Create(XRPassCreateInfo createInfo) { }

	// RVA: 0x2F9EBF0 Offset: 0x2F9ECF1 VA: 0x2F9EBF0
	internal void UpdateView(int viewId, XRDisplaySubsystem.XRRenderPass xrSdkRenderPass, XRDisplaySubsystem.XRRenderParameter xrSdkRenderParameter) { }

	// RVA: 0x2F9EEA0 Offset: 0x2F9EFA1 VA: 0x2F9EEA0
	internal void UpdateView(int viewId, Matrix4x4 proj, Matrix4x4 view, Rect vp, int textureArraySlice = -1) { }

	// RVA: 0x2F9F0E0 Offset: 0x2F9F1E1 VA: 0x2F9F0E0
	internal void UpdateCullingParams(int cullingPassId, ScriptableCullingParameters cullingParams) { }

	// RVA: 0x2F9DE00 Offset: 0x2F9DF01 VA: 0x2F9DE00
	internal void AddView(Matrix4x4 proj, Matrix4x4 view, Rect vp, int textureArraySlice = -1) { }

	// RVA: 0x2F9F300 Offset: 0x2F9F401 VA: 0x2F9F300
	internal static XRPass Create(XRDisplaySubsystem.XRRenderPass xrRenderPass, int multipassId, ScriptableCullingParameters cullingParameters, Material occlusionMeshMaterial) { }

	// RVA: 0x2F9F5E0 Offset: 0x2F9F6E1 VA: 0x2F9F5E0
	internal void AddView(XRDisplaySubsystem.XRRenderPass xrSdkRenderPass, XRDisplaySubsystem.XRRenderParameter xrSdkRenderParameter) { }

	// RVA: 0x2F9F6C0 Offset: 0x2F9F7C1 VA: 0x2F9F6C0
	internal static void Release(XRPass xrPass) { }

	// RVA: 0x2F9F110 Offset: 0x2F9F211 VA: 0x2F9F110
	internal void AddViewInternal(XRView xrView) { }

	// RVA: 0x2F9F740 Offset: 0x2F9F841 VA: 0x2F9F740
	internal void UpdateOcclusionMesh() { }

	// RVA: 0x2F9F8C0 Offset: 0x2F9F9C1 VA: 0x2F9F8C0
	private bool TryGetOcclusionMeshCombinedHashCode(out int hashCode) { }

	// RVA: 0x2F9FA20 Offset: 0x2F9FB21 VA: 0x2F9FA20
	private void CreateOcclusionMeshCombined() { }

	// RVA: 0x2F9FDA0 Offset: 0x2F9FEA1 VA: 0x2F9FDA0
	internal void StartSinglePass(CommandBuffer cmd) { }

	// RVA: 0x2FA00B0 Offset: 0x2FA01B1 VA: 0x2FA00B0
	internal void StopSinglePass(CommandBuffer cmd) { }

	// RVA: 0x2F95C70 Offset: 0x2F95D71 VA: 0x2F95C70
	internal void EndCamera(CommandBuffer cmd, CameraData cameraData) { }

	// RVA: 0x2F9E090 Offset: 0x2F9E191 VA: 0x2F9E090
	internal void RenderOcclusionMesh(CommandBuffer cmd) { }

	// RVA: 0x2FA0610 Offset: 0x2FA0711 VA: 0x2FA0610
	internal void UpdateGPUViewAndProjectionMatrices(CommandBuffer cmd, ref CameraData cameraData, bool isRenderToTexture) { }

	// RVA: 0x2FA0CB0 Offset: 0x2FA0DB1 VA: 0x2FA0CB0
	public void .ctor() { }

	// RVA: 0x2FA0E40 Offset: 0x2FA0F41 VA: 0x2FA0E40
	private static void .cctor() { }
}

