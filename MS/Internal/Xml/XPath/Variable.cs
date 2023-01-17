// Namespace: MS.Internal.Xml.XPath
internal class Variable : AstNode // TypeDefIndex: 1613
{
	// Fields
	private string localname; // 0x10
	private string prefix; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x19BC500 Offset: 0x19BC601 VA: 0x19BC500
	public void .ctor(string name, string prefix) { }

	// RVA: 0x19BC550 Offset: 0x19BC651 VA: 0x19BC550 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x19BC560 Offset: 0x19BC661 VA: 0x19BC560 Slot: 5
	public override XPathResultType get_ReturnType() { }
}

