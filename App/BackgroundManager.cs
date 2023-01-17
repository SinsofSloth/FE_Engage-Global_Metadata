// Namespace: App
internal class BackgroundManager // TypeDefIndex: 10370
{
	// Fields
	private static BindHolder s_Binder; // 0x0
	private static Camera s_Camera; // 0x8
	private static bool s_IsCaptured; // 0x10
	private static int s_CaptureCount; // 0x14

	// Methods

	// RVA: 0x2613350 Offset: 0x2613451 VA: 0x2613350
	private static void SetCamera(Camera camera, bool enable) { }

	// RVA: 0x2613440 Offset: 0x2613541 VA: 0x2613440
	private static void SetCapture(Camera camera, bool enable) { }

	// RVA: 0x2613560 Offset: 0x2613661 VA: 0x2613560
	private static void SetWallPaper(bool enable) { }

	// RVA: 0x26137E0 Offset: 0x26138E1 VA: 0x26137E0
	private static void SetBlur(bool enable) { }

	// RVA: 0x26138E0 Offset: 0x26139E1 VA: 0x26138E0
	private static void SetCapture(bool enable) { }

	// RVA: 0x2613A80 Offset: 0x2613B81 VA: 0x2613A80
	private static int GetBackground() { }

	// RVA: 0x2613AD0 Offset: 0x2613BD1 VA: 0x2613AD0
	public static void Bind(BackgroundManager.BindType type) { }

	// RVA: 0x2613CD0 Offset: 0x2613DD1 VA: 0x2613CD0
	public static void Bind() { }

	// RVA: 0x2613D40 Offset: 0x2613E41 VA: 0x2613D40
	public static void Update() { }

	// RVA: 0x2613E50 Offset: 0x2613F51 VA: 0x2613E50
	public static void Unbind() { }

	// RVA: 0x2614200 Offset: 0x2614301 VA: 0x2614200
	public static bool IsBind() { }

	// RVA: 0x2614270 Offset: 0x2614371 VA: 0x2614270
	public static bool IsCaptured() { }

	// RVA: 0x26142E0 Offset: 0x26143E1 VA: 0x26142E0
	public void .ctor() { }

	// RVA: 0x26142F0 Offset: 0x26143F1 VA: 0x26142F0
	private static void .cctor() { }
}

