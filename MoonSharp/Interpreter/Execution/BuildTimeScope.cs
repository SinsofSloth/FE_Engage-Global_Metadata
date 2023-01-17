// Namespace: MoonSharp.Interpreter.Execution
internal class BuildTimeScope // TypeDefIndex: 6176
{
	// Fields
	private List<BuildTimeScopeFrame> m_Frames; // 0x10
	private List<IClosureBuilder> m_ClosureBuilders; // 0x18

	// Methods

	// RVA: 0x30F0530 Offset: 0x30F0631 VA: 0x30F0530
	public void PushFunction(IClosureBuilder closureBuilder, bool hasVarArgs) { }

	// RVA: 0x30F06D0 Offset: 0x30F07D1 VA: 0x30F06D0
	public void PushBlock() { }

	// RVA: 0x30F0850 Offset: 0x30F0951 VA: 0x30F0850
	public RuntimeScopeBlock PopBlock() { }

	// RVA: 0x30F0940 Offset: 0x30F0A41 VA: 0x30F0940
	public RuntimeScopeFrame PopFunction() { }

	// RVA: 0x30F0B40 Offset: 0x30F0C41 VA: 0x30F0B40
	public SymbolRef Find(string name) { }

	// RVA: 0x30F0EE0 Offset: 0x30F0FE1 VA: 0x30F0EE0
	public SymbolRef CreateGlobalReference(string name) { }

	// RVA: 0x30F0FE0 Offset: 0x30F10E1 VA: 0x30F0FE0
	public void ForceEnvUpValue() { }

	// RVA: 0x30F0D60 Offset: 0x30F0E61 VA: 0x30F0D60
	private SymbolRef CreateUpValue(BuildTimeScope buildTimeScope, SymbolRef symb, int closuredFrame, int currentFrame) { }

	// RVA: 0x30F1040 Offset: 0x30F1141 VA: 0x30F1040
	public SymbolRef DefineLocal(string name) { }

	// RVA: 0x30E7050 Offset: 0x30E7151 VA: 0x30E7050
	public SymbolRef TryDefineLocal(string name) { }

	// RVA: 0x30F1150 Offset: 0x30F1251 VA: 0x30F1150
	public bool CurrentFunctionHasVarArgs() { }

	// RVA: 0x30F11B0 Offset: 0x30F12B1 VA: 0x30F11B0
	internal void DefineLabel(LabelStatement label) { }

	// RVA: 0x30F1230 Offset: 0x30F1331 VA: 0x30F1230
	internal void RegisterGoto(GotoStatement gotostat) { }

	// RVA: 0x30F12B0 Offset: 0x30F13B1 VA: 0x30F12B0
	public void .ctor() { }
}

