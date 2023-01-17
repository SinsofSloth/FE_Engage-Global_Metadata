// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x3F8A0 Offset: 0x3F9A1 VA: 0x3F8A0
public class BinaryExpression : Expression // TypeDefIndex: 2755
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x407C0 Offset: 0x408C1 VA: 0x407C0
	private readonly Expression <Right>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x407D0 Offset: 0x408D1 VA: 0x407D0
	private readonly Expression <Left>k__BackingField; // 0x18

	// Properties
	public override bool CanReduce { get; }
	public Expression Right { get; }
	public Expression Left { get; }
	public MethodInfo Method { get; }
	public LambdaExpression Conversion { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	internal bool IsLiftedLogical { get; }
	internal bool IsReferenceComparison { get; }

	// Methods

	// RVA: 0x2E4C370 Offset: 0x2E4C471 VA: 0x2E4C370
	internal void .ctor(Expression left, Expression right) { }

	// RVA: 0x2E4C8E0 Offset: 0x2E4C9E1 VA: 0x2E4C8E0 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x2E4C910 Offset: 0x2E4CA11 VA: 0x2E4C910
	private static bool IsOpAssignment(ExpressionType op) { }

	[CompilerGeneratedAttribute] // RVA: 0x41A20 Offset: 0x41B21 VA: 0x41A20
	// RVA: 0x2E4C920 Offset: 0x2E4CA21 VA: 0x2E4C920
	public Expression get_Right() { }

	[CompilerGeneratedAttribute] // RVA: 0x41A30 Offset: 0x41B31 VA: 0x41A30
	// RVA: 0x2E4C930 Offset: 0x2E4CA31 VA: 0x2E4C930
	public Expression get_Left() { }

	// RVA: 0x2E4C940 Offset: 0x2E4CA41 VA: 0x2E4C940
	public MethodInfo get_Method() { }

	// RVA: 0x2E4C950 Offset: 0x2E4CA51 VA: 0x2E4C950 Slot: 10
	internal virtual MethodInfo GetMethod() { }

	// RVA: 0x2E4C960 Offset: 0x2E4CA61 VA: 0x2E4C960
	public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right) { }

	// RVA: 0x2E4DA40 Offset: 0x2E4DB41 VA: 0x2E4DA40 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x2E4E840 Offset: 0x2E4E941 VA: 0x2E4E840
	private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op) { }

	// RVA: 0x2E4E690 Offset: 0x2E4E791 VA: 0x2E4E690
	private Expression ReduceVariable() { }

	// RVA: 0x2E4DAD0 Offset: 0x2E4DBD1 VA: 0x2E4DAD0
	private Expression ReduceMember() { }

	// RVA: 0x2E4E060 Offset: 0x2E4E161 VA: 0x2E4E060
	private Expression ReduceIndex() { }

	// RVA: 0x2E4CB10 Offset: 0x2E4CC11 VA: 0x2E4CB10
	public LambdaExpression get_Conversion() { }

	// RVA: 0x2E4F1D0 Offset: 0x2E4F2D1 VA: 0x2E4F1D0 Slot: 11
	internal virtual LambdaExpression GetConversion() { }

	// RVA: 0x2E4F1E0 Offset: 0x2E4F2E1 VA: 0x2E4F1E0
	public bool get_IsLifted() { }

	// RVA: 0x2E4CE80 Offset: 0x2E4CF81 VA: 0x2E4CE80
	public bool get_IsLiftedToNull() { }

	// RVA: 0x2E4F340 Offset: 0x2E4F441 VA: 0x2E4F340 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x2E4F360 Offset: 0x2E4F461 VA: 0x2E4F360
	internal bool get_IsLiftedLogical() { }

	// RVA: 0x2E4CB20 Offset: 0x2E4CC21 VA: 0x2E4CB20
	internal bool get_IsReferenceComparison() { }

	// RVA: 0x2E4F460 Offset: 0x2E4F561 VA: 0x2E4F460
	internal Expression ReduceUserdefinedLifted() { }
}

