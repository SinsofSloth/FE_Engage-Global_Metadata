// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x43C2E0 Offset: 0x43C3E1 VA: 0x43C2E0
[NativeHeaderAttribute] // RVA: 0x43C2E0 Offset: 0x43C3E1 VA: 0x43C2E0
public class Display // TypeDefIndex: 3439
{
	// Fields
	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x442890 Offset: 0x442991 VA: 0x442890
	[CompilerGeneratedAttribute] // RVA: 0x442890 Offset: 0x442991 VA: 0x442890
	private static Display.DisplaysUpdatedDelegate onDisplaysUpdated; // 0x10

	// Properties
	public int renderingWidth { get; }
	public int renderingHeight { get; }
	public int systemWidth { get; }
	public int systemHeight { get; }
	public bool requiresSrgbBlitToBackbuffer { get; }
	public static Display main { get; }

	// Methods

	// RVA: 0x2F207E0 Offset: 0x2F208E1 VA: 0x2F207E0
	internal void .ctor() { }

	// RVA: 0x2F20820 Offset: 0x2F20921 VA: 0x2F20820
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x2F20850 Offset: 0x2F20951 VA: 0x2F20850
	public int get_renderingWidth() { }

	// RVA: 0x2F20960 Offset: 0x2F20A61 VA: 0x2F20960
	public int get_renderingHeight() { }

	// RVA: 0x2F20A10 Offset: 0x2F20B11 VA: 0x2F20A10
	public int get_systemWidth() { }

	// RVA: 0x2F20B20 Offset: 0x2F20C21 VA: 0x2F20B20
	public int get_systemHeight() { }

	// RVA: 0x2F20BD0 Offset: 0x2F20CD1 VA: 0x2F20BD0
	public bool get_requiresSrgbBlitToBackbuffer() { }

	// RVA: 0x2F20CC0 Offset: 0x2F20DC1 VA: 0x2F20CC0
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x2F20E30 Offset: 0x2F20F31 VA: 0x2F20E30
	public static Display get_main() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x447420 Offset: 0x447521 VA: 0x447420
	// RVA: 0x2F20EA0 Offset: 0x2F20FA1 VA: 0x2F20EA0
	private static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x447430 Offset: 0x447531 VA: 0x447430
	// RVA: 0x2F21070 Offset: 0x2F21171 VA: 0x2F21070
	private static void FireDisplaysUpdated() { }

	[FreeFunctionAttribute] // RVA: 0x447440 Offset: 0x447541 VA: 0x447440
	// RVA: 0x2F20AC0 Offset: 0x2F20BC1 VA: 0x2F20AC0
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x447480 Offset: 0x447581 VA: 0x447480
	// RVA: 0x2F20900 Offset: 0x2F20A01 VA: 0x2F20900
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x4474C0 Offset: 0x4475C1 VA: 0x4474C0
	// RVA: 0x2F20DC0 Offset: 0x2F20EC1 VA: 0x2F20DC0
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	[FreeFunctionAttribute] // RVA: 0x447500 Offset: 0x447601 VA: 0x447500
	// RVA: 0x2F20C70 Offset: 0x2F20D71 VA: 0x2F20C70
	private static bool RequiresSrgbBlitToBackbufferImpl(IntPtr nativeDisplay) { }

	// RVA: 0x2F21120 Offset: 0x2F21221 VA: 0x2F21120
	private static void .cctor() { }
}

