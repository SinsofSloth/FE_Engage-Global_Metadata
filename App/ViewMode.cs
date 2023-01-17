// Namespace: App
public class ViewMode // TypeDefIndex: 10382
{
	// Fields
	private static float s_Transition; // 0x0
	private static ViewMode.Mode s_Mode; // 0x4
	private static Stack<ViewMode.Mode> s_Stack; // 0x8
	private static SkinQuality s_BmapSkinQuality; // 0x10
	private static GameParam.Holder m_ModeThreshold; // 0x18

	// Properties
	public static float ModeThreshold { get; }

	// Methods

	// RVA: 0x26C3B50 Offset: 0x26C3C51 VA: 0x26C3B50
	public static float get_ModeThreshold() { }

	// RVA: 0x26C3BC0 Offset: 0x26C3CC1 VA: 0x26C3BC0
	public static ViewMode.Mode GetMode() { }

	// RVA: 0x26C3D10 Offset: 0x26C3E11 VA: 0x26C3D10
	public static SkinQuality GetBmapSkinQuality() { }

	// RVA: 0x26C3D80 Offset: 0x26C3E81 VA: 0x26C3D80
	private static float GetBmapAlpha() { }

	// RVA: 0x26C3F80 Offset: 0x26C4081 VA: 0x26C3F80
	public static bool IsBmapShowing() { }

	// RVA: 0x26C4270 Offset: 0x26C4371 VA: 0x26C4270
	public static float GetTransition() { }

	// RVA: 0x26C42E0 Offset: 0x26C43E1 VA: 0x26C42E0
	public static void SetMode(ViewMode.Mode mode) { }

	// RVA: 0x26C4360 Offset: 0x26C4461 VA: 0x26C4360
	public static void SetMode(Camera camera, ViewMode.Mode mode) { }

	// RVA: 0x26C5850 Offset: 0x26C5951 VA: 0x26C5850
	public static void PushMode(ViewMode.Mode mode) { }

	// RVA: 0x26C5A60 Offset: 0x26C5B61 VA: 0x26C5A60
	public static void PopMode() { }

	// RVA: 0x26C5B40 Offset: 0x26C5C41 VA: 0x26C5B40
	public static void SetTransition(float transition) { }

	// RVA: 0x26C5BC0 Offset: 0x26C5CC1 VA: 0x26C5BC0
	private static void SetLayerCullingMask(Camera camera, string name, bool enable) { }

	// RVA: 0x26C4450 Offset: 0x26C4551 VA: 0x26C4450
	public static void SetTransition(Camera camera, float transition) { }

	// RVA: 0x26C5CA0 Offset: 0x26C5DA1 VA: 0x26C5CA0
	public static void UpdateBoostMode(bool isBoost) { }

	// RVA: 0x26C5CB0 Offset: 0x26C5DB1 VA: 0x26C5CB0
	public void .ctor() { }

	// RVA: 0x26C5CC0 Offset: 0x26C5DC1 VA: 0x26C5CC0
	private static void .cctor() { }
}

