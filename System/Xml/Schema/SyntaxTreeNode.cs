// Namespace: System.Xml.Schema
internal abstract class SyntaxTreeNode // TypeDefIndex: 1813
{
	// Properties
	public abstract bool IsNullable { get; }
	public virtual bool IsRangeNode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsNullable();

	// RVA: 0x19B8640 Offset: 0x19B8741 VA: 0x19B8640 Slot: 7
	public virtual bool get_IsRangeNode() { }

	// RVA: 0x19B8650 Offset: 0x19B8751 VA: 0x19B8650
	protected void .ctor() { }
}

