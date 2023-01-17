// Namespace: MoonSharp.Interpreter.Tree.Statements
internal class ForEachLoopStatement : Statement // TypeDefIndex: 6005
{
	// Fields
	private RuntimeScopeBlock m_StackFrame; // 0x20
	private SymbolRef[] m_Names; // 0x28
	private IVariable[] m_NameExps; // 0x30
	private Expression m_RValues; // 0x38
	private Statement m_Block; // 0x40
	private SourceRef m_RefFor; // 0x48
	private SourceRef m_RefEnd; // 0x50

	// Methods

	// RVA: 0x3311410 Offset: 0x3311511 VA: 0x3311410
	public void .ctor(ScriptLoadingContext lcontext, Token firstNameToken, Token forToken) { }

	// RVA: 0x33118C0 Offset: 0x33119C1 VA: 0x33118C0 Slot: 4
	public override void Compile(ByteCode bc) { }
}

