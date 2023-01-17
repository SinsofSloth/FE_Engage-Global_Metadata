// Namespace: MoonSharp.Interpreter.Tree.Expressions
internal class FunctionDefinitionExpression : Expression, IClosureBuilder // TypeDefIndex: 6028
{
	// Fields
	private SymbolRef[] m_ParamNames; // 0x20
	private Statement m_Statement; // 0x28
	private RuntimeScopeFrame m_StackFrame; // 0x30
	private List<SymbolRef> m_Closure; // 0x38
	private bool m_HasVarArgs; // 0x40
	private Instruction m_ClosureInstruction; // 0x48
	private bool m_UsesGlobalEnv; // 0x50
	private SymbolRef m_Env; // 0x58
	private SourceRef m_Begin; // 0x60
	private SourceRef m_End; // 0x68

	// Methods

	// RVA: 0x3312EB0 Offset: 0x3312FB1 VA: 0x3312EB0
	public void .ctor(ScriptLoadingContext lcontext, bool usesGlobalEnv) { }

	// RVA: 0x330C790 Offset: 0x330C891 VA: 0x330C790
	public void .ctor(ScriptLoadingContext lcontext, bool pushSelfParam, bool isLambda) { }

	// RVA: 0x3312EC0 Offset: 0x3312FC1 VA: 0x3312EC0
	private void .ctor(ScriptLoadingContext lcontext, bool pushSelfParam, bool usesGlobalEnv, bool isLambda) { }

	// RVA: 0x3313710 Offset: 0x3313811 VA: 0x3313710
	private Statement CreateLambdaBody(ScriptLoadingContext lcontext) { }

	// RVA: 0x3313840 Offset: 0x3313941 VA: 0x3313840
	private Statement CreateBody(ScriptLoadingContext lcontext) { }

	// RVA: 0x3313130 Offset: 0x3313231 VA: 0x3313130
	private List<string> BuildParamList(ScriptLoadingContext lcontext, bool pushSelfParam, Token openBracketToken, bool isLambda) { }

	// RVA: 0x33134C0 Offset: 0x33135C1 VA: 0x33134C0
	private SymbolRef[] DefineArguments(List<string> paramnames, ScriptLoadingContext lcontext) { }

	// RVA: 0x3313A60 Offset: 0x3313B61 VA: 0x3313A60 Slot: 8
	public SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol) { }

	// RVA: 0x3313BE0 Offset: 0x3313CE1 VA: 0x3313BE0 Slot: 6
	public override DynValue Eval(ScriptExecutionContext context) { }

	// RVA: 0x3313C30 Offset: 0x3313D31 VA: 0x3313C30
	public int CompileBody(ByteCode bc, string friendlyName) { }

	// RVA: 0x3313EF0 Offset: 0x3313FF1 VA: 0x3313EF0
	public int Compile(ByteCode bc, Func<int> afterDecl, string friendlyName) { }

	// RVA: 0x33140E0 Offset: 0x33141E1 VA: 0x33140E0 Slot: 4
	public override void Compile(ByteCode bc) { }
}

