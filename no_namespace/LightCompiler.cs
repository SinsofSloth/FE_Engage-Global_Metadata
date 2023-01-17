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

