// Namespace: MoonSharp.Interpreter.Tree.Statements
internal class ScopeBlockStatement : Statement // TypeDefIndex: 6016
{
	// Fields
	private Statement m_Block; // 0x20
	private RuntimeScopeBlock m_StackFrame; // 0x28
	private SourceRef m_Do; // 0x30
	private SourceRef m_End; // 0x38

	// Methods

	// RVA: 0x3015F00 Offset: 0x3016001 VA: 0x3015F00
	public void .ctor(ScriptLoadingContext lcontext) { }

	// RVA: 0x3016050 Offset: 0x3016151 VA: 0x3016050 Slot: 4
	public override void Compile(ByteCode bc) { }
}

