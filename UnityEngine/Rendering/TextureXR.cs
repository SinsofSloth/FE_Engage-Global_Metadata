// Namespace: UnityEngine.Rendering
public static class TextureXR // TypeDefIndex: 4611
{
	// Fields
	private static int m_MaxViews; // 0x0
	private static Texture m_BlackUIntTexture2DArray; // 0x8
	private static Texture m_BlackUIntTexture; // 0x10
	private static RTHandle m_BlackUIntTexture2DArrayRTH; // 0x18
	private static RTHandle m_BlackUIntTextureRTH; // 0x20
	private static Texture2DArray m_ClearTexture2DArray; // 0x28
	private static Texture2D m_ClearTexture; // 0x30
	private static RTHandle m_ClearTexture2DArrayRTH; // 0x38
	private static RTHandle m_ClearTextureRTH; // 0x40
	private static Texture2DArray m_MagentaTexture2DArray; // 0x48
	private static Texture2D m_MagentaTexture; // 0x50
	private static RTHandle m_MagentaTexture2DArrayRTH; // 0x58
	private static RTHandle m_MagentaTextureRTH; // 0x60
	private static Texture3D m_BlackTexture3D; // 0x68
	private static Texture2DArray m_BlackTexture2DArray; // 0x70
	private static RTHandle m_BlackTexture2DArrayRTH; // 0x78
	private static RTHandle m_BlackTextureRTH; // 0x80
	private static RTHandle m_BlackTexture3DRTH; // 0x88
	private static Texture2DArray m_WhiteTexture2DArray; // 0x90
	private static RTHandle m_WhiteTexture2DArrayRTH; // 0x98
	private static RTHandle m_WhiteTextureRTH; // 0xA0

	// Properties
	public static int maxViews { set; }
	public static int slices { get; }
	public static bool useTexArray { get; }
	public static TextureDimension dimension { get; }

	// Methods

	// RVA: 0x3547D00 Offset: 0x3547E01 VA: 0x3547D00
	public static void set_maxViews(int value) { }

	// RVA: 0x3547D70 Offset: 0x3547E71 VA: 0x3547D70
	public static int get_slices() { }

	// RVA: 0x3547DE0 Offset: 0x3547EE1 VA: 0x3547DE0
	public static bool get_useTexArray() { }

	// RVA: 0x3547120 Offset: 0x3547221 VA: 0x3547120
	public static TextureDimension get_dimension() { }

	// RVA: 0x3547E40 Offset: 0x3547F41 VA: 0x3547E40
	public static RTHandle GetBlackUIntTexture() { }

	// RVA: 0x3547F30 Offset: 0x3548031 VA: 0x3547F30
	public static RTHandle GetClearTexture() { }

	// RVA: 0x3548020 Offset: 0x3548121 VA: 0x3548020
	public static RTHandle GetMagentaTexture() { }

	// RVA: 0x3548110 Offset: 0x3548211 VA: 0x3548110
	public static RTHandle GetBlackTexture() { }

	// RVA: 0x3548200 Offset: 0x3548301 VA: 0x3548200
	public static RTHandle GetBlackTextureArray() { }

	// RVA: 0x3548270 Offset: 0x3548371 VA: 0x3548270
	public static RTHandle GetBlackTexture3D() { }

	// RVA: 0x35482E0 Offset: 0x35483E1 VA: 0x35482E0
	public static RTHandle GetWhiteTexture() { }

	// RVA: 0x35483D0 Offset: 0x35484D1 VA: 0x35483D0
	public static void Initialize(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	// RVA: 0x3548F30 Offset: 0x3549031 VA: 0x3548F30
	private static Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D source, string name) { }

	// RVA: 0x3548A10 Offset: 0x3548B11 VA: 0x3548A10
	private static Texture CreateBlackUIntTextureArray(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	// RVA: 0x3548CA0 Offset: 0x3548DA1 VA: 0x3548CA0
	private static Texture CreateBlackUintTexture(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	// RVA: 0x3549170 Offset: 0x3549271 VA: 0x3549170
	private static Texture3D CreateBlackTexture3D(string name) { }

	// RVA: 0x3549230 Offset: 0x3549331 VA: 0x3549230
	private static void .cctor() { }
}

