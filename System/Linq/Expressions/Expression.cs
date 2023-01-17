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

