// Namespace: MoonSharp.Interpreter.Tree.Statements
internal class WhileStatement : Statement // TypeDefIndex: 6017
{
	// Fields
	private Expression m_Condition; // 0x20
	private Statement m_Block; // 0x28
	private RuntimeScopeBlock m_StackFrame; // 0x30
	private SourceRef m_Start; // 0x38
	private SourceRef m_End; // 0x40

	// Methods

	// RVA: 0x3355370 Offset: 0x3355471 VA: 0x3355370
	public void .ctor(ScriptLoadingContext lcontext) { }

	// RVA: 0x33555B0 Offset: 0x33556B1 VA: 0x33555B0 Slot: 4
	public override void Compile(ByteCode bc) { }
}

