// Namespace: System.Threading
internal static class NativeEventCalls // TypeDefIndex: 805
{
	// Methods

	// RVA: 0x34FDAF0 Offset: 0x34FDBF1 VA: 0x34FDAF0
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	// RVA: 0x34FDB00 Offset: 0x34FDC01 VA: 0x34FDB00
	public static bool SetEvent(SafeWaitHandle handle) { }

	// RVA: 0x34FDBE0 Offset: 0x34FDCE1 VA: 0x34FDBE0
	private static bool SetEvent_internal(IntPtr handle) { }

	// RVA: 0x34FDBF0 Offset: 0x34FDCF1 VA: 0x34FDBF0
	public static bool ResetEvent(SafeWaitHandle handle) { }

	// RVA: 0x34FDCD0 Offset: 0x34FDDD1 VA: 0x34FDCD0
	private static bool ResetEvent_internal(IntPtr handle) { }

	// RVA: 0x34FDCE0 Offset: 0x34FDDE1 VA: 0x34FDCE0
	public static void CloseEvent_internal(IntPtr handle) { }
}

