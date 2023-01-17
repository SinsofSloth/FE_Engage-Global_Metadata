// Namespace: MoonSharp.Interpreter.Tree.Expressions
internal class ExprListExpression : Expression // TypeDefIndex: 6025
{
	// Fields
	private List<Expression> expressions; // 0x20

	// Methods

	// RVA: 0x330B9E0 Offset: 0x330BAE1 VA: 0x330B9E0
	public void .ctor(List<Expression> exps, ScriptLoadingContext lcontext) { }

	// RVA: 0x330BA20 Offset: 0x330BB21 VA: 0x330BA20
	public Expression[] GetExpressions() { }

	// RVA: 0x330BA80 Offset: 0x330BB81 VA: 0x330BA80 Slot: 4
	public override void Compile(ByteCode bc) { }

	// RVA: 0x330BBD0 Offset: 0x330BCD1 VA: 0x330BBD0 Slot: 6
	public override DynValue Eval(ScriptExecutionContext context) { }
}

