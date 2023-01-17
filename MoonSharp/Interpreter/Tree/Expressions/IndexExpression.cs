// Namespace: MoonSharp.Interpreter.Tree.Expressions
internal class IndexExpression : Expression, IVariable // TypeDefIndex: 6029
{
	// Fields
	private Expression m_BaseExp; // 0x20
	private Expression m_IndexExp; // 0x28
	private string m_Name; // 0x30

	// Methods

	// RVA: 0x330CDF0 Offset: 0x330CEF1 VA: 0x330CDF0
	public void .ctor(Expression baseExp, Expression indexExp, ScriptLoadingContext lcontext) { }

	// RVA: 0x330CD90 Offset: 0x330CE91 VA: 0x330CD90
	public void .ctor(Expression baseExp, string name, ScriptLoadingContext lcontext) { }

	// RVA: 0x3317430 Offset: 0x3317531 VA: 0x3317430 Slot: 4
	public override void Compile(ByteCode bc) { }

	// RVA: 0x33175A0 Offset: 0x33176A1 VA: 0x33175A0 Slot: 8
	public void CompileAssignment(ByteCode bc, int stackofs, int tupleidx) { }

	// RVA: 0x3317730 Offset: 0x3317831 VA: 0x3317730 Slot: 6
	public override DynValue Eval(ScriptExecutionContext context) { }
}

