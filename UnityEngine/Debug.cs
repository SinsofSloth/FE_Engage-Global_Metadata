// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43BF20 Offset: 0x43C021 VA: 0x43BF20
public class Debug // TypeDefIndex: 3423
{
	// Fields
	internal static readonly ILogger s_DefaultLogger; // 0x0
	internal static ILogger s_Logger; // 0x8

	// Properties
	public static ILogger unityLogger { get; }
	[StaticAccessorAttribute] // RVA: 0x459420 Offset: 0x459521 VA: 0x459420
	[NativePropertyAttribute] // RVA: 0x459420 Offset: 0x459521 VA: 0x459420
	public static bool isDebugBuild { get; }

	// Methods

	// RVA: 0x2F1EA80 Offset: 0x2F1EB81 VA: 0x2F1EA80
	public static ILogger get_unityLogger() { }

	[FreeFunctionAttribute] // RVA: 0x447260 Offset: 0x447361 VA: 0x447260
	// RVA: 0x2F1EAF0 Offset: 0x2F1EBF1 VA: 0x2F1EAF0
	public static void Break() { }

	[ThreadSafeAttribute] // RVA: 0x4472A0 Offset: 0x4473A1 VA: 0x4472A0
	// RVA: 0x2F1EB30 Offset: 0x2F1EC31 VA: 0x2F1EB30
	public static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder) { }

	// RVA: 0x2F1EB90 Offset: 0x2F1EC91 VA: 0x2F1EB90
	public static void Log(object message) { }

	// RVA: 0x2F1ECD0 Offset: 0x2F1EDD1 VA: 0x2F1ECD0
	public static void Log(object message, Object context) { }

	// RVA: 0x2F1EE10 Offset: 0x2F1EF11 VA: 0x2F1EE10
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x2F1EF50 Offset: 0x2F1F051 VA: 0x2F1EF50
	public static void LogError(object message) { }

	// RVA: 0x2F1F090 Offset: 0x2F1F191 VA: 0x2F1F090
	public static void LogError(object message, Object context) { }

	// RVA: 0x2F1F1D0 Offset: 0x2F1F2D1 VA: 0x2F1F1D0
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x2F1F310 Offset: 0x2F1F411 VA: 0x2F1F310
	public static void LogErrorFormat(Object context, string format, object[] args) { }

	// RVA: 0x2F0A2C0 Offset: 0x2F0A3C1 VA: 0x2F0A2C0
	public static void LogException(Exception exception) { }

	// RVA: 0x2F1F460 Offset: 0x2F1F561 VA: 0x2F1F460
	public static void LogException(Exception exception, Object context) { }

	// RVA: 0x2F12B00 Offset: 0x2F12C01 VA: 0x2F12B00
	public static void LogWarning(object message) { }

	// RVA: 0x2F1F5A0 Offset: 0x2F1F6A1 VA: 0x2F1F5A0
	public static void LogWarning(object message, Object context) { }

	// RVA: 0x2F1F6E0 Offset: 0x2F1F7E1 VA: 0x2F1F6E0
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x2F1F820 Offset: 0x2F1F921 VA: 0x2F1F820
	public static void LogWarningFormat(Object context, string format, object[] args) { }

	// RVA: 0x2F1F970 Offset: 0x2F1FA71 VA: 0x2F1F970
	public static bool get_isDebugBuild() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4472B0 Offset: 0x4473B1 VA: 0x4472B0
	// RVA: 0x2F1F9B0 Offset: 0x2F1FAB1 VA: 0x2F1F9B0
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4472C0 Offset: 0x4473C1 VA: 0x4472C0
	// RVA: 0x2F1FE20 Offset: 0x2F1FF21 VA: 0x2F1FE20
	internal static bool IsLoggingEnabled() { }

	// RVA: 0x2F200A0 Offset: 0x2F201A1 VA: 0x2F200A0
	private static void .cctor() { }
}

