// Namespace: System.Linq.Expressions
public abstract class ExpressionVisitor // TypeDefIndex: 2817
{
	// Methods

	// RVA: 0x31AEF70 Offset: 0x31AF071 VA: 0x31AEF70
	protected void .ctor() { }

	// RVA: 0x31B1BD0 Offset: 0x31B1CD1 VA: 0x31B1BD0 Slot: 4
	public virtual Expression Visit(Expression node) { }

	// RVA: 0x31B1C00 Offset: 0x31B1D01 VA: 0x31B1C00
	public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes) { }

	// RVA: 0x31B1E90 Offset: 0x31B1F91 VA: 0x31B1E90
	private Expression[] VisitArguments(IArgumentProvider nodes) { }

	// RVA: 0x31B2150 Offset: 0x31B2251 VA: 0x31B2150
	private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName) { }

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B4200 Offset: 0x22B4301 VA: 0x22B4200
	|-ExpressionVisitor.Visit<CatchBlock>
	|-ExpressionVisitor.Visit<object>
	*/

	// RVA: -1 Offset: -1
	public T VisitAndConvert<T>(T node, string callerName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B4450 Offset: 0x22B4551 VA: 0x22B4450
	|-ExpressionVisitor.VisitAndConvert<LambdaExpression>
	|-ExpressionVisitor.VisitAndConvert<object>
	|-ExpressionVisitor.VisitAndConvert<ParameterExpression>
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B4580 Offset: 0x22B4681 VA: 0x22B4580
	|-ExpressionVisitor.VisitAndConvert<object>
	|-ExpressionVisitor.VisitAndConvert<ParameterExpression>
	*/

	// RVA: 0x31B2430 Offset: 0x31B2531 VA: 0x31B2430 Slot: 5
	protected internal virtual Expression VisitBinary(BinaryExpression node) { }

	// RVA: 0x31B26F0 Offset: 0x31B27F1 VA: 0x31B26F0 Slot: 6
	protected internal virtual Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x31B29E0 Offset: 0x31B2AE1 VA: 0x31B29E0 Slot: 7
	protected internal virtual Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x31B2A70 Offset: 0x31B2B71 VA: 0x31B2A70 Slot: 8
	protected internal virtual Expression VisitConstant(ConstantExpression node) { }

	// RVA: 0x31B2A80 Offset: 0x31B2B81 VA: 0x31B2A80 Slot: 9
	protected internal virtual Expression VisitDefault(DefaultExpression node) { }

	// RVA: 0x31B2A90 Offset: 0x31B2B91 VA: 0x31B2A90 Slot: 10
	protected internal virtual Expression VisitExtension(Expression node) { }

	// RVA: 0x31B2AB0 Offset: 0x31B2BB1 VA: 0x31B2AB0 Slot: 11
	protected internal virtual Expression VisitGoto(GotoExpression node) { }

	// RVA: 0x31B2C80 Offset: 0x31B2D81 VA: 0x31B2C80 Slot: 12
	protected internal virtual Expression VisitInvocation(InvocationExpression node) { }

	// RVA: 0x31B2D10 Offset: 0x31B2E11 VA: 0x31B2D10 Slot: 13
	protected virtual LabelTarget VisitLabelTarget(LabelTarget node) { }

	// RVA: 0x31B2D20 Offset: 0x31B2E21 VA: 0x31B2D20 Slot: 14
	protected internal virtual Expression VisitLabel(LabelExpression node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal virtual Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B4890 Offset: 0x22B4991 VA: 0x22B4890
	|-ExpressionVisitor.VisitLambda<object>
	*/

	// RVA: 0x31B2EA0 Offset: 0x31B2FA1 VA: 0x31B2EA0 Slot: 16
	protected internal virtual Expression VisitMember(MemberExpression node) { }

	// RVA: 0x31B2EE0 Offset: 0x31B2FE1 VA: 0x31B2EE0 Slot: 17
	protected internal virtual Expression VisitIndex(IndexExpression node) { }

	// RVA: 0x31B3080 Offset: 0x31B3181 VA: 0x31B3080 Slot: 18
	protected internal virtual Expression VisitMethodCall(MethodCallExpression node) { }

	// RVA: 0x31B3120 Offset: 0x31B3221 VA: 0x31B3120 Slot: 19
	protected internal virtual Expression VisitNewArray(NewArrayExpression node) { }

	// RVA: 0x31B3150 Offset: 0x31B3251 VA: 0x31B3150 Slot: 20
	protected internal virtual Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x31B3160 Offset: 0x31B3261 VA: 0x31B3160 Slot: 21
	protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x31B3230 Offset: 0x31B3331 VA: 0x31B3230 Slot: 22
	protected internal virtual Expression VisitTry(TryExpression node) { }

	// RVA: 0x31B3350 Offset: 0x31B3451 VA: 0x31B3350 Slot: 23
	protected internal virtual Expression VisitUnary(UnaryExpression node) { }

	// RVA: 0x31B33A0 Offset: 0x31B34A1 VA: 0x31B33A0
	private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after) { }

	// RVA: 0x31B2510 Offset: 0x31B2611 VA: 0x31B2510
	private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after) { }

	// RVA: 0x31B34F0 Offset: 0x31B35F1 VA: 0x31B34F0
	private static void ValidateChildType(Type before, Type after, string methodName) { }
}

