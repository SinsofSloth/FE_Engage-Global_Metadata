// Namespace: System.Dynamic.Utils
internal static class ExpressionUtils // TypeDefIndex: 3277
{
	// Methods

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IReadOnlyList<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B3BB0 Offset: 0x22B3CB1 VA: 0x22B3BB0
	|-ExpressionUtils.ReturnReadOnly<Expression>
	|-ExpressionUtils.ReturnReadOnly<object>
	|-ExpressionUtils.ReturnReadOnly<ParameterExpression>
	*/

	// RVA: -1 Offset: -1
	public static T ReturnObject<T>(object collectionOrT) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B3AB0 Offset: 0x22B3BB1 VA: 0x22B3AB0
	|-ExpressionUtils.ReturnObject<Expression>
	|-ExpressionUtils.ReturnObject<object>
	|-ExpressionUtils.ReturnObject<ParameterExpression>
	*/

	// RVA: 0x31B1280 Offset: 0x31B1381 VA: 0x31B1280
	public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x31B1680 Offset: 0x31B1781 VA: 0x31B1680
	public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x31B1730 Offset: 0x31B1831 VA: 0x31B1730
	public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1) { }

	// RVA: 0x31B1BC0 Offset: 0x31B1CC1 VA: 0x31B1BC0
	public static void RequiresCanRead(Expression expression, string paramName) { }

	// RVA: 0x31B18F0 Offset: 0x31B19F1 VA: 0x31B18F0
	public static void RequiresCanRead(Expression expression, string paramName, int idx) { }

	// RVA: 0x31B1AA0 Offset: 0x31B1BA1 VA: 0x31B1AA0
	public static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x31B15D0 Offset: 0x31B16D1 VA: 0x31B15D0
	internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: -1 Offset: -1
	internal static bool SameElements<T>(ref IEnumerable<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B3C80 Offset: 0x22B3D81 VA: 0x22B3C80
	|-ExpressionUtils.SameElements<CatchBlock>
	|-ExpressionUtils.SameElements<Expression>
	|-ExpressionUtils.SameElements<object>
	*/

	// RVA: -1 Offset: -1
	private static bool SameElementsInCollection<T>(ICollection<T> replacement, IReadOnlyList<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B3DC0 Offset: 0x22B3EC1 VA: 0x22B3DC0
	|-ExpressionUtils.SameElementsInCollection<object>
	*/
}

