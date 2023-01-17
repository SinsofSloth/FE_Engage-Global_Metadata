// Namespace: System
[ComVisibleAttribute] // RVA: 0x470F50 Offset: 0x471051 VA: 0x470F50
public static class Environment // TypeDefIndex: 343
{
	// Fields
	private const int mono_corlib_version = 1051100001;
	private static string nl; // 0x0
	private static OperatingSystem os; // 0x8

	// Properties
	public static int CurrentManagedThreadId { get; }
	public static bool HasShutdownStarted { get; }
	public static string MachineName { get; }
	public static string NewLine { get; }
	internal static PlatformID Platform { get; }
	public static OperatingSystem OSVersion { get; }
	public static string StackTrace { get; }
	public static int TickCount { get; }
	public static string UserDomainName { get; }
	public static string UserName { get; }
	public static bool Is64BitProcess { get; }
	public static int ProcessorCount { get; }
	internal static bool IsRunningOnWindows { get; }
	internal static bool IsUnix { get; }

	// Methods

	// RVA: 0x3B587A0 Offset: 0x3B588A1 VA: 0x3B587A0
	internal static string GetResourceString(string key) { }

	// RVA: 0x3B5C4F0 Offset: 0x3B5C5F1 VA: 0x3B5C4F0
	internal static string GetResourceString(string key, object[] values) { }

	// RVA: 0x3B5E040 Offset: 0x3B5E141 VA: 0x3B5E040
	internal static string GetResourceStringEncodingName(int codePage) { }

	// RVA: 0x3B5E1E0 Offset: 0x3B5E2E1 VA: 0x3B5E1E0
	public static int get_CurrentManagedThreadId() { }

	// RVA: 0x3B5E200 Offset: 0x3B5E301 VA: 0x3B5E200
	public static bool get_HasShutdownStarted() { }

	// RVA: 0x3B5E210 Offset: 0x3B5E311 VA: 0x3B5E210
	public static string get_MachineName() { }

	// RVA: 0x3B5E220 Offset: 0x3B5E321 VA: 0x3B5E220
	private static string GetNewLine() { }

	// RVA: 0x3B5E230 Offset: 0x3B5E331 VA: 0x3B5E230
	public static string get_NewLine() { }

	[CompilerGeneratedAttribute] // RVA: 0x47AF80 Offset: 0x47B081 VA: 0x47AF80
	// RVA: 0x3B5E2C0 Offset: 0x3B5E3C1 VA: 0x3B5E2C0
	internal static PlatformID get_Platform() { }

	// RVA: 0x3B5E2D0 Offset: 0x3B5E3D1 VA: 0x3B5E2D0
	internal static string GetOSVersionString() { }

	// RVA: 0x3B5E2E0 Offset: 0x3B5E3E1 VA: 0x3B5E2E0
	public static OperatingSystem get_OSVersion() { }

	// RVA: 0x3B5E3D0 Offset: 0x3B5E4D1 VA: 0x3B5E3D0
	internal static Version CreateVersionFromString(string info) { }

	// RVA: 0x3B5E630 Offset: 0x3B5E731 VA: 0x3B5E630
	public static string get_StackTrace() { }

	// RVA: 0x3B5E6A0 Offset: 0x3B5E7A1 VA: 0x3B5E6A0
	public static int get_TickCount() { }

	// RVA: 0x3B5E6B0 Offset: 0x3B5E7B1 VA: 0x3B5E6B0
	public static string get_UserDomainName() { }

	// RVA: 0x3B5E6C0 Offset: 0x3B5E7C1 VA: 0x3B5E6C0
	public static string get_UserName() { }

	// RVA: 0x3B5E6D0 Offset: 0x3B5E7D1 VA: 0x3B5E6D0
	public static void Exit(int exitCode) { }

	// RVA: 0x3B5E6E0 Offset: 0x3B5E7E1 VA: 0x3B5E6E0
	public static string ExpandEnvironmentVariables(string name) { }

	// RVA: 0x3B5EAF0 Offset: 0x3B5EBF1 VA: 0x3B5EAF0
	public static string[] GetCommandLineArgs() { }

	// RVA: 0x3B5EB00 Offset: 0x3B5EC01 VA: 0x3B5EB00
	internal static string internalGetEnvironmentVariable_native(IntPtr variable) { }

	// RVA: 0x3B5EB10 Offset: 0x3B5EC11 VA: 0x3B5EB10
	internal static string internalGetEnvironmentVariable(string variable) { }

	// RVA: 0x3B5E9C0 Offset: 0x3B5EAC1 VA: 0x3B5E9C0
	public static string GetEnvironmentVariable(string variable) { }

	// RVA: 0x3B5E9F0 Offset: 0x3B5EAF1 VA: 0x3B5E9F0
	private static Hashtable GetEnvironmentVariablesNoCase() { }

	// RVA: 0x3B5EBC0 Offset: 0x3B5ECC1 VA: 0x3B5EBC0
	public static IDictionary GetEnvironmentVariables() { }

	// RVA: 0x3B5ECA0 Offset: 0x3B5EDA1 VA: 0x3B5ECA0
	public static string GetFolderPath(Environment.SpecialFolder folder) { }

	// RVA: 0x3B5ED40 Offset: 0x3B5EE41 VA: 0x3B5ED40
	private static string GetWindowsFolderPath(int folder) { }

	// RVA: 0x3B5ECF0 Offset: 0x3B5EDF1 VA: 0x3B5ECF0
	public static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x3B5F270 Offset: 0x3B5F371 VA: 0x3B5F270
	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) { }

	// RVA: 0x3B5ED50 Offset: 0x3B5EE51 VA: 0x3B5ED50
	internal static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x3B5F6F0 Offset: 0x3B5F7F1 VA: 0x3B5F6F0
	public static void FailFast(string message, Exception exception) { }

	// RVA: 0x3B5F770 Offset: 0x3B5F871 VA: 0x3B5F770
	public static bool get_Is64BitProcess() { }

	// RVA: 0x3B5F790 Offset: 0x3B5F891 VA: 0x3B5F790
	public static int get_ProcessorCount() { }

	// RVA: 0x3B5E9D0 Offset: 0x3B5EAD1 VA: 0x3B5E9D0
	internal static bool get_IsRunningOnWindows() { }

	// RVA: 0x3B5EBB0 Offset: 0x3B5ECB1 VA: 0x3B5EBB0
	private static string[] GetEnvironmentVariableNames() { }

	// RVA: 0x3B5F7A0 Offset: 0x3B5F8A1 VA: 0x3B5F7A0
	internal static string GetMachineConfigPath() { }

	// RVA: 0x3B5F6E0 Offset: 0x3B5F7E1 VA: 0x3B5F6E0
	internal static string internalGetHome() { }

	// RVA: 0x3B5F7B0 Offset: 0x3B5F8B1 VA: 0x3B5F7B0
	internal static int GetPageSize() { }

	// RVA: 0x3B5F7C0 Offset: 0x3B5F8C1 VA: 0x3B5F7C0
	internal static bool get_IsUnix() { }

	// RVA: 0x3B5F800 Offset: 0x3B5F901 VA: 0x3B5F800
	internal static string GetStackTrace(Exception e, bool needFileInfo) { }
}

