// Namespace: MoonSharp.Interpreter.Tree.Statements
internal class ChunkStatement : Statement, IClosureBuilder // TypeDefIndex: 6001
{
	// Fields
	private Statement m_Block; // 0x20
	private RuntimeScopeFrame m_StackFrame; // 0x28
	private SymbolRef m_Env; // 0x30
	private SymbolRef m_VarArgs; // 0x38

	// Methods

	// RVA: 0x30F6DD0 Offset: 0x30F6ED1 VA: 0x30F6DD0
	public void .ctor(ScriptLoadingContext lcontext) { }

	// RVA: 0x30F7140 Offset: 0x30F7241 VA: 0x30F7140 Slot: 4
	public override void Compile(ByteCode bc) { }

	// RVA: 0x30F7420 Offset: 0x30F7521 VA: 0x30F7420 Slot: 5
	public SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol) { }
}

