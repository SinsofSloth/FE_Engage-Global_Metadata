// Namespace: MoonSharp.Interpreter
public class ScriptExecutionContext : IScriptPrivateResource // TypeDefIndex: 5962
{
	// Fields
	private Processor m_Processor; // 0x10
	private CallbackFunction m_Callback; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE380 Offset: 0xE481 VA: 0xE380
	private bool <IsDynamicExecution>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE390 Offset: 0xE491 VA: 0xE390
	private SourceRef <CallingLocation>k__BackingField; // 0x28

	// Properties
	public bool IsDynamicExecution { get; set; }
	public SourceRef CallingLocation { get; set; }
	public object AdditionalData { get; set; }
	public Table CurrentGlobalEnv { get; }
	public Script OwnerScript { get; }

	// Methods

	// RVA: 0x3019BB0 Offset: 0x3019CB1 VA: 0x3019BB0
	internal void .ctor(Processor p, CallbackFunction callBackFunction, SourceRef sourceRef, bool isDynamic = False) { }

	[CompilerGeneratedAttribute] // RVA: 0xFB70 Offset: 0xFC71 VA: 0xFB70
	// RVA: 0x3019F80 Offset: 0x301A081 VA: 0x3019F80
	public bool get_IsDynamicExecution() { }

	[CompilerGeneratedAttribute] // RVA: 0xFB80 Offset: 0xFC81 VA: 0xFB80
	// RVA: 0x3019F90 Offset: 0x301A091 VA: 0x3019F90
	private void set_IsDynamicExecution(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFB90 Offset: 0xFC91 VA: 0xFB90
	// RVA: 0x3019FA0 Offset: 0x301A0A1 VA: 0x3019FA0
	public SourceRef get_CallingLocation() { }

	[CompilerGeneratedAttribute] // RVA: 0xFBA0 Offset: 0xFCA1 VA: 0xFBA0
	// RVA: 0x3019FB0 Offset: 0x301A0B1 VA: 0x3019FB0
	private void set_CallingLocation(SourceRef value) { }

	// RVA: 0x3019FC0 Offset: 0x301A0C1 VA: 0x3019FC0
	public object get_AdditionalData() { }

	// RVA: 0x3019FE0 Offset: 0x301A0E1 VA: 0x3019FE0
	public void set_AdditionalData(object value) { }

	// RVA: 0x301A050 Offset: 0x301A151 VA: 0x301A050
	public Table GetMetatable(DynValue value) { }

	// RVA: 0x301A060 Offset: 0x301A161 VA: 0x301A060
	public DynValue GetMetamethod(DynValue value, string metamethod) { }

	// RVA: 0x301A070 Offset: 0x301A171 VA: 0x301A070
	public DynValue GetMetamethodTailCall(DynValue value, string metamethod, DynValue[] args) { }

	// RVA: 0x301A130 Offset: 0x301A231 VA: 0x301A130
	public DynValue GetBinaryMetamethod(DynValue op1, DynValue op2, string eventName) { }

	// RVA: 0x301A140 Offset: 0x301A241 VA: 0x301A140
	public Script GetScript() { }

	// RVA: 0x301A150 Offset: 0x301A251 VA: 0x301A150
	public Coroutine GetCallingCoroutine() { }

	// RVA: 0x301A160 Offset: 0x301A261 VA: 0x301A160
	public DynValue EmulateClassicCall(CallbackArguments args, string functionName, Func<LuaState, int> callback) { }

	// RVA: 0x301A220 Offset: 0x301A321 VA: 0x301A220
	public DynValue Call(DynValue func, DynValue[] args) { }

	// RVA: 0x301A650 Offset: 0x301A751 VA: 0x301A650
	public DynValue EvaluateSymbol(SymbolRef symref) { }

	// RVA: 0x301A740 Offset: 0x301A841 VA: 0x301A740
	public DynValue EvaluateSymbolByName(string symbol) { }

	// RVA: 0x301A770 Offset: 0x301A871 VA: 0x301A770
	public SymbolRef FindSymbolByName(string symbol) { }

	// RVA: 0x301A780 Offset: 0x301A881 VA: 0x301A780
	public Table get_CurrentGlobalEnv() { }

	// RVA: 0x301A810 Offset: 0x301A911 VA: 0x301A810
	public void PerformMessageDecorationBeforeUnwind(DynValue messageHandler, ScriptRuntimeException exception) { }

	// RVA: 0x301A890 Offset: 0x301A991 VA: 0x301A890 Slot: 4
	public Script get_OwnerScript() { }
}

