// Namespace: MoonSharp.Interpreter.Serialization.Json
[ExtensionAttribute] // RVA: 0xD730 Offset: 0xD831 VA: 0xD730
public static class JsonTableConverter // TypeDefIndex: 6037
{
	// Methods

	[ExtensionAttribute] // RVA: 0x10180 Offset: 0x10281 VA: 0x10180
	// RVA: 0x331BAC0 Offset: 0x331BBC1 VA: 0x331BAC0
	public static string TableToJson(Table table) { }

	// RVA: 0x331BE60 Offset: 0x331BF61 VA: 0x331BE60
	private static void TableToJson(StringBuilder sb, Table table) { }

	// RVA: 0x331C4E0 Offset: 0x331C5E1 VA: 0x331C4E0
	public static string ObjectToJson(object obj) { }

	// RVA: 0x331C380 Offset: 0x331C481 VA: 0x331C380
	private static void ValueToJson(StringBuilder sb, DynValue value) { }

	// RVA: 0x331C5E0 Offset: 0x331C6E1 VA: 0x331C5E0
	private static string EscapeString(string s) { }

	// RVA: 0x331C310 Offset: 0x331C411 VA: 0x331C310
	private static bool IsValueJsonCompatible(DynValue value) { }

	// RVA: 0x331B6C0 Offset: 0x331B7C1 VA: 0x331B6C0
	public static Table JsonToTable(string json, Script script) { }

	// RVA: 0x331CD20 Offset: 0x331CE21 VA: 0x331CD20
	private static void AssertToken(Lexer L, TokenType type) { }

	// RVA: 0x331CB60 Offset: 0x331CC61 VA: 0x331CB60
	private static Table ParseJsonArray(Lexer L, Script script) { }

	// RVA: 0x331C8D0 Offset: 0x331C9D1 VA: 0x331C8D0
	private static Table ParseJsonObject(Lexer L, Script script) { }

	// RVA: 0x331CE40 Offset: 0x331CF41 VA: 0x331CE40
	private static DynValue ParseJsonValue(Lexer L, Script script) { }
}

