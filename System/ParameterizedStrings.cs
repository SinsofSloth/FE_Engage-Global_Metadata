// Namespace: System
internal static class ParameterizedStrings // TypeDefIndex: 398
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0x4781C0 Offset: 0x4782C1 VA: 0x4781C0
	private static ParameterizedStrings.LowLevelStack _cachedStack; // 0x80000000

	// Methods

	// RVA: 0x38185B0 Offset: 0x38186B1 VA: 0x38185B0
	public static string Evaluate(string format, ParameterizedStrings.FormatParam[] args) { }

	// RVA: 0x3818710 Offset: 0x3818811 VA: 0x3818710
	private static string EvaluateInternal(string format, ref int pos, ParameterizedStrings.FormatParam[] args, ParameterizedStrings.LowLevelStack stack, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars) { }

	// RVA: 0x3819510 Offset: 0x3819611 VA: 0x3819510
	private static bool AsBool(int i) { }

	// RVA: 0x3819500 Offset: 0x3819601 VA: 0x3819500
	private static int AsInt(bool b) { }

	// RVA: 0x3819520 Offset: 0x3819621 VA: 0x3819520
	private static string StringFromAsciiBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x3819620 Offset: 0x3819721 VA: 0x3819620
	private static extern int snprintf(byte* str, IntPtr size, string format, string arg1) { }

	// RVA: 0x3819700 Offset: 0x3819801 VA: 0x3819700
	private static extern int snprintf(byte* str, IntPtr size, string format, int arg1) { }

	// RVA: 0x3818FA0 Offset: 0x38190A1 VA: 0x3818FA0
	private static string FormatPrintF(string format, object arg) { }

	// RVA: 0x38193C0 Offset: 0x38194C1 VA: 0x38193C0
	private static ParameterizedStrings.FormatParam[] GetDynamicOrStaticVariables(char c, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars, out int index) { }
}

