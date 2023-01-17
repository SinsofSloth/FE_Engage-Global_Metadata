// Namespace: App
public class DebugManager // TypeDefIndex: 9103
{
	// Fields
	private static Stack<DebugManager.LogArg> s_LogStack; // 0x0
	private static bool s_LogLock; // 0x8

	// Methods

	// RVA: 0x2E9E660 Offset: 0x2E9E761 VA: 0x2E9E660
	public static void Initialize() { }

	// RVA: 0x2E9E790 Offset: 0x2E9E891 VA: 0x2E9E790
	private static void OnMessage(string logText, string stackTrace, LogType type) { }

	[ConditionalAttribute] // RVA: 0x2AE2C0 Offset: 0x2AE3C1 VA: 0x2AE2C0
	// RVA: 0x2E9E7A0 Offset: 0x2E9E8A1 VA: 0x2E9E7A0
	public static void Clear() { }

	// RVA: 0x2E9E7B0 Offset: 0x2E9E8B1 VA: 0x2E9E7B0
	public static string GetStackMethodName(int depth = 1) { }

	[ConditionalAttribute] // RVA: 0x2AE300 Offset: 0x2AE401 VA: 0x2AE300
	// RVA: 0x2E9E800 Offset: 0x2E9E901 VA: 0x2E9E800
	public static void Stop(string ex) { }

	// RVA: 0x2E9E890 Offset: 0x2E9E991 VA: 0x2E9E890
	public void .ctor() { }

	// RVA: 0x2E9E8A0 Offset: 0x2E9E9A1 VA: 0x2E9E8A0
	private static void .cctor() { }
}

