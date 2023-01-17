// Namespace: 
[FlagsAttribute] // RVA: 0x58D50 Offset: 0x58E51 VA: 0x58D50
public enum XRDisplaySubsystem.TextureLayout // TypeDefIndex: 4871
{
	// Fields
	public int value__; // 0x0
	public const XRDisplaySubsystem.TextureLayout Texture2DArray = 1;
	public const XRDisplaySubsystem.TextureLayout SingleTexture2D = 2;
	public const XRDisplaySubsystem.TextureLayout SeparateTexture2Ds = 4;
}

// Namespace: 
[NativeHeaderAttribute] // RVA: 0x58D60 Offset: 0x58E61 VA: 0x58D60
public struct XRDisplaySubsystem.XRRenderParameter // TypeDefIndex: 4872
{
	// Fields
	public Matrix4x4 view; // 0x0
	public Matrix4x4 projection; // 0x40
	public Rect viewport; // 0x80
	public Mesh occlusionMesh; // 0x90
	public int textureArraySlice; // 0x98
}

// Namespace: 
[NativeHeaderAttribute] // RVA: 0x58DA0 Offset: 0x58EA1 VA: 0x58DA0
[NativeHeaderAttribute] // RVA: 0x58DA0 Offset: 0x58EA1 VA: 0x58DA0
[NativeHeaderAttribute] // RVA: 0x58DA0 Offset: 0x58EA1 VA: 0x58DA0
public struct XRDisplaySubsystem.XRRenderPass // TypeDefIndex: 4873
{
	// Fields
	private IntPtr displaySubsystemInstance; // 0x0
	public int renderPassIndex; // 0x8
	public RenderTargetIdentifier renderTarget; // 0x10
	public RenderTextureDescriptor renderTargetDesc; // 0x38
	public bool shouldFillOutDepth; // 0x6C
	public int cullingPassIndex; // 0x70

	// Methods

	[NativeConditionalAttribute] // RVA: 0x59920 Offset: 0x59A21 VA: 0x59920
	[NativeMethodAttribute] // RVA: 0x59920 Offset: 0x59A21 VA: 0x59920
	// RVA: 0x1C501D0 Offset: 0x1C502D1 VA: 0x1C501D0
	public void GetRenderParameter(Camera camera, int renderParameterIndex, out XRDisplaySubsystem.XRRenderParameter renderParameter) { }

	[NativeMethodAttribute] // RVA: 0x599A0 Offset: 0x59AA1 VA: 0x599A0
	[NativeConditionalAttribute] // RVA: 0x599A0 Offset: 0x59AA1 VA: 0x599A0
	// RVA: 0x1C502B0 Offset: 0x1C503B1 VA: 0x1C502B0
	public int GetRenderParameterCount() { }

	// RVA: 0x1C50240 Offset: 0x1C50341 VA: 0x1C50240
	private static void GetRenderParameter_Injected(ref XRDisplaySubsystem.XRRenderPass _unity_self, Camera camera, int renderParameterIndex, out XRDisplaySubsystem.XRRenderParameter renderParameter) { }

	// RVA: 0x1C50300 Offset: 0x1C50401 VA: 0x1C50300
	private static int GetRenderParameterCount_Injected(ref XRDisplaySubsystem.XRRenderPass _unity_self) { }
}

// Namespace: 
[NativeHeaderAttribute] // RVA: 0x58E30 Offset: 0x58F31 VA: 0x58E30
[NativeHeaderAttribute] // RVA: 0x58E30 Offset: 0x58F31 VA: 0x58E30
public struct XRDisplaySubsystem.XRBlitParams // TypeDefIndex: 4874
{
	// Fields
	public RenderTexture srcTex; // 0x0
	public int srcTexArraySlice; // 0x8
	public Rect srcRect; // 0xC
	public Rect destRect; // 0x1C
}

// Namespace: 
[NativeHeaderAttribute] // RVA: 0x58E90 Offset: 0x58F91 VA: 0x58E90
public struct XRDisplaySubsystem.XRMirrorViewBlitDesc // TypeDefIndex: 4875
{
	// Fields
	private IntPtr displaySubsystemInstance; // 0x0
	public bool nativeBlitAvailable; // 0x8
	public bool nativeBlitInvalidStates; // 0x9
	public int blitParamsCount; // 0xC

	// Methods

	[NativeMethodAttribute] // RVA: 0x59A20 Offset: 0x59B21 VA: 0x59A20
	[NativeConditionalAttribute] // RVA: 0x59A20 Offset: 0x59B21 VA: 0x59A20
	// RVA: 0x1C50110 Offset: 0x1C50211 VA: 0x1C50110
	public void GetBlitParameter(int blitParameterIndex, out XRDisplaySubsystem.XRBlitParams blitParameter) { }

	// RVA: 0x1C50170 Offset: 0x1C50271 VA: 0x1C50170
	private static void GetBlitParameter_Injected(ref XRDisplaySubsystem.XRMirrorViewBlitDesc _unity_self, int blitParameterIndex, out XRDisplaySubsystem.XRBlitParams blitParameter) { }
}

