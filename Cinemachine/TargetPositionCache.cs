// Namespace: Cinemachine
internal class TargetPositionCache // TypeDefIndex: 5866
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x22200 Offset: 0x22301 VA: 0x22200
	private static bool <UseCache>k__BackingField; // 0x0
	public const float CacheStepSize = 0.016666668;
	private static TargetPositionCache.Mode m_CacheMode; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x22210 Offset: 0x22311 VA: 0x22210
	private static float <CurrentTime>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x22220 Offset: 0x22321 VA: 0x22220
	private static int <CurrentFrame>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x22230 Offset: 0x22331 VA: 0x22230
	private static bool <IsCameraCut>k__BackingField; // 0x10
	private static Dictionary<Transform, TargetPositionCache.CacheEntry> m_Cache; // 0x18
	private static TargetPositionCache.TimeRange m_CacheTimeRange; // 0x20
	private const float kWraparoundSlush = 0.1;

	// Properties
	public static bool UseCache { get; set; }
	public static TargetPositionCache.Mode CacheMode { get; set; }
	public static bool IsRecording { get; }
	public static bool CurrentPlaybackTimeValid { get; }
	public static bool IsEmpty { get; }
	public static float CurrentTime { get; set; }
	public static int CurrentFrame { get; set; }
	public static bool IsCameraCut { get; set; }
	public static TargetPositionCache.TimeRange CacheTimeRange { get; }
	public static bool HasHurrentTime { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x23FE0 Offset: 0x240E1 VA: 0x23FE0
	// RVA: 0x1A850D0 Offset: 0x1A851D1 VA: 0x1A850D0
	public static bool get_UseCache() { }

	[CompilerGeneratedAttribute] // RVA: 0x23FF0 Offset: 0x240F1 VA: 0x23FF0
	// RVA: 0x1A85140 Offset: 0x1A85241 VA: 0x1A85140
	public static void set_UseCache(bool value) { }

	// RVA: 0x1A851C0 Offset: 0x1A852C1 VA: 0x1A851C0
	public static TargetPositionCache.Mode get_CacheMode() { }

	// RVA: 0x1A85230 Offset: 0x1A85331 VA: 0x1A85230
	public static void set_CacheMode(TargetPositionCache.Mode value) { }

	// RVA: 0x1A85770 Offset: 0x1A85871 VA: 0x1A85770
	public static bool get_IsRecording() { }

	// RVA: 0x1A85880 Offset: 0x1A85981 VA: 0x1A85880
	public static bool get_CurrentPlaybackTimeValid() { }

	// RVA: 0x1A85A90 Offset: 0x1A85B91 VA: 0x1A85A90
	public static bool get_IsEmpty() { }

	[CompilerGeneratedAttribute] // RVA: 0x24000 Offset: 0x24101 VA: 0x24000
	// RVA: 0x1A85B70 Offset: 0x1A85C71 VA: 0x1A85B70
	public static float get_CurrentTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x24010 Offset: 0x24111 VA: 0x24010
	// RVA: 0x1A85BE0 Offset: 0x1A85CE1 VA: 0x1A85BE0
	public static void set_CurrentTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x24020 Offset: 0x24121 VA: 0x24020
	// RVA: 0x1A85C50 Offset: 0x1A85D51 VA: 0x1A85C50
	public static int get_CurrentFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x24030 Offset: 0x24131 VA: 0x24030
	// RVA: 0x1A85CC0 Offset: 0x1A85DC1 VA: 0x1A85CC0
	public static void set_CurrentFrame(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x24040 Offset: 0x24141 VA: 0x24040
	// RVA: 0x1A85D30 Offset: 0x1A85E31 VA: 0x1A85D30
	public static bool get_IsCameraCut() { }

	[CompilerGeneratedAttribute] // RVA: 0x24050 Offset: 0x24151 VA: 0x24050
	// RVA: 0x1A85DA0 Offset: 0x1A85EA1 VA: 0x1A85DA0
	public static void set_IsCameraCut(bool value) { }

	// RVA: 0x1A85E20 Offset: 0x1A85F21 VA: 0x1A85E20
	public static TargetPositionCache.TimeRange get_CacheTimeRange() { }

	// RVA: 0x1A859C0 Offset: 0x1A85AC1 VA: 0x1A859C0
	public static bool get_HasHurrentTime() { }

	// RVA: 0x1A85370 Offset: 0x1A85471 VA: 0x1A85370
	public static void ClearCache() { }

	// RVA: 0x1A855D0 Offset: 0x1A856D1 VA: 0x1A855D0
	private static void CreatePlaybackCurves() { }

	// RVA: 0x1A75350 Offset: 0x1A75451 VA: 0x1A75350
	public static Vector3 GetTargetPosition(Transform target) { }

	// RVA: 0x1A761A0 Offset: 0x1A762A1 VA: 0x1A761A0
	public static Quaternion GetTargetRotation(Transform target) { }

	// RVA: 0x1A86640 Offset: 0x1A86741 VA: 0x1A86640
	public void .ctor() { }

	// RVA: 0x1A86650 Offset: 0x1A86751 VA: 0x1A86650
	private static void .cctor() { }
}

