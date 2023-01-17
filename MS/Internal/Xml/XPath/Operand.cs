// Namespace: MS.Internal.Xml.XPath
internal class Operand : AstNode // TypeDefIndex: 1609
{
	// Fields
	private XPathResultType type; // 0x10
	private object val; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x3244440 Offset: 0x3244541 VA: 0x3244440
	public void .ctor(string val) { }

	// RVA: 0x3244480 Offset: 0x3244581 VA: 0x3244480
	public void .ctor(double val) { }

	// RVA: 0x3244510 Offset: 0x3244611 VA: 0x3244510 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x3244520 Offset: 0x3244621 VA: 0x3244520 Slot: 5
	public override XPathResultType get_ReturnType() { }
}

