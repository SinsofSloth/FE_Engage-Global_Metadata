// Namespace: MoonSharp.Interpreter.Interop.StandardDescriptors
internal class EventFacade : IUserDataType // TypeDefIndex: 6137
{
	// Fields
	private Func<object, ScriptExecutionContext, CallbackArguments, DynValue> m_AddCallback; // 0x10
	private Func<object, ScriptExecutionContext, CallbackArguments, DynValue> m_RemoveCallback; // 0x18
	private object m_Object; // 0x20

	// Methods

	// RVA: 0x33093C0 Offset: 0x33094C1 VA: 0x33093C0
	public void .ctor(EventMemberDescriptor parent, object obj) { }

	// RVA: 0x33094D0 Offset: 0x33095D1 VA: 0x33094D0
	public void .ctor(Func<object, ScriptExecutionContext, CallbackArguments, DynValue> addCallback, Func<object, ScriptExecutionContext, CallbackArguments, DynValue> removeCallback, object obj) { }

	// RVA: 0x3309540 Offset: 0x3309641 VA: 0x3309540 Slot: 4
	public DynValue Index(Script script, DynValue index, bool isDirectIndexing) { }

	// RVA: 0x33096F0 Offset: 0x33097F1 VA: 0x33096F0 Slot: 5
	public bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing) { }

	// RVA: 0x3309750 Offset: 0x3309851 VA: 0x3309750 Slot: 6
	public DynValue MetaIndex(Script script, string metaname) { }

	[CompilerGeneratedAttribute] // RVA: 0x10B40 Offset: 0x10C41 VA: 0x10B40
	// RVA: 0x3309760 Offset: 0x3309861 VA: 0x3309760
	private DynValue <Index>b__5_0(ScriptExecutionContext c, CallbackArguments a) { }

	[CompilerGeneratedAttribute] // RVA: 0x10B50 Offset: 0x10C51 VA: 0x10B50
	// RVA: 0x33097D0 Offset: 0x33098D1 VA: 0x33097D0
	private DynValue <Index>b__5_1(ScriptExecutionContext c, CallbackArguments a) { }
}

