// Namespace: System.Xml.Schema
internal sealed class LeafRangeNode : LeafNode // TypeDefIndex: 1823
{
	// Fields
	private Decimal min; // 0x14
	private Decimal max; // 0x24
	private BitSet nextIteration; // 0x38

	// Properties
	public Decimal Max { get; }
	public Decimal Min { get; }
	public BitSet NextIteration { get; set; }
	public override bool IsRangeNode { get; }

	// Methods

	// RVA: 0x323FB00 Offset: 0x323FC01 VA: 0x323FB00
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0x323FB60 Offset: 0x323FC61 VA: 0x323FB60
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0x323FBC0 Offset: 0x323FCC1 VA: 0x323FBC0
	public Decimal get_Max() { }

	// RVA: 0x323FBD0 Offset: 0x323FCD1 VA: 0x323FBD0
	public Decimal get_Min() { }

	// RVA: 0x323FBE0 Offset: 0x323FCE1 VA: 0x323FBE0
	public BitSet get_NextIteration() { }

	// RVA: 0x323FBF0 Offset: 0x323FCF1 VA: 0x323FBF0
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x323FC00 Offset: 0x323FD01 VA: 0x323FC00 Slot: 7
	public override bool get_IsRangeNode() { }

	// RVA: 0x323FC10 Offset: 0x323FD11 VA: 0x323FC10 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }
}

