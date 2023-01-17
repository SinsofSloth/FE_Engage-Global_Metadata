// Namespace: UnityEngine.Experimental.Rendering
[NativeHeaderAttribute] // RVA: 0x4418D0 Offset: 0x4419D1 VA: 0x4418D0
[NativeHeaderAttribute] // RVA: 0x4418D0 Offset: 0x4419D1 VA: 0x4418D0
[NativeHeaderAttribute] // RVA: 0x4418D0 Offset: 0x4419D1 VA: 0x4418D0
public class GraphicsFormatUtility // TypeDefIndex: 4033
{
	// Methods

	[FreeFunctionAttribute] // RVA: 0x4559E0 Offset: 0x455AE1 VA: 0x4559E0
	// RVA: 0x2F24A80 Offset: 0x2F24B81 VA: 0x2F24A80
	internal static GraphicsFormat GetFormat(Texture texture) { }

	// RVA: 0x2F1CBB0 Offset: 0x2F1CCB1 VA: 0x2F1CBB0
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x4559F0 Offset: 0x455AF1 VA: 0x4559F0
	// RVA: 0x2F24AD0 Offset: 0x2F24BD1 VA: 0x2F24AD0
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x2F24B20 Offset: 0x2F24C21 VA: 0x2F24B20
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0x455A30 Offset: 0x455B31 VA: 0x455A30
	// RVA: 0x2F24B70 Offset: 0x2F24C71 VA: 0x2F24B70
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x2F16EE0 Offset: 0x2F16FE1 VA: 0x2F16EE0
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunctionAttribute] // RVA: 0x455A40 Offset: 0x455B41 VA: 0x455A40
	// RVA: 0x2F24BC0 Offset: 0x2F24CC1 VA: 0x2F24BC0
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x455A80 Offset: 0x455B81 VA: 0x455A80
	// RVA: 0x2F24C10 Offset: 0x2F24D11 VA: 0x2F24C10
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x455AC0 Offset: 0x455BC1 VA: 0x455AC0
	// RVA: 0x2F24C60 Offset: 0x2F24D61 VA: 0x2F24C60
	internal static bool IsCompressedTextureFormat(TextureFormat format) { }

	// RVA: 0x2F1CC00 Offset: 0x2F1CD01 VA: 0x2F1CC00
	public static bool IsCrunchFormat(TextureFormat format) { }
}

