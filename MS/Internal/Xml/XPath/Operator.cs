// Namespace: MS.Internal.Xml.XPath
internal class Operator : AstNode // TypeDefIndex: 1611
{
	// Fields
	private static Operator.Op[] invertOp; // 0x0
	private Operator.Op opType; // 0x10
	private AstNode opnd1; // 0x18
	private AstNode opnd2; // 0x20

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x3244530 Offset: 0x3244631 VA: 0x3244530
	public void .ctor(Operator.Op op, AstNode opnd1, AstNode opnd2) { }

	// RVA: 0x3244590 Offset: 0x3244691 VA: 0x3244590 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x32445A0 Offset: 0x32446A1 VA: 0x32445A0 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x32445D0 Offset: 0x32446D1 VA: 0x32445D0
	private static void .cctor() { }
}

