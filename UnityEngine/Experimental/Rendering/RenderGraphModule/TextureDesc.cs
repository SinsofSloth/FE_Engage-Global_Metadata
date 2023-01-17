// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public struct TextureDesc // TypeDefIndex: 4504
{
	// Fields
	public TextureSizeMode sizeMode; // 0x0
	public int width; // 0x4
	public int height; // 0x8
	public int slices; // 0xC
	public Vector2 scale; // 0x10
	public ScaleFunc func; // 0x18
	public DepthBits depthBufferBits; // 0x20
	public GraphicsFormat colorFormat; // 0x24
	public FilterMode filterMode; // 0x28
	public TextureWrapMode wrapMode; // 0x2C
	public TextureDimension dimension; // 0x30
	public bool enableRandomWrite; // 0x34
	public bool useMipMap; // 0x35
	public bool autoGenerateMips; // 0x36
	public bool isShadowMap; // 0x37
	public int anisoLevel; // 0x38
	public float mipMapBias; // 0x3C
	public bool enableMSAA; // 0x40
	public MSAASamples msaaSamples; // 0x44
	public bool bindTextureMS; // 0x48
	public bool useDynamicScale; // 0x49
	public RenderTextureMemoryless memoryless; // 0x4C
	public string name; // 0x50
	public FastMemoryDesc fastMemoryDesc; // 0x58
	public bool clearBuffer; // 0x64
	public Color clearColor; // 0x68

	// Methods

	// RVA: 0x3546FB0 Offset: 0x35470B1 VA: 0x3546FB0
	private void InitDefaultValues(bool dynamicResolution, bool xrReady) { }

	// RVA: 0x35471D0 Offset: 0x35472D1 VA: 0x35471D0
	public void .ctor(int width, int height, bool dynamicResolution = False, bool xrReady = False) { }

	// RVA: 0x3547210 Offset: 0x3547311 VA: 0x3547210
	public void .ctor(Vector2 scale, bool dynamicResolution = False, bool xrReady = False) { }

	// RVA: 0x3547280 Offset: 0x3547381 VA: 0x3547280
	public void .ctor(ScaleFunc func, bool dynamicResolution = False, bool xrReady = False) { }

	// RVA: 0x3547310 Offset: 0x3547411 VA: 0x3547310
	public void .ctor(TextureDesc input) { }

	// RVA: 0x3543D70 Offset: 0x3543E71 VA: 0x3543D70 Slot: 2
	public override int GetHashCode() { }
}

