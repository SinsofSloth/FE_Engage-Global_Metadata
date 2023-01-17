// Namespace: UnityEngine.Rendering
public static class RTHandles // TypeDefIndex: 4610
{
	// Fields
	private static RTHandleSystem s_DefaultInstance; // 0x0

	// Properties
	public static int maxWidth { get; }
	public static int maxHeight { get; }
	public static RTHandleProperties rtHandleProperties { get; }

	// Methods

	// RVA: 0x1A16430 Offset: 0x1A16531 VA: 0x1A16430
	public static int get_maxWidth() { }

	// RVA: 0x1A164A0 Offset: 0x1A165A1 VA: 0x1A164A0
	public static int get_maxHeight() { }

	// RVA: 0x1A16510 Offset: 0x1A16611 VA: 0x1A16510
	public static RTHandleProperties get_rtHandleProperties() { }

	// RVA: 0x1A165A0 Offset: 0x1A166A1 VA: 0x1A165A0
	public static RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, string name = "") { }

	// RVA: 0x1A16740 Offset: 0x1A16841 VA: 0x1A16740
	public static RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, bool enableMSAA = False, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, string name = "") { }

	// RVA: 0x1A168F0 Offset: 0x1A169F1 VA: 0x1A168F0
	public static RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, bool enableMSAA = False, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, string name = "") { }

	// RVA: 0x1A16AA0 Offset: 0x1A16BA1 VA: 0x1A16AA0
	public static RTHandle Alloc(Texture tex) { }

	// RVA: 0x1A16B20 Offset: 0x1A16C21 VA: 0x1A16B20
	public static RTHandle Alloc(RenderTexture tex) { }

	// RVA: 0x1A16BA0 Offset: 0x1A16CA1 VA: 0x1A16BA0
	public static RTHandle Alloc(RenderTargetIdentifier tex) { }

	// RVA: 0x1A16C80 Offset: 0x1A16D81 VA: 0x1A16C80
	public static RTHandle Alloc(RenderTargetIdentifier tex, string name) { }

	// RVA: 0x1A16D20 Offset: 0x1A16E21 VA: 0x1A16D20
	private static RTHandle Alloc(RTHandle tex) { }

	// RVA: 0x1A16DA0 Offset: 0x1A16EA1 VA: 0x1A16DA0
	public static void Initialize(int width, int height, bool scaledRTsupportsMSAA, MSAASamples scaledRTMSAASamples) { }

	// RVA: 0x1A16E40 Offset: 0x1A16F41 VA: 0x1A16E40
	public static void Release(RTHandle rth) { }

	// RVA: 0x1A16EC0 Offset: 0x1A16FC1 VA: 0x1A16EC0
	public static void SetHardwareDynamicResolutionState(bool hwDynamicResRequested) { }

	// RVA: 0x1A16F40 Offset: 0x1A17041 VA: 0x1A16F40
	public static void SetReferenceSize(int width, int height, MSAASamples msaaSamples) { }

	// RVA: 0x1A16FD0 Offset: 0x1A170D1 VA: 0x1A16FD0
	public static void ResetReferenceSize(int width, int height) { }

	// RVA: 0x1A17060 Offset: 0x1A17161 VA: 0x1A17060
	private static void .cctor() { }
}

