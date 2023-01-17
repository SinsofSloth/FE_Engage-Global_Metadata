// Namespace: System.Xml.Schema
[DefaultMemberAttribute] // RVA: 0x470E0 Offset: 0x471E1 VA: 0x470E0
internal class KeySequence // TypeDefIndex: 1808
{
	// Fields
	private TypedObject[] ks; // 0x10
	private int dim; // 0x18
	private int hashcode; // 0x1C
	private int posline; // 0x20
	private int poscol; // 0x24

	// Properties
	public int PosLine { get; }
	public int PosCol { get; }
	public object Item { get; set; }

	// Methods

	// RVA: 0x323F250 Offset: 0x323F351 VA: 0x323F250
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x323F2F0 Offset: 0x323F3F1 VA: 0x323F2F0
	public int get_PosLine() { }

	// RVA: 0x323F300 Offset: 0x323F401 VA: 0x323F300
	public int get_PosCol() { }

	// RVA: 0x323F310 Offset: 0x323F411 VA: 0x323F310
	public object get_Item(int index) { }

	// RVA: 0x323F350 Offset: 0x323F451 VA: 0x323F350
	public void set_Item(int index, object value) { }

	// RVA: 0x323F450 Offset: 0x323F551 VA: 0x323F450
	internal bool IsQualified() { }

	// RVA: 0x323F4C0 Offset: 0x323F5C1 VA: 0x323F4C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x323F810 Offset: 0x323F911 VA: 0x323F810 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x323F920 Offset: 0x323FA21 VA: 0x323F920 Slot: 3
	public override string ToString() { }
}

