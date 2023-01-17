// Namespace: MoonSharp.Interpreter.Tree.Statements
internal class AssignmentStatement : Statement // TypeDefIndex: 5999
{
	// Fields
	private List<IVariable> m_LValues; // 0x20
	private List<Expression> m_RValues; // 0x28
	private SourceRef m_Ref; // 0x30

	// Methods

	// RVA: 0x30E6CE0 Offset: 0x30E6DE1 VA: 0x30E6CE0
	public void .ctor(ScriptLoadingContext lcontext, Token startToken) { }

	// RVA: 0x30E7110 Offset: 0x30E7211 VA: 0x30E7110
	public void .ctor(ScriptLoadingContext lcontext, Expression firstExpression, Token first) { }

	// RVA: 0x30E72D0 Offset: 0x30E73D1 VA: 0x30E72D0
	private IVariable CheckVar(ScriptLoadingContext lcontext, Expression firstExpression) { }

	// RVA: 0x30E73E0 Offset: 0x30E74E1 VA: 0x30E73E0 Slot: 4
	public override void Compile(ByteCode bc) { }
}

