// Namespace: MoonSharp.Interpreter.CoreLib
[MoonSharpModuleAttribute] // RVA: 0xDC30 Offset: 0xDD31 VA: 0xDC30
public class ErrorHandlingModule // TypeDefIndex: 6235
{
	// Methods

	[MoonSharpModuleMethodAttribute] // RVA: 0x118E0 Offset: 0x119E1 VA: 0x118E0
	// RVA: 0x3308380 Offset: 0x3308481 VA: 0x3308380
	public static DynValue pcall(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x33083E0 Offset: 0x33084E1 VA: 0x33083E0
	private static DynValue SetErrorHandlerStrategy(string funcName, ScriptExecutionContext executionContext, CallbackArguments args, DynValue handlerBeforeUnwind) { }

	// RVA: 0x3308E40 Offset: 0x3308F41 VA: 0x3308E40
	private static DynValue MakeReturnTuple(bool retstatus, CallbackArguments args) { }

	// RVA: 0x3308FC0 Offset: 0x33090C1 VA: 0x3308FC0
	public static DynValue pcall_continuation(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x3308FD0 Offset: 0x33090D1 VA: 0x3308FD0
	public static DynValue pcall_onerror(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x118F0 Offset: 0x119F1 VA: 0x118F0
	// RVA: 0x3308FE0 Offset: 0x33090E1 VA: 0x3308FE0
	public static DynValue xpcall(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x33091D0 Offset: 0x33092D1 VA: 0x33091D0
	public void .ctor() { }
}

