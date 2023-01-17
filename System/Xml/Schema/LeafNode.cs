// Namespace: System.Xml.Schema
internal class LeafNode : SyntaxTreeNode // TypeDefIndex: 1814
{
	// Fields
	private int pos; // 0x10

	// Properties
	public int Pos { get; set; }
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x323FA50 Offset: 0x323FB51 VA: 0x323FA50
	public void .ctor(int pos) { }

	// RVA: 0x323FA80 Offset: 0x323FB81 VA: 0x323FA80
	public int get_Pos() { }

	// RVA: 0x323FA90 Offset: 0x323FB91 VA: 0x323FA90
	public void set_Pos(int value) { }

	// RVA: 0x323FAA0 Offset: 0x323FBA1 VA: 0x323FAA0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x323FAB0 Offset: 0x323FBB1 VA: 0x323FAB0 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x323FAF0 Offset: 0x323FBF1 VA: 0x323FAF0 Slot: 6
	public override bool get_IsNullable() { }
}

