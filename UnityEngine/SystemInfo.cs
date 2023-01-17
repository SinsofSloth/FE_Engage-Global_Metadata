// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43EE00 Offset: 0x43EF01 VA: 0x43EE00
[NativeHeaderAttribute] // RVA: 0x43EE00 Offset: 0x43EF01 VA: 0x43EE00
[NativeHeaderAttribute] // RVA: 0x43EE00 Offset: 0x43EF01 VA: 0x43EE00
[NativeHeaderAttribute] // RVA: 0x43EE00 Offset: 0x43EF01 VA: 0x43EE00
[NativeHeaderAttribute] // RVA: 0x43EE00 Offset: 0x43EF01 VA: 0x43EE00
[NativeHeaderAttribute] // RVA: 0x43EE00 Offset: 0x43EF01 VA: 0x43EE00
public sealed class SystemInfo // TypeDefIndex: 3636
{
	// Properties
	public static OperatingSystemFamily operatingSystemFamily { get; }
	public static string processorType { get; }
	public static DeviceType deviceType { get; }
	public static string graphicsDeviceVendor { get; }
	public static GraphicsDeviceType graphicsDeviceType { get; }
	public static bool graphicsUVStartsAtTop { get; }
	public static int graphicsShaderLevel { get; }
	public static bool hasHiddenSurfaceRemovalOnGPU { get; }
	public static bool supportsShadows { get; }
	public static CopyTextureSupport copyTextureSupport { get; }
	public static bool supportsRenderTargetArrayIndexFromVertexShader { get; }
	public static int supportedRenderTargetCount { get; }
	public static int supportsMultisampledTextures { get; }
	public static bool supportsMultisampleAutoResolve { get; }
	public static bool usesReversedZBuffer { get; }
	public static bool supportsGraphicsFence { get; }
	public static bool supportsMultiview { get; }

	// Methods

	// RVA: 0x383F480 Offset: 0x383F581 VA: 0x383F480
	public static OperatingSystemFamily get_operatingSystemFamily() { }

	// RVA: 0x383F500 Offset: 0x383F601 VA: 0x383F500
	public static string get_processorType() { }

	// RVA: 0x383F580 Offset: 0x383F681 VA: 0x383F580
	public static DeviceType get_deviceType() { }

	// RVA: 0x383F600 Offset: 0x383F701 VA: 0x383F600
	public static string get_graphicsDeviceVendor() { }

	// RVA: 0x383F680 Offset: 0x383F781 VA: 0x383F680
	public static GraphicsDeviceType get_graphicsDeviceType() { }

	// RVA: 0x383F700 Offset: 0x383F801 VA: 0x383F700
	public static bool get_graphicsUVStartsAtTop() { }

	// RVA: 0x383F780 Offset: 0x383F881 VA: 0x383F780
	public static int get_graphicsShaderLevel() { }

	// RVA: 0x383F800 Offset: 0x383F901 VA: 0x383F800
	public static bool get_hasHiddenSurfaceRemovalOnGPU() { }

	// RVA: 0x383F880 Offset: 0x383F981 VA: 0x383F880
	public static bool get_supportsShadows() { }

	// RVA: 0x383F900 Offset: 0x383FA01 VA: 0x383F900
	public static CopyTextureSupport get_copyTextureSupport() { }

	// RVA: 0x383F980 Offset: 0x383FA81 VA: 0x383F980
	public static bool get_supportsRenderTargetArrayIndexFromVertexShader() { }

	// RVA: 0x383FA00 Offset: 0x383FB01 VA: 0x383FA00
	public static int get_supportedRenderTargetCount() { }

	// RVA: 0x383FA80 Offset: 0x383FB81 VA: 0x383FA80
	public static int get_supportsMultisampledTextures() { }

	// RVA: 0x383FB00 Offset: 0x383FC01 VA: 0x383FB00
	public static bool get_supportsMultisampleAutoResolve() { }

	// RVA: 0x383FB80 Offset: 0x383FC81 VA: 0x383FB80
	public static bool get_usesReversedZBuffer() { }

	// RVA: 0x383FC00 Offset: 0x383FD01 VA: 0x383FC00
	private static bool IsValidEnumValue(Enum value) { }

	// RVA: 0x383FC80 Offset: 0x383FD81 VA: 0x383FC80
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x383FE10 Offset: 0x383FF11 VA: 0x383FE10
	public static bool SupportsTextureFormat(TextureFormat format) { }

	// RVA: 0x383FFA0 Offset: 0x38400A1 VA: 0x383FFA0
	public static bool get_supportsGraphicsFence() { }

	// RVA: 0x3840020 Offset: 0x3840121 VA: 0x3840020
	public static bool get_supportsMultiview() { }

	[FreeFunctionAttribute] // RVA: 0x450D30 Offset: 0x450E31 VA: 0x450D30
	// RVA: 0x383F4C0 Offset: 0x383F5C1 VA: 0x383F4C0
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunctionAttribute] // RVA: 0x450D70 Offset: 0x450E71 VA: 0x450D70
	// RVA: 0x383F540 Offset: 0x383F641 VA: 0x383F540
	private static string GetProcessorType() { }

	[FreeFunctionAttribute] // RVA: 0x450DB0 Offset: 0x450EB1 VA: 0x450DB0
	// RVA: 0x383F5C0 Offset: 0x383F6C1 VA: 0x383F5C0
	private static DeviceType GetDeviceType() { }

	[FreeFunctionAttribute] // RVA: 0x450DF0 Offset: 0x450EF1 VA: 0x450DF0
	// RVA: 0x383F640 Offset: 0x383F741 VA: 0x383F640
	private static string GetGraphicsDeviceVendor() { }

	[FreeFunctionAttribute] // RVA: 0x450E30 Offset: 0x450F31 VA: 0x450E30
	// RVA: 0x383F6C0 Offset: 0x383F7C1 VA: 0x383F6C0
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[FreeFunctionAttribute] // RVA: 0x450E70 Offset: 0x450F71 VA: 0x450E70
	// RVA: 0x383F740 Offset: 0x383F841 VA: 0x383F740
	private static bool GetGraphicsUVStartsAtTop() { }

	[FreeFunctionAttribute] // RVA: 0x450EB0 Offset: 0x450FB1 VA: 0x450EB0
	// RVA: 0x383F7C0 Offset: 0x383F8C1 VA: 0x383F7C0
	private static int GetGraphicsShaderLevel() { }

	[FreeFunctionAttribute] // RVA: 0x450EF0 Offset: 0x450FF1 VA: 0x450EF0
	// RVA: 0x383F840 Offset: 0x383F941 VA: 0x383F840
	private static bool HasHiddenSurfaceRemovalOnGPU() { }

	[FreeFunctionAttribute] // RVA: 0x450F30 Offset: 0x451031 VA: 0x450F30
	// RVA: 0x383F8C0 Offset: 0x383F9C1 VA: 0x383F8C0
	private static bool SupportsShadows() { }

	[FreeFunctionAttribute] // RVA: 0x450F70 Offset: 0x451071 VA: 0x450F70
	// RVA: 0x383F940 Offset: 0x383FA41 VA: 0x383F940
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[FreeFunctionAttribute] // RVA: 0x450FB0 Offset: 0x4510B1 VA: 0x450FB0
	// RVA: 0x383F9C0 Offset: 0x383FAC1 VA: 0x383F9C0
	private static bool SupportsRenderTargetArrayIndexFromVertexShader() { }

	[FreeFunctionAttribute] // RVA: 0x450FF0 Offset: 0x4510F1 VA: 0x450FF0
	// RVA: 0x383FA40 Offset: 0x383FB41 VA: 0x383FA40
	private static int SupportedRenderTargetCount() { }

	[FreeFunctionAttribute] // RVA: 0x451030 Offset: 0x451131 VA: 0x451030
	// RVA: 0x383FAC0 Offset: 0x383FBC1 VA: 0x383FAC0
	private static int SupportsMultisampledTextures() { }

	[FreeFunctionAttribute] // RVA: 0x451070 Offset: 0x451171 VA: 0x451070
	// RVA: 0x383FB40 Offset: 0x383FC41 VA: 0x383FB40
	private static bool SupportsMultisampleAutoResolve() { }

	[FreeFunctionAttribute] // RVA: 0x4510B0 Offset: 0x4511B1 VA: 0x4510B0
	// RVA: 0x383FBC0 Offset: 0x383FCC1 VA: 0x383FBC0
	private static bool UsesReversedZBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x4510F0 Offset: 0x4511F1 VA: 0x4510F0
	// RVA: 0x383FDC0 Offset: 0x383FEC1 VA: 0x383FDC0
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x451130 Offset: 0x451231 VA: 0x451130
	// RVA: 0x383FF50 Offset: 0x3840051 VA: 0x383FF50
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x451170 Offset: 0x451271 VA: 0x451170
	// RVA: 0x383FFE0 Offset: 0x38400E1 VA: 0x383FFE0
	private static bool SupportsGPUFence() { }

	[FreeFunctionAttribute] // RVA: 0x4511B0 Offset: 0x4512B1 VA: 0x4511B0
	// RVA: 0x38400A0 Offset: 0x38401A1 VA: 0x38400A0
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] // RVA: 0x4511F0 Offset: 0x4512F1 VA: 0x4511F0
	// RVA: 0x38400F0 Offset: 0x38401F1 VA: 0x38400F0
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunctionAttribute] // RVA: 0x451230 Offset: 0x451331 VA: 0x451230
	// RVA: 0x3840140 Offset: 0x3840241 VA: 0x3840140
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x451270 Offset: 0x451371 VA: 0x451270
	// RVA: 0x3840190 Offset: 0x3840291 VA: 0x3840190
	public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0x4512B0 Offset: 0x4513B1 VA: 0x4512B0
	// RVA: 0x3840060 Offset: 0x3840161 VA: 0x3840060
	private static bool SupportsMultiview() { }

	// RVA: 0x38401E0 Offset: 0x38402E1 VA: 0x38401E0
	private static int GetRenderTextureSupportedMSAASampleCount_Injected(ref RenderTextureDescriptor desc) { }
}

