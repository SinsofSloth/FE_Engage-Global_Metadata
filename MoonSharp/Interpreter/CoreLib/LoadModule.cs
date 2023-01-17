// Namespace: MoonSharp.Interpreter.CoreLib
[MoonSharpModuleAttribute] // RVA: 0xDCF0 Offset: 0xDDF1 VA: 0xDCF0
public class LoadModule // TypeDefIndex: 6239
{
	// Fields
	[MoonSharpModuleMethodAttribute] // RVA: 0xEDD0 Offset: 0xEED1 VA: 0xEDD0
	public const string require = "\r\nfunction(modulename)\r\n\tif (package == nil) then package = { }; end\r\n\tif (package.loaded == nil) then package.loaded = { }; end\r\n\r\n\tlocal m = package.loaded[modulename];\r\n\r\n\tif (m ~= nil) then\r\n\t\treturn m;\r\n\tend\r\n\r\n\tlocal func = __require_clr_impl(modulename);\r\n\r\n\tlocal res = func(modulename);\r\n\r\n\tif (res == nil) then\r\n\t\tres = true;\r\n\tend\r\n\r\n\tpackage.loaded[modulename] = res;\r\n\r\n\treturn res;\r\nend";

	// Methods

	// RVA: 0x2BAD170 Offset: 0x2BAD271 VA: 0x2BAD170
	public static void MoonSharpInit(Table globalTable, Table ioTable) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x119E0 Offset: 0x11AE1 VA: 0x119E0
	// RVA: 0x2BAD360 Offset: 0x2BAD461 VA: 0x2BAD360
	public static DynValue load(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x119F0 Offset: 0x11AF1 VA: 0x119F0
	// RVA: 0x2BAD950 Offset: 0x2BADA51 VA: 0x2BAD950
	public static DynValue loadsafe(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x2BAD370 Offset: 0x2BAD471 VA: 0x2BAD370
	public static DynValue load_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11A00 Offset: 0x11B01 VA: 0x11A00
	// RVA: 0x2BADA40 Offset: 0x2BADB41 VA: 0x2BADA40
	public static DynValue loadfile(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11A10 Offset: 0x11B11 VA: 0x11A10
	// RVA: 0x2BADD70 Offset: 0x2BADE71 VA: 0x2BADD70
	public static DynValue loadfilesafe(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x2BADA50 Offset: 0x2BADB51 VA: 0x2BADA50
	private static DynValue loadfile_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv) { }

	// RVA: 0x2BAD9D0 Offset: 0x2BADAD1 VA: 0x2BAD9D0
	private static Table GetSafeDefaultEnv(ScriptExecutionContext executionContext) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11A20 Offset: 0x11B21 VA: 0x11A20
	// RVA: 0x2BADDF0 Offset: 0x2BADEF1 VA: 0x2BADDF0
	public static DynValue dofile(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11A30 Offset: 0x11B31 VA: 0x11A30
	// RVA: 0x2BAE020 Offset: 0x2BAE121 VA: 0x2BAE020
	public static DynValue __require_clr_impl(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x2BAE0C0 Offset: 0x2BAE1C1 VA: 0x2BAE0C0
	public void .ctor() { }
}

