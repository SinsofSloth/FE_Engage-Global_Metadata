// Namespace: UniRx.Async
[ExtensionAttribute] // RVA: 0x27920 Offset: 0x27A21 VA: 0x27920
public static class DiagnosticsExtensions // TypeDefIndex: 4913
{
	// Fields
	private static bool displayFilenames; // 0x0
	private static readonly Regex typeBeautifyRegex; // 0x8
	private static readonly Dictionary<Type, string> builtInTypeNames; // 0x10

	// Methods

	[ExtensionAttribute] // RVA: 0x29F70 Offset: 0x2A071 VA: 0x29F70
	// RVA: 0x2E800C0 Offset: 0x2E801C1 VA: 0x2E800C0
	public static string ToStringWithCleanupAsyncStackTrace(Exception exception) { }

	[ExtensionAttribute] // RVA: 0x29F80 Offset: 0x2A081 VA: 0x29F80
	// RVA: 0x2E80410 Offset: 0x2E80511 VA: 0x2E80410
	public static string CleanupAsyncStackTrace(StackTrace stackTrace) { }

	// RVA: 0x2E80DC0 Offset: 0x2E80EC1 VA: 0x2E80DC0
	private static bool IsAsync(MethodBase methodInfo) { }

	// RVA: 0x2E80E70 Offset: 0x2E80F71 VA: 0x2E80E70
	private static bool TryResolveStateMachineMethod(ref MethodBase method, out Type declaringType) { }

	// RVA: 0x2E81340 Offset: 0x2E81441 VA: 0x2E81340
	private static string BeautifyType(Type t, bool shortName) { }

	// RVA: 0x2E80C90 Offset: 0x2E80D91 VA: 0x2E80C90
	private static bool IgnoreLine(MethodBase methodInfo) { }

	// RVA: 0x2E81850 Offset: 0x2E81951 VA: 0x2E81850
	private static string SimplifyPath(string path) { }

	// RVA: 0x2E81930 Offset: 0x2E81A31 VA: 0x2E81930
	private static void .cctor() { }
}

