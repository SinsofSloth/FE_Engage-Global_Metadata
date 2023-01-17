// Namespace: MoonSharp.Interpreter.Tree.Expressions
internal class SymbolRefExpression : Expression, IVariable // TypeDefIndex: 6031
{
	// Fields
	private SymbolRef m_Ref; // 0x20
	private string m_VarName; // 0x28

	// Methods

	// RVA: 0x3029A60 Offset: 0x3029B61 VA: 0x3029A60
	public void .ctor(Token T, ScriptLoadingContext lcontext) { }

	// RVA: 0x3029C10 Offset: 0x3029D11 VA: 0x3029C10
	public void .ctor(ScriptLoadingContext lcontext, SymbolRef refr) { }

	// RVA: 0x3029CB0 Offset: 0x3029DB1 VA: 0x3029CB0 Slot: 4
	public override void Compile(ByteCode bc) { }

	// RVA: 0x3029CD0 Offset: 0x3029DD1 VA: 0x3029CD0 Slot: 8
	public void CompileAssignment(ByteCode bc, int stackofs, int tupleidx) { }

	// RVA: 0x3029CF0 Offset: 0x3029DF1 VA: 0x3029CF0 Slot: 6
	public override DynValue Eval(ScriptExecutionContext context) { }

	// RVA: 0x3029D30 Offset: 0x3029E31 VA: 0x3029D30 Slot: 7
	public override SymbolRef FindDynamic(ScriptExecutionContext context) { }
}

