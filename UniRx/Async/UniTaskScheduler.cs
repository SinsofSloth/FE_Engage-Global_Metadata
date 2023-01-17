// Namespace: UniRx.Async
public static class UniTaskScheduler // TypeDefIndex: 5136
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29CD0 Offset: 0x29DD1 VA: 0x29CD0
	private static Action<Exception> UnobservedTaskException; // 0x0
	public static bool PropagateOperationCanceledException; // 0x8
	public static LogType UnobservedExceptionWriteLogType; // 0xC
	public static bool DispatchUnityMainThread; // 0x10
	private static readonly SendOrPostCallback handleExceptionInvoke; // 0x18

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2DDA0 Offset: 0x2DEA1 VA: 0x2DDA0
	// RVA: 0x2E888F0 Offset: 0x2E889F1 VA: 0x2E888F0
	public static void add_UnobservedTaskException(Action<Exception> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2DDB0 Offset: 0x2DEB1 VA: 0x2DDB0
	// RVA: 0x2E889F0 Offset: 0x2E88AF1 VA: 0x2E889F0
	public static void remove_UnobservedTaskException(Action<Exception> value) { }

	// RVA: 0x2E7D280 Offset: 0x2E7D381 VA: 0x2E7D280
	internal static void PublishUnobservedTaskException(Exception ex) { }

	// RVA: 0x2E88AF0 Offset: 0x2E88BF1 VA: 0x2E88AF0
	private static void InvokeUnobservedTaskException(object state) { }

	// RVA: 0x2E88BE0 Offset: 0x2E88CE1 VA: 0x2E88BE0
	private static void .cctor() { }
}

