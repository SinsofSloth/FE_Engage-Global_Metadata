// Namespace: MoonSharp.Interpreter.Tree.Statements
internal class RepeatStatement : Statement // TypeDefIndex: 6014
{
	// Fields
	private Expression m_Condition; // 0x20
	private Statement m_Block; // 0x28
	private RuntimeScopeBlock m_StackFrame; // 0x30
	private SourceRef m_Repeat; // 0x38
	private SourceRef m_Until; // 0x40

	// Methods

	// RVA: 0x3013DF0 Offset: 0x3013EF1 VA: 0x3013DF0
	public void .ctor(ScriptLoadingContext lcontext) { }

	// RVA: 0x3013F90 Offset: 0x3014091 VA: 0x3013F90 Slot: 4
	public override void Compile(ByteCode bc) { }
}

