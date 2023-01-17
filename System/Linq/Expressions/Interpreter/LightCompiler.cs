// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LightCompiler // TypeDefIndex: 3086
{
	// Fields
	private readonly InstructionList _instructions; // 0x10
	private readonly LocalVariables _locals; // 0x18
	private readonly List<DebugInfo> _debugInfos; // 0x20
	private readonly HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels; // 0x28
	private LabelScopeInfo _labelBlock; // 0x30
	private readonly Stack<ParameterExpression> _exceptionForRethrowStack; // 0x38
	private readonly LightCompiler _parent; // 0x40
	private readonly StackGuard _guard; // 0x48
	private static readonly LocalDefinition[] s_emptyLocals; // 0x0

	// Properties
	public InstructionList Instructions { get; }

	// Methods

	// RVA: 0x31C0940 Offset: 0x31C0A41 VA: 0x31C0940
	public void .ctor() { }

	// RVA: 0x31C0BE0 Offset: 0x31C0CE1 VA: 0x31C0BE0
	private void .ctor(LightCompiler parent) { }

	// RVA: 0x31C0C10 Offset: 0x31C0D11 VA: 0x31C0C10
	public InstructionList get_Instructions() { }

	// RVA: 0x31C0C20 Offset: 0x31C0D21 VA: 0x31C0C20
	public LightDelegateCreator CompileTop(LambdaExpression node) { }

	// RVA: 0x31C0F00 Offset: 0x31C1001 VA: 0x31C0F00
	private Interpreter MakeInterpreter(string lambdaName) { }

	// RVA: 0x31C12A0 Offset: 0x31C13A1 VA: 0x31C12A0
	private void CompileConstantExpression(Expression expr) { }

	// RVA: 0x31C1350 Offset: 0x31C1451 VA: 0x31C1350
	private void CompileDefaultExpression(Expression expr) { }

	// RVA: 0x31C1390 Offset: 0x31C1491 VA: 0x31C1390
	private void CompileDefaultExpression(Type type) { }

	// RVA: 0x31C14F0 Offset: 0x31C15F1 VA: 0x31C14F0
	private LocalVariable EnsureAvailableForClosure(ParameterExpression expr) { }

	// RVA: 0x31C15F0 Offset: 0x31C16F1 VA: 0x31C15F0
	private LocalVariable ResolveLocal(ParameterExpression variable) { }

	// RVA: 0x31C1660 Offset: 0x31C1761 VA: 0x31C1660
	private void CompileGetVariable(ParameterExpression variable) { }

	// RVA: 0x31C17B0 Offset: 0x31C18B1 VA: 0x31C17B0
	private void EmitCopyValueType(Type valueType) { }

	// RVA: 0x31C16A0 Offset: 0x31C17A1 VA: 0x31C16A0
	private void LoadLocalNoValueTypeCopy(ParameterExpression variable) { }

	// RVA: 0x31C1880 Offset: 0x31C1981 VA: 0x31C1880
	private bool MaybeMutableValueType(Type type) { }

	// RVA: 0x31C18F0 Offset: 0x31C19F1 VA: 0x31C18F0
	private void CompileGetBoxedVariable(ParameterExpression variable) { }

	// RVA: 0x31C1980 Offset: 0x31C1A81 VA: 0x31C1980
	private void CompileSetVariable(ParameterExpression variable, bool isVoid) { }

	// RVA: 0x31C1B40 Offset: 0x31C1C41 VA: 0x31C1B40
	private void CompileParameterExpression(Expression expr) { }

	// RVA: 0x31C1BF0 Offset: 0x31C1CF1 VA: 0x31C1BF0
	private void CompileBlockExpression(Expression expr, bool asVoid) { }

	// RVA: 0x31C1DE0 Offset: 0x31C1EE1 VA: 0x31C1DE0
	private LocalDefinition[] CompileBlockStart(BlockExpression node) { }

	// RVA: 0x31C22A0 Offset: 0x31C23A1 VA: 0x31C22A0
	private void CompileBlockEnd(LocalDefinition[] locals) { }

	// RVA: 0x31C2560 Offset: 0x31C2661 VA: 0x31C2560
	private void CompileIndexExpression(Expression expr) { }

	// RVA: 0x31C2780 Offset: 0x31C2881 VA: 0x31C2780
	private void EmitIndexGet(IndexExpression index) { }

	// RVA: 0x31C29B0 Offset: 0x31C2AB1 VA: 0x31C29B0
	private void CompileIndexAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x31C2F30 Offset: 0x31C3031 VA: 0x31C2F30
	private void CompileMemberAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x31C3000 Offset: 0x31C3101 VA: 0x31C3000
	private void CompileMemberAssignment(bool asVoid, MemberInfo refMember, Expression value, bool forBinding) { }

	// RVA: 0x31C3460 Offset: 0x31C3561 VA: 0x31C3460
	private void CompileVariableAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x31C3540 Offset: 0x31C3641 VA: 0x31C3540
	private void CompileAssignBinaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x31C3730 Offset: 0x31C3831 VA: 0x31C3730
	private void CompileBinaryExpression(Expression expr) { }

	// RVA: 0x31C4CD0 Offset: 0x31C4DD1 VA: 0x31C4CD0
	private void CompileEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x31C4D90 Offset: 0x31C4E91 VA: 0x31C4D90
	private void CompileNotEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x31C4E50 Offset: 0x31C4F51 VA: 0x31C4E50
	private void CompileComparison(BinaryExpression node) { }

	// RVA: 0x31C4AC0 Offset: 0x31C4BC1 VA: 0x31C4AC0
	private void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right) { }

	// RVA: 0x31C5020 Offset: 0x31C5121 VA: 0x31C5020
	private void CompileConvertUnaryExpression(Expression expr) { }

	// RVA: 0x31C56D0 Offset: 0x31C57D1 VA: 0x31C56D0
	private void CompileConvertToType(Type typeFrom, Type typeTo, bool isChecked, bool isLiftedToNull) { }

	// RVA: 0x31C5CA0 Offset: 0x31C5DA1 VA: 0x31C5CA0
	private void CompileNotExpression(UnaryExpression node) { }

	// RVA: 0x31C5D20 Offset: 0x31C5E21 VA: 0x31C5D20
	private void CompileUnaryExpression(Expression expr) { }

	// RVA: 0x31C6210 Offset: 0x31C6311 VA: 0x31C6210
	private void EmitUnaryMethodCall(UnaryExpression node) { }

	// RVA: 0x31C6580 Offset: 0x31C6681 VA: 0x31C6580
	private void EmitUnaryBoolCheck(UnaryExpression node) { }

	// RVA: 0x31C6870 Offset: 0x31C6971 VA: 0x31C6870
	private void CompileAndAlsoBinaryExpression(Expression expr) { }

	// RVA: 0x31C6AC0 Offset: 0x31C6BC1 VA: 0x31C6AC0
	private void CompileOrElseBinaryExpression(Expression expr) { }

	// RVA: 0x31C6910 Offset: 0x31C6A11 VA: 0x31C6910
	private void CompileLogicalBinaryExpression(BinaryExpression b, bool andAlso) { }

	// RVA: 0x31C6B60 Offset: 0x31C6C61 VA: 0x31C6B60
	private void CompileMethodLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x31C6E50 Offset: 0x31C6F51 VA: 0x31C6E50
	private void CompileLiftedLogicalBinaryExpression(BinaryExpression node, bool andAlso) { }

	// RVA: 0x31C7970 Offset: 0x31C7A71 VA: 0x31C7970
	private void CompileUnliftedLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x31C7BC0 Offset: 0x31C7CC1 VA: 0x31C7BC0
	private void CompileConditionalExpression(Expression expr, bool asVoid) { }

	// RVA: 0x31C7FF0 Offset: 0x31C80F1 VA: 0x31C7FF0
	private void CompileLoopExpression(Expression expr) { }

	// RVA: 0x31C84A0 Offset: 0x31C85A1 VA: 0x31C84A0
	private void CompileSwitchExpression(Expression expr) { }

	// RVA: -1 Offset: -1
	private void CompileIntSwitchExpression<T>(SwitchExpression node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295B180 Offset: 0x295B281 VA: 0x295B180
	|-LightCompiler.CompileIntSwitchExpression<int>
	|
	|-RVA: 0x295B730 Offset: 0x295B831 VA: 0x295B730
	|-LightCompiler.CompileIntSwitchExpression<object>
	*/

	// RVA: 0x31C8E20 Offset: 0x31C8F21 VA: 0x31C8E20
	private void CompileStringSwitchExpression(SwitchExpression node) { }

	// RVA: 0x31C96C0 Offset: 0x31C97C1 VA: 0x31C96C0
	private void CompileLabelExpression(Expression expr) { }

	// RVA: 0x31C9990 Offset: 0x31C9A91 VA: 0x31C9990
	private void CompileGotoExpression(Expression expr) { }

	// RVA: 0x31C8360 Offset: 0x31C8461 VA: 0x31C8360
	private void PushLabelBlock(LabelScopeKind type) { }

	// RVA: 0x31C8490 Offset: 0x31C8591 VA: 0x31C8490
	private void PopLabelBlock(LabelScopeKind kind) { }

	// RVA: 0x31C9D10 Offset: 0x31C9E11 VA: 0x31C9D10
	private LabelInfo EnsureLabel(LabelTarget node) { }

	// RVA: 0x31C9C90 Offset: 0x31C9D91 VA: 0x31C9C90
	private LabelInfo ReferenceLabel(LabelTarget node) { }

	// RVA: 0x31C83F0 Offset: 0x31C84F1 VA: 0x31C83F0
	private LabelInfo DefineLabel(LabelTarget node) { }

	// RVA: 0x31C9DE0 Offset: 0x31C9EE1 VA: 0x31C9DE0
	private bool TryPushLabelBlock(Expression node) { }

	// RVA: 0x31CA410 Offset: 0x31CA511 VA: 0x31CA410
	private void DefineBlockLabels(Expression node) { }

	// RVA: 0x31CA5A0 Offset: 0x31CA6A1 VA: 0x31CA5A0
	private void CheckRethrow() { }

	// RVA: 0x31CA600 Offset: 0x31CA701 VA: 0x31CA600
	private void CompileThrowUnaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x31CA8F0 Offset: 0x31CA9F1 VA: 0x31CA8F0
	private void CompileTryExpression(Expression expr) { }

	// RVA: 0x31CBA60 Offset: 0x31CBB61 VA: 0x31CBA60
	private void CompileTryFaultExpression(TryExpression expr) { }

	// RVA: 0x31CBFC0 Offset: 0x31CC0C1 VA: 0x31CBFC0
	private void CompileMethodCallExpression(Expression expr) { }

	// RVA: 0x31CC070 Offset: 0x31CC171 VA: 0x31CC070
	private void CompileMethodCallExpression(Expression object, MethodInfo method, IArgumentProvider arguments) { }

	// RVA: 0x31CD2D0 Offset: 0x31CD3D1 VA: 0x31CD2D0
	private ByRefUpdater CompileArrayIndexAddress(Expression array, Expression index, int argumentIndex) { }

	// RVA: 0x31C2770 Offset: 0x31C2871 VA: 0x31C2770
	private void EmitThisForMethodCall(Expression node) { }

	// RVA: 0x31CD590 Offset: 0x31CD691 VA: 0x31CD590
	private static bool ShouldWritebackNode(Expression node) { }

	// RVA: 0x31CC570 Offset: 0x31CC671 VA: 0x31CC570
	private ByRefUpdater CompileAddress(Expression node, int index) { }

	// RVA: 0x31CD720 Offset: 0x31CD821 VA: 0x31CD720
	private ByRefUpdater CompileMultiDimArrayAccess(Expression array, IArgumentProvider arguments, int index) { }

	// RVA: 0x31CDCD0 Offset: 0x31CDDD1 VA: 0x31CDCD0
	private void CompileNewExpression(Expression expr) { }

	// RVA: 0x31CE0E0 Offset: 0x31CE1E1 VA: 0x31CE0E0
	private void CompileMemberExpression(Expression expr) { }

	// RVA: 0x31CE190 Offset: 0x31CE291 VA: 0x31CE190
	private void CompileMember(Expression from, MemberInfo member, bool forBinding) { }

	// RVA: 0x31CE530 Offset: 0x31CE631 VA: 0x31CE530
	private void CompileNewArrayExpression(Expression expr) { }

	// RVA: 0x31CE940 Offset: 0x31CEA41 VA: 0x31CE940
	private void CompileDebugInfoExpression(Expression expr) { }

	// RVA: 0x31CEAA0 Offset: 0x31CEBA1 VA: 0x31CEAA0
	private void CompileRuntimeVariablesExpression(Expression expr) { }

	// RVA: 0x31CEDF0 Offset: 0x31CEEF1 VA: 0x31CEDF0
	private void CompileLambdaExpression(Expression expr) { }

	// RVA: 0x31CF070 Offset: 0x31CF171 VA: 0x31CF070
	private void CompileCoalesceBinaryExpression(Expression expr) { }

	// RVA: 0x31CF650 Offset: 0x31CF751 VA: 0x31CF650
	private void CompileInvocationExpression(Expression expr) { }

	// RVA: 0x31CF8C0 Offset: 0x31CF9C1 VA: 0x31CF8C0
	private void CompileListInitExpression(Expression expr) { }

	// RVA: 0x31CF950 Offset: 0x31CFA51 VA: 0x31CF950
	private void CompileListInit(ReadOnlyCollection<ElementInit> initializers) { }

	// RVA: 0x31CFE20 Offset: 0x31CFF21 VA: 0x31CFE20
	private void CompileMemberInitExpression(Expression expr) { }

	// RVA: 0x31CFEB0 Offset: 0x31CFFB1 VA: 0x31CFEB0
	private void CompileMemberInit(ReadOnlyCollection<MemberBinding> bindings) { }

	// RVA: 0x31D0470 Offset: 0x31D0571 VA: 0x31D0470
	private static Type GetMemberType(MemberInfo member) { }

	// RVA: 0x31D05E0 Offset: 0x31D06E1 VA: 0x31D05E0
	private void CompileQuoteUnaryExpression(Expression expr) { }

	// RVA: 0x31D0880 Offset: 0x31D0981 VA: 0x31D0880
	private void CompileUnboxUnaryExpression(Expression expr) { }

	// RVA: 0x31D09B0 Offset: 0x31D0AB1 VA: 0x31D09B0
	private void CompileTypeEqualExpression(Expression expr) { }

	// RVA: 0x31C64C0 Offset: 0x31C65C1 VA: 0x31C64C0
	private void CompileTypeAsExpression(UnaryExpression node) { }

	// RVA: 0x31D0C00 Offset: 0x31D0D01 VA: 0x31D0C00
	private void CompileTypeIsExpression(Expression expr) { }

	// RVA: 0x31C2210 Offset: 0x31C2311 VA: 0x31C2210
	private void Compile(Expression expr, bool asVoid) { }

	// RVA: 0x31C2370 Offset: 0x31C2471 VA: 0x31C2370
	private void CompileAsVoid(Expression expr) { }

	// RVA: 0x31D0F00 Offset: 0x31D1001 VA: 0x31D0F00
	private void CompileNoLabelPush(Expression expr) { }

	// RVA: 0x31C0EA0 Offset: 0x31C0FA1 VA: 0x31C0EA0
	private void Compile(Expression expr) { }

	// RVA: 0x31D19A0 Offset: 0x31D1AA1 VA: 0x31D19A0
	private static void .cctor() { }
}

