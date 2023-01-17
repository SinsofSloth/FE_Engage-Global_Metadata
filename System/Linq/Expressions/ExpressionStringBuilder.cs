// Namespace: System.Linq.Expressions
internal sealed class ExpressionStringBuilder : ExpressionVisitor // TypeDefIndex: 2815
{
	// Fields
	private readonly StringBuilder _out; // 0x10
	private Dictionary<object, int> _ids; // 0x18

	// Methods

	// RVA: 0x31AEEF0 Offset: 0x31AEFF1 VA: 0x31AEEF0
	private void .ctor() { }

	// RVA: 0x31AEF80 Offset: 0x31AF081 VA: 0x31AEF80 Slot: 3
	public override string ToString() { }

	// RVA: 0x31AEF90 Offset: 0x31AF091 VA: 0x31AEF90
	private int GetLabelId(LabelTarget label) { }

	// RVA: 0x31AF0C0 Offset: 0x31AF1C1 VA: 0x31AF0C0
	private int GetParamId(ParameterExpression p) { }

	// RVA: 0x31AEFA0 Offset: 0x31AF0A1 VA: 0x31AEFA0
	private int GetId(object o) { }

	// RVA: 0x31AF0D0 Offset: 0x31AF1D1 VA: 0x31AF0D0
	private void Out(string s) { }

	// RVA: 0x31AF0E0 Offset: 0x31AF1E1 VA: 0x31AF0E0
	private void Out(char c) { }

	// RVA: 0x31AF0F0 Offset: 0x31AF1F1 VA: 0x31AF0F0
	internal static string ExpressionToString(Expression node) { }

	// RVA: 0x31AF1C0 Offset: 0x31AF2C1 VA: 0x31AF1C0
	internal static string CatchBlockToString(CatchBlock node) { }

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B35D0 Offset: 0x22B36D1 VA: 0x22B35D0
	|-ExpressionStringBuilder.VisitExpressions<Expression>
	|-ExpressionStringBuilder.VisitExpressions<object>
	*/

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close, string seperator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B3660 Offset: 0x22B3761 VA: 0x22B3660
	|-ExpressionStringBuilder.VisitExpressions<object>
	*/

	// RVA: 0x31AF2A0 Offset: 0x31AF3A1 VA: 0x31AF2A0 Slot: 5
	protected internal override Expression VisitBinary(BinaryExpression node) { }

	// RVA: 0x31AF8C0 Offset: 0x31AF9C1 VA: 0x31AF8C0 Slot: 20
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B3900 Offset: 0x22B3A01 VA: 0x22B3900
	|-ExpressionStringBuilder.VisitLambda<object>
	*/

	// RVA: 0x31AF9C0 Offset: 0x31AFAC1 VA: 0x31AF9C0 Slot: 7
	protected internal override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x31AFAC0 Offset: 0x31AFBC1 VA: 0x31AFAC0 Slot: 8
	protected internal override Expression VisitConstant(ConstantExpression node) { }

	// RVA: 0x31AFC20 Offset: 0x31AFD21 VA: 0x31AFC20
	private void OutMember(Expression instance, MemberInfo member) { }

	// RVA: 0x31AFCB0 Offset: 0x31AFDB1 VA: 0x31AFCB0 Slot: 16
	protected internal override Expression VisitMember(MemberExpression node) { }

	// RVA: 0x31AFD70 Offset: 0x31AFE71 VA: 0x31AFD70 Slot: 12
	protected internal override Expression VisitInvocation(InvocationExpression node) { }

	// RVA: 0x31AFE80 Offset: 0x31AFF81 VA: 0x31AFE80 Slot: 18
	protected internal override Expression VisitMethodCall(MethodCallExpression node) { }

	// RVA: 0x31B0070 Offset: 0x31B0171 VA: 0x31B0070 Slot: 19
	protected internal override Expression VisitNewArray(NewArrayExpression node) { }

	// RVA: 0x31B0190 Offset: 0x31B0291 VA: 0x31B0190 Slot: 23
	protected internal override Expression VisitUnary(UnaryExpression node) { }

	// RVA: 0x31B0520 Offset: 0x31B0621 VA: 0x31B0520 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x31B07F0 Offset: 0x31B08F1 VA: 0x31B07F0 Slot: 9
	protected internal override Expression VisitDefault(DefaultExpression node) { }

	// RVA: 0x31B0890 Offset: 0x31B0991 VA: 0x31B0890 Slot: 14
	protected internal override Expression VisitLabel(LabelExpression node) { }

	// RVA: 0x31B09F0 Offset: 0x31B0AF1 VA: 0x31B09F0 Slot: 11
	protected internal override Expression VisitGoto(GotoExpression node) { }

	// RVA: 0x31B0B40 Offset: 0x31B0C41 VA: 0x31B0B40 Slot: 21
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x31B0C30 Offset: 0x31B0D31 VA: 0x31B0C30 Slot: 22
	protected internal override Expression VisitTry(TryExpression node) { }

	// RVA: 0x31B0CA0 Offset: 0x31B0DA1 VA: 0x31B0CA0 Slot: 17
	protected internal override Expression VisitIndex(IndexExpression node) { }

	// RVA: 0x31B1070 Offset: 0x31B1171 VA: 0x31B1070 Slot: 10
	protected internal override Expression VisitExtension(Expression node) { }

	// RVA: 0x31B0910 Offset: 0x31B0A11 VA: 0x31B0910
	private void DumpLabel(LabelTarget target) { }

	// RVA: 0x31AF7A0 Offset: 0x31AF8A1 VA: 0x31AF7A0
	private static bool IsBool(Expression node) { }
}

