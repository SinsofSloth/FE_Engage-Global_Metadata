// Namespace: MoonSharp.Interpreter.Execution.VM
internal class ByteCode : RefIdObject // TypeDefIndex: 6186
{
	// Fields
	public List<Instruction> Code; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xEB50 Offset: 0xEC51 VA: 0xEB50
	private Script <Script>k__BackingField; // 0x20
	private List<SourceRef> m_SourceRefStack; // 0x28
	private SourceRef m_CurrentSourceRef; // 0x30
	internal LoopTracker LoopTracker; // 0x38

	// Properties
	public Script Script { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x10FA0 Offset: 0x110A1 VA: 0x10FA0
	// RVA: 0x30F27A0 Offset: 0x30F28A1 VA: 0x30F27A0
	public Script get_Script() { }

	[CompilerGeneratedAttribute] // RVA: 0x10FB0 Offset: 0x110B1 VA: 0x10FB0
	// RVA: 0x30F27B0 Offset: 0x30F28B1 VA: 0x30F27B0
	private void set_Script(Script value) { }

	// RVA: 0x30F27C0 Offset: 0x30F28C1 VA: 0x30F27C0
	public void .ctor(Script script) { }

	// RVA: 0x30E7890 Offset: 0x30E7991 VA: 0x30E7890
	public IDisposable EnterSource(SourceRef sref) { }

	// RVA: 0x30F2930 Offset: 0x30F2A31 VA: 0x30F2930
	public void PushSourceRef(SourceRef sref) { }

	// RVA: 0x30F29A0 Offset: 0x30F2AA1 VA: 0x30F29A0
	public void PopSourceRef() { }

	// RVA: 0x30F2A50 Offset: 0x30F2B51 VA: 0x30F2A50
	public void Dump(string file) { }

	// RVA: 0x30ED540 Offset: 0x30ED641 VA: 0x30ED540
	public int GetJumpPointForNextInstruction() { }

	// RVA: 0x30F2C30 Offset: 0x30F2D31 VA: 0x30F2C30
	public int GetJumpPointForLastInstruction() { }

	// RVA: 0x30F2C80 Offset: 0x30F2D81 VA: 0x30F2C80
	public Instruction GetLastInstruction() { }

	// RVA: 0x30F2CF0 Offset: 0x30F2DF1 VA: 0x30F2CF0
	private Instruction AppendInstruction(Instruction c) { }

	// RVA: 0x30F2D60 Offset: 0x30F2E61 VA: 0x30F2D60
	public Instruction Emit_Nop(string comment) { }

	// RVA: 0x30F2E20 Offset: 0x30F2F21 VA: 0x30F2E20
	public Instruction Emit_Invalid(string type) { }

	// RVA: 0x30E7900 Offset: 0x30E7A01 VA: 0x30E7900
	public Instruction Emit_Pop(int num = 1) { }

	// RVA: 0x30F2EE0 Offset: 0x30F2FE1 VA: 0x30F2EE0
	public void Emit_Call(int argCount, string debugName) { }

	// RVA: 0x30F2FB0 Offset: 0x30F30B1 VA: 0x30F2FB0
	public void Emit_ThisCall(int argCount, string debugName) { }

	// RVA: 0x30F3080 Offset: 0x30F3181 VA: 0x30F3080
	public Instruction Emit_Literal(DynValue value) { }

	// RVA: 0x30ED480 Offset: 0x30ED581 VA: 0x30ED480
	public Instruction Emit_Jump(OpCode jumpOpCode, int idx, int optPar = 0) { }

	// RVA: 0x30F3140 Offset: 0x30F3241 VA: 0x30F3140
	public Instruction Emit_MkTuple(int cnt) { }

	// RVA: 0x30ED590 Offset: 0x30ED691 VA: 0x30ED590
	public Instruction Emit_Operator(OpCode opcode) { }

	[ConditionalAttribute] // RVA: 0x10FC0 Offset: 0x110C1 VA: 0x10FC0
	// RVA: 0x30F3200 Offset: 0x30F3301 VA: 0x30F3200
	public void Emit_Debug(string str) { }

	// RVA: 0x30F3320 Offset: 0x30F3421 VA: 0x30F3320
	public Instruction Emit_Enter(RuntimeScopeBlock runtimeScopeBlock) { }

	// RVA: 0x30F33E0 Offset: 0x30F34E1 VA: 0x30F33E0
	public Instruction Emit_Leave(RuntimeScopeBlock runtimeScopeBlock) { }

	// RVA: 0x30F34A0 Offset: 0x30F35A1 VA: 0x30F34A0
	public Instruction Emit_Exit(RuntimeScopeBlock runtimeScopeBlock) { }

	// RVA: 0x30F3560 Offset: 0x30F3661 VA: 0x30F3560
	public Instruction Emit_Clean(RuntimeScopeBlock runtimeScopeBlock) { }

	// RVA: 0x30F3630 Offset: 0x30F3731 VA: 0x30F3630
	public Instruction Emit_Closure(SymbolRef[] symbols, int jmpnum) { }

	// RVA: 0x30F3700 Offset: 0x30F3801 VA: 0x30F3700
	public Instruction Emit_Args(SymbolRef[] symbols) { }

	// RVA: 0x30F37C0 Offset: 0x30F38C1 VA: 0x30F37C0
	public Instruction Emit_Ret(int retvals) { }

	// RVA: 0x30F3880 Offset: 0x30F3981 VA: 0x30F3880
	public Instruction Emit_ToNum(int stage = 0) { }

	// RVA: 0x30F3940 Offset: 0x30F3A41 VA: 0x30F3940
	public Instruction Emit_Incr(int i) { }

	// RVA: 0x30F3A00 Offset: 0x30F3B01 VA: 0x30F3A00
	public Instruction Emit_NewTable(bool shared) { }

	// RVA: 0x30F3AC0 Offset: 0x30F3BC1 VA: 0x30F3AC0
	public Instruction Emit_IterPrep() { }

	// RVA: 0x30F3B70 Offset: 0x30F3C71 VA: 0x30F3B70
	public Instruction Emit_ExpTuple(int stackOffset) { }

	// RVA: 0x30F3C30 Offset: 0x30F3D31 VA: 0x30F3C30
	public Instruction Emit_IterUpd() { }

	// RVA: 0x30F3CE0 Offset: 0x30F3DE1 VA: 0x30F3CE0
	public Instruction Emit_Meta(string funcName, OpCodeMetadataType metaType, DynValue value) { }

	// RVA: 0x30F3DD0 Offset: 0x30F3ED1 VA: 0x30F3DD0
	public Instruction Emit_BeginFn(RuntimeScopeFrame stackFrame) { }

	// RVA: 0x30E5E70 Offset: 0x30E5F71 VA: 0x30E5E70
	public Instruction Emit_Scalar() { }

	// RVA: 0x30F3ED0 Offset: 0x30F3FD1 VA: 0x30F3ED0
	public int Emit_Load(SymbolRef sym) { }

	// RVA: 0x30F4120 Offset: 0x30F4221 VA: 0x30F4120
	public int Emit_Store(SymbolRef sym, int stackofs, int tupleidx) { }

	// RVA: 0x30F4390 Offset: 0x30F4491 VA: 0x30F4390
	public Instruction Emit_TblInitN() { }

	// RVA: 0x30F4440 Offset: 0x30F4541 VA: 0x30F4440
	public Instruction Emit_TblInitI(bool lastpos) { }

	// RVA: 0x30F4500 Offset: 0x30F4601 VA: 0x30F4500
	public Instruction Emit_Index(DynValue index, bool isNameIndex = False, bool isExpList = False) { }

	// RVA: 0x30F45F0 Offset: 0x30F46F1 VA: 0x30F45F0
	public Instruction Emit_IndexSet(int stackofs, int tupleidx, DynValue index, bool isNameIndex = False, bool isExpList = False) { }

	// RVA: 0x30F46F0 Offset: 0x30F47F1 VA: 0x30F46F0
	public Instruction Emit_Copy(int numval) { }

	// RVA: 0x30F47B0 Offset: 0x30F48B1 VA: 0x30F47B0
	public Instruction Emit_Swap(int p1, int p2) { }
}

