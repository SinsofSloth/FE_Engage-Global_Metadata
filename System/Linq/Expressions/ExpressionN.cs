// Namespace: System.Linq.Expressions
internal class ExpressionN<TDelegate> : Expression<TDelegate> // TypeDefIndex: 2834
{
	// Fields
	private IReadOnlyList<ParameterExpression> _parameters; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, IReadOnlyList<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CFAD0 Offset: 0x33CFBD1 VA: 0x33CFAD0
	|-ExpressionN<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CFB10 Offset: 0x33CFC11 VA: 0x33CFB10
	|-ExpressionN<object>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CFBC0 Offset: 0x33CFCC1 VA: 0x33CFBC0
	|-ExpressionN<object>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CFC70 Offset: 0x33CFD71 VA: 0x33CFC70
	|-ExpressionN<object>.Rewrite
	*/
}

