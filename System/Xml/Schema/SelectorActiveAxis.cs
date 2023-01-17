// Namespace: System.Xml.Schema
internal class SelectorActiveAxis : ActiveAxis // TypeDefIndex: 1804
{
	// Fields
	private ConstraintStruct cs; // 0x28
	private ArrayList KSs; // 0x30
	private int KSpointer; // 0x38

	// Properties
	public int lastDepth { get; }

	// Methods

	// RVA: 0x19B5DA0 Offset: 0x19B5EA1 VA: 0x19B5DA0
	public int get_lastDepth() { }

	// RVA: 0x19B5E50 Offset: 0x19B5F51 VA: 0x19B5E50
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0x19B5EF0 Offset: 0x19B5FF1 VA: 0x19B5EF0 Slot: 4
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0x19B5FE0 Offset: 0x19B60E1 VA: 0x19B5FE0
	public int PushKS(int errline, int errcol) { }

	// RVA: 0x19B62B0 Offset: 0x19B63B1 VA: 0x19B62B0
	public KeySequence PopKS() { }
}

