// Namespace: MoonSharp.Interpreter.Interop.LuaStateInterop
public class LuaState // TypeDefIndex: 6149
{
	// Fields
	private List<DynValue> m_Stack; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xE9D0 Offset: 0xEAD1 VA: 0xE9D0
	private ScriptExecutionContext <ExecutionContext>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE9E0 Offset: 0xEAE1 VA: 0xE9E0
	private string <FunctionName>k__BackingField; // 0x20

	// Properties
	public ScriptExecutionContext ExecutionContext { get; set; }
	public string FunctionName { get; set; }
	public int Count { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x10C20 Offset: 0x10D21 VA: 0x10C20
	// RVA: 0x2BB1960 Offset: 0x2BB1A61 VA: 0x2BB1960
	public ScriptExecutionContext get_ExecutionContext() { }

	[CompilerGeneratedAttribute] // RVA: 0x10C30 Offset: 0x10D31 VA: 0x10C30
	// RVA: 0x2BB1970 Offset: 0x2BB1A71 VA: 0x2BB1970
	private void set_ExecutionContext(ScriptExecutionContext value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10C40 Offset: 0x10D41 VA: 0x10C40
	// RVA: 0x2BB1980 Offset: 0x2BB1A81 VA: 0x2BB1980
	public string get_FunctionName() { }

	[CompilerGeneratedAttribute] // RVA: 0x10C50 Offset: 0x10D51 VA: 0x10C50
	// RVA: 0x2BB1990 Offset: 0x2BB1A91 VA: 0x2BB1990
	private void set_FunctionName(string value) { }

	// RVA: 0x2BB19A0 Offset: 0x2BB1AA1 VA: 0x2BB19A0
	internal void .ctor(ScriptExecutionContext executionContext, CallbackArguments args, string functionName) { }

	// RVA: 0x2BB1AD0 Offset: 0x2BB1BD1 VA: 0x2BB1AD0
	public DynValue Top(int pos = 0) { }

	// RVA: 0x2BAF110 Offset: 0x2BAF211 VA: 0x2BAF110
	public DynValue At(int pos) { }

	// RVA: 0x2BAF8D0 Offset: 0x2BAF9D1 VA: 0x2BAF8D0
	public int get_Count() { }

	// RVA: 0x2BAF430 Offset: 0x2BAF531 VA: 0x2BAF430
	public void Push(DynValue v) { }

	// RVA: 0x2BAF590 Offset: 0x2BAF691 VA: 0x2BAF590
	public DynValue Pop() { }

	// RVA: 0x2BB0560 Offset: 0x2BB0661 VA: 0x2BB0560
	public DynValue[] GetTopArray(int num) { }

	// RVA: 0x2BB1B50 Offset: 0x2BB1C51 VA: 0x2BB1B50
	public DynValue GetReturnValue(int retvals) { }

	// RVA: 0x2BB06B0 Offset: 0x2BB07B1 VA: 0x2BB06B0
	public void Discard(int nargs) { }
}

