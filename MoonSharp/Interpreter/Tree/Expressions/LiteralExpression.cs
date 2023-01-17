// Namespace: MoonSharp.Interpreter.Tree.Expressions
internal class LiteralExpression : Expression // TypeDefIndex: 6030
{
	// Fields
	private DynValue m_Value; // 0x20

	// Properties
	public DynValue Value { get; }

	// Methods

	// RVA: 0x2BACDA0 Offset: 0x2BACEA1 VA: 0x2BACDA0
	public DynValue get_Value() { }

	// RVA: 0x2BACDB0 Offset: 0x2BACEB1 VA: 0x2BACDB0
	public void .ctor(ScriptLoadingContext lcontext, DynValue value) { }

	// RVA: 0x2BACDF0 Offset: 0x2BACEF1 VA: 0x2BACDF0
	public void .ctor(ScriptLoadingContext lcontext, Token t) { }

	// RVA: 0x2BAD140 Offset: 0x2BAD241 VA: 0x2BAD140 Slot: 4
	public override void Compile(ByteCode bc) { }

	// RVA: 0x2BAD160 Offset: 0x2BAD261 VA: 0x2BAD160 Slot: 6
	public override DynValue Eval(ScriptExecutionContext context) { }
}

