// Namespace: MS.Internal.Xml.XPath
internal class Filter : AstNode // TypeDefIndex: 1605
{
	// Fields
	private AstNode input; // 0x10
	private AstNode condition; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x323E630 Offset: 0x323E731 VA: 0x323E630
	public void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x323E680 Offset: 0x323E781 VA: 0x323E680 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x323E690 Offset: 0x323E791 VA: 0x323E690 Slot: 5
	public override XPathResultType get_ReturnType() { }
}

