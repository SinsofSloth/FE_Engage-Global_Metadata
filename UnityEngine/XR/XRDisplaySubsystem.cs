// Namespace: UnityEngine.XR
[NativeTypeAttribute] // RVA: 0x58CB0 Offset: 0x58DB1 VA: 0x58CB0
[UsedByNativeCodeAttribute] // RVA: 0x58CB0 Offset: 0x58DB1 VA: 0x58CB0
[NativeHeaderAttribute] // RVA: 0x58CB0 Offset: 0x58DB1 VA: 0x58CB0
[NativeConditionalAttribute] // RVA: 0x58CB0 Offset: 0x58DB1 VA: 0x58CB0
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor> // TypeDefIndex: 4876
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x594C0 Offset: 0x595C1 VA: 0x594C0
	[CompilerGeneratedAttribute] // RVA: 0x594C0 Offset: 0x595C1 VA: 0x594C0
	private Action<bool> displayFocusChanged; // 0x20

	// Properties
	public float scaleOfAllRenderTargets { set; }
	public float zNear { set; }
	public float zFar { set; }
	public bool sRGB { set; }
	public XRDisplaySubsystem.TextureLayout textureLayout { set; }
	public bool disableLegacyRenderer { set; }

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x596E0 Offset: 0x597E1 VA: 0x596E0
	// RVA: 0x1C4F560 Offset: 0x1C4F661 VA: 0x1C4F560
	private void InvokeDisplayFocusChanged(bool focus) { }

	// RVA: 0x1C4F5D0 Offset: 0x1C4F6D1 VA: 0x1C4F5D0
	public void set_scaleOfAllRenderTargets(float value) { }

	// RVA: 0x1C4F620 Offset: 0x1C4F721 VA: 0x1C4F620
	public void set_zNear(float value) { }

	// RVA: 0x1C4F670 Offset: 0x1C4F771 VA: 0x1C4F670
	public void set_zFar(float value) { }

	// RVA: 0x1C4F6C0 Offset: 0x1C4F7C1 VA: 0x1C4F6C0
	public void set_sRGB(bool value) { }

	// RVA: 0x1C4F710 Offset: 0x1C4F811 VA: 0x1C4F710
	public void set_textureLayout(XRDisplaySubsystem.TextureLayout value) { }

	// RVA: 0x1C4F760 Offset: 0x1C4F861 VA: 0x1C4F760
	public void SetMSAALevel(int level) { }

	// RVA: 0x1C4F7B0 Offset: 0x1C4F8B1 VA: 0x1C4F7B0
	public void set_disableLegacyRenderer(bool value) { }

	// RVA: 0x1C4F800 Offset: 0x1C4F901 VA: 0x1C4F800
	public int GetRenderPassCount() { }

	// RVA: 0x1C4F850 Offset: 0x1C4F951 VA: 0x1C4F850
	public void GetRenderPass(int renderPassIndex, out XRDisplaySubsystem.XRRenderPass renderPass) { }

	[NativeMethodAttribute] // RVA: 0x596F0 Offset: 0x597F1 VA: 0x596F0
	// RVA: 0x1C4F900 Offset: 0x1C4FA01 VA: 0x1C4F900
	private bool Internal_TryGetRenderPass(int renderPassIndex, out XRDisplaySubsystem.XRRenderPass renderPass) { }

	// RVA: 0x1C4F960 Offset: 0x1C4FA61 VA: 0x1C4F960
	public void GetCullingParameters(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters) { }

	[NativeMethodAttribute] // RVA: 0x59730 Offset: 0x59831 VA: 0x59730
	[NativeHeaderAttribute] // RVA: 0x59730 Offset: 0x59831 VA: 0x59730
	// RVA: 0x1C4FAA0 Offset: 0x1C4FBA1 VA: 0x1C4FAA0
	private bool Internal_TryGetCullingParams(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters) { }

	[NativeConditionalAttribute] // RVA: 0x59790 Offset: 0x59891 VA: 0x59790
	[NativeMethodAttribute] // RVA: 0x59790 Offset: 0x59891 VA: 0x59790
	// RVA: 0x1C4FB10 Offset: 0x1C4FC11 VA: 0x1C4FB10
	public int GetPreferredMirrorBlitMode() { }

	[NativeMethodAttribute] // RVA: 0x59810 Offset: 0x59911 VA: 0x59810
	[NativeConditionalAttribute] // RVA: 0x59810 Offset: 0x59911 VA: 0x59810
	// RVA: 0x1C4FB60 Offset: 0x1C4FC61 VA: 0x1C4FB60
	public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc, int mode) { }

	[NativeMethodAttribute] // RVA: 0x59880 Offset: 0x59981 VA: 0x59880
	[NativeHeaderAttribute] // RVA: 0x59880 Offset: 0x59981 VA: 0x59880
	[NativeConditionalAttribute] // RVA: 0x59880 Offset: 0x59981 VA: 0x59880
	// RVA: 0x1C4FBD0 Offset: 0x1C4FCD1 VA: 0x1C4FBD0
	public bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode) { }

	// RVA: 0x1C4FC40 Offset: 0x1C4FD41 VA: 0x1C4FC40
	public void .ctor() { }
}

