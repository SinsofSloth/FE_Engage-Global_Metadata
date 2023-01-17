// Namespace: UnityEngine.Rendering.Universal
internal class XRSystem // TypeDefIndex: 5382
{
	// Fields
	internal readonly XRPass emptyPass; // 0x10
	private List<XRPass> framePasses; // 0x18
	private static List<XRDisplaySubsystem> displayList; // 0x0
	private XRDisplaySubsystem display; // 0x20
	private static int msaaLevel; // 0x8
	private Material occlusionMeshMaterial; // 0x28
	private Material mirrorViewMaterial; // 0x30
	private MaterialPropertyBlock mirrorViewMaterialProperty; // 0x38
	private RenderTexture testRenderTexture; // 0x40
	private const string k_XRMirrorTag = "XR Mirror View";
	private static ProfilingSampler _XRMirrorProfilingSampler; // 0x10

	// Methods

	// RVA: 0x2F9B410 Offset: 0x2F9B511 VA: 0x2F9B410
	internal void .ctor() { }

	// RVA: 0x2FA0F90 Offset: 0x2FA1091 VA: 0x2FA0F90
	internal void InitializeXRSystemData(XRSystemData data) { }

	// RVA: 0x2FA1160 Offset: 0x2FA1261 VA: 0x2FA1160
	private static void GetDisplaySubsystem() { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x4849B0 Offset: 0x484AB1 VA: 0x4849B0
	// RVA: 0x2FA1220 Offset: 0x2FA1321 VA: 0x2FA1220
	internal static void XRSystemInit() { }

	// RVA: 0x2F92450 Offset: 0x2F92551 VA: 0x2F92450
	internal static void UpdateMSAALevel(int level) { }

	// RVA: 0x2FA1400 Offset: 0x2FA1501 VA: 0x2FA1400
	internal static int GetMSAALevel() { }

	// RVA: 0x2F92600 Offset: 0x2F92701 VA: 0x2F92600
	internal static void UpdateRenderScale(float renderScale) { }

	// RVA: 0x2FA0F70 Offset: 0x2FA1071 VA: 0x2FA0F70
	internal int GetMaxViews() { }

	// RVA: 0x2F95DD0 Offset: 0x2F95ED1 VA: 0x2F95DD0
	internal List<XRPass> SetupFrame(CameraData cameraData) { }

	// RVA: 0x2F97DC0 Offset: 0x2F97EC1 VA: 0x2F97DC0
	internal void ReleaseFrame() { }

	// RVA: 0x2F98CD0 Offset: 0x2F98DD1 VA: 0x2F98CD0
	internal bool RefreshXrSdk() { }

	// RVA: 0x2F96040 Offset: 0x2F96141 VA: 0x2F96040
	internal void UpdateCameraData(ref CameraData baseCameraData, in XRPass xr) { }

	// RVA: 0x2F96EC0 Offset: 0x2F96FC1 VA: 0x2F96EC0
	internal void UpdateFromCamera(ref XRPass xrPass, CameraData cameraData) { }

	// RVA: 0x2FA1470 Offset: 0x2FA1571 VA: 0x2FA1470
	private void CreateLayoutFromXrSdk(Camera camera, bool singlePassAllowed) { }

	// RVA: 0x2F929C0 Offset: 0x2F92AC1 VA: 0x2F929C0
	internal void Dispose() { }

	// RVA: 0x2F9DCA0 Offset: 0x2F9DDA1 VA: 0x2F9DCA0
	internal void AddPassToFrame(XRPass xrPass) { }

	// RVA: 0x2F97670 Offset: 0x2F97771 VA: 0x2F97670
	internal void RenderMirrorView(CommandBuffer cmd, Camera camera) { }

	// RVA: 0x2FA1E90 Offset: 0x2FA1F91 VA: 0x2FA1E90
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x4849D0 Offset: 0x484AD1 VA: 0x4849D0
	// RVA: 0x2FA1D70 Offset: 0x2FA1E71 VA: 0x2FA1D70
	internal static bool <CreateLayoutFromXrSdk>g__CanUseSinglePass|24_0(XRDisplaySubsystem.XRRenderPass renderPass, ref XRSystem.<>c__DisplayClass24_0 ) { }
}

