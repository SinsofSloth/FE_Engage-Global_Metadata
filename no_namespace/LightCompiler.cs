// Namespace: 
private sealed class LightCompiler.QuoteVisitor : ExpressionVisitor // TypeDefIndex: 3084
{
	// Fields
	private readonly Dictionary<ParameterExpression, int> _definedParameters; // 0x10
	public readonly HashSet<ParameterExpression> _hoistedParameters; // 0x18

	// Methods

	// RVA: 0x1C1D7C0 Offset: 0x1C1D8C1 VA: 0x1C1D7C0 Slot: 20
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x1C1D850 Offset: 0x1C1D951 VA: 0x1C1D850 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x1C1DEE0 Offset: 0x1C1DFE1 VA: 0x1C1DEE0 Slot: 21
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3889830 Offset: 0x3889931 VA: 0x3889830
	|-LightCompiler.QuoteVisitor.VisitLambda<object>
	*/

	// RVA: 0x1C1D8C0 Offset: 0x1C1D9C1 VA: 0x1C1D8C0
	private void PushParameters(IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1C1DBD0 Offset: 0x1C1DCD1 VA: 0x1C1DBD0
	private void PopParameters(IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1C1E030 Offset: 0x1C1E131 VA: 0x1C1E030
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x40570 Offset: 0x40671 VA: 0x40570
[Serializable]
private sealed class LightCompiler.<>c // TypeDefIndex: 3085
{
	// Fields
	public static readonly LightCompiler.<>c <>9; // 0x0
	public static Func<Expression, bool> <>9__56_1; // 0x8
	public static Func<SwitchCase, bool> <>9__56_0; // 0x10
	public static Action<LightCompiler, Expression> <>9__101_0; // 0x18

	// Methods

	// RVA: 0x1C1D570 Offset: 0x1C1D671 VA: 0x1C1D570
	private static void .cctor() { }

	// RVA: 0x1C1D5E0 Offset: 0x1C1D6E1 VA: 0x1C1D5E0
	public void .ctor() { }

	// RVA: 0x1C1D5F0 Offset: 0x1C1D6F1 VA: 0x1C1D5F0
	internal bool <CompileSwitchExpression>b__56_0(SwitchCase c) { }

	// RVA: 0x1C1D720 Offset: 0x1C1D821 VA: 0x1C1D720
	internal bool <CompileSwitchExpression>b__56_1(Expression t) { }

	// RVA: 0x1C1D7B0 Offset: 0x1C1D8B1 VA: 0x1C1D7B0
	internal void <CompileNoLabelPush>b__101_0(LightCompiler this, Expression e) { }
}

