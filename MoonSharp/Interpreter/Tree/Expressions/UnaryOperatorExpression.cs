// Namespace: MoonSharp.Interpreter.Tree.Expressions
internal class UnaryOperatorExpression : Expression // TypeDefIndex: 6033
{
	// Fields
	private Expression m_Exp; // 0x20
	private string m_OpText; // 0x28

	// Methods

	// RVA: 0x3350DB0 Offset: 0x3350EB1 VA: 0x3350DB0
	public void .ctor(ScriptLoadingContext lcontext, Expression subExpression, Token unaryOpToken) { }

	// RVA: 0x3350E00 Offset: 0x3350F01 VA: 0x3350E00 Slot: 4
	public override void Compile(ByteCode bc) { }

	// RVA: 0x3350F70 Offset: 0x3351071 VA: 0x3350F70 Slot: 6
	public override DynValue Eval(ScriptExecutionContext context) { }
}

