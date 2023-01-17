// Namespace: UnityEngine.XR
[NativeHeaderAttribute] // RVA: 0x75FB0 Offset: 0x760B1 VA: 0x75FB0
[NativeHeaderAttribute] // RVA: 0x75FB0 Offset: 0x760B1 VA: 0x75FB0
[NativeHeaderAttribute] // RVA: 0x75FB0 Offset: 0x760B1 VA: 0x75FB0
[NativeHeaderAttribute] // RVA: 0x75FB0 Offset: 0x760B1 VA: 0x75FB0
[NativeConditionalAttribute] // RVA: 0x75FB0 Offset: 0x760B1 VA: 0x75FB0
public static class XRSettings // TypeDefIndex: 4452
{
	// Properties
	public static bool enabled { get; }
	[StaticAccessorAttribute] // RVA: 0x76150 Offset: 0x76251 VA: 0x76150
	[NativeNameAttribute] // RVA: 0x76150 Offset: 0x76251 VA: 0x76150
	public static bool isDeviceActive { get; }
	[NativeNameAttribute] // RVA: 0x761C0 Offset: 0x762C1 VA: 0x761C0
	[StaticAccessorAttribute] // RVA: 0x761C0 Offset: 0x762C1 VA: 0x761C0
	public static float eyeTextureResolutionScale { get; set; }
	[StaticAccessorAttribute] // RVA: 0x76230 Offset: 0x76331 VA: 0x76230
	public static int eyeTextureWidth { get; }
	[StaticAccessorAttribute] // RVA: 0x76270 Offset: 0x76371 VA: 0x76270
	public static int eyeTextureHeight { get; }
	[NativeNameAttribute] // RVA: 0x762B0 Offset: 0x763B1 VA: 0x762B0
	[StaticAccessorAttribute] // RVA: 0x762B0 Offset: 0x763B1 VA: 0x762B0
	[NativeConditionalAttribute] // RVA: 0x762B0 Offset: 0x763B1 VA: 0x762B0
	public static RenderTextureDescriptor eyeTextureDesc { get; }
	public static float renderViewportScale { get; }
	[StaticAccessorAttribute] // RVA: 0x76350 Offset: 0x76451 VA: 0x76350
	[NativeNameAttribute] // RVA: 0x76350 Offset: 0x76451 VA: 0x76350
	internal static float renderViewportScaleInternal { get; }
	[StaticAccessorAttribute] // RVA: 0x763C0 Offset: 0x764C1 VA: 0x763C0
	[NativeNameAttribute] // RVA: 0x763C0 Offset: 0x764C1 VA: 0x763C0
	public static string loadedDeviceName { get; }
	public static string[] supportedDevices { get; }
	[StaticAccessorAttribute] // RVA: 0x76430 Offset: 0x76531 VA: 0x76430
	public static XRSettings.StereoRenderingMode stereoRenderingMode { get; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0x76100 Offset: 0x76201 VA: 0x76100
	// RVA: 0x1C6DA50 Offset: 0x1C6DB51 VA: 0x1C6DA50
	public static bool get_enabled() { }

	// RVA: 0x1C6DA90 Offset: 0x1C6DB91 VA: 0x1C6DA90
	public static bool get_isDeviceActive() { }

	// RVA: 0x1C6DAD0 Offset: 0x1C6DBD1 VA: 0x1C6DAD0
	public static float get_eyeTextureResolutionScale() { }

	// RVA: 0x1C6DB10 Offset: 0x1C6DC11 VA: 0x1C6DB10
	public static void set_eyeTextureResolutionScale(float value) { }

	// RVA: 0x1C6DB60 Offset: 0x1C6DC61 VA: 0x1C6DB60
	public static int get_eyeTextureWidth() { }

	// RVA: 0x1C6DBA0 Offset: 0x1C6DCA1 VA: 0x1C6DBA0
	public static int get_eyeTextureHeight() { }

	// RVA: 0x1C6DBE0 Offset: 0x1C6DCE1 VA: 0x1C6DBE0
	public static RenderTextureDescriptor get_eyeTextureDesc() { }

	// RVA: 0x1C6DCB0 Offset: 0x1C6DDB1 VA: 0x1C6DCB0
	public static float get_renderViewportScale() { }

	// RVA: 0x1C6DCF0 Offset: 0x1C6DDF1 VA: 0x1C6DCF0
	internal static float get_renderViewportScaleInternal() { }

	// RVA: 0x1C6DD30 Offset: 0x1C6DE31 VA: 0x1C6DD30
	public static string get_loadedDeviceName() { }

	// RVA: 0x1C6DD70 Offset: 0x1C6DE71 VA: 0x1C6DD70
	public static string[] get_supportedDevices() { }

	// RVA: 0x1C6DDB0 Offset: 0x1C6DEB1 VA: 0x1C6DDB0
	public static XRSettings.StereoRenderingMode get_stereoRenderingMode() { }

	// RVA: 0x1C6DC60 Offset: 0x1C6DD61 VA: 0x1C6DC60
	private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret) { }
}

