// Namespace: MoonSharp.Interpreter.Tree.Statements
internal class ForLoopStatement : Statement // TypeDefIndex: 6006
{
	// Fields
	private RuntimeScopeBlock m_StackFrame; // 0x20
	private Statement m_InnerBlock; // 0x28
	private SymbolRef m_VarName; // 0x30
	private Expression m_Start; // 0x38
	private Expression m_End; // 0x40
	private Expression m_Step; // 0x48
	private SourceRef m_RefFor; // 0x50
	private SourceRef m_RefEnd; // 0x58

	// Methods

	// RVA: 0x3311CB0 Offset: 0x3311DB1 VA: 0x3311CB0
	public void .ctor(ScriptLoadingContext lcontext, Token nameToken, Token forToken) { }

	// RVA: 0x3311FB0 Offset: 0x33120B1 VA: 0x3311FB0 Slot: 4
	public override void Compile(ByteCode bc) { }
}

