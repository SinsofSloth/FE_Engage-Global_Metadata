// Namespace: MoonSharp.Interpreter
public class DynamicExpression : IScriptPrivateResource // TypeDefIndex: 5961
{
	// Fields
	private DynamicExprExpression m_Exp; // 0x10
	private DynValue m_Constant; // 0x18
	public readonly string ExpressionCode; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE370 Offset: 0xE471 VA: 0xE370
	private Script <OwnerScript>k__BackingField; // 0x28

	// Properties
	public Script OwnerScript { get; set; }

	// Methods

	// RVA: 0x33053E0 Offset: 0x33054E1 VA: 0x33053E0
	internal void .ctor(Script S, string strExpr, DynamicExprExpression expr) { }

	// RVA: 0x3305450 Offset: 0x3305551 VA: 0x3305450
	internal void .ctor(Script S, string strExpr, DynValue constant) { }

	// RVA: 0x3304C90 Offset: 0x3304D91 VA: 0x3304C90
	public DynValue Evaluate(ScriptExecutionContext context) { }

	// RVA: 0x33054C0 Offset: 0x33055C1 VA: 0x33054C0
	public SymbolRef FindSymbol(ScriptExecutionContext context) { }

	[CompilerGeneratedAttribute] // RVA: 0xFB50 Offset: 0xFC51 VA: 0xFB50
	// RVA: 0x3305520 Offset: 0x3305621 VA: 0x3305520 Slot: 4
	public Script get_OwnerScript() { }

	[CompilerGeneratedAttribute] // RVA: 0xFB60 Offset: 0xFC61 VA: 0xFB60
	// RVA: 0x3305530 Offset: 0x3305631 VA: 0x3305530
	private void set_OwnerScript(Script value) { }

	// RVA: 0x3305540 Offset: 0x3305641 VA: 0x3305540
	public bool IsConstant() { }

	// RVA: 0x3305550 Offset: 0x3305651 VA: 0x3305550 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3305560 Offset: 0x3305661 VA: 0x3305560 Slot: 0
	public override bool Equals(object obj) { }
}

