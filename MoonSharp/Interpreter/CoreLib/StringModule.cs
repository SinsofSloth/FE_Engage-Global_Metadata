// Namespace: MoonSharp.Interpreter.CoreLib
[MoonSharpModuleAttribute] // RVA: 0xDE10 Offset: 0xDF11 VA: 0xDE10
public class StringModule // TypeDefIndex: 6246
{
	// Fields
	public const string BASE64_DUMP_HEADER = "MoonSharp_dump_b64::";

	// Methods

	// RVA: 0x3027950 Offset: 0x3027A51 VA: 0x3027950
	public static void MoonSharpInit(Table globalTable, Table stringTable) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11D00 Offset: 0x11E01 VA: 0x11D00
	// RVA: 0x3027A30 Offset: 0x3027B31 VA: 0x3027A30
	public static DynValue dump(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11D10 Offset: 0x11E11 VA: 0x11D10
	// RVA: 0x3027D70 Offset: 0x3027E71 VA: 0x3027D70
	public static DynValue char(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11D20 Offset: 0x11E21 VA: 0x11D20
	// RVA: 0x3027F50 Offset: 0x3028051 VA: 0x3027F50
	public static DynValue byte(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11D30 Offset: 0x11E31 VA: 0x11D30
	// RVA: 0x3028330 Offset: 0x3028431 VA: 0x3028330
	public static DynValue unicode(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x30284D0 Offset: 0x30285D1 VA: 0x30284D0
	private static int Unicode2Ascii(int i) { }

	// RVA: 0x30280F0 Offset: 0x30281F1 VA: 0x30280F0
	private static DynValue PerformByteLike(DynValue vs, DynValue vi, DynValue vj, Func<int, int> filter) { }

	// RVA: 0x30286A0 Offset: 0x30287A1 VA: 0x30286A0
	private static Nullable<int> AdjustIndex(string s, DynValue vi, int defval) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11D40 Offset: 0x11E41 VA: 0x11D40
	// RVA: 0x30287C0 Offset: 0x30288C1 VA: 0x30287C0
	public static DynValue len(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11D50 Offset: 0x11E51 VA: 0x11D50
	// RVA: 0x3028870 Offset: 0x3028971 VA: 0x3028870
	public static DynValue lower(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11D60 Offset: 0x11E61 VA: 0x11D60
	// RVA: 0x3028920 Offset: 0x3028A21 VA: 0x3028920
	public static DynValue upper(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11D70 Offset: 0x11E71 VA: 0x11D70
	// RVA: 0x30289D0 Offset: 0x3028AD1 VA: 0x30289D0
	public static DynValue rep(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11D80 Offset: 0x11E81 VA: 0x11D80
	// RVA: 0x3028C10 Offset: 0x3028D11 VA: 0x3028C10
	public static DynValue reverse(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11D90 Offset: 0x11E91 VA: 0x11D90
	// RVA: 0x3028D40 Offset: 0x3028E41 VA: 0x3028D40
	public static DynValue sub(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11DA0 Offset: 0x11EA1 VA: 0x11DA0
	// RVA: 0x3028F20 Offset: 0x3029021 VA: 0x3028F20
	public static DynValue startsWith(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11DB0 Offset: 0x11EB1 VA: 0x11DB0
	// RVA: 0x30290C0 Offset: 0x30291C1 VA: 0x30290C0
	public static DynValue endsWith(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11DC0 Offset: 0x11EC1 VA: 0x11DC0
	// RVA: 0x3029260 Offset: 0x3029361 VA: 0x3029260
	public static DynValue contains(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x3029400 Offset: 0x3029501 VA: 0x3029400
	public void .ctor() { }
}

