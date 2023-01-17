// Namespace: Microsoft.Win32
internal static class NativeMethods // TypeDefIndex: 2211
{
	// Methods

	// RVA: 0x1ACE040 Offset: 0x1ACE141 VA: 0x1ACE040
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, SafeHandle hSourceHandle, HandleRef hTargetProcess, out SafeWaitHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	// RVA: 0x1ACE270 Offset: 0x1ACE371 VA: 0x1ACE270
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	// RVA: 0x1ACE400 Offset: 0x1ACE501 VA: 0x1ACE400
	public static IntPtr GetCurrentProcess() { }

	// RVA: 0x1ACE410 Offset: 0x1ACE511 VA: 0x1ACE410
	public static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode) { }

	// RVA: 0x1ACE420 Offset: 0x1ACE521 VA: 0x1ACE420
	public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode) { }

	// RVA: 0x1ACE500 Offset: 0x1ACE601 VA: 0x1ACE500
	public static int GetCurrentProcessId() { }

	// RVA: 0x1ACE510 Offset: 0x1ACE611 VA: 0x1ACE510
	public static bool CloseProcess(IntPtr handle) { }
}

