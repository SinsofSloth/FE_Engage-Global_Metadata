// Namespace: MoonSharp.Interpreter
public class TailCallData // TypeDefIndex: 5950
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE280 Offset: 0xE381 VA: 0xE280
	private DynValue <Function>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xE290 Offset: 0xE391 VA: 0xE290
	private DynValue[] <Args>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE2A0 Offset: 0xE3A1 VA: 0xE2A0
	private CallbackFunction <Continuation>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE2B0 Offset: 0xE3B1 VA: 0xE2B0
	private CallbackFunction <ErrorHandler>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xE2C0 Offset: 0xE3C1 VA: 0xE2C0
	private DynValue <ErrorHandlerBeforeUnwind>k__BackingField; // 0x30

	// Properties
	public DynValue Function { get; set; }
	public DynValue[] Args { get; set; }
	public CallbackFunction Continuation { get; set; }
	public CallbackFunction ErrorHandler { get; set; }
	public DynValue ErrorHandlerBeforeUnwind { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xF970 Offset: 0xFA71 VA: 0xF970
	// RVA: 0x3348BD0 Offset: 0x3348CD1 VA: 0x3348BD0
	public DynValue get_Function() { }

	[CompilerGeneratedAttribute] // RVA: 0xF980 Offset: 0xFA81 VA: 0xF980
	// RVA: 0x3348BE0 Offset: 0x3348CE1 VA: 0x3348BE0
	public void set_Function(DynValue value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF990 Offset: 0xFA91 VA: 0xF990
	// RVA: 0x3348BF0 Offset: 0x3348CF1 VA: 0x3348BF0
	public DynValue[] get_Args() { }

	[CompilerGeneratedAttribute] // RVA: 0xF9A0 Offset: 0xFAA1 VA: 0xF9A0
	// RVA: 0x3348C00 Offset: 0x3348D01 VA: 0x3348C00
	public void set_Args(DynValue[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF9B0 Offset: 0xFAB1 VA: 0xF9B0
	// RVA: 0x3348C10 Offset: 0x3348D11 VA: 0x3348C10
	public CallbackFunction get_Continuation() { }

	[CompilerGeneratedAttribute] // RVA: 0xF9C0 Offset: 0xFAC1 VA: 0xF9C0
	// RVA: 0x3348C20 Offset: 0x3348D21 VA: 0x3348C20
	public void set_Continuation(CallbackFunction value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF9D0 Offset: 0xFAD1 VA: 0xF9D0
	// RVA: 0x3348C30 Offset: 0x3348D31 VA: 0x3348C30
	public CallbackFunction get_ErrorHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0xF9E0 Offset: 0xFAE1 VA: 0xF9E0
	// RVA: 0x3348C40 Offset: 0x3348D41 VA: 0x3348C40
	public void set_ErrorHandler(CallbackFunction value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF9F0 Offset: 0xFAF1 VA: 0xF9F0
	// RVA: 0x3348C50 Offset: 0x3348D51 VA: 0x3348C50
	public DynValue get_ErrorHandlerBeforeUnwind() { }

	[CompilerGeneratedAttribute] // RVA: 0xFA00 Offset: 0xFB01 VA: 0xFA00
	// RVA: 0x3348C60 Offset: 0x3348D61 VA: 0x3348C60
	public void set_ErrorHandlerBeforeUnwind(DynValue value) { }

	// RVA: 0x3348C70 Offset: 0x3348D71 VA: 0x3348C70
	public void .ctor() { }
}

