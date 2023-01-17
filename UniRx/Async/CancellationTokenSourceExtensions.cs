// Namespace: UniRx.Async
[ExtensionAttribute] // RVA: 0x27900 Offset: 0x27A01 VA: 0x27900
public static class CancellationTokenSourceExtensions // TypeDefIndex: 4911
{
	// Methods

	[ExtensionAttribute] // RVA: 0x29EB0 Offset: 0x29FB1 VA: 0x29EB0
	// RVA: 0x2E7F240 Offset: 0x2E7F341 VA: 0x2E7F240
	public static void CancelAfterSlim(CancellationTokenSource cts, int millisecondsDelay, bool ignoreTimeScale = False, PlayerLoopTiming delayTiming = 4) { }

	[ExtensionAttribute] // RVA: 0x29EC0 Offset: 0x29FC1 VA: 0x29EC0
	// RVA: 0x2E7F600 Offset: 0x2E7F701 VA: 0x2E7F600
	public static void CancelAfterSlim(CancellationTokenSource cts, TimeSpan delayTimeSpan, bool ignoreTimeScale = False, PlayerLoopTiming delayTiming = 4) { }

	[AsyncStateMachineAttribute] // RVA: 0x29ED0 Offset: 0x29FD1 VA: 0x29ED0
	// RVA: 0x2E7F520 Offset: 0x2E7F621 VA: 0x2E7F520
	private static UniTaskVoid CancelAfterCore(CancellationTokenSource cts, UniTask delayTask) { }

	[ExtensionAttribute] // RVA: 0x29F40 Offset: 0x2A041 VA: 0x29F40
	// RVA: 0x2E7F8D0 Offset: 0x2E7F9D1 VA: 0x2E7F8D0
	public static void RegisterRaiseCancelOnDestroy(CancellationTokenSource cts, Component component) { }

	[ExtensionAttribute] // RVA: 0x29F50 Offset: 0x2A051 VA: 0x29F50
	// RVA: 0x2E7F940 Offset: 0x2E7FA41 VA: 0x2E7F940
	public static void RegisterRaiseCancelOnDestroy(CancellationTokenSource cts, GameObject gameObject) { }
}

