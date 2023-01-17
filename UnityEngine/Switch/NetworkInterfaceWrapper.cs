// Namespace: UnityEngine.Switch
[NativeHeaderAttribute] // RVA: 0x48A680 Offset: 0x48A781 VA: 0x48A680
public static class NetworkInterfaceWrapper // TypeDefIndex: 7529
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x48A860 Offset: 0x48A961 VA: 0x48A860
	[DebuggerBrowsableAttribute] // RVA: 0x48A860 Offset: 0x48A961 VA: 0x48A860
	private static NetworkInterfaceWrapper.NetworkConnectedHandler _networkConnected; // 0x0

	// Methods

	// RVA: 0x3F0B520 Offset: 0x3F0B621 VA: 0x3F0B520
	public static bool EnterNetworkConnecting(bool isLocalNetworkMode = False) { }

	[NativeConditionalAttribute] // RVA: 0x48A920 Offset: 0x48AA21 VA: 0x48A920
	[ThreadSafeAttribute] // RVA: 0x48A920 Offset: 0x48AA21 VA: 0x48A920
	[FreeFunctionAttribute] // RVA: 0x48A920 Offset: 0x48AA21 VA: 0x48A920
	// RVA: 0x3F0B570 Offset: 0x3F0B671 VA: 0x3F0B570
	public static bool EnterNetworkConnecting(bool isLocalNetworkMode, bool reportIfUnavailable) { }

	[NativeConditionalAttribute] // RVA: 0x48A990 Offset: 0x48AA91 VA: 0x48A990
	[ThreadSafeAttribute] // RVA: 0x48A990 Offset: 0x48AA91 VA: 0x48A990
	[FreeFunctionAttribute] // RVA: 0x48A990 Offset: 0x48AA91 VA: 0x48A990
	// RVA: 0x3F0B5C0 Offset: 0x3F0B6C1 VA: 0x3F0B5C0
	public static bool WeakEnterNetworkConnecting() { }

	[NativeConditionalAttribute] // RVA: 0x48AA00 Offset: 0x48AB01 VA: 0x48AA00
	[ThreadSafeAttribute] // RVA: 0x48AA00 Offset: 0x48AB01 VA: 0x48AA00
	[FreeFunctionAttribute] // RVA: 0x48AA00 Offset: 0x48AB01 VA: 0x48AA00
	// RVA: 0x3F0B600 Offset: 0x3F0B701 VA: 0x3F0B600
	public static void LeaveNetworkConnecting() { }

	[ThreadSafeAttribute] // RVA: 0x48AA70 Offset: 0x48AB71 VA: 0x48AA70
	[FreeFunctionAttribute] // RVA: 0x48AA70 Offset: 0x48AB71 VA: 0x48AA70
	[NativeConditionalAttribute] // RVA: 0x48AA70 Offset: 0x48AB71 VA: 0x48AA70
	// RVA: 0x3F0B640 Offset: 0x3F0B741 VA: 0x3F0B640
	public static bool IsNetworkConnecting() { }

	[FreeFunctionAttribute] // RVA: 0x48AAE0 Offset: 0x48ABE1 VA: 0x48AAE0
	[ThreadSafeAttribute] // RVA: 0x48AAE0 Offset: 0x48ABE1 VA: 0x48AAE0
	[NativeConditionalAttribute] // RVA: 0x48AAE0 Offset: 0x48ABE1 VA: 0x48AAE0
	// RVA: 0x3F0B680 Offset: 0x3F0B781 VA: 0x3F0B680
	public static void WaitForNetworkConnecting() { }

	[NativeConditionalAttribute] // RVA: 0x48AB50 Offset: 0x48AC51 VA: 0x48AB50
	[ThreadSafeAttribute] // RVA: 0x48AB50 Offset: 0x48AC51 VA: 0x48AB50
	[FreeFunctionAttribute] // RVA: 0x48AB50 Offset: 0x48AC51 VA: 0x48AB50
	// RVA: 0x3F0B6C0 Offset: 0x3F0B7C1 VA: 0x3F0B6C0
	public static bool IsNetworkAccepted() { }

	[NativeConditionalAttribute] // RVA: 0x48ABC0 Offset: 0x48ACC1 VA: 0x48ABC0
	[ThreadSafeAttribute] // RVA: 0x48ABC0 Offset: 0x48ACC1 VA: 0x48ABC0
	[FreeFunctionAttribute] // RVA: 0x48ABC0 Offset: 0x48ACC1 VA: 0x48ABC0
	// RVA: 0x3F0B700 Offset: 0x3F0B801 VA: 0x3F0B700
	public static bool IsNetworkFinished() { }

	[FreeFunctionAttribute] // RVA: 0x48AC30 Offset: 0x48AD31 VA: 0x48AC30
	[ThreadSafeAttribute] // RVA: 0x48AC30 Offset: 0x48AD31 VA: 0x48AC30
	[NativeConditionalAttribute] // RVA: 0x48AC30 Offset: 0x48AD31 VA: 0x48AC30
	// RVA: 0x3F0B740 Offset: 0x3F0B841 VA: 0x3F0B740
	public static int GetNetworkReferenceCount() { }

	[NativeConditionalAttribute] // RVA: 0x48ACA0 Offset: 0x48ADA1 VA: 0x48ACA0
	[ThreadSafeAttribute] // RVA: 0x48ACA0 Offset: 0x48ADA1 VA: 0x48ACA0
	[FreeFunctionAttribute] // RVA: 0x48ACA0 Offset: 0x48ADA1 VA: 0x48ACA0
	// RVA: 0x3F0B780 Offset: 0x3F0B881 VA: 0x3F0B780
	public static bool IsNetworkAvailable() { }

	[FreeFunctionAttribute] // RVA: 0x48AD10 Offset: 0x48AE11 VA: 0x48AD10
	[NativeConditionalAttribute] // RVA: 0x48AD10 Offset: 0x48AE11 VA: 0x48AD10
	[ThreadSafeAttribute] // RVA: 0x48AD10 Offset: 0x48AE11 VA: 0x48AD10
	// RVA: 0x3F0B7C0 Offset: 0x3F0B8C1 VA: 0x3F0B7C0
	public static bool IsNetworkConnectingOnBackground() { }

	[FreeFunctionAttribute] // RVA: 0x48AD80 Offset: 0x48AE81 VA: 0x48AD80
	[NativeConditionalAttribute] // RVA: 0x48AD80 Offset: 0x48AE81 VA: 0x48AD80
	[ThreadSafeAttribute] // RVA: 0x48AD80 Offset: 0x48AE81 VA: 0x48AD80
	// RVA: 0x3F0B800 Offset: 0x3F0B901 VA: 0x3F0B800
	public static void SetNetworkConnectingOnBackground(bool isBackground) { }

	[ThreadSafeAttribute] // RVA: 0x48ADF0 Offset: 0x48AEF1 VA: 0x48ADF0
	[FreeFunctionAttribute] // RVA: 0x48ADF0 Offset: 0x48AEF1 VA: 0x48ADF0
	[NativeConditionalAttribute] // RVA: 0x48ADF0 Offset: 0x48AEF1 VA: 0x48ADF0
	// RVA: 0x3F0B850 Offset: 0x3F0B951 VA: 0x3F0B850
	private static void SetNetworkConnectedEnabled(bool isEnabled) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x48AE60 Offset: 0x48AF61 VA: 0x48AE60
	// RVA: 0x3F0B8A0 Offset: 0x3F0B9A1 VA: 0x3F0B8A0
	private static int InvokeNetworkConnected() { }

	// RVA: 0x3F0BB10 Offset: 0x3F0BC11 VA: 0x3F0BB10
	public static void add_networkConnected(NetworkInterfaceWrapper.NetworkConnectedHandler value) { }

	// RVA: 0x3F0BCC0 Offset: 0x3F0BDC1 VA: 0x3F0BCC0
	public static void remove_networkConnected(NetworkInterfaceWrapper.NetworkConnectedHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x48AE70 Offset: 0x48AF71 VA: 0x48AE70
	// RVA: 0x3F0BC00 Offset: 0x3F0BD01 VA: 0x3F0BC00
	private static void add__networkConnected(NetworkInterfaceWrapper.NetworkConnectedHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x48AE80 Offset: 0x48AF81 VA: 0x48AE80
	// RVA: 0x3F0BDF0 Offset: 0x3F0BEF1 VA: 0x3F0BDF0
	private static void remove__networkConnected(NetworkInterfaceWrapper.NetworkConnectedHandler value) { }
}

