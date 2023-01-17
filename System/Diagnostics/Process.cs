// Namespace: System.Diagnostics
[DefaultEventAttribute] // RVA: 0x2FD50 Offset: 0x2FE51 VA: 0x2FD50
[DesignerAttribute] // RVA: 0x2FD50 Offset: 0x2FE51 VA: 0x2FD50
[DefaultPropertyAttribute] // RVA: 0x2FD50 Offset: 0x2FE51 VA: 0x2FD50
[MonitoringDescriptionAttribute] // RVA: 0x2FD50 Offset: 0x2FE51 VA: 0x2FD50
public class Process : Component // TypeDefIndex: 2281
{
	// Fields
	private bool haveProcessId; // 0x28
	private int processId; // 0x2C
	private bool haveProcessHandle; // 0x30
	private SafeProcessHandle m_processHandle; // 0x38
	private bool isRemoteMachine; // 0x40
	private string machineName; // 0x48
	private int m_processAccess; // 0x50
	private ProcessThreadCollection threads; // 0x58
	private ProcessModuleCollection modules; // 0x60
	private bool haveWorkingSetLimits; // 0x68
	private bool havePriorityClass; // 0x69
	private ProcessStartInfo startInfo; // 0x70
	private bool watchForExit; // 0x78
	private bool watchingForExit; // 0x79
	private EventHandler onExited; // 0x80
	private bool exited; // 0x88
	private int exitCode; // 0x8C
	private bool signaled; // 0x90
	private bool haveExitTime; // 0x91
	private bool raisedOnExited; // 0x92
	private RegisteredWaitHandle registeredWaitHandle; // 0x98
	private WaitHandle waitHandle; // 0xA0
	private ISynchronizeInvoke synchronizingObject; // 0xA8
	private StreamReader standardOutput; // 0xB0
	private StreamWriter standardInput; // 0xB8
	private StreamReader standardError; // 0xC0
	private bool disposed; // 0xC8
	private Process.StreamReadMode outputStreamReadMode; // 0xCC
	private Process.StreamReadMode errorStreamReadMode; // 0xD0
	private Process.StreamReadMode inputStreamReadMode; // 0xD4
	internal AsyncStreamReader output; // 0xD8
	internal AsyncStreamReader error; // 0xE0
	private string process_name; // 0xE8

	// Properties
	[DesignerSerializationVisibilityAttribute] // RVA: 0x33980 Offset: 0x33A81 VA: 0x33980
	[MonitoringDescriptionAttribute] // RVA: 0x33980 Offset: 0x33A81 VA: 0x33980
	[BrowsableAttribute] // RVA: 0x33980 Offset: 0x33A81 VA: 0x33980
	private bool Associated { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x339F0 Offset: 0x33AF1 VA: 0x339F0
	[BrowsableAttribute] // RVA: 0x339F0 Offset: 0x33AF1 VA: 0x339F0
	[MonitoringDescriptionAttribute] // RVA: 0x339F0 Offset: 0x33AF1 VA: 0x339F0
	public int ExitCode { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x33A60 Offset: 0x33B61 VA: 0x33A60
	[BrowsableAttribute] // RVA: 0x33A60 Offset: 0x33B61 VA: 0x33A60
	[MonitoringDescriptionAttribute] // RVA: 0x33A60 Offset: 0x33B61 VA: 0x33A60
	public bool HasExited { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x33AD0 Offset: 0x33BD1 VA: 0x33AD0
	[MonitoringDescriptionAttribute] // RVA: 0x33AD0 Offset: 0x33BD1 VA: 0x33AD0
	[BrowsableAttribute] // RVA: 0x33AD0 Offset: 0x33BD1 VA: 0x33AD0
	public IntPtr Handle { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x33B40 Offset: 0x33C41 VA: 0x33B40
	[MonitoringDescriptionAttribute] // RVA: 0x33B40 Offset: 0x33C41 VA: 0x33B40
	public int Id { get; }
	[BrowsableAttribute] // RVA: 0x33B90 Offset: 0x33C91 VA: 0x33B90
	[MonitoringDescriptionAttribute] // RVA: 0x33B90 Offset: 0x33C91 VA: 0x33B90
	[DesignerSerializationVisibilityAttribute] // RVA: 0x33B90 Offset: 0x33C91 VA: 0x33B90
	public ProcessStartInfo StartInfo { get; set; }
	[MonitoringDescriptionAttribute] // RVA: 0x33C00 Offset: 0x33D01 VA: 0x33C00
	[BrowsableAttribute] // RVA: 0x33C00 Offset: 0x33D01 VA: 0x33C00
	[DefaultValueAttribute] // RVA: 0x33C00 Offset: 0x33D01 VA: 0x33C00
	public ISynchronizeInvoke SynchronizingObject { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x33C70 Offset: 0x33D71 VA: 0x33C70
	[MonitoringDescriptionAttribute] // RVA: 0x33C70 Offset: 0x33D71 VA: 0x33C70
	public string ProcessName { get; }
	private static bool IsWindows { get; }

	// Methods

	// RVA: 0x1AD4CD0 Offset: 0x1AD4DD1 VA: 0x1AD4CD0
	public void .ctor() { }

	// RVA: 0x1AD4D80 Offset: 0x1AD4E81 VA: 0x1AD4D80
	private void .ctor(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	// RVA: 0x1AD4E40 Offset: 0x1AD4F41 VA: 0x1AD4E40
	private bool get_Associated() { }

	// RVA: 0x1AD4E60 Offset: 0x1AD4F61 VA: 0x1AD4E60
	public int get_ExitCode() { }

	// RVA: 0x1AD5030 Offset: 0x1AD5131 VA: 0x1AD5030
	public bool get_HasExited() { }

	// RVA: 0x1AD5950 Offset: 0x1AD5A51 VA: 0x1AD5950
	public IntPtr get_Handle() { }

	// RVA: 0x1AD5A60 Offset: 0x1AD5B61 VA: 0x1AD5A60
	public int get_Id() { }

	// RVA: 0x1AD5A90 Offset: 0x1AD5B91 VA: 0x1AD5A90
	public ProcessStartInfo get_StartInfo() { }

	// RVA: 0x1AD5C10 Offset: 0x1AD5D11 VA: 0x1AD5C10
	public void set_StartInfo(ProcessStartInfo value) { }

	// RVA: 0x1AD5C80 Offset: 0x1AD5D81 VA: 0x1AD5C80
	public ISynchronizeInvoke get_SynchronizingObject() { }

	// RVA: 0x1AD5820 Offset: 0x1AD5921 VA: 0x1AD5820
	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	// RVA: 0x1AD5E40 Offset: 0x1AD5F41 VA: 0x1AD5E40
	private void CompletionCallback(object context, bool wasSignaled) { }

	// RVA: 0x1AD5FA0 Offset: 0x1AD60A1 VA: 0x1AD5FA0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AD6000 Offset: 0x1AD6101 VA: 0x1AD6000
	public void Close() { }

	// RVA: 0x1AD4F00 Offset: 0x1AD5001 VA: 0x1AD4F00
	private void EnsureState(Process.State state) { }

	// RVA: 0x1AD6250 Offset: 0x1AD6351 VA: 0x1AD6250
	private void EnsureWatchingForExit() { }

	// RVA: 0x1AD64C0 Offset: 0x1AD65C1 VA: 0x1AD64C0
	public static Process GetCurrentProcess() { }

	// RVA: 0x1AD65C0 Offset: 0x1AD66C1 VA: 0x1AD65C0
	protected void OnExited() { }

	// RVA: 0x1AD5350 Offset: 0x1AD5451 VA: 0x1AD5350
	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	// RVA: 0x1AD6840 Offset: 0x1AD6941 VA: 0x1AD6840
	private SafeProcessHandle GetProcessHandle(int access) { }

	// RVA: 0x1AD5990 Offset: 0x1AD5A91 VA: 0x1AD5990
	private SafeProcessHandle OpenProcessHandle(int access) { }

	// RVA: 0x1AD6200 Offset: 0x1AD6301 VA: 0x1AD6200
	public void Refresh() { }

	// RVA: 0x1AD6850 Offset: 0x1AD6951 VA: 0x1AD6850
	private void SetProcessHandle(SafeProcessHandle processHandle) { }

	// RVA: 0x1AD68A0 Offset: 0x1AD69A1 VA: 0x1AD68A0
	private void SetProcessId(int processId) { }

	// RVA: 0x1AD68B0 Offset: 0x1AD69B1 VA: 0x1AD68B0
	public bool Start() { }

	// RVA: 0x1AD7FE0 Offset: 0x1AD80E1 VA: 0x1AD7FE0
	public static Process Start(ProcessStartInfo startInfo) { }

	// RVA: 0x1AD5E70 Offset: 0x1AD5F71 VA: 0x1AD5E70
	private void StopWatchingForExit() { }

	// RVA: 0x1AD8130 Offset: 0x1AD8231 VA: 0x1AD8130 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AD84C0 Offset: 0x1AD85C1 VA: 0x1AD84C0
	public bool WaitForExit(int milliseconds) { }

	// RVA: 0x1AD86C0 Offset: 0x1AD87C1 VA: 0x1AD86C0
	public void WaitForExit() { }

	// RVA: 0x1AD86D0 Offset: 0x1AD87D1 VA: 0x1AD86D0
	private static string ProcessName_internal(IntPtr handle) { }

	// RVA: 0x1AD86E0 Offset: 0x1AD87E1 VA: 0x1AD86E0
	private static string ProcessName_internal(SafeProcessHandle handle) { }

	// RVA: 0x1AD82B0 Offset: 0x1AD83B1 VA: 0x1AD82B0
	public string get_ProcessName() { }

	// RVA: 0x1AD87C0 Offset: 0x1AD88C1 VA: 0x1AD87C0
	private static bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo) { }

	// RVA: 0x1AD87D0 Offset: 0x1AD88D1 VA: 0x1AD87D0
	private static bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, ref Process.ProcInfo procInfo) { }

	// RVA: 0x1AD6A30 Offset: 0x1AD6B31 VA: 0x1AD6A30
	private bool StartWithShellExecuteEx(ProcessStartInfo startInfo) { }

	// RVA: 0x1AD89D0 Offset: 0x1AD8AD1 VA: 0x1AD89D0
	private static void CreatePipe(out IntPtr read, out IntPtr write, bool writeDirection) { }

	// RVA: 0x1AD8BF0 Offset: 0x1AD8CF1 VA: 0x1AD8BF0
	private static bool get_IsWindows() { }

	// RVA: 0x1AD6D90 Offset: 0x1AD6E91 VA: 0x1AD6D90
	private bool StartWithCreateProcess(ProcessStartInfo startInfo) { }

	// RVA: 0x1AD8850 Offset: 0x1AD8951 VA: 0x1AD8850
	private static void FillUserInfo(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo) { }

	// RVA: 0x1AD5850 Offset: 0x1AD5951 VA: 0x1AD5850
	private void RaiseOnExited() { }
}

