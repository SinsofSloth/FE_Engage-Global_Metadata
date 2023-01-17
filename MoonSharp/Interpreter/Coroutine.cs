// Namespace: MoonSharp.Interpreter
public class Coroutine : RefIdObject, IScriptPrivateResource // TypeDefIndex: 5934
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE220 Offset: 0xE321 VA: 0xE220
	private Coroutine.CoroutineType <Type>k__BackingField; // 0x14
	private CallbackFunction m_ClrCallback; // 0x18
	private Processor m_Processor; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE230 Offset: 0xE331 VA: 0xE230
	private Script <OwnerScript>k__BackingField; // 0x28

	// Properties
	public Coroutine.CoroutineType Type { get; set; }
	public CoroutineState State { get; }
	public Script OwnerScript { get; set; }
	public long AutoYieldCounter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xF4D0 Offset: 0xF5D1 VA: 0xF4D0
	// RVA: 0x30F99F0 Offset: 0x30F9AF1 VA: 0x30F99F0
	public Coroutine.CoroutineType get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0xF4E0 Offset: 0xF5E1 VA: 0xF4E0
	// RVA: 0x30F9A00 Offset: 0x30F9B01 VA: 0x30F9A00
	private void set_Type(Coroutine.CoroutineType value) { }

	// RVA: 0x30F9A10 Offset: 0x30F9B11 VA: 0x30F9A10
	internal void .ctor(CallbackFunction function) { }

	// RVA: 0x30F9AB0 Offset: 0x30F9BB1 VA: 0x30F9AB0
	internal void .ctor(Processor proc) { }

	// RVA: 0x30F9B60 Offset: 0x30F9C61 VA: 0x30F9B60
	internal void MarkClrCallbackAsDead() { }

	[IteratorStateMachineAttribute] // RVA: 0xF4F0 Offset: 0xF5F1 VA: 0xF4F0
	// RVA: 0x30F9BE0 Offset: 0x30F9CE1 VA: 0x30F9BE0
	public IEnumerable<DynValue> AsTypedEnumerable() { }

	[IteratorStateMachineAttribute] // RVA: 0xF560 Offset: 0xF661 VA: 0xF560
	// RVA: 0x30F9C60 Offset: 0x30F9D61 VA: 0x30F9C60
	public IEnumerable<object> AsEnumerable() { }

	[IteratorStateMachineAttribute] // RVA: 0xF5D0 Offset: 0xF6D1 VA: 0xF5D0
	// RVA: -1 Offset: -1
	public IEnumerable<T> AsEnumerable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229D500 Offset: 0x229D601 VA: 0x229D500
	|-Coroutine.AsEnumerable<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xF640 Offset: 0xF741 VA: 0xF640
	// RVA: 0x30F9CE0 Offset: 0x30F9DE1 VA: 0x30F9CE0
	public IEnumerator AsUnityCoroutine() { }

	// RVA: 0x30F9D60 Offset: 0x30F9E61 VA: 0x30F9D60
	public DynValue Resume(DynValue[] args) { }

	// RVA: 0x30F9DF0 Offset: 0x30F9EF1 VA: 0x30F9DF0
	public DynValue Resume(ScriptExecutionContext context, DynValue[] args) { }

	// RVA: 0x30F9EF0 Offset: 0x30F9FF1 VA: 0x30F9EF0
	public DynValue Resume() { }

	// RVA: 0x30F9F50 Offset: 0x30FA051 VA: 0x30F9F50
	public DynValue Resume(ScriptExecutionContext context) { }

	// RVA: 0x30F9FC0 Offset: 0x30FA0C1 VA: 0x30F9FC0
	public DynValue Resume(object[] args) { }

	// RVA: 0x30FA170 Offset: 0x30FA271 VA: 0x30FA170
	public DynValue Resume(ScriptExecutionContext context, object[] args) { }

	// RVA: 0x30FA2D0 Offset: 0x30FA3D1 VA: 0x30FA2D0
	public CoroutineState get_State() { }

	// RVA: 0x30FA300 Offset: 0x30FA401 VA: 0x30FA300
	public WatchItem[] GetStackTrace(int skip, SourceRef entrySourceRef) { }

	[CompilerGeneratedAttribute] // RVA: 0xF6B0 Offset: 0xF7B1 VA: 0xF6B0
	// RVA: 0x30FA3C0 Offset: 0x30FA4C1 VA: 0x30FA3C0 Slot: 4
	public Script get_OwnerScript() { }

	[CompilerGeneratedAttribute] // RVA: 0xF6C0 Offset: 0xF7C1 VA: 0xF6C0
	// RVA: 0x30FA3D0 Offset: 0x30FA4D1 VA: 0x30FA3D0
	private void set_OwnerScript(Script value) { }

	// RVA: 0x30FA3E0 Offset: 0x30FA4E1 VA: 0x30FA3E0
	public long get_AutoYieldCounter() { }

	// RVA: 0x30FA3F0 Offset: 0x30FA4F1 VA: 0x30FA3F0
	public void set_AutoYieldCounter(long value) { }
}

