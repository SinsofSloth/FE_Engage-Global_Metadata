// Namespace: MoonSharp.Interpreter.Execution.VM
internal sealed class Processor // TypeDefIndex: 6197
{
	// Fields
	private ByteCode m_RootChunk; // 0x10
	private FastStack<DynValue> m_ValueStack; // 0x18
	private FastStack<CallStackItem> m_ExecutionStack; // 0x20
	private List<Processor> m_CoroutinesStack; // 0x28
	private Table m_GlobalTable; // 0x30
	private Script m_Script; // 0x38
	private Processor m_Parent; // 0x40
	private CoroutineState m_State; // 0x48
	private bool m_CanYield; // 0x4C
	private int m_SavedInstructionPtr; // 0x50
	private Processor.DebugContext m_Debug; // 0x58
	private int m_OwningThreadID; // 0x60
	private int m_ExecutionNesting; // 0x64
	private const ulong DUMP_CHUNK_MAGIC = 1877195438928383261;
	private const int DUMP_CHUNK_VERSION = 336;
	[CompilerGeneratedAttribute] // RVA: 0xEB60 Offset: 0xEC61 VA: 0xEB60
	private Coroutine <AssociatedCoroutine>k__BackingField; // 0x68
	private const int YIELD_SPECIAL_TRAP = -99;
	internal long AutoYieldCounter; // 0x70

	// Properties
	public CoroutineState State { get; }
	public Coroutine AssociatedCoroutine { get; set; }
	internal bool DebuggerEnabled { get; set; }

	// Methods

	// RVA: 0x2BCA320 Offset: 0x2BCA421 VA: 0x2BCA320
	public void .ctor(Script script, Table globalContext, ByteCode byteCode) { }

	// RVA: 0x2BCA560 Offset: 0x2BCA661 VA: 0x2BCA560
	private void .ctor(Processor parentProcessor) { }

	// RVA: 0x2BCA6C0 Offset: 0x2BCA7C1 VA: 0x2BCA6C0
	public DynValue Call(DynValue function, DynValue[] args) { }

	// RVA: 0x2BCAA30 Offset: 0x2BCAB31 VA: 0x2BCAA30
	private int PushClrToScriptStackFrame(CallStackItemFlags flags, DynValue function, DynValue[] args) { }

	// RVA: 0x2BCBDF0 Offset: 0x2BCBEF1 VA: 0x2BCBDF0
	private void LeaveProcessor() { }

	// RVA: 0x2BCC700 Offset: 0x2BCC801 VA: 0x2BCC700
	private int GetThreadId() { }

	// RVA: 0x2BCA8F0 Offset: 0x2BCA9F1 VA: 0x2BCA8F0
	private void EnterProcessor() { }

	// RVA: 0x2BCC720 Offset: 0x2BCC821 VA: 0x2BCC720
	internal SourceRef GetCoroutineSuspendedLocation() { }

	// RVA: 0x2BCC860 Offset: 0x2BCC961 VA: 0x2BCC860
	internal static bool IsDumpStream(Stream stream) { }

	// RVA: 0x2BCCA30 Offset: 0x2BCCB31 VA: 0x2BCCA30
	internal int Dump(Stream stream, int baseAddress, bool hasUpvalues) { }

	// RVA: 0x2BCD480 Offset: 0x2BCD581 VA: 0x2BCD480
	private void AddSymbolToMap(Dictionary<SymbolRef, int> symbolMap, SymbolRef s) { }

	// RVA: 0x2BCD540 Offset: 0x2BCD641 VA: 0x2BCD540
	internal int Undump(Stream stream, int sourceID, Table envTable, out bool hasUpvalues) { }

	// RVA: 0x2BCDA00 Offset: 0x2BCDB01 VA: 0x2BCDA00
	public DynValue Coroutine_Create(Closure closure) { }

	// RVA: 0x2BCDB00 Offset: 0x2BCDC01 VA: 0x2BCDB00
	public CoroutineState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x11000 Offset: 0x11101 VA: 0x11000
	// RVA: 0x2BCDB10 Offset: 0x2BCDC11 VA: 0x2BCDB10
	public Coroutine get_AssociatedCoroutine() { }

	[CompilerGeneratedAttribute] // RVA: 0x11010 Offset: 0x11111 VA: 0x11010
	// RVA: 0x2BCDB20 Offset: 0x2BCDC21 VA: 0x2BCDB20
	public void set_AssociatedCoroutine(Coroutine value) { }

	// RVA: 0x2BCDB30 Offset: 0x2BCDC31 VA: 0x2BCDB30
	public DynValue Coroutine_Resume(DynValue[] args) { }

	// RVA: 0x2BCD3C0 Offset: 0x2BCD4C1 VA: 0x2BCD3C0
	internal Instruction FindMeta(ref int baseAddress) { }

	// RVA: 0x2BCDE60 Offset: 0x2BCDF61 VA: 0x2BCDE60
	internal void AttachDebugger(IDebugger debugger) { }

	// RVA: 0x2BCDFC0 Offset: 0x2BCE0C1 VA: 0x2BCDFC0
	internal bool get_DebuggerEnabled() { }

	// RVA: 0x2BCDFD0 Offset: 0x2BCE0D1 VA: 0x2BCDFD0
	internal void set_DebuggerEnabled(bool value) { }

	// RVA: 0x2BCDFE0 Offset: 0x2BCE0E1 VA: 0x2BCDFE0
	private void ListenDebugger(Instruction instr, int instructionPtr) { }

	// RVA: 0x2BCEC90 Offset: 0x2BCED91 VA: 0x2BCEC90
	private void ResetBreakPoints(DebuggerAction action) { }

	// RVA: 0x2BCED40 Offset: 0x2BCEE41 VA: 0x2BCED40
	internal HashSet<int> ResetBreakPoints(SourceCode src, HashSet<int> lines) { }

	// RVA: 0x2BCE900 Offset: 0x2BCEA01 VA: 0x2BCE900
	private bool ToggleBreakPoint(DebuggerAction action, Nullable<bool> state) { }

	// RVA: 0x2BCE4A0 Offset: 0x2BCE5A1 VA: 0x2BCE4A0
	private void RefreshDebugger(bool hard, int instructionPtr) { }

	// RVA: 0x2BCF600 Offset: 0x2BCF701 VA: 0x2BCF600
	private List<WatchItem> Debugger_RefreshThreads(ScriptExecutionContext context) { }

	// RVA: 0x2BCF2A0 Offset: 0x2BCF3A1 VA: 0x2BCF2A0
	private List<WatchItem> Debugger_RefreshVStack() { }

	// RVA: 0x2BCF160 Offset: 0x2BCF261 VA: 0x2BCF160
	private List<WatchItem> Debugger_RefreshWatches(ScriptExecutionContext context, List<DynamicExpression> watchList) { }

	// RVA: 0x2BCF410 Offset: 0x2BCF511 VA: 0x2BCF410
	private List<WatchItem> Debugger_RefreshLocals(ScriptExecutionContext context) { }

	// RVA: 0x2BCF760 Offset: 0x2BCF861 VA: 0x2BCF760
	private WatchItem Debugger_RefreshWatch(ScriptExecutionContext context, DynamicExpression dynExpr) { }

	// RVA: 0x2BCEF00 Offset: 0x2BCF001 VA: 0x2BCEF00
	internal List<WatchItem> Debugger_GetCallStack(SourceRef startingRef) { }

	// RVA: 0x2BCC7C0 Offset: 0x2BCC8C1 VA: 0x2BCC7C0
	private SourceRef GetCurrentSourceRef(int instructionPtr) { }

	// RVA: 0x2BCF960 Offset: 0x2BCFA61 VA: 0x2BCF960
	private void FillDebugData(InterpreterException ex, int ip) { }

	// RVA: 0x2BCFA50 Offset: 0x2BCFB51 VA: 0x2BCFA50
	internal Table GetMetatable(DynValue value) { }

	// RVA: 0x2BCFAB0 Offset: 0x2BCFBB1 VA: 0x2BCFAB0
	internal DynValue GetBinaryMetamethod(DynValue op1, DynValue op2, string eventName) { }

	// RVA: 0x2BCFD20 Offset: 0x2BCFE21 VA: 0x2BCFD20
	internal DynValue GetMetamethod(DynValue value, string metamethod) { }

	// RVA: 0x2BCFE90 Offset: 0x2BCFF91 VA: 0x2BCFE90
	internal DynValue GetMetamethodRaw(DynValue value, string metamethod) { }

	// RVA: 0x2BCFF20 Offset: 0x2BD0021 VA: 0x2BCFF20
	internal Script GetScript() { }

	// RVA: 0x2BCFF30 Offset: 0x2BD0031 VA: 0x2BCFF30
	public Instruction GetInstruction(int iAddress) { }

	// RVA: 0x2BCAC50 Offset: 0x2BCAD51 VA: 0x2BCAC50
	private DynValue Processing_Loop(int instructionPtr) { }

	// RVA: 0x2BD4EA0 Offset: 0x2BD4FA1 VA: 0x2BD4EA0
	internal string PerformMessageDecorationBeforeUnwind(DynValue messageHandler, string decoratedMessage, SourceRef sourceRef) { }

	// RVA: 0x2BD5240 Offset: 0x2BD5341 VA: 0x2BD5240
	private void AssignLocal(SymbolRef symref, DynValue value) { }

	// RVA: 0x2BD4160 Offset: 0x2BD4261 VA: 0x2BD4160
	private void ExecStoreLcl(Instruction i) { }

	// RVA: 0x2BD4030 Offset: 0x2BD4131 VA: 0x2BD4030
	private void ExecStoreUpv(Instruction i) { }

	// RVA: 0x2BCFFE0 Offset: 0x2BD00E1 VA: 0x2BCFFE0
	private void ExecSwap(Instruction i) { }

	// RVA: 0x2BD5370 Offset: 0x2BD5471 VA: 0x2BD5370
	private DynValue GetStoreValue(Instruction i) { }

	// RVA: 0x2BD26B0 Offset: 0x2BD27B1 VA: 0x2BD26B0
	private void ExecClosure(Instruction i) { }

	// RVA: 0x2BD5480 Offset: 0x2BD5581 VA: 0x2BD5480
	private DynValue GetUpvalueSymbol(SymbolRef s) { }

	// RVA: 0x2BD24C0 Offset: 0x2BD25C1 VA: 0x2BD24C0
	private void ExecMkTuple(Instruction i) { }

	// RVA: 0x2BD3290 Offset: 0x2BD3391 VA: 0x2BD3290
	private void ExecToNum(Instruction i) { }

	// RVA: 0x2BD3E40 Offset: 0x2BD3F41 VA: 0x2BD3E40
	private void ExecIterUpd(Instruction i) { }

	// RVA: 0x2BD3F10 Offset: 0x2BD4011 VA: 0x2BD3F10
	private void ExecExpTuple(Instruction i) { }

	// RVA: 0x2BD3490 Offset: 0x2BD3591 VA: 0x2BD3490
	private void ExecIterPrep(Instruction i) { }

	// RVA: 0x2BD33D0 Offset: 0x2BD34D1 VA: 0x2BD33D0
	private int ExecJFor(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD31A0 Offset: 0x2BD32A1 VA: 0x2BD31A0
	private void ExecIncr(Instruction i) { }

	// RVA: 0x2BD2200 Offset: 0x2BD2301 VA: 0x2BD2200
	private void ExecCNot(Instruction i) { }

	// RVA: 0x2BD2130 Offset: 0x2BD2231 VA: 0x2BD2130
	private void ExecNot(Instruction i) { }

	// RVA: 0x2BD2840 Offset: 0x2BD2941 VA: 0x2BD2840
	private void ExecBeginFn(Instruction i) { }

	// RVA: 0x2BD51B0 Offset: 0x2BD52B1 VA: 0x2BD51B0
	private CallStackItem PopToBasePointer() { }

	// RVA: 0x2BD55B0 Offset: 0x2BD56B1 VA: 0x2BD55B0
	private int PopExecStackAndCheckVStack(int vstackguard) { }

	// RVA: 0x2BD5670 Offset: 0x2BD5771 VA: 0x2BD5670
	private IList<DynValue> CreateArgsListForFunctionCall(int numargs, int offsFromTop) { }

	// RVA: 0x2BD2950 Offset: 0x2BD2A51 VA: 0x2BD2950
	private void ExecArgs(Instruction I) { }

	// RVA: 0x2BD19F0 Offset: 0x2BD1AF1 VA: 0x2BD19F0
	private int Internal_ExecCall(int argsCount, int instructionPtr, CallbackFunction handler, CallbackFunction continuation, bool thisCall = False, string debugText, DynValue unwindHandler) { }

	// RVA: 0x2BD58B0 Offset: 0x2BD59B1 VA: 0x2BD58B0
	private int PerformTCO(int instructionPtr, int argsCount) { }

	// RVA: 0x2BD2DB0 Offset: 0x2BD2EB1 VA: 0x2BD2DB0
	private int ExecRet(Instruction i) { }

	// RVA: 0x2BD5AA0 Offset: 0x2BD5BA1 VA: 0x2BD5AA0
	private int Internal_CheckForTailRequests(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD2430 Offset: 0x2BD2531 VA: 0x2BD2430
	private int JumpBool(Instruction i, bool expectedValueForJump, int instructionPtr) { }

	// RVA: 0x2BD2370 Offset: 0x2BD2471 VA: 0x2BD2370
	private int ExecShortCircuitingOperator(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD00A0 Offset: 0x2BD01A1 VA: 0x2BD00A0
	private int ExecAdd(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD0590 Offset: 0x2BD0691 VA: 0x2BD0590
	private int ExecSub(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD0770 Offset: 0x2BD0871 VA: 0x2BD0770
	private int ExecMul(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD0B30 Offset: 0x2BD0C31 VA: 0x2BD0B30
	private int ExecMod(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD0950 Offset: 0x2BD0A51 VA: 0x2BD0950
	private int ExecDiv(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD0D60 Offset: 0x2BD0E61 VA: 0x2BD0D60
	private int ExecPower(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD0410 Offset: 0x2BD0511 VA: 0x2BD0410
	private int ExecNeg(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD0F80 Offset: 0x2BD1081 VA: 0x2BD0F80
	private int ExecEq(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD1670 Offset: 0x2BD1771 VA: 0x2BD1670
	private int ExecLess(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD12D0 Offset: 0x2BD13D1 VA: 0x2BD12D0
	private int ExecLessEq(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD1860 Offset: 0x2BD1961 VA: 0x2BD1860
	private int ExecLen(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD0280 Offset: 0x2BD0381 VA: 0x2BD0280
	private int ExecConcat(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD42E0 Offset: 0x2BD43E1 VA: 0x2BD42E0
	private void ExecTblInitI(Instruction i) { }

	// RVA: 0x2BD4190 Offset: 0x2BD4291 VA: 0x2BD4190
	private void ExecTblInitN(Instruction i) { }

	// RVA: 0x2BD49A0 Offset: 0x2BD4AA1 VA: 0x2BD49A0
	private int ExecIndexSet(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD4420 Offset: 0x2BD4521 VA: 0x2BD4420
	private int ExecIndex(Instruction i, int instructionPtr) { }

	// RVA: 0x2BD2610 Offset: 0x2BD2711 VA: 0x2BD2610
	private void ClearBlockData(Instruction I) { }

	// RVA: 0x2BD5EE0 Offset: 0x2BD5FE1 VA: 0x2BD5EE0
	public DynValue GetGenericSymbol(SymbolRef symref) { }

	// RVA: 0x2BD61B0 Offset: 0x2BD62B1 VA: 0x2BD61B0
	private DynValue GetGlobalSymbol(DynValue dynValue, string name) { }

	// RVA: 0x2BD6320 Offset: 0x2BD6421 VA: 0x2BD6320
	private void SetGlobalSymbol(DynValue dynValue, string name, DynValue value) { }

	// RVA: 0x2BD64A0 Offset: 0x2BD65A1 VA: 0x2BD64A0
	public void AssignGenericSymbol(SymbolRef symref, DynValue value) { }

	// RVA: 0x2BD6270 Offset: 0x2BD6371 VA: 0x2BD6270
	private CallStackItem GetTopNonClrFunction() { }

	// RVA: 0x2BD6880 Offset: 0x2BD6981 VA: 0x2BD6880
	public SymbolRef FindSymbolByName(string name) { }

	// RVA: 0x2BCBF10 Offset: 0x2BCC011 VA: 0x2BCBF10
	private DynValue[] Internal_AdjustTuple(IList<DynValue> values) { }

	// RVA: 0x2BD5D10 Offset: 0x2BD5E11 VA: 0x2BD5D10
	private int Internal_InvokeUnaryMetaMethod(DynValue op1, string eventName, int instructionPtr) { }

	// RVA: 0x2BD5C00 Offset: 0x2BD5D01 VA: 0x2BD5C00
	private int Internal_InvokeBinaryMetaMethod(DynValue l, DynValue r, string eventName, int instructionPtr, DynValue extraPush) { }

	// RVA: 0x2BD6B90 Offset: 0x2BD6C91 VA: 0x2BD6B90
	private DynValue[] StackTopToArray(int items, bool pop) { }

	// RVA: 0x2BD6D50 Offset: 0x2BD6E51 VA: 0x2BD6D50
	private DynValue[] StackTopToArrayReverse(int items, bool pop) { }

	[CompilerGeneratedAttribute] // RVA: 0x11020 Offset: 0x11121 VA: 0x11020
	// RVA: 0x2BD6EF0 Offset: 0x2BD6FF1 VA: 0x2BD6EF0
	private DynValue <ExecClosure>b__69_0(SymbolRef s) { }
}

