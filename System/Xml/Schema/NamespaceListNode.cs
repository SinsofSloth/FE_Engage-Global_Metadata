// Namespace: System.Xml.Schema
internal class NamespaceListNode : SyntaxTreeNode // TypeDefIndex: 1815
{
	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x3242160 Offset: 0x3242261 VA: 0x3242160
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0x32421B0 Offset: 0x32422B1 VA: 0x32421B0 Slot: 8
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0x32421D0 Offset: 0x32422D1 VA: 0x32421D0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x32426F0 Offset: 0x32427F1 VA: 0x32426F0 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x3242730 Offset: 0x3242831 VA: 0x3242730 Slot: 6
	public override bool get_IsNullable() { }
}

