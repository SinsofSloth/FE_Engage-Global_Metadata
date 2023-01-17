// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x40000 Offset: 0x40101 VA: 0x40000
public class MethodCallExpression : Expression, IArgumentProvider // TypeDefIndex: 2847
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x40A90 Offset: 0x40B91 VA: 0x40A90
	private readonly MethodInfo <Method>k__BackingField; // 0x10

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }
	public MethodInfo Method { get; }
	public Expression Object { get; }
	[ExcludeFromCodeCoverageAttribute] // RVA: 0x42580 Offset: 0x42681 VA: 0x42580
	public virtual int ArgumentCount { get; }

	// Methods

	// RVA: 0x33261B0 Offset: 0x33262B1 VA: 0x33261B0
	internal void .ctor(MethodInfo method) { }

	// RVA: 0x3326230 Offset: 0x3326331 VA: 0x3326230 Slot: 12
	internal virtual Expression GetInstance() { }

	// RVA: 0x3326240 Offset: 0x3326341 VA: 0x3326240 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x3326250 Offset: 0x3326351 VA: 0x3326250 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x41EB0 Offset: 0x41FB1 VA: 0x41EB0
	// RVA: 0x3326270 Offset: 0x3326371 VA: 0x3326270
	public MethodInfo get_Method() { }

	// RVA: 0x3326280 Offset: 0x3326381 VA: 0x3326280
	public Expression get_Object() { }

	// RVA: 0x3326290 Offset: 0x3326391 VA: 0x3326290 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41EC0 Offset: 0x41FC1 VA: 0x41EC0
	// RVA: 0x33262B0 Offset: 0x33263B1 VA: 0x33262B0 Slot: 13
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41ED0 Offset: 0x41FD1 VA: 0x41ED0
	// RVA: 0x33262E0 Offset: 0x33263E1 VA: 0x33262E0 Slot: 14
	public virtual Expression GetArgument(int index) { }

	// RVA: 0x3326310 Offset: 0x3326411 VA: 0x3326310 Slot: 15
	public virtual int get_ArgumentCount() { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression0 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 2851
{
	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x3326340 Offset: 0x3326441 VA: 0x3326340
	public void .ctor(MethodInfo method) { }

	// RVA: 0x33263C0 Offset: 0x33264C1 VA: 0x33263C0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x3326420 Offset: 0x3326521 VA: 0x3326420 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x3326430 Offset: 0x3326531 VA: 0x3326430 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression1 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 2852
{
	// Fields
	private object _arg0; // 0x18

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x33264A0 Offset: 0x33265A1 VA: 0x33264A0
	public void .ctor(MethodInfo method, Expression arg0) { }

	// RVA: 0x3326540 Offset: 0x3326641 VA: 0x3326540 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x33265F0 Offset: 0x33266F1 VA: 0x33265F0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x3326600 Offset: 0x3326701 VA: 0x3326600 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression2 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 2853
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x3326730 Offset: 0x3326831 VA: 0x3326730
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x33267E0 Offset: 0x33268E1 VA: 0x33267E0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x33268A0 Offset: 0x33269A1 VA: 0x33268A0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x33268B0 Offset: 0x33269B1 VA: 0x33268B0 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression3 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 2854
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x3326A60 Offset: 0x3326B61 VA: 0x3326A60
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x3326B30 Offset: 0x3326C31 VA: 0x3326B30 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x3326C10 Offset: 0x3326D11 VA: 0x3326C10 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x3326C20 Offset: 0x3326D21 VA: 0x3326C20 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression4 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 2855
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28
	private readonly Expression _arg3; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x3326E40 Offset: 0x3326F41 VA: 0x3326E40
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x3326F20 Offset: 0x3327021 VA: 0x3326F20 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x3327020 Offset: 0x3327121 VA: 0x3327020 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x3327030 Offset: 0x3327131 VA: 0x3327030 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression5 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 2856
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28
	private readonly Expression _arg3; // 0x30
	private readonly Expression _arg4; // 0x38

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x33272C0 Offset: 0x33273C1 VA: 0x33272C0
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x33273C0 Offset: 0x33274C1 VA: 0x33273C0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x33274E0 Offset: 0x33275E1 VA: 0x33274E0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x33274F0 Offset: 0x33275F1 VA: 0x33274F0 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

