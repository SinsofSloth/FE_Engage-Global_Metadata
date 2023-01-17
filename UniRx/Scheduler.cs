// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x12DC0 Offset: 0x12EC1 VA: 0x12DC0
public static class Scheduler // TypeDefIndex: 6626
{
	// Fields
	public static readonly IScheduler CurrentThread; // 0x0
	public static readonly IScheduler Immediate; // 0x8
	public static readonly IScheduler ThreadPool; // 0x10
	private static IScheduler mainThread; // 0x18
	private static IScheduler mainThreadIgnoreTimeScale; // 0x20
	private static IScheduler mainThreadFixedUpdate; // 0x28
	private static IScheduler mainThreadEndOfFrame; // 0x30

	// Properties
	public static bool IsCurrentThreadSchedulerScheduleRequired { get; }
	public static DateTimeOffset Now { get; }
	public static IScheduler MainThread { get; }
	public static IScheduler MainThreadIgnoreTimeScale { get; }
	public static IScheduler MainThreadFixedUpdate { get; }
	public static IScheduler MainThreadEndOfFrame { get; }

	// Methods

	// RVA: 0x1AF5880 Offset: 0x1AF5981 VA: 0x1AF5880
	public static bool get_IsCurrentThreadSchedulerScheduleRequired() { }

	// RVA: 0x1AF5940 Offset: 0x1AF5A41 VA: 0x1AF5940
	public static DateTimeOffset get_Now() { }

	// RVA: 0x1AF59B0 Offset: 0x1AF5AB1 VA: 0x1AF59B0
	public static TimeSpan Normalize(TimeSpan timeSpan) { }

	[ExtensionAttribute] // RVA: 0x15900 Offset: 0x15A01 VA: 0x15900
	// RVA: 0x1AF5A60 Offset: 0x1AF5B61 VA: 0x1AF5A60
	public static IDisposable Schedule(IScheduler scheduler, DateTimeOffset dueTime, Action action) { }

	[ExtensionAttribute] // RVA: 0x15910 Offset: 0x15A11 VA: 0x15910
	// RVA: 0x1AF5BD0 Offset: 0x1AF5CD1 VA: 0x1AF5BD0
	public static IDisposable Schedule(IScheduler scheduler, Action<Action> action) { }

	[ExtensionAttribute] // RVA: 0x15920 Offset: 0x15A21 VA: 0x15920
	// RVA: 0x1AF5E00 Offset: 0x1AF5F01 VA: 0x1AF5E00
	public static IDisposable Schedule(IScheduler scheduler, TimeSpan dueTime, Action<Action<TimeSpan>> action) { }

	[ExtensionAttribute] // RVA: 0x15930 Offset: 0x15A31 VA: 0x15930
	// RVA: 0x1AF6030 Offset: 0x1AF6131 VA: 0x1AF6030
	public static IDisposable Schedule(IScheduler scheduler, DateTimeOffset dueTime, Action<Action<DateTimeOffset>> action) { }

	// RVA: 0x1AF6230 Offset: 0x1AF6331 VA: 0x1AF6230
	public static void SetDefaultForUnity() { }

	// RVA: 0x1AF63F0 Offset: 0x1AF64F1 VA: 0x1AF63F0
	public static IScheduler get_MainThread() { }

	// RVA: 0x1AF65C0 Offset: 0x1AF66C1 VA: 0x1AF65C0
	public static IScheduler get_MainThreadIgnoreTimeScale() { }

	// RVA: 0x1AF6790 Offset: 0x1AF6891 VA: 0x1AF6790
	public static IScheduler get_MainThreadFixedUpdate() { }

	// RVA: 0x1AF6940 Offset: 0x1AF6A41 VA: 0x1AF6940
	public static IScheduler get_MainThreadEndOfFrame() { }

	// RVA: 0x1AF6AF0 Offset: 0x1AF6BF1 VA: 0x1AF6AF0
	private static void .cctor() { }
}

