// Namespace: nn.err
public static class Error // TypeDefIndex: 14766
{
	// Methods

	// RVA: 0x2605560 Offset: 0x2605661 VA: 0x2605560
	public static extern void Show(Result result) { }

	// RVA: 0x2605570 Offset: 0x2605671 VA: 0x2605570
	public static extern void Show(ErrorCode errorCode) { }

	// RVA: 0x2605580 Offset: 0x2605681 VA: 0x2605580
	public static void Show(Result result, bool suspendUnityThreads) { }

	// RVA: 0x26055D0 Offset: 0x26056D1 VA: 0x26055D0
	public static void Show(ErrorCode errorCode, bool suspendUnityThreads) { }

	// RVA: 0x2605620 Offset: 0x2605721 VA: 0x2605620
	public static extern void ShowUnacceptableAddOnContentVersion() { }

	// RVA: 0x2605630 Offset: 0x2605731 VA: 0x2605630
	public static void ShowUnacceptableAddOnContentVersion(bool suspendUnityThreads) { }

	// RVA: 0x2605660 Offset: 0x2605761 VA: 0x2605660
	public static extern void ShowUnacceptableApplicationVersion() { }

	// RVA: 0x2605670 Offset: 0x2605771 VA: 0x2605670
	public static void ShowUnacceptableApplicationVersion(bool suspendUnityThreads) { }
}

