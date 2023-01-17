// Namespace: MoonSharp.Interpreter
public class Closure : RefIdObject, IScriptPrivateResource // TypeDefIndex: 5928
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE1F0 Offset: 0xE2F1 VA: 0xE1F0
	private int <EntryPointByteCodeLocation>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0xE200 Offset: 0xE301 VA: 0xE200
	private Script <OwnerScript>k__BackingField; // 0x18
	private static ClosureContext emptyClosure; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xE210 Offset: 0xE311 VA: 0xE210
	private ClosureContext <ClosureContext>k__BackingField; // 0x20

	// Properties
	public int EntryPointByteCodeLocation { get; set; }
	public Script OwnerScript { get; set; }
	internal ClosureContext ClosureContext { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xF450 Offset: 0xF551 VA: 0xF450
	// RVA: 0x30F7430 Offset: 0x30F7531 VA: 0x30F7430
	public int get_EntryPointByteCodeLocation() { }

	[CompilerGeneratedAttribute] // RVA: 0xF460 Offset: 0xF561 VA: 0xF460
	// RVA: 0x30F7440 Offset: 0x30F7541 VA: 0x30F7440
	private void set_EntryPointByteCodeLocation(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF470 Offset: 0xF571 VA: 0xF470
	// RVA: 0x30F7450 Offset: 0x30F7551 VA: 0x30F7450 Slot: 4
	public Script get_OwnerScript() { }

	[CompilerGeneratedAttribute] // RVA: 0xF480 Offset: 0xF581 VA: 0xF480
	// RVA: 0x30F7460 Offset: 0x30F7561 VA: 0x30F7460
	private void set_OwnerScript(Script value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF490 Offset: 0xF591 VA: 0xF490
	// RVA: 0x30F7470 Offset: 0x30F7571 VA: 0x30F7470
	internal ClosureContext get_ClosureContext() { }

	[CompilerGeneratedAttribute] // RVA: 0xF4A0 Offset: 0xF5A1 VA: 0xF4A0
	// RVA: 0x30F7480 Offset: 0x30F7581 VA: 0x30F7480
	private void set_ClosureContext(ClosureContext value) { }

	// RVA: 0x30F7490 Offset: 0x30F7591 VA: 0x30F7490
	internal void .ctor(Script script, int idx, SymbolRef[] symbols, IEnumerable<DynValue> resolvedLocals) { }

	// RVA: 0x30F77C0 Offset: 0x30F78C1 VA: 0x30F77C0
	public DynValue Call() { }

	// RVA: 0x30F77D0 Offset: 0x30F78D1 VA: 0x30F77D0
	public DynValue Call(object[] args) { }

	// RVA: 0x30F77F0 Offset: 0x30F78F1 VA: 0x30F77F0
	public DynValue Call(DynValue[] args) { }

	// RVA: 0x30F7810 Offset: 0x30F7911 VA: 0x30F7810
	public ScriptFunctionDelegate GetDelegate() { }

	// RVA: -1 Offset: -1
	public ScriptFunctionDelegate<T> GetDelegate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229AC60 Offset: 0x229AD61 VA: 0x229AC60
	|-Closure.GetDelegate<object>
	*/

	// RVA: 0x30F7890 Offset: 0x30F7991 VA: 0x30F7890
	public int GetUpvaluesCount() { }

	// RVA: 0x30F78E0 Offset: 0x30F79E1 VA: 0x30F78E0
	public string GetUpvalueName(int idx) { }

	// RVA: 0x30F7920 Offset: 0x30F7A21 VA: 0x30F7920
	public DynValue GetUpvalue(int idx) { }

	// RVA: 0x30F7990 Offset: 0x30F7A91 VA: 0x30F7990
	public Closure.UpvaluesType GetUpvaluesType() { }

	// RVA: 0x30F7A70 Offset: 0x30F7B71 VA: 0x30F7A70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0xF4B0 Offset: 0xF5B1 VA: 0xF4B0
	// RVA: 0x30F7BA0 Offset: 0x30F7CA1 VA: 0x30F7BA0
	private object <GetDelegate>b__18_0(object[] args) { }

	[CompilerGeneratedAttribute] // RVA: 0xF4C0 Offset: 0xF5C1 VA: 0xF4C0
	// RVA: -1 Offset: -1
	private T <GetDelegate>b__19_0<T>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229AC30 Offset: 0x229AD31 VA: 0x229AC30
	|-Closure.<GetDelegate>b__19_0<object>
	*/
}

