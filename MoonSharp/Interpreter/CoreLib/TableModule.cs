// Namespace: MoonSharp.Interpreter.CoreLib
[MoonSharpModuleAttribute] // RVA: 0xDE80 Offset: 0xDF81 VA: 0xDE80
public class TableModule // TypeDefIndex: 6249
{
	// Methods

	[MoonSharpModuleMethodAttribute] // RVA: 0x11E00 Offset: 0x11F01 VA: 0x11E00
	// RVA: 0x3347430 Offset: 0x3347531 VA: 0x3347430
	public static DynValue unpack(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11E10 Offset: 0x11F11 VA: 0x11E10
	// RVA: 0x3347810 Offset: 0x3347911 VA: 0x3347810
	public static DynValue pack(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11E20 Offset: 0x11F21 VA: 0x11E20
	// RVA: 0x3347960 Offset: 0x3347A61 VA: 0x3347960
	public static DynValue sort(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x3347D00 Offset: 0x3347E01 VA: 0x3347D00
	private static int SortComparer(ScriptExecutionContext executionContext, DynValue a, DynValue b, DynValue lt) { }

	// RVA: 0x3347FC0 Offset: 0x33480C1 VA: 0x3347FC0
	private static int LuaComparerToClrComparer(DynValue dynValue1, DynValue dynValue2) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11E30 Offset: 0x11F31 VA: 0x11E30
	// RVA: 0x3348080 Offset: 0x3348181 VA: 0x3348080
	public static DynValue insert(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11E40 Offset: 0x11F41 VA: 0x11E40
	// RVA: 0x33482D0 Offset: 0x33483D1 VA: 0x33482D0
	public static DynValue remove(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11E50 Offset: 0x11F51 VA: 0x11E50
	// RVA: 0x3348550 Offset: 0x3348651 VA: 0x3348550
	public static DynValue concat(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x3347650 Offset: 0x3347751 VA: 0x3347650
	private static int GetTableLength(ScriptExecutionContext executionContext, DynValue vlist) { }

	// RVA: 0x3348910 Offset: 0x3348A11 VA: 0x3348910
	public void .ctor() { }
}

// Namespace: MoonSharp.Interpreter.CoreLib
[MoonSharpModuleAttribute] // RVA: 0xDEE0 Offset: 0xDFE1 VA: 0xDEE0
public class TableModule_Globals // TypeDefIndex: 6250
{
	// Methods

	[MoonSharpModuleMethodAttribute] // RVA: 0x11E60 Offset: 0x11F61 VA: 0x11E60
	// RVA: 0x3348920 Offset: 0x3348A21 VA: 0x3348920
	public static DynValue unpack(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11E70 Offset: 0x11F71 VA: 0x11E70
	// RVA: 0x3348930 Offset: 0x3348A31 VA: 0x3348930
	public static DynValue pack(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x3348940 Offset: 0x3348A41 VA: 0x3348940
	public void .ctor() { }
}

