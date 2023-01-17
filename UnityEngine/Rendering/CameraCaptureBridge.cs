// Namespace: UnityEngine.Rendering
public static class CameraCaptureBridge // TypeDefIndex: 4620
{
	// Fields
	private static Dictionary<Camera, HashSet<Action<RenderTargetIdentifier, CommandBuffer>>> actionDict; // 0x0
	private static bool _enabled; // 0x8

	// Properties
	public static bool enabled { get; set; }

	// Methods

	// RVA: 0x1B2A6F0 Offset: 0x1B2A7F1 VA: 0x1B2A6F0
	private static void .cctor() { }

	// RVA: 0x1B2A790 Offset: 0x1B2A891 VA: 0x1B2A790
	public static bool get_enabled() { }

	// RVA: 0x1B2A800 Offset: 0x1B2A901 VA: 0x1B2A800
	public static void set_enabled(bool value) { }

	// RVA: 0x1B2A880 Offset: 0x1B2A981 VA: 0x1B2A880
	public static IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> GetCaptureActions(Camera camera) { }

	// RVA: 0x1B2A980 Offset: 0x1B2AA81 VA: 0x1B2A980
	public static void AddCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action) { }

	// RVA: 0x1B2AAE0 Offset: 0x1B2ABE1 VA: 0x1B2AAE0
	public static void RemoveCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action) { }
}

