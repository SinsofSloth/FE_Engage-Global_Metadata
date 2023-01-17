// Namespace: MS.Internal.Xml.XPath
internal class Function : AstNode // TypeDefIndex: 1607
{
	// Fields
	private Function.FunctionType functionType; // 0x10
	private ArrayList argumentList; // 0x18
	private string name; // 0x20
	private string prefix; // 0x28
	internal static XPathResultType[] ReturnTypes; // 0x0

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x323E810 Offset: 0x323E911 VA: 0x323E810
	public void .ctor(Function.FunctionType ftype, ArrayList argumentList) { }

	// RVA: 0x323E8A0 Offset: 0x323E9A1 VA: 0x323E8A0
	public void .ctor(string prefix, string name, ArrayList argumentList) { }

	// RVA: 0x323E960 Offset: 0x323EA61 VA: 0x323E960
	public void .ctor(Function.FunctionType ftype, AstNode arg) { }

	// RVA: 0x323EA10 Offset: 0x323EB11 VA: 0x323EA10 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x323EA20 Offset: 0x323EB21 VA: 0x323EA20 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x323EAC0 Offset: 0x323EBC1 VA: 0x323EAC0
	private static void .cctor() { }
}

