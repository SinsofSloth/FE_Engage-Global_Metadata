// Namespace: UnityEngine.AddressableAssets.Initialization
public static class AddressablesRuntimeProperties // TypeDefIndex: 7316
{
	// Fields
	private static Stack<string> s_TokenStack; // 0x0
	private static Stack<int> s_TokenStartStack; // 0x8
	private static Dictionary<string, string> s_CachedValues; // 0x10

	// Methods

	// RVA: 0x3093E50 Offset: 0x3093F51 VA: 0x3093E50
	private static Assembly[] GetAssemblies() { }

	// RVA: 0x3093E70 Offset: 0x3093F71 VA: 0x3093E70
	internal static int GetCachedValueCount() { }

	// RVA: 0x3093EF0 Offset: 0x3093FF1 VA: 0x3093EF0
	public static void SetPropertyValue(string name, string val) { }

	// RVA: 0x3093F90 Offset: 0x3094091 VA: 0x3093F90
	public static void ClearCachedPropertyValues() { }

	// RVA: 0x3094010 Offset: 0x3094111 VA: 0x3094010
	public static string EvaluateProperty(string name) { }

	// RVA: 0x308D8F0 Offset: 0x308D9F1 VA: 0x308D8F0
	public static string EvaluateString(string input) { }

	// RVA: 0x3094460 Offset: 0x3094561 VA: 0x3094460
	public static string EvaluateString(string inputString, char startDelimiter, char endDelimiter, Func<string, string> varFunc) { }

	// RVA: 0x30949F0 Offset: 0x3094AF1 VA: 0x30949F0
	private static void .cctor() { }
}

