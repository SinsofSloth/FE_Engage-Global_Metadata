// Namespace: MoonSharp.Interpreter.Serialization
[ExtensionAttribute] // RVA: 0xD720 Offset: 0xD821 VA: 0xD720
public static class SerializationExtensions // TypeDefIndex: 6035
{
	// Fields
	private static HashSet<string> LUAKEYWORDS; // 0x0

	// Methods

	[ExtensionAttribute] // RVA: 0x10140 Offset: 0x10241 VA: 0x10140
	// RVA: 0x301E690 Offset: 0x301E791 VA: 0x301E690
	public static string Serialize(Table table, bool prefixReturn = False, int tabs = 0) { }

	// RVA: 0x301ED30 Offset: 0x301EE31 VA: 0x301ED30
	private static bool IsStringIdentifierValid(DynValue dynValue) { }

	[ExtensionAttribute] // RVA: 0x10150 Offset: 0x10251 VA: 0x10150
	// RVA: 0x301EF40 Offset: 0x301F041 VA: 0x301EF40
	public static string SerializeValue(DynValue dynValue, int tabs = 0) { }

	// RVA: 0x301F1E0 Offset: 0x301F2E1 VA: 0x301F1E0
	private static string EscapeString(string s) { }

	// RVA: 0x301F480 Offset: 0x301F581 VA: 0x301F480
	private static void .cctor() { }
}

