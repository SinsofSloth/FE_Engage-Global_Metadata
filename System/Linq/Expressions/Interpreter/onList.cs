// Namespace: System.Linq.Expressions.Interpreter
[DebuggerTypeProxyAttribute] // RVA: 0x404E0 Offset: 0x405E1 VA: 0x404E0
internal sealed class InstructionList // TypeDefIndex: 3035
{
	// Fields
	private readonly List<Instruction> _instructions; // 0x10
	private List<object> _objects; // 0x18
	private int _currentStackDepth; // 0x20
	private int _maxStackDepth; // 0x24
	private int _currentContinuationsDepth; // 0x28
	private int _maxContinuationDepth; // 0x2C
	private int _runtimeLabelCount; // 0x30
	private List<BranchLabel> _labels; // 0x38
	private List<KeyValuePair<int, object>> _debugCookies; // 0x40
	private static Instruction s_null; // 0x0
	private static Instruction s_true; // 0x8
	private static Instruction s_false; // 0x10
	private static Instruction[] s_Ints; // 0x18
	private static Instruction[] s_loadObjectCached; // 0x20
	private static Instruction[] s_loadLocal; // 0x28
	private static Instruction[] s_loadLocalBoxed; // 0x30
	private static Instruction[] s_loadLocalFromClosure; // 0x38
	private static Instruction[] s_loadLocalFromClosureBoxed; // 0x40
	private static Instruction[] s_assignLocal; // 0x48
	private static Instruction[] s_storeLocal; // 0x50
	private static Instruction[] s_assignLocalBoxed; // 0x58
	private static Instruction[] s_storeLocalBoxed; // 0x60
	private static Instruction[] s_assignLocalToClosure; // 0x68
	private static readonly Dictionary<FieldInfo, Instruction> s_loadFields; // 0x70
	private static readonly RuntimeLabel[] s_emptyRuntimeLabels; // 0x78

	// Properties
	public int Count { get; }
	public int CurrentStackDepth { get; }
	public int CurrentContinuationsDepth { get; }

	// Methods

	// RVA: 0x31B7370 Offset: 0x31B7471 VA: 0x31B7370
	public void Emit(Instruction instruction) { }

	// RVA: 0x31B7460 Offset: 0x31B7561 VA: 0x31B7460
	private void UpdateStackDepth(Instruction instruction) { }

	// RVA: 0x31B7510 Offset: 0x31B7611 VA: 0x31B7510
	public void UnEmit() { }

	// RVA: 0x31B3750 Offset: 0x31B3851 VA: 0x31B3750
	public int get_Count() { }

	// RVA: 0x31B7620 Offset: 0x31B7721 VA: 0x31B7620
	public int get_CurrentStackDepth() { }

	// RVA: 0x31B7630 Offset: 0x31B7731 VA: 0x31B7630
	public int get_CurrentContinuationsDepth() { }

	// RVA: 0x31B7640 Offset: 0x31B7741 VA: 0x31B7640
	internal Instruction GetInstruction(int index) { }

	// RVA: 0x31B76B0 Offset: 0x31B77B1 VA: 0x31B76B0
	public InstructionArray ToArray() { }

	// RVA: 0x31B79F0 Offset: 0x31B7AF1 VA: 0x31B79F0
	public void EmitLoad(object value) { }

	// RVA: 0x31B7F50 Offset: 0x31B8051 VA: 0x31B7F50
	public void EmitLoad(bool value) { }

	// RVA: 0x31B7A00 Offset: 0x31B7B01 VA: 0x31B7A00
	public void EmitLoad(object value, Type type) { }

	// RVA: 0x31B8120 Offset: 0x31B8221 VA: 0x31B8120
	public void EmitDup() { }

	// RVA: 0x31B81A0 Offset: 0x31B82A1 VA: 0x31B81A0
	public void EmitPop() { }

	// RVA: 0x31B8220 Offset: 0x31B8321 VA: 0x31B8220
	internal void SwitchToBoxed(int index, int instructionIndex) { }

	// RVA: 0x31B8360 Offset: 0x31B8461 VA: 0x31B8360
	public void EmitLoadLocal(int index) { }

	// RVA: 0x31B8580 Offset: 0x31B8681 VA: 0x31B8580
	public void EmitLoadLocalBoxed(int index) { }

	// RVA: 0x31B8600 Offset: 0x31B8701 VA: 0x31B8600
	internal static Instruction LoadLocalBoxed(int index) { }

	// RVA: 0x31B8810 Offset: 0x31B8911 VA: 0x31B8810
	public void EmitLoadLocalFromClosure(int index) { }

	// RVA: 0x31B8A30 Offset: 0x31B8B31 VA: 0x31B8A30
	public void EmitLoadLocalFromClosureBoxed(int index) { }

	// RVA: 0x31B8C50 Offset: 0x31B8D51 VA: 0x31B8C50
	public void EmitAssignLocal(int index) { }

	// RVA: 0x31B8E70 Offset: 0x31B8F71 VA: 0x31B8E70
	public void EmitStoreLocal(int index) { }

	// RVA: 0x31B9090 Offset: 0x31B9191 VA: 0x31B9090
	public void EmitAssignLocalBoxed(int index) { }

	// RVA: 0x31B9110 Offset: 0x31B9211 VA: 0x31B9110
	internal static Instruction AssignLocalBoxed(int index) { }

	// RVA: 0x31B9320 Offset: 0x31B9421 VA: 0x31B9320
	public void EmitStoreLocalBoxed(int index) { }

	// RVA: 0x31B93A0 Offset: 0x31B94A1 VA: 0x31B93A0
	internal static Instruction StoreLocalBoxed(int index) { }

	// RVA: 0x31B95B0 Offset: 0x31B96B1 VA: 0x31B95B0
	public void EmitAssignLocalToClosure(int index) { }

	// RVA: 0x31B97D0 Offset: 0x31B98D1 VA: 0x31B97D0
	public void EmitStoreLocalToClosure(int index) { }

	// RVA: 0x31B9850 Offset: 0x31B9951 VA: 0x31B9850
	public void EmitInitializeLocal(int index, Type type) { }

	// RVA: 0x31B9A10 Offset: 0x31B9B11 VA: 0x31B9A10
	internal void EmitInitializeParameter(int index) { }

	// RVA: 0x31B9AC0 Offset: 0x31B9BC1 VA: 0x31B9AC0
	internal static Instruction Parameter(int index) { }

	// RVA: 0x31B9B30 Offset: 0x31B9C31 VA: 0x31B9B30
	internal static Instruction ParameterBox(int index) { }

	// RVA: 0x31B99A0 Offset: 0x31B9AA1 VA: 0x31B99A0
	internal static Instruction InitReference(int index) { }

	// RVA: 0x31B9BA0 Offset: 0x31B9CA1 VA: 0x31B9BA0
	internal static Instruction InitImmutableRefBox(int index) { }

	// RVA: 0x31B9C10 Offset: 0x31B9D11 VA: 0x31B9C10
	public void EmitNewRuntimeVariables(int count) { }

	// RVA: 0x31B9C80 Offset: 0x31B9D81 VA: 0x31B9C80
	public void EmitGetArrayItem() { }

	// RVA: 0x31B9D00 Offset: 0x31B9E01 VA: 0x31B9D00
	public void EmitSetArrayItem() { }

	// RVA: 0x31B9D80 Offset: 0x31B9E81 VA: 0x31B9D80
	public void EmitNewArray(Type elementType) { }

	// RVA: 0x31B9DF0 Offset: 0x31B9EF1 VA: 0x31B9DF0
	public void EmitNewArrayBounds(Type elementType, int rank) { }

	// RVA: 0x31B9E70 Offset: 0x31B9F71 VA: 0x31B9E70
	public void EmitNewArrayInit(Type elementType, int elementCount) { }

	// RVA: 0x31B9EF0 Offset: 0x31B9FF1 VA: 0x31B9EF0
	public void EmitAdd(Type type, bool checked) { }

	// RVA: 0x31B9F30 Offset: 0x31BA031 VA: 0x31B9F30
	public void EmitSub(Type type, bool checked) { }

	// RVA: 0x31B9F70 Offset: 0x31BA071 VA: 0x31B9F70
	public void EmitMul(Type type, bool checked) { }

	// RVA: 0x31B9FB0 Offset: 0x31BA0B1 VA: 0x31B9FB0
	public void EmitDiv(Type type) { }

	// RVA: 0x31B9FE0 Offset: 0x31BA0E1 VA: 0x31B9FE0
	public void EmitModulo(Type type) { }

	// RVA: 0x31BA010 Offset: 0x31BA111 VA: 0x31BA010
	public void EmitExclusiveOr(Type type) { }

	// RVA: 0x31BA040 Offset: 0x31BA141 VA: 0x31BA040
	public void EmitAnd(Type type) { }

	// RVA: 0x31BA070 Offset: 0x31BA171 VA: 0x31BA070
	public void EmitOr(Type type) { }

	// RVA: 0x31BA0A0 Offset: 0x31BA1A1 VA: 0x31BA0A0
	public void EmitLeftShift(Type type) { }

	// RVA: 0x31BA430 Offset: 0x31BA531 VA: 0x31BA430
	public void EmitRightShift(Type type) { }

	// RVA: 0x31BA460 Offset: 0x31BA561 VA: 0x31BA460
	public void EmitEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x31BA4A0 Offset: 0x31BA5A1 VA: 0x31BA4A0
	public void EmitNotEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x31BA4E0 Offset: 0x31BA5E1 VA: 0x31BA4E0
	public void EmitLessThan(Type type, bool liftedToNull) { }

	// RVA: 0x31BAEF0 Offset: 0x31BAFF1 VA: 0x31BAEF0
	public void EmitLessThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x31BB900 Offset: 0x31BBA01 VA: 0x31BB900
	public void EmitGreaterThan(Type type, bool liftedToNull) { }

	// RVA: 0x31BB940 Offset: 0x31BBA41 VA: 0x31BB940
	public void EmitGreaterThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x31BB980 Offset: 0x31BBA81 VA: 0x31BB980
	public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x31BBA10 Offset: 0x31BBB11 VA: 0x31BBA10
	public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x31BBAA0 Offset: 0x31BBBA1 VA: 0x31BBAA0
	public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x31BBB20 Offset: 0x31BBC21 VA: 0x31BBB20
	public void EmitCast(Type toType) { }

	// RVA: 0x31BBB50 Offset: 0x31BBC51 VA: 0x31BBB50
	public void EmitCastToEnum(Type toType) { }

	// RVA: 0x31BBBC0 Offset: 0x31BBCC1 VA: 0x31BBBC0
	public void EmitCastReferenceToEnum(Type toType) { }

	// RVA: 0x31BBC30 Offset: 0x31BBD31 VA: 0x31BBC30
	public void EmitNot(Type type) { }

	// RVA: 0x31BBC60 Offset: 0x31BBD61 VA: 0x31BBC60
	public void EmitDefaultValue(Type type) { }

	// RVA: 0x31BBCD0 Offset: 0x31BBDD1 VA: 0x31BBCD0
	public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters) { }

	// RVA: 0x31BBD50 Offset: 0x31BBE51 VA: 0x31BBD50
	public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters) { }

	// RVA: 0x31BBDE0 Offset: 0x31BBEE1 VA: 0x31BBDE0
	internal void EmitCreateDelegate(LightDelegateCreator creator) { }

	// RVA: 0x31BBE50 Offset: 0x31BBF51 VA: 0x31BBE50
	public void EmitTypeEquals() { }

	// RVA: 0x31BBED0 Offset: 0x31BBFD1 VA: 0x31BBED0
	public void EmitArrayLength() { }

	// RVA: 0x31BBF50 Offset: 0x31BC051 VA: 0x31BBF50
	public void EmitNegate(Type type) { }

	// RVA: 0x31BBF80 Offset: 0x31BC081 VA: 0x31BBF80
	public void EmitNegateChecked(Type type) { }

	// RVA: 0x31BBFB0 Offset: 0x31BC0B1 VA: 0x31BBFB0
	public void EmitIncrement(Type type) { }

	// RVA: 0x31BBFE0 Offset: 0x31BC0E1 VA: 0x31BBFE0
	public void EmitDecrement(Type type) { }

	// RVA: 0x31BC010 Offset: 0x31BC111 VA: 0x31BC010
	public void EmitTypeIs(Type type) { }

	// RVA: 0x31BC080 Offset: 0x31BC181 VA: 0x31BC080
	public void EmitTypeAs(Type type) { }

	// RVA: 0x31BC0F0 Offset: 0x31BC1F1 VA: 0x31BC0F0
	public void EmitLoadField(FieldInfo field) { }

	// RVA: 0x31BC120 Offset: 0x31BC221 VA: 0x31BC120
	private Instruction GetLoadField(FieldInfo field) { }

	// RVA: 0x31BC360 Offset: 0x31BC461 VA: 0x31BC360
	public void EmitStoreField(FieldInfo field) { }

	// RVA: 0x31BC410 Offset: 0x31BC511 VA: 0x31BC410
	public void EmitCall(MethodInfo method) { }

	// RVA: 0x31BC4A0 Offset: 0x31BC5A1 VA: 0x31BC4A0
	public void EmitCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x31BC4E0 Offset: 0x31BC5E1 VA: 0x31BC4E0
	public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x31BC590 Offset: 0x31BC691 VA: 0x31BC590
	public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x31B77D0 Offset: 0x31B78D1 VA: 0x31B77D0
	private RuntimeLabel[] BuildRuntimeLabels() { }

	// RVA: 0x31BC5F0 Offset: 0x31BC6F1 VA: 0x31BC5F0
	public BranchLabel MakeLabel() { }

	// RVA: 0x31BC6D0 Offset: 0x31BC7D1 VA: 0x31BC6D0
	internal void FixupBranch(int branchIndex, int offset) { }

	// RVA: 0x31BC7E0 Offset: 0x31BC8E1 VA: 0x31BC7E0
	private int EnsureLabelIndex(BranchLabel label) { }

	// RVA: 0x31BC840 Offset: 0x31BC941 VA: 0x31BC840
	public int MarkRuntimeLabel() { }

	// RVA: 0x31BC8B0 Offset: 0x31BC9B1 VA: 0x31BC8B0
	public void MarkLabel(BranchLabel label) { }

	// RVA: 0x31BC8D0 Offset: 0x31BC9D1 VA: 0x31BC8D0
	public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x31BC9B0 Offset: 0x31BCAB1 VA: 0x31BC9B0
	private void EmitBranch(OffsetInstruction instruction, BranchLabel label) { }

	// RVA: 0x31BCA20 Offset: 0x31BCB21 VA: 0x31BCA20
	public void EmitBranch(BranchLabel label) { }

	// RVA: 0x31BCAD0 Offset: 0x31BCBD1 VA: 0x31BCAD0
	public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue) { }

	// RVA: 0x31BCB90 Offset: 0x31BCC91 VA: 0x31BCB90
	public void EmitCoalescingBranch(BranchLabel leftNotNull) { }

	// RVA: 0x31BCC40 Offset: 0x31BCD41 VA: 0x31BCC40
	public void EmitBranchTrue(BranchLabel elseLabel) { }

	// RVA: 0x31BCCF0 Offset: 0x31BCDF1 VA: 0x31BCCF0
	public void EmitBranchFalse(BranchLabel elseLabel) { }

	// RVA: 0x31BCDA0 Offset: 0x31BCEA1 VA: 0x31BCDA0
	public void EmitThrow() { }

	// RVA: 0x31BCE20 Offset: 0x31BCF21 VA: 0x31BCE20
	public void EmitThrowVoid() { }

	// RVA: 0x31BCEA0 Offset: 0x31BCFA1 VA: 0x31BCEA0
	public void EmitRethrow() { }

	// RVA: 0x31BCF20 Offset: 0x31BD021 VA: 0x31BCF20
	public void EmitRethrowVoid() { }

	// RVA: 0x31BCFA0 Offset: 0x31BD0A1 VA: 0x31BCFA0
	public void EmitEnterTryFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x31BD000 Offset: 0x31BD101 VA: 0x31BD000
	public void EmitEnterTryCatch() { }

	// RVA: 0x31BD030 Offset: 0x31BD131 VA: 0x31BD030
	public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd) { }

	// RVA: 0x31BD0E0 Offset: 0x31BD1E1 VA: 0x31BD0E0
	public void EmitEnterFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x31BD1A0 Offset: 0x31BD2A1 VA: 0x31BD1A0
	public void EmitLeaveFinally() { }

	// RVA: 0x31BD220 Offset: 0x31BD321 VA: 0x31BD220
	public void EmitEnterFault(BranchLabel faultStartLabel) { }

	// RVA: 0x31BD2E0 Offset: 0x31BD3E1 VA: 0x31BD2E0
	public void EmitLeaveFault() { }

	// RVA: 0x31BD360 Offset: 0x31BD461 VA: 0x31BD360
	public void EmitEnterExceptionFilter() { }

	// RVA: 0x31BD3E0 Offset: 0x31BD4E1 VA: 0x31BD3E0
	public void EmitLeaveExceptionFilter() { }

	// RVA: 0x31BD460 Offset: 0x31BD561 VA: 0x31BD460
	public void EmitEnterExceptionHandlerNonVoid() { }

	// RVA: 0x31BD4E0 Offset: 0x31BD5E1 VA: 0x31BD4E0
	public void EmitEnterExceptionHandlerVoid() { }

	// RVA: 0x31BD560 Offset: 0x31BD661 VA: 0x31BD560
	public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel) { }

	// RVA: -1 Offset: -1
	public void EmitIntSwitch<T>(Dictionary<T, int> cases) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2959EA0 Offset: 0x2959FA1 VA: 0x2959EA0
	|-InstructionList.EmitIntSwitch<int>
	|
	|-RVA: 0x2959F10 Offset: 0x295A011 VA: 0x2959F10
	|-InstructionList.EmitIntSwitch<object>
	*/

	// RVA: 0x31BD780 Offset: 0x31BD881 VA: 0x31BD780
	public void EmitStringSwitch(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x31BD800 Offset: 0x31BD901 VA: 0x31BD800
	public void .ctor() { }

	// RVA: 0x31BD890 Offset: 0x31BD991 VA: 0x31BD890
	private static void .cctor() { }
}

