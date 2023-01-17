// Namespace: MoonSharp.Interpreter.Tree.Expressions
internal class DynamicExprExpression : Expression // TypeDefIndex: 6024
{
	// Fields
	private Expression m_Exp; // 0x20

	// Methods

	// RVA: 0x3305320 Offset: 0x3305421 VA: 0x3305320
	public void .ctor(Expression exp, ScriptLoadingContext lcontext) { }

	// RVA: 0x3305380 Offset: 0x3305481 VA: 0x3305380 Slot: 6
	public override DynValue Eval(ScriptExecutionContext context) { }

	// RVA: 0x3305390 Offset: 0x3305491 VA: 0x3305390 Slot: 4
	public override void Compile(ByteCode bc) { }

	// RVA: 0x33053D0 Offset: 0x33054D1 VA: 0x33053D0 Slot: 7
	public override SymbolRef FindDynamic(ScriptExecutionContext context) { }
}

