// Namespace: MoonSharp.Interpreter.Tree.Expressions
internal class BinaryOperatorExpression : Expression // TypeDefIndex: 6023
{
	// Fields
	private const BinaryOperatorExpression.Operator POWER = 32768;
	private const BinaryOperatorExpression.Operator MUL_DIV_MOD = 28672;
	private const BinaryOperatorExpression.Operator ADD_SUB = 1536;
	private const BinaryOperatorExpression.Operator STRCAT = 256;
	private const BinaryOperatorExpression.Operator COMPARES = 252;
	private const BinaryOperatorExpression.Operator LOGIC_AND = 2;
	private const BinaryOperatorExpression.Operator LOGIC_OR = 1;
	private Expression m_Exp1; // 0x20
	private Expression m_Exp2; // 0x28
	private BinaryOperatorExpression.Operator m_Operator; // 0x30

	// Methods

	// RVA: 0x30EC600 Offset: 0x30EC701 VA: 0x30EC600
	public static object BeginOperatorChain() { }

	// RVA: 0x30EC660 Offset: 0x30EC761 VA: 0x30EC660
	public static void AddExpressionToChain(object chain, Expression exp) { }

	// RVA: 0x30EC820 Offset: 0x30EC921 VA: 0x30EC820
	public static void AddOperatorToChain(object chain, Token op) { }

	// RVA: 0x30ECAE0 Offset: 0x30ECBE1 VA: 0x30ECAE0
	public static Expression CommitOperatorChain(object chain, ScriptLoadingContext lcontext) { }

	// RVA: 0x30ECCA0 Offset: 0x30ECDA1 VA: 0x30ECCA0
	public static Expression CreatePowerExpression(Expression op1, Expression op2, ScriptLoadingContext lcontext) { }

	// RVA: 0x30EC790 Offset: 0x30EC891 VA: 0x30EC790
	private static void AddNode(BinaryOperatorExpression.LinkedList list, BinaryOperatorExpression.Node node) { }

	// RVA: 0x30ECB70 Offset: 0x30ECC71 VA: 0x30ECB70
	private static Expression CreateSubTree(BinaryOperatorExpression.LinkedList list, ScriptLoadingContext lcontext) { }

	// RVA: 0x30ECF10 Offset: 0x30ED011 VA: 0x30ECF10
	private static BinaryOperatorExpression.Node PrioritizeLeftAssociative(BinaryOperatorExpression.Node nodes, ScriptLoadingContext lcontext, BinaryOperatorExpression.Operator operatorsToFind) { }

	// RVA: 0x30ECDA0 Offset: 0x30ECEA1 VA: 0x30ECDA0
	private static BinaryOperatorExpression.Node PrioritizeRightAssociative(BinaryOperatorExpression.Node nodes, ScriptLoadingContext lcontext, BinaryOperatorExpression.Operator operatorsToFind) { }

	// RVA: 0x30EC940 Offset: 0x30ECA41 VA: 0x30EC940
	private static BinaryOperatorExpression.Operator ParseBinaryOperator(Token token) { }

	// RVA: 0x30ECD40 Offset: 0x30ECE41 VA: 0x30ECD40
	private void .ctor(Expression exp1, Expression exp2, BinaryOperatorExpression.Operator op, ScriptLoadingContext lcontext) { }

	// RVA: 0x30ED070 Offset: 0x30ED171 VA: 0x30ED070
	private static bool ShouldInvertBoolean(BinaryOperatorExpression.Operator op) { }

	// RVA: 0x30ED0A0 Offset: 0x30ED1A1 VA: 0x30ED0A0
	private static OpCode OperatorToOpCode(BinaryOperatorExpression.Operator op) { }

	// RVA: 0x30ED230 Offset: 0x30ED331 VA: 0x30ED230 Slot: 4
	public override void Compile(ByteCode bc) { }

	// RVA: 0x30ED6F0 Offset: 0x30ED7F1 VA: 0x30ED6F0 Slot: 6
	public override DynValue Eval(ScriptExecutionContext context) { }

	// RVA: 0x30EDE20 Offset: 0x30EDF21 VA: 0x30EDE20
	private double EvalArithmetic(DynValue v1, DynValue v2) { }

	// RVA: 0x30EDA70 Offset: 0x30EDB71 VA: 0x30EDA70
	private bool EvalComparison(DynValue l, DynValue r, BinaryOperatorExpression.Operator op) { }
}

