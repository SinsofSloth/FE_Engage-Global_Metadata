// Namespace: System.Xml.Schema
internal abstract class InteriorNode : SyntaxTreeNode // TypeDefIndex: 1816
{
	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Properties
	public SyntaxTreeNode LeftChild { get; set; }
	public SyntaxTreeNode RightChild { get; set; }

	// Methods

	// RVA: 0x323EF30 Offset: 0x323F031 VA: 0x323EF30
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x323EF40 Offset: 0x323F041 VA: 0x323EF40
	public void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x323EF50 Offset: 0x323F051 VA: 0x323EF50
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0x323EF60 Offset: 0x323F061 VA: 0x323EF60
	public void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0x323EF70 Offset: 0x323F071 VA: 0x323EF70
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x323F140 Offset: 0x323F241 VA: 0x323F140 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x323F1B0 Offset: 0x323F2B1 VA: 0x323F1B0
	protected void .ctor() { }
}

