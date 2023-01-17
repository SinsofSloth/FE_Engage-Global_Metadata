// Namespace: UnityEngine.Rendering
public class RTHandleSystem : IDisposable // TypeDefIndex: 4609
{
	// Fields
	private bool m_HardwareDynamicResRequested; // 0x10
	private bool m_ScaledRTSupportsMSAA; // 0x11
	private MSAASamples m_ScaledRTCurrentMSAASamples; // 0x14
	private HashSet<RTHandle> m_AutoSizedRTs; // 0x18
	private RTHandle[] m_AutoSizedRTsArray; // 0x20
	private HashSet<RTHandle> m_ResizeOnDemandRTs; // 0x28
	private RTHandleProperties m_RTHandleProperties; // 0x30
	private int m_MaxWidths; // 0x60
	private int m_MaxHeights; // 0x64

	// Properties
	public RTHandleProperties rtHandleProperties { get; }

	// Methods

	// RVA: 0x1A13D60 Offset: 0x1A13E61 VA: 0x1A13D60
	public RTHandleProperties get_rtHandleProperties() { }

	// RVA: 0x1A13D80 Offset: 0x1A13E81 VA: 0x1A13D80
	public void .ctor() { }

	// RVA: 0x1A13E50 Offset: 0x1A13F51 VA: 0x1A13E50 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A14020 Offset: 0x1A14121 VA: 0x1A14020
	public void Initialize(int width, int height, bool scaledRTsupportsMSAA, MSAASamples scaledRTMSAASamples) { }

	// RVA: 0x1A142E0 Offset: 0x1A143E1 VA: 0x1A142E0
	public void Release(RTHandle rth) { }

	// RVA: 0x1A13AF0 Offset: 0x1A13BF1 VA: 0x1A13AF0
	internal void Remove(RTHandle rth) { }

	// RVA: 0x1A142F0 Offset: 0x1A143F1 VA: 0x1A142F0
	public void ResetReferenceSize(int width, int height) { }

	// RVA: 0x1A14650 Offset: 0x1A14751 VA: 0x1A14650
	public void SetReferenceSize(int width, int height, MSAASamples msaaSamples) { }

	// RVA: 0x1A14300 Offset: 0x1A14401 VA: 0x1A14300
	public void SetReferenceSize(int width, int height, MSAASamples msaaSamples, bool reset) { }

	// RVA: 0x1A149C0 Offset: 0x1A14AC1 VA: 0x1A149C0
	public void SetHardwareDynamicResolutionState(bool enableHWDynamicRes) { }

	// RVA: 0x1A14B60 Offset: 0x1A14C61 VA: 0x1A14B60
	internal void SwitchResizeMode(RTHandle rth, RTHandleSystem.ResizeMode mode) { }

	// RVA: 0x1A14C60 Offset: 0x1A14D61 VA: 0x1A14C60
	private void DemandResize(RTHandle rth) { }

	// RVA: 0x1A14EF0 Offset: 0x1A14FF1 VA: 0x1A14EF0
	public int GetMaxWidth() { }

	// RVA: 0x1A14F00 Offset: 0x1A15001 VA: 0x1A14F00
	public int GetMaxHeight() { }

	// RVA: 0x1A13E60 Offset: 0x1A13F61 VA: 0x1A13E60
	private void Dispose(bool disposing) { }

	// RVA: 0x1A14660 Offset: 0x1A14761 VA: 0x1A14660
	private void Resize(int width, int height, MSAASamples msaaSamples, bool sizeChanged, bool msaaSampleChanged) { }

	// RVA: 0x1A14F10 Offset: 0x1A15011 VA: 0x1A14F10
	public RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, string name = "") { }

	// RVA: 0x1A15460 Offset: 0x1A15561 VA: 0x1A15460
	public RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, bool enableMSAA = False, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, string name = "") { }

	// RVA: 0x1A15BA0 Offset: 0x1A15CA1 VA: 0x1A15BA0
	public RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, bool enableMSAA = False, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, string name = "") { }

	// RVA: 0x1A155D0 Offset: 0x1A156D1 VA: 0x1A155D0
	private RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, DepthBits depthBufferBits, GraphicsFormat colorFormat, FilterMode filterMode, TextureWrapMode wrapMode, TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, bool enableMSAA, bool bindTextureMS, bool useDynamicScale, RenderTextureMemoryless memoryless, string name) { }

	// RVA: 0x1A15D10 Offset: 0x1A15E11 VA: 0x1A15D10
	public RTHandle Alloc(RenderTexture texture) { }

	// RVA: 0x1A15E10 Offset: 0x1A15F11 VA: 0x1A15E10
	public RTHandle Alloc(Texture texture) { }

	// RVA: 0x1A15F10 Offset: 0x1A16011 VA: 0x1A15F10
	public RTHandle Alloc(RenderTargetIdentifier texture) { }

	// RVA: 0x1A15F90 Offset: 0x1A16091 VA: 0x1A15F90
	public RTHandle Alloc(RenderTargetIdentifier texture, string name) { }

	// RVA: 0x1A16090 Offset: 0x1A16191 VA: 0x1A16090
	private static RTHandle Alloc(RTHandle tex) { }

	// RVA: 0x1A16110 Offset: 0x1A16211 VA: 0x1A16110
	internal string DumpRTInfo() { }
}

