// Namespace: MoonSharp.Interpreter.Tree.Statements
internal class FunctionDefinitionStatement : Statement // TypeDefIndex: 6009
{
	// Fields
	private SymbolRef m_FuncSymbol; // 0x20
	private SourceRef m_SourceRef; // 0x28
	private bool m_Local; // 0x30
	private bool m_IsMethodCallingConvention; // 0x31
	private string m_MethodName; // 0x38
	private string m_FriendlyName; // 0x40
	private List<string> m_TableAccessors; // 0x48
	private FunctionDefinitionExpression m_FuncDef; // 0x50

	// Methods

	// RVA: 0x3314210 Offset: 0x3314311 VA: 0x3314210
	public void .ctor(ScriptLoadingContext lcontext, bool local, Token localToken) { }

	// RVA: 0x33146E0 Offset: 0x33147E1 VA: 0x33146E0 Slot: 4
	public override void Compile(ByteCode bc) { }

	// RVA: 0x3314A60 Offset: 0x3314B61 VA: 0x3314A60
	private int SetMethod(ByteCode bc) { }

	// RVA: 0x3314C30 Offset: 0x3314D31 VA: 0x3314C30
	private int SetFunction(ByteCode bc, int numPop) { }
}

