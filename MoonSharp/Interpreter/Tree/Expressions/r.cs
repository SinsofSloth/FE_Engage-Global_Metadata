// Namespace: MoonSharp.Interpreter.Tree.Expressions
internal class TableConstructor : Expression // TypeDefIndex: 6032
{
	// Fields
	private bool m_Shared; // 0x20
	private List<Expression> m_PositionalValues; // 0x28
	private List<KeyValuePair<Expression, Expression>> m_CtorArgs; // 0x30

	// Methods

	// RVA: 0x3343AF0 Offset: 0x3343BF1 VA: 0x3343AF0
	public void .ctor(ScriptLoadingContext lcontext, bool shared) { }

	// RVA: 0x3343ED0 Offset: 0x3343FD1 VA: 0x3343ED0
	private void MapField(ScriptLoadingContext lcontext) { }

	// RVA: 0x3343D10 Offset: 0x3343E11 VA: 0x3343D10
	private void StructField(ScriptLoadingContext lcontext) { }

	// RVA: 0x3343E60 Offset: 0x3343F61 VA: 0x3343E60
	private void ArrayField(ScriptLoadingContext lcontext) { }

	// RVA: 0x3343FC0 Offset: 0x33440C1 VA: 0x3343FC0 Slot: 4
	public override void Compile(ByteCode bc) { }

	// RVA: 0x33441C0 Offset: 0x33442C1 VA: 0x33441C0 Slot: 6
	public override DynValue Eval(ScriptExecutionContext context) { }
}

