// Namespace: MoonSharp.Interpreter.Tree.Expressions
internal class FunctionCallExpression : Expression // TypeDefIndex: 6026
{
	// Fields
	private List<Expression> m_Arguments; // 0x20
	private Expression m_Function; // 0x28
	private string m_Name; // 0x30
	private string m_DebugErr; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xE610 Offset: 0xE711 VA: 0xE610
	private SourceRef <SourceRef>k__BackingField; // 0x40

	// Properties
	internal SourceRef SourceRef { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x10120 Offset: 0x10221 VA: 0x10120
	// RVA: 0x3312AA0 Offset: 0x3312BA1 VA: 0x3312AA0
	internal SourceRef get_SourceRef() { }

	[CompilerGeneratedAttribute] // RVA: 0x10130 Offset: 0x10231 VA: 0x10130
	// RVA: 0x3312AB0 Offset: 0x3312BB1 VA: 0x3312AB0
	private void set_SourceRef(SourceRef value) { }

	// RVA: 0x330CE50 Offset: 0x330CF51 VA: 0x330CE50
	public void .ctor(ScriptLoadingContext lcontext, Expression function, Token thisCallName) { }

	// RVA: 0x3312AC0 Offset: 0x3312BC1 VA: 0x3312AC0 Slot: 4
	public override void Compile(ByteCode bc) { }

	// RVA: 0x3312C60 Offset: 0x3312D61 VA: 0x3312C60 Slot: 6
	public override DynValue Eval(ScriptExecutionContext context) { }
}

