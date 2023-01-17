// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43C440 Offset: 0x43C541 VA: 0x43C440
[NativeHeaderAttribute] // RVA: 0x43C440 Offset: 0x43C541 VA: 0x43C440
[NativeHeaderAttribute] // RVA: 0x43C440 Offset: 0x43C541 VA: 0x43C440
[NativeHeaderAttribute] // RVA: 0x43C440 Offset: 0x43C541 VA: 0x43C440
[NativeHeaderAttribute] // RVA: 0x43C440 Offset: 0x43C541 VA: 0x43C440
[NativeHeaderAttribute] // RVA: 0x43C440 Offset: 0x43C541 VA: 0x43C440
public class Graphics // TypeDefIndex: 3444
{
	// Fields
	internal static readonly int kMaxDrawMeshInstanceCount; // 0x0

	// Properties
	[StaticAccessorAttribute] // RVA: 0x459640 Offset: 0x459741 VA: 0x459640
	public static GraphicsTier activeTier { get; set; }
	public static bool preserveFramebufferAlpha { get; }
	public static OpenGLESVersion minOpenGLESVersion { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x447660 Offset: 0x447761 VA: 0x447660
	// RVA: 0x2F245A0 Offset: 0x2F246A1 VA: 0x2F245A0
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	// RVA: 0x2F245E0 Offset: 0x2F246E1 VA: 0x2F245E0
	public static GraphicsTier get_activeTier() { }

	// RVA: 0x2F24620 Offset: 0x2F24721 VA: 0x2F24620
	public static void set_activeTier(GraphicsTier value) { }

	[StaticAccessorAttribute] // RVA: 0x4476A0 Offset: 0x4477A1 VA: 0x4476A0
	[NativeMethodAttribute] // RVA: 0x4476A0 Offset: 0x4477A1 VA: 0x4476A0
	// RVA: 0x2F24670 Offset: 0x2F24771 VA: 0x2F24670
	internal static bool GetPreserveFramebufferAlpha() { }

	// RVA: 0x2F246B0 Offset: 0x2F247B1 VA: 0x2F246B0
	public static bool get_preserveFramebufferAlpha() { }

	[NativeMethodAttribute] // RVA: 0x447710 Offset: 0x447811 VA: 0x447710
	[StaticAccessorAttribute] // RVA: 0x447710 Offset: 0x447811 VA: 0x447710
	// RVA: 0x2F24740 Offset: 0x2F24841 VA: 0x2F24740
	internal static OpenGLESVersion GetMinOpenGLESVersion() { }

	// RVA: 0x2F24780 Offset: 0x2F24881 VA: 0x2F24780
	public static OpenGLESVersion get_minOpenGLESVersion() { }

	[FreeFunctionAttribute] // RVA: 0x447780 Offset: 0x447881 VA: 0x447780
	// RVA: 0x2F24810 Offset: 0x2F24911 VA: 0x2F24810
	private static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	[FreeFunctionAttribute] // RVA: 0x4477C0 Offset: 0x4478C1 VA: 0x4477C0
	[VisibleToOtherModulesAttribute] // RVA: 0x4477C0 Offset: 0x4478C1 VA: 0x4477C0
	// RVA: 0x2F24890 Offset: 0x2F24991 VA: 0x2F24890
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	// RVA: 0x2F248E0 Offset: 0x2F249E1 VA: 0x2F248E0
	public static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	// RVA: 0x2F249B0 Offset: 0x2F24AB1 VA: 0x2F249B0
	private static void .cctor() { }
}

