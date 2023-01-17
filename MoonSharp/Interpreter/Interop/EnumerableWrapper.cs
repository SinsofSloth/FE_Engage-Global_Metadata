// Namespace: MoonSharp.Interpreter.Interop
internal class EnumerableWrapper : IUserDataType // TypeDefIndex: 6073
{
	// Fields
	private IEnumerator m_Enumerator; // 0x10
	private Script m_Script; // 0x18
	private DynValue m_Prev; // 0x20
	private bool m_HasTurnOnce; // 0x28

	// Methods

	// RVA: 0x3307510 Offset: 0x3307611 VA: 0x3307510
	private void .ctor(Script script, IEnumerator enumerator) { }

	// RVA: 0x3307620 Offset: 0x3307721 VA: 0x3307620
	public void Reset() { }

	// RVA: 0x33076E0 Offset: 0x33077E1 VA: 0x33076E0
	private DynValue GetNext(DynValue prev) { }

	// RVA: 0x3307970 Offset: 0x3307A71 VA: 0x3307970
	private DynValue LuaIteratorCallback(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x33079B0 Offset: 0x3307AB1 VA: 0x33079B0
	internal static DynValue ConvertIterator(Script script, IEnumerator enumerator) { }

	// RVA: 0x3307C40 Offset: 0x3307D41 VA: 0x3307C40
	internal static DynValue ConvertTable(Table table) { }

	// RVA: 0x3307D00 Offset: 0x3307E01 VA: 0x3307D00 Slot: 4
	public DynValue Index(Script script, DynValue index, bool isDirectIndexing) { }

	// RVA: 0x3307FF0 Offset: 0x33080F1 VA: 0x3307FF0 Slot: 5
	public bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing) { }

	// RVA: 0x3308000 Offset: 0x3308101 VA: 0x3308000 Slot: 6
	public DynValue MetaIndex(Script script, string metaname) { }

	[CompilerGeneratedAttribute] // RVA: 0x105A0 Offset: 0x106A1 VA: 0x105A0
	// RVA: 0x3308110 Offset: 0x3308211 VA: 0x3308110
	private DynValue <Index>b__10_0(ScriptExecutionContext ctx, CallbackArguments args) { }

	[CompilerGeneratedAttribute] // RVA: 0x105B0 Offset: 0x106B1 VA: 0x105B0
	// RVA: 0x33081F0 Offset: 0x33082F1 VA: 0x33081F0
	private DynValue <Index>b__10_1(ScriptExecutionContext ctx, CallbackArguments args) { }
}

