// Namespace: MoonSharp.Interpreter
[ExtensionAttribute] // RVA: 0xD390 Offset: 0xD491 VA: 0xD390
public static class LuaTypeExtensions // TypeDefIndex: 5937
{
	// Fields
	internal const DataType MaxMetaTypes = 6;
	internal const DataType MaxConvertibleTypes = 10;

	// Methods

	[ExtensionAttribute] // RVA: 0xF870 Offset: 0xF971 VA: 0xF870
	// RVA: 0x2BB1CE0 Offset: 0x2BB1DE1 VA: 0x2BB1CE0
	public static bool CanHaveTypeMetatables(DataType type) { }

	[ExtensionAttribute] // RVA: 0xF880 Offset: 0xF981 VA: 0xF880
	// RVA: 0x2BAFD80 Offset: 0x2BAFE81 VA: 0x2BAFD80
	public static string ToErrorTypeString(DataType type) { }

	[ExtensionAttribute] // RVA: 0xF890 Offset: 0xF991 VA: 0xF890
	// RVA: 0x2BB1CF0 Offset: 0x2BB1DF1 VA: 0x2BB1CF0
	public static string ToLuaDebuggerString(DataType type) { }

	[ExtensionAttribute] // RVA: 0xF8A0 Offset: 0xF9A1 VA: 0xF8A0
	// RVA: 0x2BB1D80 Offset: 0x2BB1E81 VA: 0x2BB1D80
	public static string ToLuaTypeString(DataType type) { }
}

