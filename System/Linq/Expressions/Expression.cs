// Namespace: System.Linq.Expressions
public abstract class Expression // TypeDefIndex: 2789
{
	// Fields
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; // 0x0
	private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories; // 0x8
	private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable; // 0x10

	// Properties
	public virtual ExpressionType NodeType { get; }
	public virtual Type Type { get; }
	public virtual bool CanReduce { get; }

	// Methods

	// RVA: 0x2E4EAA0 Offset: 0x2E4EBA1 VA: 0x2E4EAA0
	public static BinaryExpression Assign(Expression left, Expression right) { }

	// RVA: 0x2E5E850 Offset: 0x2E5E951 VA: 0x2E5E850
	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x2E5EDF0 Offset: 0x2E5EEF1 VA: 0x2E5EDF0
	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	// RVA: 0x2E5F6B0 Offset: 0x2E5F7B1 VA: 0x2E5F6B0
	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x2E5FAD0 Offset: 0x2E5FBD1 VA: 0x2E5FAD0
	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x2E5FD60 Offset: 0x2E5FE61 VA: 0x2E5FD60
	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x2E5EB90 Offset: 0x2E5EC91 VA: 0x2E5EB90
	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	// RVA: 0x2E5FF90 Offset: 0x2E60091 VA: 0x2E5FF90
	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	// RVA: 0x2E5F5C0 Offset: 0x2E5F6C1 VA: 0x2E5F5C0
	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	// RVA: 0x2E5F620 Offset: 0x2E5F721 VA: 0x2E5F620
	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	// RVA: 0x2E5F460 Offset: 0x2E5F561 VA: 0x2E5F460
	private static void ValidateOperator(MethodInfo method) { }

	// RVA: 0x2E60020 Offset: 0x2E60121 VA: 0x2E60020
	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	// RVA: 0x2E60110 Offset: 0x2E60211 VA: 0x2E60110
	private static bool IsNullComparison(Expression left, Expression right) { }

	// RVA: 0x2E60300 Offset: 0x2E60401 VA: 0x2E60300
	private static bool IsNullConstant(Expression e) { }

	// RVA: 0x2E60390 Offset: 0x2E60491 VA: 0x2E60390
	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	// RVA: 0x2E60AE0 Offset: 0x2E60BE1 VA: 0x2E60AE0
	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	// RVA: 0x2E60A50 Offset: 0x2E60B51 VA: 0x2E60A50
	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	// RVA: 0x2E4E890 Offset: 0x2E4E991 VA: 0x2E4E890
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x2E4CED0 Offset: 0x2E4CFD1 VA: 0x2E4CED0
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E632E0 Offset: 0x2E633E1 VA: 0x2E632E0
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x2E4CBE0 Offset: 0x2E4CCE1 VA: 0x2E4CBE0
	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	// RVA: 0x2E63430 Offset: 0x2E63531 VA: 0x2E63430
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x2E4CD30 Offset: 0x2E4CE31 VA: 0x2E4CD30
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	// RVA: 0x2E66630 Offset: 0x2E66731 VA: 0x2E66630
	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x2E63040 Offset: 0x2E63141 VA: 0x2E63040
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x2E62DA0 Offset: 0x2E62EA1 VA: 0x2E62DA0
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x2E63190 Offset: 0x2E63291 VA: 0x2E63190
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x2E62EF0 Offset: 0x2E62FF1 VA: 0x2E62EF0
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x2E669B0 Offset: 0x2E66AB1 VA: 0x2E669B0
	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x2E62230 Offset: 0x2E62331 VA: 0x2E62230
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E628F0 Offset: 0x2E629F1 VA: 0x2E628F0
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E637B0 Offset: 0x2E638B1 VA: 0x2E637B0
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x2E66BC0 Offset: 0x2E66CC1 VA: 0x2E66BC0
	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	// RVA: 0x2E60D00 Offset: 0x2E60E01 VA: 0x2E60D00
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E64320 Offset: 0x2E64421 VA: 0x2E64320
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E5F8E0 Offset: 0x2E5F9E1 VA: 0x2E5F8E0
	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	// RVA: 0x2E65E80 Offset: 0x2E65F81 VA: 0x2E65E80
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E60F30 Offset: 0x2E61031 VA: 0x2E60F30
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E61160 Offset: 0x2E61261 VA: 0x2E61160
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E65BF0 Offset: 0x2E65CF1 VA: 0x2E65BF0
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E66110 Offset: 0x2E66211 VA: 0x2E66110
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E61390 Offset: 0x2E61491 VA: 0x2E61390
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E61A20 Offset: 0x2E61B21 VA: 0x2E61A20
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E64840 Offset: 0x2E64941 VA: 0x2E64840
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E61C50 Offset: 0x2E61D51 VA: 0x2E61C50
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E65000 Offset: 0x2E65101 VA: 0x2E65000
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E615C0 Offset: 0x2E616C1 VA: 0x2E615C0
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E65290 Offset: 0x2E65391 VA: 0x2E65290
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E663A0 Offset: 0x2E664A1 VA: 0x2E663A0
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E617F0 Offset: 0x2E618F1 VA: 0x2E617F0
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E66CA0 Offset: 0x2E66DA1 VA: 0x2E66CA0
	private static bool IsSimpleShift(Type left, Type right) { }

	// RVA: 0x2E66D70 Offset: 0x2E66E71 VA: 0x2E66D70
	private static Type GetResultTypeOfShift(Type left, Type right) { }

	// RVA: 0x2E640E0 Offset: 0x2E641E1 VA: 0x2E640E0
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E64D60 Offset: 0x2E64E61 VA: 0x2E64D60
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E63EA0 Offset: 0x2E63FA1 VA: 0x2E63EA0
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E65950 Offset: 0x2E65A51 VA: 0x2E65950
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E62000 Offset: 0x2E62101 VA: 0x2E62000
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E645B0 Offset: 0x2E646B1 VA: 0x2E645B0
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E626C0 Offset: 0x2E627C1 VA: 0x2E626C0
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E65520 Offset: 0x2E65621 VA: 0x2E65520
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E63580 Offset: 0x2E63681 VA: 0x2E63580
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E64AD0 Offset: 0x2E64BD1 VA: 0x2E64AD0
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E61E80 Offset: 0x2E61F81 VA: 0x2E61E80
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x2E657B0 Offset: 0x2E658B1 VA: 0x2E657B0
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x2E63CB0 Offset: 0x2E63DB1 VA: 0x2E63CB0
	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	// RVA: 0x2E66EC0 Offset: 0x2E66FC1 VA: 0x2E66EC0
	public static BlockExpression Block(Type type, Expression[] expressions) { }

	// RVA: 0x2E66F90 Offset: 0x2E67091 VA: 0x2E66F90
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	// RVA: 0x2E672B0 Offset: 0x2E673B1 VA: 0x2E672B0
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x2E4EF30 Offset: 0x2E4F031 VA: 0x2E4EF30
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x2E67040 Offset: 0x2E67141 VA: 0x2E67040
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x2E67E60 Offset: 0x2E67F61 VA: 0x2E67E60
	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x2E681A0 Offset: 0x2E682A1 VA: 0x2E681A0
	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	// RVA: 0x2E67490 Offset: 0x2E67591 VA: 0x2E67490
	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x2E55350 Offset: 0x2E55451 VA: 0x2E55350
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	// RVA: 0x2E50710 Offset: 0x2E50811 VA: 0x2E50710
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x2E55D20 Offset: 0x2E55E21 VA: 0x2E55D20
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x2E68370 Offset: 0x2E68471 VA: 0x2E68370
	public static ConstantExpression Constant(object value) { }

	// RVA: 0x2E50430 Offset: 0x2E50531 VA: 0x2E50430
	public static ConstantExpression Constant(object value, Type type) { }

	// RVA: 0x2E68430 Offset: 0x2E68531 VA: 0x2E68430
	public static DefaultExpression Empty() { }

	// RVA: 0x2E4C8D0 Offset: 0x2E4C9D1 VA: 0x2E4C8D0
	protected void .ctor() { }

	// RVA: 0x2E68540 Offset: 0x2E68641 VA: 0x2E68540 Slot: 4
	public virtual ExpressionType get_NodeType() { }

	// RVA: 0x2E68640 Offset: 0x2E68741 VA: 0x2E68640 Slot: 5
	public virtual Type get_Type() { }

	// RVA: 0x2E68740 Offset: 0x2E68841 VA: 0x2E68740 Slot: 6
	public virtual bool get_CanReduce() { }

	// RVA: 0x2E68750 Offset: 0x2E68851 VA: 0x2E68750 Slot: 7
	public virtual Expression Reduce() { }

	// RVA: 0x2E687A0 Offset: 0x2E688A1 VA: 0x2E687A0 Slot: 8
	protected internal virtual Expression VisitChildren(ExpressionVisitor visitor) { }

	// RVA: 0x2E688D0 Offset: 0x2E689D1 VA: 0x2E688D0 Slot: 9
	protected internal virtual Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x2E68810 Offset: 0x2E68911 VA: 0x2E68810
	public Expression ReduceAndCheck() { }

	// RVA: 0x2E688F0 Offset: 0x2E689F1 VA: 0x2E688F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2E67330 Offset: 0x2E67431 VA: 0x2E67330
	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	// RVA: 0x2E5E600 Offset: 0x2E5E701 VA: 0x2E5E600
	private static void RequiresCanWrite(Expression expression, string paramName) { }

	// RVA: 0x2E68900 Offset: 0x2E68A01 VA: 0x2E68900
	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	// RVA: 0x2E689E0 Offset: 0x2E68AE1 VA: 0x2E689E0
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	// RVA: 0x2E68AE0 Offset: 0x2E68BE1 VA: 0x2E68AE0
	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	// RVA: 0x2E68CB0 Offset: 0x2E68DB1 VA: 0x2E68CB0
	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	// RVA: 0x2E4F100 Offset: 0x2E4F201 VA: 0x2E4F100
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x2E69360 Offset: 0x2E69461 VA: 0x2E69360
	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	// RVA: 0x2E68EE0 Offset: 0x2E68FE1 VA: 0x2E68EE0
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	// RVA: 0x2E68E20 Offset: 0x2E68F21 VA: 0x2E68E20
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x2E693D0 Offset: 0x2E694D1 VA: 0x2E693D0
	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x2E694A0 Offset: 0x2E695A1 VA: 0x2E694A0
	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x2E69A20 Offset: 0x2E69B21 VA: 0x2E69A20
	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x2E69CC0 Offset: 0x2E69DC1 VA: 0x2E69CC0
	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x2E4E930 Offset: 0x2E4EA31 VA: 0x2E4E930
	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	// RVA: 0x2E6A0B0 Offset: 0x2E6A1B1 VA: 0x2E6A0B0
	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	// RVA: 0x2E6A2B0 Offset: 0x2E6A3B1 VA: 0x2E6A2B0
	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	// RVA: 0x2E6A3A0 Offset: 0x2E6A4A1 VA: 0x2E6A3A0
	public static LabelTarget Label(Type type, string name) { }

	// RVA: 0x2E6A480 Offset: 0x2E6A581 VA: 0x2E6A480
	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B3320 Offset: 0x22B3421 VA: 0x22B3320
	|-Expression.Lambda<Action<object, object[]>>
	|-Expression.Lambda<Action<object, object>>
	|-Expression.Lambda<Func<object, object>>
	|-Expression.Lambda<Func<object, object[], object>>
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B33B0 Offset: 0x22B34B1 VA: 0x22B33B0
	|-Expression.Lambda<object>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B3450 Offset: 0x22B3551 VA: 0x22B3450
	|-Expression.Lambda<object>
	*/

	// RVA: 0x2E6A940 Offset: 0x2E6AA41 VA: 0x2E6A940
	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	// RVA: 0x2E6A9D0 Offset: 0x2E6AAD1 VA: 0x2E6A9D0
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x2E6AAC0 Offset: 0x2E6ABC1 VA: 0x2E6AAC0
	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	// RVA: 0x2E6B0B0 Offset: 0x2E6B1B1 VA: 0x2E6B0B0
	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	// RVA: 0x2E6B250 Offset: 0x2E6B351 VA: 0x2E6B250
	public static MemberExpression Field(Expression expression, string fieldName) { }

	// RVA: 0x2E4FCB0 Offset: 0x2E4FDB1 VA: 0x2E4FCB0
	public static MemberExpression Property(Expression expression, string propertyName) { }

	// RVA: 0x2E6B3E0 Offset: 0x2E6B4E1 VA: 0x2E6B3E0
	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	// RVA: 0x2E4ED40 Offset: 0x2E4EE41 VA: 0x2E4ED40
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	// RVA: 0x2E6B690 Offset: 0x2E6B791 VA: 0x2E6B690
	internal static MethodCallExpression Call(MethodInfo method) { }

	// RVA: 0x2E50050 Offset: 0x2E50151 VA: 0x2E50050
	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	// RVA: 0x2E501D0 Offset: 0x2E502D1 VA: 0x2E501D0
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x2E6B840 Offset: 0x2E6B941 VA: 0x2E6B840
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x2E6BA90 Offset: 0x2E6BB91 VA: 0x2E6BA90
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x2E6BD40 Offset: 0x2E6BE41 VA: 0x2E6BD40
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x2E6C050 Offset: 0x2E6C151 VA: 0x2E6C050
	public static MethodCallExpression Call(MethodInfo method, Expression[] arguments) { }

	// RVA: 0x2E6C190 Offset: 0x2E6C291 VA: 0x2E6C190
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x2E6CBB0 Offset: 0x2E6CCB1 VA: 0x2E6CBB0
	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	// RVA: 0x2E6C110 Offset: 0x2E6C211 VA: 0x2E6C110
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	// RVA: 0x2E6CD00 Offset: 0x2E6CE01 VA: 0x2E6CD00
	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	// RVA: 0x2E6CEC0 Offset: 0x2E6CFC1 VA: 0x2E6CEC0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x2E6D0F0 Offset: 0x2E6D1F1 VA: 0x2E6D0F0
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x2E4FE50 Offset: 0x2E4FF51 VA: 0x2E4FE50
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	// RVA: 0x2E6C210 Offset: 0x2E6C311 VA: 0x2E6C210
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x2E6B7A0 Offset: 0x2E6B8A1 VA: 0x2E6B7A0
	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	// RVA: 0x2E6D670 Offset: 0x2E6D771 VA: 0x2E6D670
	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	// RVA: 0x2E69C50 Offset: 0x2E69D51 VA: 0x2E69C50
	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	// RVA: 0x2E6D790 Offset: 0x2E6D891 VA: 0x2E6D790
	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x2E6A280 Offset: 0x2E6A381 VA: 0x2E6A280
	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: 0x2E6A290 Offset: 0x2E6A391 VA: 0x2E6A290
	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x2E6A2A0 Offset: 0x2E6A3A1 VA: 0x2E6A2A0
	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	// RVA: 0x2E68E10 Offset: 0x2E68F11 VA: 0x2E68E10
	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x2E6D380 Offset: 0x2E6D481 VA: 0x2E6D380
	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	// RVA: 0x2E6D850 Offset: 0x2E6D951 VA: 0x2E6D850
	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	// RVA: 0x2E6D7A0 Offset: 0x2E6D8A1 VA: 0x2E6D7A0
	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	// RVA: 0x2E6DA90 Offset: 0x2E6DB91 VA: 0x2E6DA90
	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	// RVA: 0x2E6DB00 Offset: 0x2E6DC01 VA: 0x2E6DB00
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	// RVA: 0x2E6DF20 Offset: 0x2E6E021 VA: 0x2E6DF20
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	// RVA: 0x2E6E1A0 Offset: 0x2E6E2A1 VA: 0x2E6E1A0
	public static ParameterExpression Parameter(Type type) { }

	// RVA: 0x2E4FC00 Offset: 0x2E4FD01 VA: 0x2E4FC00
	public static ParameterExpression Parameter(Type type, string name) { }

	// RVA: 0x2E4ECB0 Offset: 0x2E4EDB1 VA: 0x2E4ECB0
	public static ParameterExpression Variable(Type type, string name) { }

	// RVA: 0x2E6E210 Offset: 0x2E6E311 VA: 0x2E6E210
	private static void Validate(Type type, bool allowByRef) { }

	// RVA: 0x2E6E350 Offset: 0x2E6E451 VA: 0x2E6E350
	public static TryExpression TryFinally(Expression body, Expression finally) { }

	// RVA: 0x2E6E3D0 Offset: 0x2E6E4D1 VA: 0x2E6E3D0
	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	// RVA: 0x2E6E600 Offset: 0x2E6E701 VA: 0x2E6E600
	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	// RVA: 0x2E6EE90 Offset: 0x2E6EF91 VA: 0x2E6EE90
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	// RVA: 0x2E71060 Offset: 0x2E71161 VA: 0x2E71060
	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x2E71240 Offset: 0x2E71341 VA: 0x2E71240
	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x2E714F0 Offset: 0x2E715F1 VA: 0x2E714F0
	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	// RVA: 0x2E718E0 Offset: 0x2E719E1 VA: 0x2E718E0
	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x2E71A20 Offset: 0x2E71B21 VA: 0x2E71A20
	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x2E71AE0 Offset: 0x2E71BE1 VA: 0x2E71AE0
	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	// RVA: 0x2E6F510 Offset: 0x2E6F611 VA: 0x2E6F510
	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	// RVA: 0x2E70820 Offset: 0x2E70921 VA: 0x2E70820
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	// RVA: 0x2E6F6B0 Offset: 0x2E6F7B1 VA: 0x2E6F6B0
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	// RVA: 0x2E6F850 Offset: 0x2E6F951 VA: 0x2E6F850
	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	// RVA: 0x2E6FA10 Offset: 0x2E6FB11 VA: 0x2E6FA10
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	// RVA: 0x2E6FB80 Offset: 0x2E6FC81 VA: 0x2E6FB80
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	// RVA: 0x2E6FCF0 Offset: 0x2E6FDF1 VA: 0x2E6FCF0
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	// RVA: 0x2E705A0 Offset: 0x2E706A1 VA: 0x2E705A0
	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	// RVA: 0x2E70990 Offset: 0x2E70A91 VA: 0x2E70990
	public static UnaryExpression Unbox(Expression expression, Type type) { }

	// RVA: 0x2E503B0 Offset: 0x2E504B1 VA: 0x2E503B0
	public static UnaryExpression Convert(Expression expression, Type type) { }

	// RVA: 0x2E70050 Offset: 0x2E70151 VA: 0x2E70050
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x2E70240 Offset: 0x2E70341 VA: 0x2E70240
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x2E6FE60 Offset: 0x2E6FF61 VA: 0x2E6FE60
	public static UnaryExpression ArrayLength(Expression array) { }

	// RVA: 0x2E70700 Offset: 0x2E70801 VA: 0x2E70700
	public static UnaryExpression Quote(Expression expression) { }

	// RVA: 0x2E70450 Offset: 0x2E70551 VA: 0x2E70450
	public static UnaryExpression Throw(Expression value, Type type) { }

	// RVA: 0x2E70B80 Offset: 0x2E70C81 VA: 0x2E70B80
	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	// RVA: 0x2E70CF0 Offset: 0x2E70DF1 VA: 0x2E70CF0
	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	// RVA: 0x2E70E60 Offset: 0x2E70F61 VA: 0x2E70E60
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x2E70F60 Offset: 0x2E71061 VA: 0x2E70F60
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x2E70EE0 Offset: 0x2E70FE1 VA: 0x2E70EE0
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x2E70FE0 Offset: 0x2E710E1 VA: 0x2E70FE0
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x2E71E40 Offset: 0x2E71F41 VA: 0x2E71E40
	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	// RVA: 0x2E72090 Offset: 0x2E72191 VA: 0x2E72090
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions
public class Expression<TDelegate> : LambdaExpression // TypeDefIndex: 2828
{
	// Properties
	internal sealed override Type TypeCore { get; }
	internal override Type PublicType { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Expression body) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CFD50 Offset: 0x33CFE51 VA: 0x33CFD50
	|-Expression<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	internal sealed override Type get_TypeCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CFD60 Offset: 0x33CFE61 VA: 0x33CFD60
	|-Expression<object>.get_TypeCore
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override Type get_PublicType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CFDE0 Offset: 0x33CFEE1 VA: 0x33CFDE0
	|-Expression<object>.get_PublicType
	*/

	// RVA: -1 Offset: -1
	public TDelegate Compile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CFE60 Offset: 0x33CFF61 VA: 0x33CFE60
	|-Expression<Action<object, object[]>>.Compile
	|-Expression<Action<object, object>>.Compile
	|-Expression<Func<object, object>>.Compile
	|-Expression<Func<object, object[], object>>.Compile
	|-Expression<object>.Compile
	*/

	// RVA: -1 Offset: -1
	public TDelegate Compile(bool preferInterpretation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CFE80 Offset: 0x33CFF81 VA: 0x33CFE80
	|-Expression<object>.Compile
	*/

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41DB0 Offset: 0x41EB1 VA: 0x41DB0
	// RVA: -1 Offset: -1 Slot: 18
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CFF50 Offset: 0x33D0051 VA: 0x33CFF50
	|-Expression<object>.Rewrite
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CFF80 Offset: 0x33D0081 VA: 0x33CFF80
	|-Expression<object>.Accept
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class Expression0<TDelegate> : Expression<TDelegate> // TypeDefIndex: 2830
{
	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CED90 Offset: 0x33CEE91 VA: 0x33CED90
	|-Expression0<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CEDB0 Offset: 0x33CEEB1 VA: 0x33CEDB0
	|-Expression0<object>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CEDC0 Offset: 0x33CEEC1 VA: 0x33CEDC0
	|-Expression0<object>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CEE00 Offset: 0x33CEF01 VA: 0x33CEE00
	|-Expression0<object>.Rewrite
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class Expression1<TDelegate> : Expression<TDelegate> // TypeDefIndex: 2831
{
	// Fields
	private object _par0; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CEE90 Offset: 0x33CEF91 VA: 0x33CEE90
	|-Expression1<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CEED0 Offset: 0x33CEFD1 VA: 0x33CEED0
	|-Expression1<object>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CEEE0 Offset: 0x33CEFE1 VA: 0x33CEEE0
	|-Expression1<object>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CEF70 Offset: 0x33CF071 VA: 0x33CEF70
	|-Expression1<object>.Rewrite
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class Expression2<TDelegate> : Expression<TDelegate> // TypeDefIndex: 2832
{
	// Fields
	private object _par0; // 0x0
	private readonly ParameterExpression _par1; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0, ParameterExpression par1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CF0B0 Offset: 0x33CF1B1 VA: 0x33CF0B0
	|-Expression2<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CF110 Offset: 0x33CF211 VA: 0x33CF110
	|-Expression2<object>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CF120 Offset: 0x33CF221 VA: 0x33CF120
	|-Expression2<object>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CF1D0 Offset: 0x33CF2D1 VA: 0x33CF1D0
	|-Expression2<object>.Rewrite
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class Expression3<TDelegate> : Expression<TDelegate> // TypeDefIndex: 2833
{
	// Fields
	private object _par0; // 0x0
	private readonly ParameterExpression _par1; // 0x0
	private readonly ParameterExpression _par2; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CF340 Offset: 0x33CF441 VA: 0x33CF340
	|-Expression3<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CF3B0 Offset: 0x33CF4B1 VA: 0x33CF3B0
	|-Expression3<object>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CF3C0 Offset: 0x33CF4C1 VA: 0x33CF3C0
	|-Expression3<object>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CF490 Offset: 0x33CF591 VA: 0x33CF490
	|-Expression3<object>.Rewrite
	*/
}

