// Namespace: App
public class GameTime // TypeDefIndex: 9201
{
	// Fields
	private static readonly float DefaultFixedDeltaTime; // 0x0
	private static float[] LocalTimeScale; // 0x8
	private static Stack<int> s_VsyncStack; // 0x10
	private const int Version = 0;
	private static int s_PlayTime; // 0x18
	private static int s_WatchTime; // 0x1C
	private const int MaxTime = 1843199744;
	private const int TimeUnit = 512;
	private const float TimeInv = 0.001953125;
	public const float MaxTimeFloat = 3599999.5;
	[CompilerGeneratedAttribute] // RVA: 0x286D70 Offset: 0x286E71 VA: 0x286D70
	private static bool <IsWatching>k__BackingField; // 0x20

	// Properties
	public static float Time { get; }
	public static float UnscaledTime { get; }
	public static double RealTime { get; }
	public static float DeltaTime { get; }
	public static float UnscaledDeltaTime { get; }
	public static int FrameCount { get; }
	public static float TimeScale { get; }
	public static int VsyncDeltaCount { get; }
	public static float VsyncDeltaTime { get; }
	public static int VsyncFixedCount { get; }
	public static float VsyncFixedTime { get; }
	public static float PlayTime { get; set; }
	public static float WatchTime { get; set; }
	private static bool IsWatching { get; set; }

	// Methods

	// RVA: 0x28CC4B0 Offset: 0x28CC5B1 VA: 0x28CC4B0
	public static float get_Time() { }

	// RVA: 0x28CC4C0 Offset: 0x28CC5C1 VA: 0x28CC4C0
	public static float get_UnscaledTime() { }

	// RVA: 0x28CC4D0 Offset: 0x28CC5D1 VA: 0x28CC4D0
	public static double get_RealTime() { }

	// RVA: 0x28CC4E0 Offset: 0x28CC5E1 VA: 0x28CC4E0
	public static float get_DeltaTime() { }

	// RVA: 0x28CC4F0 Offset: 0x28CC5F1 VA: 0x28CC4F0
	public static float get_UnscaledDeltaTime() { }

	// RVA: 0x28CC530 Offset: 0x28CC631 VA: 0x28CC530
	public static int get_FrameCount() { }

	// RVA: 0x28CC540 Offset: 0x28CC641 VA: 0x28CC540
	public static float get_TimeScale() { }

	// RVA: 0x28CC550 Offset: 0x28CC651 VA: 0x28CC550
	public static void Initialize() { }

	// RVA: 0x28CC710 Offset: 0x28CC811 VA: 0x28CC710
	public static float SetTimeScale(GameTime.Ch ch, float scale) { }

	// RVA: 0x28CC960 Offset: 0x28CCA61 VA: 0x28CC960
	public static float GetTimeScale(GameTime.Ch ch) { }

	// RVA: 0x28CC7C0 Offset: 0x28CC8C1 VA: 0x28CC7C0
	private static void UpdateTimeScale() { }

	// RVA: 0x28CC9F0 Offset: 0x28CCAF1 VA: 0x28CC9F0
	public static void PushVsyncCount(GameTime.VsycMode mode) { }

	// RVA: 0x28CCBB0 Offset: 0x28CCCB1 VA: 0x28CCBB0
	public static void PopVsyncCount() { }

	// RVA: 0x28CCA90 Offset: 0x28CCB91 VA: 0x28CCA90
	public static void SetVsyncCount(GameTime.VsycMode mode) { }

	// RVA: 0x28CCC30 Offset: 0x28CCD31 VA: 0x28CCC30
	public static void SetVsyncCount(int count) { }

	// RVA: 0x28CCD40 Offset: 0x28CCE41 VA: 0x28CCD40
	public static int get_VsyncDeltaCount() { }

	// RVA: 0x28CCD90 Offset: 0x28CCE91 VA: 0x28CCD90
	public static float get_VsyncDeltaTime() { }

	// RVA: 0x28CCE40 Offset: 0x28CCF41 VA: 0x28CCE40
	public static int get_VsyncFixedCount() { }

	// RVA: 0x28CCE50 Offset: 0x28CCF51 VA: 0x28CCE50
	public static float get_VsyncFixedTime() { }

	// RVA: 0x28CCED0 Offset: 0x28CCFD1 VA: 0x28CCED0
	public static float GetTimeRatio(float time) { }

	// RVA: 0x28CCF50 Offset: 0x28CD051 VA: 0x28CCF50
	public static float get_PlayTime() { }

	// RVA: 0x28CCFD0 Offset: 0x28CD0D1 VA: 0x28CCFD0
	public static void set_PlayTime(float value) { }

	// RVA: 0x28CD070 Offset: 0x28CD171 VA: 0x28CD070
	public static float get_WatchTime() { }

	// RVA: 0x28CD0F0 Offset: 0x28CD1F1 VA: 0x28CD0F0
	public static void set_WatchTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE730 Offset: 0x2AE831 VA: 0x2AE730
	// RVA: 0x28CD190 Offset: 0x28CD291 VA: 0x28CD190
	private static bool get_IsWatching() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE740 Offset: 0x2AE841 VA: 0x2AE740
	// RVA: 0x28CD200 Offset: 0x28CD301 VA: 0x28CD200
	private static void set_IsWatching(bool value) { }

	// RVA: 0x28CD280 Offset: 0x28CD381 VA: 0x28CD280
	public static void WatchStart() { }

	// RVA: 0x28CD350 Offset: 0x28CD451 VA: 0x28CD350
	public static void WatchStop() { }

	// RVA: 0x28CD410 Offset: 0x28CD511 VA: 0x28CD410
	public static void WatchReset() { }

	// RVA: 0x28CD480 Offset: 0x28CD581 VA: 0x28CD480
	public static int ToHour(float time) { }

	// RVA: 0x28CD4B0 Offset: 0x28CD5B1 VA: 0x28CD4B0
	public static int ToMinute(float time) { }

	// RVA: 0x28CD510 Offset: 0x28CD611 VA: 0x28CD510
	public static int ToSecond(float time) { }

	// RVA: 0x28CD560 Offset: 0x28CD661 VA: 0x28CD560
	public static string ToDebug(float time) { }

	// RVA: 0x28CD700 Offset: 0x28CD801 VA: 0x28CD700
	public static void Reset() { }

	// RVA: 0x28CD770 Offset: 0x28CD871 VA: 0x28CD770
	public static void Update() { }

	// RVA: 0x28CD910 Offset: 0x28CDA11 VA: 0x28CD910
	public static void Serialize(Stream stream) { }

	// RVA: 0x28CDA60 Offset: 0x28CDB61 VA: 0x28CDA60
	public static void Deserialize(Stream stream) { }

	// RVA: 0x28CDCE0 Offset: 0x28CDDE1 VA: 0x28CDCE0
	public void .ctor() { }

	// RVA: 0x28CDCF0 Offset: 0x28CDDF1 VA: 0x28CDCF0
	private static void .cctor() { }
}

