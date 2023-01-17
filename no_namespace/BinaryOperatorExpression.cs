// Namespace: 
[FlagsAttribute] // RVA: 0xD700 Offset: 0xD801 VA: 0xD700
private enum BinaryOperatorExpression.Operator // TypeDefIndex: 6020
{
	// Fields
	public int value__; // 0x0
	public const BinaryOperatorExpression.Operator NotAnOperator = 0;
	public const BinaryOperatorExpression.Operator Or = 1;
	public const BinaryOperatorExpression.Operator And = 2;
	public const BinaryOperatorExpression.Operator Less = 4;
	public const BinaryOperatorExpression.Operator Greater = 8;
	public const BinaryOperatorExpression.Operator LessOrEqual = 16;
	public const BinaryOperatorExpression.Operator GreaterOrEqual = 32;
	public const BinaryOperatorExpression.Operator NotEqual = 64;
	public const BinaryOperatorExpression.Operator Equal = 128;
	public const BinaryOperatorExpression.Operator StrConcat = 256;
	public const BinaryOperatorExpression.Operator Add = 512;
	public const BinaryOperatorExpression.Operator Sub = 1024;
	public const BinaryOperatorExpression.Operator Mul = 4096;
	public const BinaryOperatorExpression.Operator Div = 8192;
	public const BinaryOperatorExpression.Operator Mod = 16384;
	public const BinaryOperatorExpression.Operator Power = 32768;
}

// Namespace: 
private class BinaryOperatorExpression.Node // TypeDefIndex: 6021
{
	// Fields
	public Expression Expr; // 0x10
	public BinaryOperatorExpression.Operator Op; // 0x18
	public BinaryOperatorExpression.Node Prev; // 0x20
	public BinaryOperatorExpression.Node Next; // 0x28

	// Methods

	// RVA: 0x33558C0 Offset: 0x33559C1 VA: 0x33558C0
	public void .ctor() { }
}

// Namespace: 
private class BinaryOperatorExpression.LinkedList // TypeDefIndex: 6022
{
	// Fields
	public BinaryOperatorExpression.Node Nodes; // 0x10
	public BinaryOperatorExpression.Node Last; // 0x18
	public BinaryOperatorExpression.Operator OperatorMask; // 0x20

	// Methods

	// RVA: 0x33558B0 Offset: 0x33559B1 VA: 0x33558B0
	public void .ctor() { }
}

